using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCourse
{
    class DegreeProgram
    {
        public string name;
        public string deptHead;
        public string degrees;
        public DegreeProgram(string programName, string dh, string deg)
        {
            name = programName;
            deptHead = dh;
            degrees = deg;
        }
    }
}
