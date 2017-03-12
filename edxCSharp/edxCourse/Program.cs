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

            ArrayList students = new ArrayList();
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

            //changing third grade
            int count = 1;
            string dup1 = s1.Grades.Peek();
            s1.Grades.Pop();
            string dup2 = s1.Grades.Peek();
            s1.Grades.Pop();
            s1.Grades.Pop();
            s1.Grades.Push("B");
            s1.Grades.Push(dup2);
            s1.Grades.Push(dup1);

            //display student grades
            foreach(Student s in math.Students)
            {
                Console.Write("{0} {1}: ", s.FirstName, s.LastName);
                foreach(string grade in s.Grades)
                {
                    Console.Write("{0} ", grade);
                }
                Console.WriteLine();
            }

        }
    }
}
