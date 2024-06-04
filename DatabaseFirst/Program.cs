using DatabaseFirst.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var data = new PostgresContext().AccountRoles;
        foreach (var item in data)
        {
            Console.WriteLine(item.RoleId + " "+ item.AccountRoleId);
        }
        Console.WriteLine(data);
    }
}