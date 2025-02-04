using EF_Task1.DAL;
using EF_Task1.DAL.DataBase;

namespace EF_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDBContext db = new ApplicationDBContext();
            db.Add(new Employee { Name="Mohamed",Salary=3500});
            db.Add(new Deprtment { Name = "Hr" });
            db.Add(new Project { Name = "Mansoura" });
            db.SaveChanges();


        }
    }
}
