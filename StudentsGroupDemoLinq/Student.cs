using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroupDemoLinq
{
    class Student : Person
    {
        public int GroupId { get; set; }

        public int GecordBookNumber { get; set; }
    }
}
