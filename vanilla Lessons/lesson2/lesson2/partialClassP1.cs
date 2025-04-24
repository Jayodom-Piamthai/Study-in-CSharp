using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class partialClassP1
    {
        //All the partial class definitions must be in the same assembly and namespace.
        //  All the parts must have the same accessibility like public or private, etc.
        // If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
        //  Different parts can have different base types and so the final class will inherit all the base types.
        // The Partial modifier can only appear immediately before the keywords class, struct, or interface.
        //Nested partial types are allowed.

        //multiple developers can work simultaneously in the same class in different files with this
        public partial class Employee
        {
            public Employee()
            {
                GenerateEmployeeId();
            }
            public int EmpId { get; set; }
            public string Name { get; set; }

            partial void GenerateEmployeeId();

        }
    }
}
