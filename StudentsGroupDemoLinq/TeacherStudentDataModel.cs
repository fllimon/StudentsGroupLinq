using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroupDemoLinq
{
    class TeacherStudentDataModel
    {
        #region ======------ PRIVATE DATA ------========

        private List<Group> _groups = new List<Group>();
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        private readonly Dictionary<LessonDay, Schedule> _lessonSchedule = new Dictionary<LessonDay, Schedule>();

        #endregion
    }
}
