using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    public class Course
    {
        public string CourseName { get; }
        private Dictionary<Student, int> Grade { get; }

        public Course(string courseName)
        {
            CourseName = courseName;
            Grade = new Dictionary<Student, int>();
            
        }

        public void SetStudentGrade(Student student, int grade)
        {
            Grade[student] = grade;
        }

        public int GetStudentGrade(Student student)
        {
            return Grade.ContainsKey(student) ? Grade[student] : -1;
        }
    }
}
