using System;
using System.Collections.Generic;
using System.Linq;

namespace Task.Module15
{
    /// <summary>
    /// Entry class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry method
        /// </summary>
        /// <param name="args">Entry parameter</param>
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };

            var allStudents = GetAllStudents(classes);
            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadLine();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var fin = from stu in classes
                      from a in stu.Students
                      select a;
            return fin.ToArray();
        }
    }
}