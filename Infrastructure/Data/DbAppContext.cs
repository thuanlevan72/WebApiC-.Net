using Entity.Audits;
using Entity.Models;
using Entity.Models.ModelV2;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;


namespace Infrastructure.Data
{
    public class DbAppContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DbAppContext(DbContextOptions<DbAppContext> options, IHttpContextAccessor httpContextAccessor)
           : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public DbSet<Acccount> Acccounts { get; set; }
        public DbSet<Decentralization> Decentralizations { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<UserConnections> UserConnections { get; set; }

        // v2 thiết kê phân quyền mới 
        public DbSet<UserEntity> UserEntities { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        // log audit
        public DbSet<AuditLog> AuditLogs { get; set; }

        // custom model 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /* Cấu hình khóa chính tổng hợp cho bảng RolePermission
             */
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });
            // Cấu hình khóa chính tổng hợp cho bảng UserRole
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });
        }
        public override int SaveChanges()
        {
            AddAuditLogs();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddAuditLogs();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void AddAuditLogs()
        {
            ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditLog>();
            // Lấy userId từ JWT
            var userId = GetUserIdFromJwt();
            
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is AuditLog || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;
                var auditEntry = new AuditLog
                {
                    UserId = userId.HasValue ? userId.Value : -1,
                    TableName = entry.Entity.GetType().Name,
                    Action = entry.State.ToString(),
                    Timestamp = DateTime.UtcNow,
                    RecordId = entry.Properties.FirstOrDefault(p => p.Metadata.IsPrimaryKey())?.CurrentValue as int? ?? 0 // Gán giá trị cho RecordId
                };

                foreach (var property in entry.Properties)
                {
                    string propertyName = property.Metadata.Name;

                    if (entry.State == EntityState.Added)
                    {
                        auditEntry.NewValues = auditEntry.NewValues ?? "{}";
                        auditEntry.NewValues = JsonConvert.SerializeObject(new { propertyName, property.CurrentValue });
                    }
                    else if (entry.State == EntityState.Deleted)
                    {
                        auditEntry.OldValues = auditEntry.OldValues ?? "{}";
                        auditEntry.OldValues = JsonConvert.SerializeObject(new { propertyName, property.OriginalValue });
                    }
                    else if (entry.State == EntityState.Modified && property.IsModified)
                    {
                        auditEntry.OldValues = auditEntry.OldValues ?? "{}";
                        auditEntry.NewValues = auditEntry.NewValues ?? "{}";
                        auditEntry.OldValues = JsonConvert.SerializeObject(new { propertyName, property.OriginalValue });
                        auditEntry.NewValues = JsonConvert.SerializeObject(new { propertyName, property.CurrentValue });
                    }
                }

                auditEntries.Add(auditEntry);
            }

            if (auditEntries.Any())
            {
                AuditLogs.AddRange(auditEntries);
            }
        }
        private int? GetUserIdFromJwt()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            int res = -1;
            if (httpContext == null)
            {
                return res;
            }

            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (token == null)
            {
                return res;
            }
            
            var jwtToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;
            var userId = int.TryParse(jwtToken?.Claims.FirstOrDefault(c => c.Type == "jti")?.Value, out res);

            return res;
        }
    }
}
