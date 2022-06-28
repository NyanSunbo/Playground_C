using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Playground_Full.Chapter1;
using static System.Console;

namespace Playground_Full
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chapter1 chapter1 = new Chapter1();

            Student student = new Student("S20323742");
            var (FirstName, Surname) = student;


            WriteLine($"The student name is {FirstName} {Surname}");

            int a = 10;
            int b = 20;
            Chapter1 ch1 = new Chapter1();
            int val = ch1.GetLargest(a, b);
            val += 25;

            ref int refVal = ref ch1.GetLargest(ref a, ref b);
            refVal += 25;
            WriteLine($"refVal = {refVal} a = {a} b = {b} ");

            

        }
    }
}
