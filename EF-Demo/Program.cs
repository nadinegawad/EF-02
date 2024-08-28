using EF_Demo.Contexts;
using EF_Demo.Entities;

namespace EF_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          using EnterPriceContext DbContext = new EnterPriceContext();

            #region Create
            //Employee Emp01 = new Employee()
            //{
            //    Name = "Aya",
            //    Salary = 4_000,
            //    Email = "aya123@gmail.com",
            //    Password = "password123",
            //    Phone = "01255112",
            //    Age = 23,

            //};

            //Employee Emp02 = new Employee()
            //{
            //    Name = "Omar",
            //    Salary = 10_000,
            //    Email = "omar123@gmail.com",
            //    Password = "password123",
            //    Phone = "0125599715",
            //    Age = 30,

            //};
            //Console.WriteLine(DbContext.Entry(Emp01).State);
            //Console.WriteLine(DbContext.Entry(Emp02).State);
            //DbContext.Employees.Add(Emp01);
            //DbContext.Employees.Add(Emp02);
            //DbContext.SaveChanges();
            //Console.WriteLine(DbContext.Entry(Emp01).State);
            //Console.WriteLine(DbContext.Entry(Emp02).State); 
            #endregion

            #region Read
            //var Employee= (from E in DbContext.Employees
            //              where E.EmpId==1
            //              select E).FirstOrDefault();
            //Console.WriteLine(Employee.Name);
            #endregion

            #region Update
            //var Employee = (from E in DbContext.Employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine(DbContext.Entry(Employee).State);
            //Employee.Salary = 20_000;
            //DbContext.SaveChanges();
            //Console.WriteLine(DbContext.Entry(Employee).State);
            #endregion
            #region Delete
            //var Employee = (from E in DbContext.Employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();
            //DbContext.Employees.Remove(Employee);
            #endregion

        }
    }
}
