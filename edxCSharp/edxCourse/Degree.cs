using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCourse
{
    public class Degree
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _credits;
        public int Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }
        private Course[] _courses;
        public Course[] Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }
        public Degree()
        {
            Name = "NA";
            Credits = 120;
        }
        public Degree(string degName, int degCredits)
        {
            Name = degName;
            Credits = degCredits;
        }
        public Degree getDegreeInformation()
        {
            string name;
            int creditsReq;

            Console.WriteLine("Please enter Degree Name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the number of credits required:");
            creditsReq = int.Parse(Console.ReadLine());

            Degree var = new Degree(name, creditsReq);
            return var;
        }
        public void printDegreeInformation(Degree var)
        {
            Console.WriteLine("Degree Name: {0}", var.Name);
            Console.WriteLine("Number of Credits: {0}", var.Credits);
        }
    }
}
