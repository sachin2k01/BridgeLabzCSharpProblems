using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    public  class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name,int age,string email)
        {
            Name = name;
            Age = age;
            Email = email;
            
        }
    }

    public class Student : Person
    {
        public int Sid { get; }
        public List<Course> EnrolledCourse { get; }

        public Student(int stdis,string name,int age,string email):base(name,age,email)
        {
            Sid = stdis;
            EnrolledCourse = new List<Course>();
        }

        public void EnrolledCourses(Course course)
        {
            EnrolledCourse.Add(course);
        }

        public void GetGrades()
        {
            foreach(var course in EnrolledCourse)
            {
                Console.WriteLine($"Course: {course.CourseName}, Grade: {course.GetStudentGrade(this)} ");
            }
        }

    }

    public class Teacher : Person
    {
        public string Department { get; }

        public Teacher(string name,int age,string email,string department):base(name,age,email)
        {
            Department = department;
        }

        public void GradeStudent(Student student,Course course,int grade)
        {
            course.SetStudentGrade(student, grade);
        }

        public void SetMessageToStudent(Student student, string msg)
        {
            Console.WriteLine($"Message From Teacher {Name} to {student.Name} is:  {msg}");

        }


    }
        

}
