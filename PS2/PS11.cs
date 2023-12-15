using System;


namespace PS2
{
    public class PS11
    {
        static void Main(string[] args)
        {

            // Create students
            Student student1 = new Student(4, "Amith", 20, "alice@example.com");
            Student student2 = new Student(2, "Sumith", 21, "bob@example.com");

            //Create Teacher
            Teacher teacher = new Teacher("Mr. Samarth", 35, "samarth@example.com", "Math");

            // Create courses
            Course mathCourse = new Course("Mathematics");
            Course physicsCourse = new Course("Physics");


            // Enroll students in courses
            student1.EnrolledCourses(mathCourse);
            student2.EnrolledCourses(physicsCourse);

            // Teacher grades students
            teacher.GradeStudent(student1, mathCourse, 90);
            teacher.GradeStudent(student2, physicsCourse, 95);

            // Students check their grades
            Console.WriteLine("Grades for student 1:");
            student1.GetGrades();
            Console.WriteLine();

            Console.WriteLine("\nGrades for student 2:");
            student2.GetGrades();
            Console.WriteLine();

            // Teacher sends a message to a student

            
            teacher.SetMessageToStudent(student2, "Keep up the good work!");


        }
    }
}
