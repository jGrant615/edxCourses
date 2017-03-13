using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCourse
{
    class edxProgram
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Course math = new Course();

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            foreach(Student s in students)
            {
                for(int i=0; i<5; i++)
                {
                    s.Grades.Push("A");
                }
                math.enrollStudent(s);
            }
            math.listStudents();

            

        }
    }
}
