using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCourse
{
    public class Degree
    {
        public string name;
        public int credits;
        public Degree(string degName, int degCredits)
        {
            name = degName;
            credits = degCredits;
        }
    }
}
