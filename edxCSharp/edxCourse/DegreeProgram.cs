using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCourse
{
    class DegreeProgram
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _deptHead;
        public string DeptHead
        {
            get { return _deptHead; }
            set { _deptHead = value; }
        }
        private Degree[] _degrees;
        public Degree[] Degrees
        {
            get { return _degrees; }
            set { _degrees = value; }
        }
        public DegreeProgram()
        {
            Name = "NA";
            DeptHead = "NA";
        } 
        public DegreeProgram(string programName, string dh)
        {
            Name = programName;
            DeptHead = dh;
        }
        public DegreeProgram getProgramInformation()
        {
            string name;
            string deptHead;

            Console.WriteLine("Enter Program Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter name of the department head:");
            deptHead = Console.ReadLine();

            DegreeProgram var = new DegreeProgram(name, deptHead);
            return var;
        }
        public void printProgramInformation(DegreeProgram var)
        {
            Console.WriteLine("Program Name: {0}", var.Name);
            Console.WriteLine("Department Head: {0}", var.DeptHead);
        }
    }
}
