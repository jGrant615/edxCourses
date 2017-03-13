using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCourse
{
    public class Course
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private int _credits;
        public int Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }
        private List<Student> _students = new List<Student>();
        public List<Student> CourseRoster
        {
            get { return _students; }
            set { _students = value; }
        }
        private Teacher[] _teachers = new Teacher[3];
        public Teacher[] Teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
        }
        public Course()
        {
            Name = "NA";
            Duration = 100;
            Credits = 4;
        }
        public Course(string cName, int cDuration, int cCredits)
        {
            Name = cName;
            Duration = cDuration;
            Credits = cCredits;
        }
        public Course getCourseInformation()
        {
            string name;
            int duration;
            int credits;

            Console.WriteLine("Please enter the name of the course:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the course duration (# of weeks):");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of Credits that this course is worth:");
            credits = int.Parse(Console.ReadLine());
           
            Course var = new Course(name, duration, credits);
            return var;
        }
        public void printCourseInformation(Course var)
        {
            Console.WriteLine("Course Name: {0}", var.Name);
            Console.WriteLine("Course Duration (weeks): {0}", var.Duration);
            Console.WriteLine("Number of Credits Awarded: {0}", var.Credits);
        }
        public void enrollStudent(Student var)
        {
            _students.Add(var);
            try
            {
                _students.Sort();
            } catch ( InvalidOperationException e){}
        }
        public void listStudents()
        {
            foreach (Student s in CourseRoster)
            {
                Console.WriteLine("Student: {0} {1}", s.FirstName, s.LastName);
            }
        }
    }
}
