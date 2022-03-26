using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Full
{
    internal class Chapter1
    {
        public class Student
        {

            public string Name { get; private set; }
            public string LastName { get; private set; }
            public List<int> CourseCodes { get; private set; }
    
            public Student(string studentNumber)
            {
                (Name, LastName) = GetStudentDetails(studentNumber);
            }

            public Student()
            {

            }

            public void Deconstruct(out string name, out string lastName)
            {
                name = Name;
                lastName = LastName;
            }

            private (string name, string surname) GetStudentDetails(string studentNumber)
            {
                var detail = (n: "Dirk", s: "Strauss");
                return detail;
            }

        }




    }
}
