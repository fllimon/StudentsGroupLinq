using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroupDemoLinq
{
    struct LessonDay
    {
        public int LessonNumber { get; set; }

        DayOfWeek Day { get; set; }

        public override bool Equals(object obj)
        {
            LessonDay someObj = (LessonDay)obj;

            return ((Day == someObj.Day) && (LessonNumber == someObj.LessonNumber));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
