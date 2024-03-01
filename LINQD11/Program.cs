using System.Linq;
using System.Text.RegularExpressions;
using System.Transactions;

namespace LINQD11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] fruits = { "orange", "apple", "mango", "grape" };
            /*var res = fruits.OrderByDescending(x => x);
            res.Print("Fruits Asc (method syntax)");*/

            //var res2 = from f in fruits
            //           orderby f descending
            //           select f;

            //res2.Print("Fruits Asc (Query syntax)");


            /*string[] fruits = { "orange", "apple", "mango", "grape" };
            var res = fruits.OrderByDescending(x => x.Length);
            res.Print("Fruits Asc (method syntax)");

            var res2 = from f in fruits
                       orderby f.Length descending
                       select f;

            res2.Print("Fruits Asc (Query syntax)");*/


            /*var emp = Repository.LoadEmployees();
            var sortedEmps = emp.OrderBy(e => e.Name);
            sortedEmps.Print("sorted employee names");

            var emp2 = Repository.LoadEmployees();
            var sortedEmps2 = emp.OrderBy(e => e.Name).ThenByDescending(x => x.Salary);
            sortedEmps.Print("sorted employee names then by salary");*/

            /*var emp = Repository.LoadEmployees();
            var sortedEmps2 = emp.OrderBy(e => e , new EmpCompare());
            sortedEmps2.Print("sorted employeeNo");*/


            /*string[] fruits = { "orange", "apple", "mango", "grape" };
            var res = fruits.Reverse();
            res.Print("result");*/

            //var emp = Repository.LoadEmployees();
            //var q1 = emp.Skip(10);
            //q1.Print("result");

            //var q2 = emp.SkipWhile(x => x.Salary != 1855) ;
            //q2.Print("result");

            /*var emp = Repository.LoadEmployees();
            var q1 = emp.Take(10);
            q1.Print("result");

            var q2 = emp.TakeWhile(x => x.Salary != 1855);
            q2.Print("result");*/

            //-----------------------------------------------------------------
            /*var emp = Repository.LoadEmployees();
            var ch = emp.Chunk(10).ToList();
            for(int i = 0; i < ch.Count; i++)
            {
                ch[i].Print($"{i+1}");
            }*/
            //-----------------------------------------------------------------

            //**********************************************************************

            #region pagination
            //var page = 1;
            //var size = 10;

            //Console.WriteLine("Result per page");
            //if (int.TryParse(Console.ReadLine() , out int res1))
            //{
            //    size = res1;
            //}

            //Console.WriteLine("Page No:");
            //if (int.TryParse(Console.ReadLine(), out int res2))
            //{
            //    page = res2;
            //}

            //var emps = Repository.LoadEmployees();

            //var result = emps.paginate(page , size);

            //var count = result.Count();
            //var startRec = ((page - 1) * size) + 1;
            //var endRec =
            //    count < size ? startRec + count - 1
            //    : ((page - 1) * size) + size;

            //result.Print($"Result for Page No:{page} with startRecord:{startRec},endRecord:{endRec}");
            #endregion

            #region Quantifiers
            //RunAnyDemo();
            //RunAllDemo();
            //RunContains();
            //RunGrouping();
            //RunJoin();
            //RunQuerySyntax();
            RunGroupJoin();

        }

        private static void RunGroupJoin()
        {
            var employee = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();

            var res2 = department.GroupJoin(employee, 
                dept => dept.Id, emp => emp.DepartmentId, 
                (dept, emp) => new { Department = dept.Name, Employees = emp.Select(e => e.FullName).ToList() });

            foreach (var item in res2)
            {
                Console.WriteLine($"+++++++++++++++{item.Department}++++++++++++++");
                foreach (var item2 in item.Employees)
                {
                    Console.WriteLine(item2);
                }
            }
            Console.WriteLine("____________________________________________________________");
            //----------------------------------------------------------------------------
            var res = from dept in department
                      join emp in employee
                      on dept.Id equals emp.DepartmentId into g
                      select g;

            foreach ( var item in res )
            {
                
                foreach (var item1 in item)
                {
                    Console.WriteLine($"{item1.FullName}");
                }
            }

            //var res = from dept in department
            //          join emp in employee
            //          on dept.Id equals emp.DepartmentId into empgroup
            //          select empgroup;

            //foreach ( var item in res)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1.FullName + " ");
            //    }
            //}
        }

        private static void RunQuerySyntax()
        {
            var employee = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();

            var res = from emp in employee
                      join dept in department
                      on emp.DepartmentId equals dept.Id
                      select new {fullName = emp.FullName , departmentName = dept.Name};

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        private static void RunJoin()
        {
            var employee = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();

            var res = employee.Join(department, emp => emp.DepartmentId, dep => dep.Id, (emp, dep) => new { full = emp.FullName, depart = dep.Name });

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }

        //private static void RunGrouping()
        //{
        //    var employees = Repository.LoadEmployees();
        //    /*var groups = employees.GroupBy(e => e.Dpartment);
        //    foreach ( var group in groups)
        //    {
        //        //Console.WriteLine(group.Key);
        //        group.Print($"{group.Key}");
        //    }*/

        //    /*var res = from e in employees
        //              group e by e.Dpartment;
        //    foreach (var group in res)
        //    {
        //        //Console.WriteLine(group.Key);
        //        group.Print($"{group.Key}");
        //    }*/

        //    var groups = employees.ToLookup(e => e.Dpartment);
        //    foreach(var group in groups)
        //    {
        //        group.Print($"{group.Key}");
        //    }
        //}

        //private static void RunContains()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++++++++++");
        //    Console.WriteLine("RunContains()");
        //    Console.WriteLine("+++++++++++++++++");
        //    Console.WriteLine();

        //    var employee = Repository.LoadEmployees();
        //    /*var res = employee.Any(x => x.Name.Contains("ee"));
        //    Console.WriteLine(res);*/

        //    /*var res = 
        //        from e in employee
        //        where e.Name.Contains("ee")
        //        select e;

        //    res.Print("employee whose name contain 'ee'");*/

        //    var e = new Employee { Email = "Buck.Wallace@example.com" };
        //    var res = employee.Contains(e);
        //    Console.WriteLine(res);
        //}

        //private static void RunAllDemo()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++++++++++");
        //    Console.WriteLine("RunAllDemo()");
        //    Console.WriteLine("+++++++++++++++++");
        //    Console.WriteLine();

        //    var employee = Repository.LoadEmployees();
        //    var res1 = employee.All(x => !string.IsNullOrEmpty(x.Email));
        //    Console.WriteLine($"check for all employee has an email {res1}");

        //    var res2 = employee.All(x => x.Skills.Any(s => s == "C#"));
        //    Console.WriteLine($"check for all employee has a C# as skill {res2}");

        //    var res3 = from e in employee
        //               where e.Skills.All(s => s.Length > 3)
        //               select e;
        //    res3.Print("Employee whose skills length > 3");


        //    var res4 = from e in employee
        //               where e.Skills.Any(s => s.Length > 3)
        //               select e;
        //    res4.Print("Any");
        //}

        //private static void RunAnyDemo()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++++++++++");
        //    Console.WriteLine("RunAnyDemo()");
        //    Console.WriteLine("+++++++++++++++++");
        //    Console.WriteLine();

        //    var employee = Repository.LoadEmployees();
        //    /*var res1 = employee.Any(x => x.Name.StartsWith("jac" , StringComparison.OrdinalIgnoreCase));
        //    Console.WriteLine(res1);*/

        //    var res2 = employee.Any(x => x.Salary < 10000);
        //    Console.WriteLine(res2);

        //    var res2_2 = from emp in employee
        //                 where emp.Salary < 10000
        //                 select emp;
        //    res2_2.Print("Employee who salary < 10000");

        //    /*var res3 = employee.Any(x => x.Skills.Count == 10);
        //    Console.WriteLine(res3);*/
        //}

        #endregion
    }
}