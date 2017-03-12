using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCourse
{
    public class Course
    {
        public string name;
        public string teacher;
        public int duration;
        public int credits;
        public Course(string cName, string cTeacher, int cDuration, int cCredits)
        {
            name = cName;
            teacher = cTeacher;
            duration = cDuration;
            credits = cCredits;
        }
    }
}
