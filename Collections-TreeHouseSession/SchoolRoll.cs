using System;
using System.Collections.Generic;
using System.Text;


namespace Treehouse
{
    class SchoolRoll
    {
        private List<Student> _students = new List<Student>();

        public IEnumerable<Student> Students { get { return _students; } }

        public void AddStudents(IEnumerable<Student> students)
            {
                _students.AddRange(students);
            }
    }
}
