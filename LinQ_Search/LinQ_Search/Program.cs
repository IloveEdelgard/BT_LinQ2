using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = Employee.getEmployees();
            foreach (var item in employees)
            {
                Console.WriteLine($"Employee: {item.emName}, Age: {item.age}");
            }
            Console.WriteLine("");

            var departments = Department.getDepartments();
            Console.WriteLine("Department:");
            foreach (var item in departments)
            {
                Console.WriteLine($"{item.depName}");
            }
            Console.WriteLine("");

            var positions = Position.getPositions();
            Console.WriteLine("Position:");
            foreach (var item in positions)
            {
                Console.WriteLine($"{item.posName}");
            }
            Console.WriteLine("");

            Console.WriteLine("Nhap tu khoa tim kiem: ");
            Console.Write("Tuoi tu: ");
            int minAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("den tuoi: ");
            int maxAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vi tri: ");
            string positionKey = Console.ReadLine();

            Console.Write("Phong ban: ");
            string departmentKey = Console.ReadLine();

            var result = employees.Where(e => e.age >= minAge && e.age <= maxAge)
                                  .Join(positions,
                                        e => e.posID,
                                        p => p.positionID,
                                        (e, p) => new { Emp = e, Pos = p })
                                  .Where(p => p.Pos.posName.Contains(positionKey))
                                  .Join(departments,
                                        e => e.Emp.departmentID,
                                        d => d.departmentID,
                                        (e, d) => new { EmpDep = e, Dep = d })
                                  .Where(d => d.Dep.depName.Contains(departmentKey));

            if (result.Any())
            {
                foreach (var item in result)
                {
                    var employee = item.EmpDep.Emp.emName;
                    var position = item.EmpDep.Pos.posName;
                    var department = item.Dep.depName;
                    Console.WriteLine($"Employee: {employee}, Age: {item.EmpDep.Emp.age}, Position: {position}, Department: {department}");
                }
            }
            else
                Console.Write("Khong co nhan vien can tim");

            Console.ReadKey();
        }
    }
}
