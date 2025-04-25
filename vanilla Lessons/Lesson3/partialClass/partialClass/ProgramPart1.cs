using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClass
{
    internal class ProgramPart1
    {
        public partial class Employee
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
