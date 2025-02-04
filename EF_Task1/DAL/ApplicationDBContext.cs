using EF_Task1.DAL.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EF_Task1.DAL
{
    public class ApplicationDBContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = Ef_Core; Integrated Security = True; Encrypt = True; Trust Server Certificate = True");
        }
        DbSet<Employee> employees { get; set; }
        DbSet<Deprtment> deprtment { get; set; }
        DbSet<Project> project { get; set; }

        

    }
}
