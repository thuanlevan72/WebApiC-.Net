using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Audits
{
    public class AuditEntry
    {
        public AuditEntry(EntityEntry entry)
        {
            Entry = entry;
            KeyValues = new Dictionary<string, object>();
            OldValues = new Dictionary<string, object>();
            NewValues = new Dictionary<string, object>();
            TemporaryProperties = new List<PropertyEntry>();
        }

        public EntityEntry Entry { get; }
        public string TableName { get; set; }
        public Dictionary<string, object> KeyValues { get; }
        public Dictionary<string, object> OldValues { get; }
        public Dictionary<string, object> NewValues { get; }
        public List<PropertyEntry> TemporaryProperties { get; }
        public bool HasTemporaryProperties => TemporaryProperties.Any();

        public AuditLog ToAudit()
        {
            return new AuditLog
            {
                UserId = 1,
                Action = Entry.State.ToString(),
                TableName = TableName,
                RecordId = 1,
                Timestamp = DateTime.UtcNow,
                OldValues = OldValues.Count == 0 ? null : JsonConvert.SerializeObject(OldValues),
                NewValues = NewValues.Count == 0 ? null : JsonConvert.SerializeObject(NewValues),
            };
        }
    }
}
