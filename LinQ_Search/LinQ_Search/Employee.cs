using System;
using System.Collections.Generic;

namespace LinQ_Search
{
    class Employee
    {
        public int employeeID { get; set; }
        public string emName { get; set; }
        public int age { get; set; }
        public int posID { get; set; }
        public int departmentID { get; set; }


        public static List<Employee> getEmployees()
        {
            return new List<Employee>()
            {
                new Employee { employeeID = 1, emName = "Nam", age = 23, posID=1, departmentID = 1},
                new Employee { employeeID = 2, emName = "Ha",  age = 27, posID=3, departmentID = 1},
                new Employee { employeeID = 3, emName = "Quang", age = 23, posID=2, departmentID = 3},
                new Employee { employeeID = 4, emName = "Hang", age = 30, posID=4 , departmentID = 1},
                new Employee { employeeID = 5, emName = "Nga", age = 22, posID=2, departmentID = 4},
                new Employee { employeeID = 6, emName = "Hung", age = 25, posID=1, departmentID = 1},
                new Employee { employeeID = 7, emName = "Thanh",  age = 27, posID=4, departmentID = 3},
                new Employee { employeeID = 8, emName = "Lan", age = 26, posID=2, departmentID = 4},
                new Employee { employeeID = 9, emName = "Tram", age = 30, posID=3 , departmentID = 1},
                new Employee { employeeID = 10, emName = "Nhi", age = 32, posID=1, departmentID = 2}
            };
        }
    }
}