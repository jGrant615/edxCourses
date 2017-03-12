using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCourse
{
    public class Student : Person
    {
        private static int studentCount = 0;
        public static int StudentCount()
        {
            return studentCount;
        }
        private Stack<string> _grades = new Stack<string>();
        public Stack<string> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        } 
        public Student()
        {
            studentCount++;
        }
        public Student(string first, string last, string birth, string a1, string a2, string cityVar, string stateVar, int zipCode, string countryVar)
        {
            studentCount++;
        }
        public void TakeTest()
        {
            Console.WriteLine("Taking Exam");
        }
        public void ChangeGrade(string g)
        {
            Grades.Pop();
            Grades.Push(g);
        }
    }
}

