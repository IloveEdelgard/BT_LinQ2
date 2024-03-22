using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Search
{
    class Department
    {
        public int departmentID { get; set; }
        public string depName { get; set; }

        public static List<Department> getDepartments()
        {
            return new List<Department>()
            {
                new Department {departmentID=1, depName="A"},
                new Department {departmentID=2, depName="B"},
                new Department {departmentID=3, depName="C"},
                new Department {departmentID=4, depName="D"}
            };
        }
    }
}
