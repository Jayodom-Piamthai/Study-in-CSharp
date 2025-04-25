using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClass
{
    public partial class Employee
    {
        //constructor
        public Employee(int id, string name)
        {
            this.EmpId = id;
            this.Name = name;
        }

        public void DisplayEmpInfo()
        {
            Console.WriteLine(this.EmpId + " " this.Name);
        }
    }
    internal class ProgramPart2
    {
    }
}
