using EF_01.Context;
using EF_01.Enities;

namespace EF_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIContext ItiContext = new ITIContext();
            Student Stud01 = new Student()
            {
                FName = "Aya",
                LName = "Ahamed",
                Address = "15stalex",
                Age = 30

            };
            Student Stud02 = new Student()
            {
                FName = "Omar",
                LName = "Ahamed",
                Address = "15stalex",
                Age = 25

            };
            #region Create
            //Console.WriteLine(ItiContext.Entry(Stud01).State);
            //Console.WriteLine(ItiContext.Entry(Stud02).State);
            //ItiContext.Students.Add(Stud01);
            //ItiContext.Students.Add(Stud02);
            //ItiContext.SaveChanges();
            //Console.WriteLine(ItiContext.Entry(Stud01).State);
            //Console.WriteLine(ItiContext.Entry(Stud02).State);
            #endregion
            #region Read
            //var Student = (from S in ItiContext.Students
            //               where S.Id == 1
            //               select S).FirstOrDefault();

            #endregion
            #region Update
            //var Student = (from S in ItiContext.Students
            //               where S.Id == 1
            //               select S).FirstOrDefault();
            //Student.FName = "Amr";
            #endregion
            #region Delete
            //var Student = (from S in ItiContext.Students
            //               where S.Id == 1
            //               select S).FirstOrDefault();
            //ItiContext.Students.Remove(Student);
            #endregion


        }
    }
}
