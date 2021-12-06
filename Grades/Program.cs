using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor Jacob = new Professor("Jacob", "tzug", 316164144, new List<int> { 95, 99, 100 });

            Professor.ProfessorAppEntry();


        }
    }

}