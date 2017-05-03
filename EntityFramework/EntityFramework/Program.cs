using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            Student newStud = new Student() { StudentName = "New Student" };
             


            using (var context = new SchoolDBEntities())
            {

                var studentList = context.Students.ToList();

                context.Students.Add(newStud);
                // context.Standards.Add(new Standard() { StandardID = 5 });


                var studentEntry = context.Entry(newStud);
                Console.WriteLine("Student EntityState: {0}", studentEntry.State);



                context.Students.Add(new Student() { StudentName = "Maria", StandardId = 3, RowVersion="2" });


                Student studentToUpdate = context.Students.Where(s => s.StudentName == "Bill").FirstOrDefault<Student>();
               // studentToUpdate.StudentName = "John";

                // update all students named Bill

                foreach (var all in context.Students.Where(x => x.StudentName == "Bill"))
                    {

                    all.StudentName = "ANA";

                }


                // remove all students named ANA

                var removename = from n in context.Students
                                 where n.StudentName == "ANA"
                                 select n;
                                

                foreach (var removeall in removename )
                {
                    context.Students.Remove(removeall);
                }
            
                    


               


                //studentToUpdate.StudentName = " Sarah ";

                //context.Students.Remove(studentList.ElementAt<Student>(0));
















                context.SaveChanges();












               // var studentName = context.Students.SqlQuery("Select StudentId, StudentName, StandardId, RowVersion from Student").ToList<Student>();
              

              //  var entry = context.Entry(student);


                //foreach (var stud in studentName)
                //{
                //    Console.WriteLine(stud.StudentName);
                //}


                //var nestedQuery = from s in context.Students
                //                  from c in s.StudentCourses
                //                  where s.StandardId == 3
                //                  select new { s.StudentName, c };

                //var nestedQueryResult = nestedQuery.ToList();

                //foreach(var nq in nestedQueryResult)
                //{
                //    Console.WriteLine(nq.StudentName+ " "+nq.c.StudentId+" "+ nq.c.CourseId);
                //}

                //var L2EQuery = context.Students.Where(s => s.StudentName == "Bill");

                //var student = L2EQuery.FirstOrDefault<Student>();
                //var stud1 = L2EQuery.Count();


                //var entrystudent = context.Students.Find(22);
                //var entry = context.Entry(entrystudent);

                //var entityname = entry.Entity.GetType().FullName.ToList();

                //Console.WriteLine("Entity Name:{0}", entityname);
                //Console.WriteLine("Entity State :{0}", entry.State);

                // ChangeTracker

                //Console.WriteLine("Find Student");
                //var std1 = context.Students.Find(23);

                //Console.WriteLine("Context tracking changes of {0} entity.", context.ChangeTracker.Entries().Count());

                //DisplayTrackedEntities(context.ChangeTracker);

                //Console.WriteLine("Find Standard");
                //var standard = context.Standards.Find(3) ;

                //Console.WriteLine("Context tracking changes of {0} entities.", context.ChangeTracker.Entries().Count());
                //Console.WriteLine("");

                //Console.WriteLine("Remove Student");
                //Console.WriteLine("");

                // context.Students.Remove(std1);
                //   DisplayTrackedEntities(context.ChangeTracker);


                //Console.WriteLine(stud1);
                //Console.WriteLine(student.StudentName);

                //var query2 = from st in context.Students
                //             where st.StudentName == "Bill"
                //             select st;


                // CRUD Operation in Connected Scenario:





                Console.ReadKey();
              



            }






        }

        //private static void DisplayTrackedEntities(DbChangeTracker changeTracker)
        //{
        //    Console.WriteLine("");

        //    var entries = changeTracker.Entries();
        //    foreach (var entry in entries)
        //    {
        //        Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);
        //        Console.WriteLine("Status: {0}", entry.State);
        //    }
        //    Console.WriteLine("");
        //    Console.WriteLine("---------------------------------------");
        //}
    }
}
