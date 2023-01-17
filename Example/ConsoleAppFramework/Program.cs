using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new TrainingDBEntities1())
            {
               
                /*                StudentGrade obj = new StudentGrade();
                                obj.StudentID = 2;
                                obj.CourseID = 20;
                                obj.Grade = 1;
                                context.StudentGrades.Add(obj);
                                context.SaveChanges();
                */
              /*  int studentID = 2;
                var studentGrades = context.GetStudentGrades(studentID);// here to stored procedure call

                foreach (var student in studentGrades)
                {
                    Console.WriteLine("Course ID: {0}, Student ID: {1}, Grade: {2} ",
                       student.CourseID, student.StudentID, student.Grade);
                }*/
                var item = context.getAllAuther();

                foreach (var auther in item)
                {
                    Console.WriteLine("Auther Id: {0}, AddedDate : {1},Email: {2},FirstName: {3}, LastName: {4}, Ipaddress: {5}, Modifieddate: {6}",
                        auther.id,auther.AddedDate,auther.Email,auther.FirstName,auther.LastName,auther.IPAddress,auther.ModifiedDate);
                }

                Console.ReadKey();

            }
        }
    }
}
