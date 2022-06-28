using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground_Full
{
    internal class Chapter1
    {
        #region Deconstruc
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
        #endregion

        #region Ref return
        public ref int GetLargest(ref int valueA, ref int valueB)
        {
            if (valueA > valueB)
                return ref valueA;
            else
                return ref valueB;
        }
        public int GetLargest(int valueA, int valueB)
        {
            if (valueA > valueB)
                return valueA;
            else
                return valueB;
        }

        #region View Memory
        //unsafe
        //{
        //    IntPtr a_var_memoryAddress = (IntPtr)(&a);
        //    IntPtr b_var_memoryAddress = (IntPtr)(&b);
        //    IntPtr val_var_memoryAddress = (IntPtr)(&val);
        //    fixed (int* refVal_var = &refVal)
        //    {
        //        IntPtr refVal_var_memoryAddress = (IntPtr)(refVal_var);
        //        WriteLine($"The memory address of a is {a_var_memoryAddress}");
        //        WriteLine($"The memory address of b is {b_var_memoryAddress}");
        //        WriteLine($"The memory address of val is {val_var_memoryAddress}");
        //        WriteLine($"The memory address of refVal is { refVal_var_memoryAddress}");
        //    }
        //}
        #endregion

        #endregion



    }
}
