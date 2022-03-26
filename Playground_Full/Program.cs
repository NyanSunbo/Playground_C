using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Playground_Full.Chapter1;

namespace Playground_Full
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chapter1 chapter1 = new Chapter1();

            Student student = new Student("S20323742");
            var (FirstName, Surname) = student;
            Console.WriteLine($"The student name is {FirstName} {Surname}");
        }
    }
}
