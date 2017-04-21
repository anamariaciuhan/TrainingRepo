using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Course
    {   // Working with Scope and Accessibility Modifiers:
        //Expand upon the Person and Student example seen above by creating a Course class with a List<Student> to keep track of whom is enrolled.
        //Make sure code using Course can't get access to the Student objects directly.
        //Create two methods on the Course class one which provides its name and another which provides a list of the RosterNames of the enrolled students. 
        //Use these methods to print out the information for the course rather than accessing the collection of enrolled student objects directly.
        //While writing this, try accessing some of the code restricted by the access modifiers and notice the error messages you receive when trying.


        public Course(string courseName)
        {
            StudentList = new List<Student>();
        }


        private List<Student> StudentList
        {
            get;

            set;
        }



        public string CourseName
        {
            get;

            set;

        }


        public void AddStudentToCourse(Student student)
        {
            StudentList.Add(student);

        }


        public List<string> GetStudentsNames()
        {
            var studentsNames = StudentList.Select(s => s.FullName).ToList();
            return studentsNames;
        } 


    }


} 


