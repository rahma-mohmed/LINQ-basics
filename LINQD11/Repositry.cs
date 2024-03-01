using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD11
{
    public static class Repository
    {

        //public static IEnumerable<Employee> LoadEmployees()
        //{
        //    return new List<Employee>
        //    {
        //            new Employee
        //            {
        //                 index = 1,
        //                 EmployeeNo = "2017-FI-1343",
        //                 Name = "Cochran Cole",
        //                 Email = "Cole.Cochran01@example.com",
        //                 Salary = 1032,
        //                 Skills = new() {"Javascript" , "C++" , "NodeJS"  },
        //                 Dpartment = "Hr"
        //            },
        //            new Employee
        //            {
        //                 index = 2,
        //                 EmployeeNo = "2018-FI-1755",
        //                 Name = "Jaclyn Wolfe",
        //                 Email = "Wolfe.Jaclyn@example.com",
        //                 Salary = 1924,
        //                 Skills = new() {"C#" , "Javascript" , "ASP.NET"  },
        //                 Dpartment = "Hr"

        //            },
        //            new Employee
        //            {
        //                 index = 3,
        //                 EmployeeNo = "2016-IT-1441",
        //                 Name = "Cochran Cole",
        //                 Email = "Cole.Cochran02@example.com",
        //                 Salary = 1728,
        //                 Skills = new() {"ASP.NET" , "Javascript"  },
        //                 Dpartment = "Sales"
        //            },
        //            new Employee
        //            {
        //                index = 4,
        //                 EmployeeNo = "2016-FI-3447",
        //                 Name = "Hester Evans",
        //                 Email = "Evans.Hester@example.com",
        //                 Salary = 1555,
        //                 Skills = new() {"CSS" , "Javascript" , "NodeJS"  },
        //                 Dpartment = "Sales"

        //            },
        //            new Employee
        //            {
        //                index = 5,
        //                 EmployeeNo = "2014-IT-2956",
        //                 Name = "Wallace Buck",
        //                 Email = "Buck.Wallace@example.com",
        //                 Salary = 3158,
        //                 Skills = new() {"Oracle" , "HTML" , "CSS"  },
        //                 Dpartment = "Sales"

        //            },
        //            new Employee
        //            {
        //                 index = 6,
        //                 EmployeeNo = "2020-IT-6341",
        //                 Name = "Acevedo Wall",
        //                 Email = "Wall.Acevedo@example.com",
        //                 Salary = 3437,
        //                 Skills = new() {"ASP.NET"  },
        //                 Dpartment = "Sales"

        //            },
        //            new Employee
        //            {
        //                 index = 7,
        //                 EmployeeNo = "2021-IT-4488",
        //                 Name = "Jacqueline Pickett",
        //                 Email = "Pickett.Jacqueline@example.com",
        //                 Salary = 3700,
        //                 Skills = new() {"NodeJS"  },
        //                 Dpartment = "Hr"

        //            },
        //            new Employee
        //            {
        //                 index=8,
        //                 EmployeeNo = "2017-HR-3248",
        //                 Name = "Oconnor Espinoza",
        //                 Email = "Espinoza.Oconnor@example.com",
        //                 Salary = 1556,
        //                 Skills = new() {"SQL Server" , "C#" , "HTML" , "C++"  },
        //                 Dpartment = "Sales"

        //            },
        //            new Employee
        //            {

        //                 index = 9,
        //                 EmployeeNo = "2020-AC-9097",
        //                 Name = "Allie Elliott",
        //                 Email = "Elliott.Allie@example.com",
        //                 Salary = 3154,
        //                 Skills = new() {"Oracle"  }
        //            },
        //            new Employee
        //            {

        //                 index = 10,
        //                 EmployeeNo = "2016-HR-3770",
        //                 Name = "Elva Decker",
        //                 Email = "Decker.Elva@example.com",
        //                 Salary = 3459,
        //                 Skills = new() {"ASP.NET" , "Javascript" , "C#"  }
        //            },
        //            new Employee
        //            {

        //                 index = 11,
        //                 EmployeeNo = "2020-HR-8809",
        //                 Name = "Hayes Beasley",
        //                 Email = "Beasley.Hayes@example.com",
        //                 Salary = 3727,
        //                 Skills = new() {"SQL Server" , "C++" , "NodeJS" , "Oracle" , "Javascript"  }
        //            },
        //            new Employee
        //            {

        //                 index = 12,
        //                 EmployeeNo = "2015-FI-3038",
        //                 Name = "Florine Cervantes",
        //                 Email = "Cervantes.Florine@example.com",
        //                 Salary = 3387,
        //                 Skills = new() {"HTML"  }
        //            },
        //            new Employee
        //            {

        //                 index=13,
        //                 EmployeeNo = "2017-AC-7409",
        //                 Name = "Bullock Carney",
        //                 Email = "Carney.Bullock@example.com",
        //                 Salary = 2144,
        //                 Skills = new() {"C++" , "CSS"  }
        //            },
        //            new Employee
        //            {

        //                 index = 13,
        //                 EmployeeNo = "2021-FI-3725",
        //                 Name = "Carroll Cantu",
        //                 Email = "Cantu.Carroll@example.com",
        //                 Salary = 3432,
        //                 Skills = new() {"C++" , "C#"  }
        //            },
        //            new Employee
        //            {

        //                 index = 14,
        //                 EmployeeNo = "2019-IT-9738",
        //                 Name = "Debra Hogan",
        //                 Email = "Hogan.Debra@example.com",
        //                 Salary = 2491,
        //                 Skills = new() {"Oracle" , "NodeJS" , "HTML" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-IT-7184",
        //                 Name = "Winnie Mccall",
        //                 Email = "Mccall.Winnie@example.com",
        //                 Salary = 2873,
        //                 Skills = new() {"CSS" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2015-IT-4664",
        //                 Name = "Manuela Berger",
        //                 Email = "Berger.Manuela@example.com",
        //                 Salary = 1725,
        //                 Skills = new() {"Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-IT-3609",
        //                 Name = "Lakeisha Lowe",
        //                 Email = "Lowe.Lakeisha@example.com",
        //                 Salary = 3143,
        //                 Skills = new() {"NodeJS" , "Oracle" , "CSS" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-FI-2682",
        //                 Name = "Stewart Lott",
        //                 Email = "Lott.Stewart@example.com",
        //                 Salary = 1466,
        //                 Skills = new() {"ASP.NET" , "C#" , "Javascript" , "SQL Server" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-IT-3754",
        //                 Name = "Stafford Peck",
        //                 Email = "Peck.Stafford@example.com",
        //                 Salary = 3207,
        //                 Skills = new() {"C++" , "ASP.NET"  },
        //                 Dpartment = "Sales"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2020-HR-7462",
        //                 Name = "Barron Bird",
        //                 Email = "Bird.Barron@example.com",
        //                 Salary = 1512,
        //                 Skills = new() {"NodeJS" , "Javascript" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2015-IT-5171",
        //                 Name = "Nona Brooks",
        //                 Email = "Brooks.Nona@example.com",
        //                 Salary = 1365,
        //                 Skills = new() {"HTML" , "NodeJS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-IT-6267",
        //                 Name = "Clara Reeves",
        //                 Email = "Reeves.Clara@example.com",
        //                 Salary = 2458,
        //                 Skills = new() {"ASP.NET" , "NodeJS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-IT-8208",
        //                 Name = "Karin Blanchard",
        //                 Email = "Blanchard.Karin@example.com",
        //                 Salary = 3412,
        //                 Skills = new() {"C#" , "SQL Server" , "NodeJS" , "CSS" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-AC-8905",
        //                 Name = "Burris Morgan",
        //                 Email = "Morgan.Burris@example.com",
        //                 Salary = 3603,
        //                 Skills = new() {"C++" , "CSS" , "ASP.NET" , "Oracle"  },
        //                 Dpartment = "Human resource"
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-IT-7496",
        //                 Name = "Owen Cortez",
        //                 Email = "Cortez.Owen@example.com",
        //                 Salary = 1937,
        //                 Skills = new() {"Oracle" , "Javascript" , "C++" , "NodeJS" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-AC-4762",
        //                 Name = "Letha Finch",
        //                 Email = "Finch.Letha@example.com",
        //                 Salary = 3572,
        //                 Skills = new() {"Oracle" , "CSS" , "NodeJS" , "C#" , "ASP.NET"  },
        //                 Dpartment = "Human resource"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-AC-2518",
        //                 Name = "Sondra Rojas",
        //                 Email = "Rojas.Sondra@example.com",
        //                 Salary = 3097,
        //                 Skills = new() {"Javascript" , "SQL Server"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2020-HR-9123",
        //                 Name = "Hoover Cook",
        //                 Email = "Cook.Hoover@example.com",
        //                 Salary = 2822,
        //                 Skills = new() {"Oracle" , "ASP.NET" , "Javascript" , "CSS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-AC-5938",
        //                 Name = "Wanda Bender",
        //                 Email = "Bender.Wanda@example.com",
        //                 Salary = 2942,
        //                 Skills = new() {"SQL Server" , "Javascript" , "NodeJS" , "C#" , "CSS"  },
        //                 Dpartment = "Hr"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2020-AC-6792",
        //                 Name = "Sanford Craig",
        //                 Email = "Craig.Sanford@example.com",
        //                 Salary = 2782,
        //                 Skills = new() {"NodeJS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-FI-7673",
        //                 Name = "Christy Middleton",
        //                 Email = "Middleton.Christy@example.com",
        //                 Salary = 3774,
        //                 Skills = new() {"CSS" , "C#"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-HR-7369",
        //                 Name = "Day Brady",
        //                 Email = "Brady.Day@example.com",
        //                 Salary = 1426,
        //                 Skills = new() {"SQL Server" , "Oracle" , "C++" , "CSS" , "ASP.NET"  },
        //                 Dpartment = "Human resource"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-FI-2740",
        //                 Name = "Powers Beard",
        //                 Email = "Beard.Powers@example.com",
        //                 Salary = 2240,
        //                 Skills = new() {"NodeJS" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-FI-6079",
        //                 Name = "Arline Pratt",
        //                 Email = "Pratt.Arline@example.com",
        //                 Salary = 3603,
        //                 Skills = new() {"Javascript" , "Oracle"  },
        //                 Dpartment = "Hr"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-AC-5189",
        //                 Name = "Sharpe Cardenas",
        //                 Email = "Cardenas.Sharpe@example.com",
        //                 Salary = 2661,
        //                 Skills = new() {"HTML" , "SQL Server" , "ASP.NET" , "Oracle" , "C++"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2020-AC-6920",
        //                 Name = "Madeleine Stanton",
        //                 Email = "Stanton.Madeleine@example.com",
        //                 Salary = 1983,
        //                 Skills = new() {"C#"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-FI-8160",
        //                 Name = "Spears Noble",
        //                 Email = "Noble.Spears@example.com",
        //                 Salary = 1763,
        //                 Skills = new() {"C#" , "HTML"  },
        //                 Dpartment = "Human resource"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-IT-7542",
        //                 Name = "Gonzalez Gilliam",
        //                 Email = "Gilliam.Gonzalez@example.com",
        //                 Salary = 3943,
        //                 Skills = new() {"Oracle" , "CSS" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-FI-1312",
        //                 Name = "Abigail Bradford",
        //                 Email = "Bradford.Abigail@example.com",
        //                 Salary = 2961,
        //                 Skills = new() {"C#" , "ASP.NET" , "HTML" , "NodeJS" , "CSS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2020-IT-4198",
        //                 Name = "Ashlee Farmer",
        //                 Email = "Farmer.Ashlee@example.com",
        //                 Salary = 1253,
        //                 Skills = new() {"Javascript" , "C++" , "SQL Server"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-IT-7772",
        //                 Name = "Glover Lloyd",
        //                 Email = "Lloyd.Glover@example.com",
        //                 Salary = 1230,
        //                 Skills = new() {"Oracle" , "CSS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-IT-4562",
        //                 Name = "Cleo Mays",
        //                 Email = "Mays.Cleo@example.com",
        //                 Salary = 2149,
        //                 Skills = new() {"SQL Server" , "NodeJS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-IT-4227",
        //                 Name = "Patrice House",
        //                 Email = "House.Patrice@example.com",
        //                 Salary = 1245,
        //                 Skills = new() {"Javascript" , "CSS" , "Oracle" , "C#"  },
        //                 Dpartment = "Hr"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2015-AC-6366",
        //                 Name = "Atkins Shannon",
        //                 Email = "Shannon.Atkins@example.com",
        //                 Salary = 1366,
        //                 Skills = new() {"Oracle" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-AC-1212",
        //                 Name = "Luisa Hopkins",
        //                 Email = "Hopkins.Luisa@example.com",
        //                 Salary = 1929,
        //                 Skills = new() {"C++" , "ASP.NET" , "Javascript" , "Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-IT-4794",
        //                 Name = "Kaufman Gross",
        //                 Email = "Gross.Kaufman@example.com",
        //                 Salary = 2236,
        //                 Skills = new() {"ASP.NET" , "HTML" , "C#" , "CSS" , "SQL Server"  },
        //                 Dpartment = "Human resource"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-HR-4395",
        //                 Name = "William Clay",
        //                 Email = "Clay.William@example.com",
        //                 Salary = 2375,
        //                 Skills = new() {"Javascript"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-IT-1387",
        //                 Name = "Alison Kirby",
        //                 Email = "Kirby.Alison@example.com",
        //                 Salary = 3548,
        //                 Skills = new() {"Javascript"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-AC-7846",
        //                 Name = "Morrow Lynch",
        //                 Email = "Lynch.Morrow@example.com",
        //                 Salary = 2814,
        //                 Skills = new() {"ASP.NET" , "C#"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-IT-3225",
        //                 Name = "Roach Bright",
        //                 Email = "Bright.Roach@example.com",
        //                 Salary = 3267,
        //                 Skills = new() {"Javascript" , "SQL Server" , "NodeJS" , "ASP.NET" , "C#"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-FI-6985",
        //                 Name = "Carolyn Justice",
        //                 Email = "Justice.Carolyn@example.com",
        //                 Salary = 1431,
        //                 Skills = new() {"HTML" , "C++" , "ASP.NET" , "Javascript" , "Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-FI-6331",
        //                 Name = "Cathryn Mathews",
        //                 Email = "Mathews.Cathryn@example.com",
        //                 Salary = 3660,
        //                 Skills = new() {"C++"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-AC-2870",
        //                 Name = "Lindsay Pruitt",
        //                 Email = "Pruitt.Lindsay@example.com",
        //                 Salary = 1073,
        //                 Skills = new() {"C#" , "NodeJS" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-AC-9730",
        //                 Name = "Cummings Webster",
        //                 Email = "Webster.Cummings@example.com",
        //                 Salary = 2227,
        //                 Skills = new() {"Oracle" , "NodeJS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-AC-5421",
        //                 Name = "Cannon Pace",
        //                 Email = "Pace.Cannon@example.com",
        //                 Salary = 3450,
        //                 Skills = new() {"HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-AC-1564",
        //                 Name = "Barber Singleton",
        //                 Email = "Singleton.Barber@example.com",
        //                 Salary = 1924,
        //                 Skills = new() {"Javascript"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-AC-8647",
        //                 Name = "Aileen Sweet",
        //                 Email = "Sweet.Aileen@example.com",
        //                 Salary = 2624,
        //                 Skills = new() {"CSS" , "Javascript" , "C++"  },
        //                 Dpartment = "Hr"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-FI-1877",
        //                 Name = "Lindsey Hughes",
        //                 Email = "Hughes.Lindsey@example.com",
        //                 Salary = 3700,
        //                 Skills = new() {"SQL Server" , "C++" , "CSS" , "C#" , "Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-FI-5494",
        //                 Name = "Stout Phillips",
        //                 Email = "Phillips.Stout@example.com",
        //                 Salary = 1510,
        //                 Skills = new() {"Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-AC-4682",
        //                 Name = "Benjamin Stephens",
        //                 Email = "Stephens.Benjamin@example.com",
        //                 Salary = 3996,
        //                 Skills = new() {"C#" , "NodeJS" , "CSS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-AC-8818",
        //                 Name = "Mandy Odom",
        //                 Email = "Odom.Mandy@example.com",
        //                 Salary = 2264,
        //                 Skills = new() {"SQL Server"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-AC-8946",
        //                 Name = "Hays Austin",
        //                 Email = "Austin.Hays@example.com",
        //                 Salary = 2920,
        //                 Skills = new() {"C#" , "Oracle" , "C++" , "CSS" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2020-HR-2271",
        //                 Name = "Jean Salas",
        //                 Email = "Salas.Jean@example.com",
        //                 Salary = 2116,
        //                 Skills = new() {"HTML" , "SQL Server" , "Javascript" , "Oracle" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-HR-3289",
        //                 Name = "Luann Hubbard",
        //                 Email = "Hubbard.Luann@example.com",
        //                 Salary = 3016,
        //                 Skills = new() {"Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-IT-2893",
        //                 Name = "Eaton Lyons",
        //                 Email = "Lyons.Eaton@example.com",
        //                 Salary = 2376,
        //                 Skills = new() {"C#" , "CSS" , "Javascript" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2015-HR-7939",
        //                 Name = "Beck Ortiz",
        //                 Email = "Ortiz.Beck@example.com",
        //                 Salary = 1929,
        //                 Skills = new() {"CSS" , "C#" , "SQL Server" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-IT-8169",
        //                 Name = "Patty Knight",
        //                 Email = "Knight.Patty@example.com",
        //                 Salary = 1731,
        //                 Skills = new() {"NodeJS" , "SQL Server" , "Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-IT-8048",
        //                 Name = "Bowman Hampton",
        //                 Email = "Hampton.Bowman@example.com",
        //                 Salary = 1452,
        //                 Skills = new() {"Oracle" , "ASP.NET" , "C#"  },
        //                 Dpartment = "Human resource"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-HR-9151",
        //                 Name = "Pace Bryant",
        //                 Email = "Bryant.Pace@example.com",
        //                 Salary = 1601,
        //                 Skills = new() {"CSS" , "Javascript" , "NodeJS" , "Oracle" , "SQL Server"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-FI-1631",
        //                 Name = "Watts Green",
        //                 Email = "Green.Watts@example.com",
        //                 Salary = 3303,
        //                 Skills = new() {"ASP.NET" , "Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-AC-4574",
        //                 Name = "Sonia Clarke",
        //                 Email = "Clarke.Sonia@example.com",
        //                 Salary = 2018,
        //                 Skills = new() {"C#" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-FI-2678",
        //                 Name = "Donovan Brennan",
        //                 Email = "Brennan.Donovan@example.com",
        //                 Salary = 2436,
        //                 Skills = new() {"SQL Server" , "Javascript" , "C#" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-IT-7173",
        //                 Name = "Rutledge Harris",
        //                 Email = "Harris.Rutledge@example.com",
        //                 Salary = 1533,
        //                 Skills = new() {"CSS" , "C#" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-FI-3360",
        //                 Name = "Buckley Meyers",
        //                 Email = "Meyers.Buckley@example.com",
        //                 Salary = 3420,
        //                 Skills = new() {"C#" , "HTML" , "Oracle" , "Javascript"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-AC-6780",
        //                 Name = "Reynolds Hammond",
        //                 Email = "Hammond.Reynolds@example.com",
        //                 Salary = 2326,
        //                 Skills = new() {"Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-HR-2514",
        //                 Name = "Butler Bowen",
        //                 Email = "Bowen.Butler@example.com",
        //                 Salary = 2391,
        //                 Skills = new() {"C++" , "SQL Server" , "Oracle" , "C#" , "NodeJS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-IT-8910",
        //                 Name = "Karina Miles",
        //                 Email = "Miles.Karina@example.com",
        //                 Salary = 1855,
        //                 Skills = new() {"CSS" , "NodeJS" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-AC-3932",
        //                 Name = "Fulton Conner",
        //                 Email = "Conner.Fulton@example.com",
        //                 Salary = 1981,
        //                 Skills = new() {"CSS" , "ASP.NET" , "Oracle" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-HR-1973",
        //                 Name = "Jewell Tran",
        //                 Email = "Tran.Jewell@example.com",
        //                 Salary = 2648,
        //                 Skills = new() {"ASP.NET" , "HTML" , "C++" , "Javascript"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-AC-3751",
        //                 Name = "Avis Herrera",
        //                 Email = "Herrera.Avis@example.com",
        //                 Salary = 2988,
        //                 Skills = new() {"C#" , "ASP.NET" , "Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-IT-4849",
        //                 Name = "Nora Dale",
        //                 Email = "Dale.Nora@example.com",
        //                 Salary = 3689,
        //                 Skills = new() {"SQL Server" , "ASP.NET" , "Javascript"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-AC-9189",
        //                 Name = "Hillary Duran",
        //                 Email = "Duran.Hillary@example.com",
        //                 Salary = 2822,
        //                 Skills = new() {"CSS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-HR-9193",
        //                 Name = "Hamilton Macias",
        //                 Email = "Macias.Hamilton@example.com",
        //                 Salary = 2373,
        //                 Skills = new() {"C#" , "Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-HR-8262",
        //                 Name = "Kent Parsons",
        //                 Email = "Parsons.Kent@example.com",
        //                 Salary = 1764,
        //                 Skills = new() {"C#"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-AC-6998",
        //                 Name = "Dunn Oliver",
        //                 Email = "Oliver.Dunn@example.com",
        //                 Salary = 2444,
        //                 Skills = new() {"C++" , "C#" , "NodeJS" , "Javascript" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2018-IT-7524",
        //                 Name = "Betsy Dean",
        //                 Email = "Dean.Betsy@example.com",
        //                 Salary = 1969,
        //                 Skills = new() {"HTML" , "SQL Server" , "Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2020-AC-1313",
        //                 Name = "Kay May",
        //                 Email = "May.Kay@example.com",
        //                 Salary = 2240,
        //                 Skills = new() {"HTML" , "Javascript" , "C#" , "CSS" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-IT-9981",
        //                 Name = "Farley Bartlett",
        //                 Email = "Bartlett.Farley@example.com",
        //                 Salary = 3696,
        //                 Skills = new() {"CSS"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-IT-9816",
        //                 Name = "Agnes Riggs",
        //                 Email = "Riggs.Agnes@example.com",
        //                 Salary = 1068,
        //                 Skills = new() {"SQL Server"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-HR-4458",
        //                 Name = "White Figueroa",
        //                 Email = "Figueroa.White@example.com",
        //                 Salary = 2264,
        //                 Skills = new() {"Oracle" , "ASP.NET" , "C#"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-HR-8991",
        //                 Name = "Estes Stone",
        //                 Email = "Stone.Estes@example.com",
        //                 Salary = 2938,
        //                 Skills = new() {"Javascript" , "C++" , "HTML"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-FI-4888",
        //                 Name = "Julia Contreras",
        //                 Email = "Contreras.Julia@example.com",
        //                 Salary = 2038,
        //                 Skills = new() {"C++" , "CSS" , "NodeJS" , "Javascript"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2017-FI-8639",
        //                 Name = "Cecilia Cooper",
        //                 Email = "Cooper.Cecilia@example.com",
        //                 Salary = 3294,
        //                 Skills = new() {"SQL Server" , "HTML"  },
        //                 Dpartment = "Hr"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2015-AC-2109",
        //                 Name = "Zelma Frank",
        //                 Email = "Frank.Zelma@example.com",
        //                 Salary = 3111,
        //                 Skills = new() {"Oracle"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2021-FI-4677",
        //                 Name = "Peters Morales",
        //                 Email = "Morales.Peters@example.com",
        //                 Salary = 1203,
        //                 Skills = new() {"C#" , "NodeJS" , "SQL Server" , "ASP.NET" , "C++"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2016-FI-1198",
        //                 Name = "Leigh Moss",
        //                 Email = "Moss.Leigh@example.com",
        //                 Salary = 1671,
        //                 Skills = new() {"Oracle" , "Javascript" , "C#" , "SQL Server" , "ASP.NET"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2014-FI-5416",
        //                 Name = "Megan Bailey",
        //                 Email = "Bailey.Megan@example.com",
        //                 Salary = 2325,
        //                 Skills = new() {"CSS" , "ASP.NET" , "HTML"  },
        //                 Dpartment = "Human resource"

        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2020-FI-1804",
        //                 Name = "Juliana Pope",
        //                 Email = "Pope.Juliana@example.com",
        //                 Salary = 3053,
        //                 Skills = new() {"C#" , "SQL Server"  }
        //            },
        //            new Employee
        //            {
        //                 EmployeeNo = "2019-IT-1162",
        //                 Name = "Cervantes Wong",
        //                 Email = "Wong.Cervantes@example.com",
        //                 Salary = 2351,
        //                 Skills = new() {"CSS" , "HTML" , "ASP.NET" , "NodeJS" , "Javascript"  }
        //            }
        //    };
        //}





        public static IEnumerable<Department> LoadDepartment()
        {
            return new List<Department> {
                new Department { Id = 1, Name = "FINANCE" },
                new Department { Id = 2, Name = "IT" },
                new Department { Id = 3, Name = "HR" },
                new Department { Id = 4, Name = "ACCOUNTING" },
                new Department { Id = 5, Name = "SALES" }
            };
        }
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                        Id = 1001,
                        FirstName = "Coc3an",
                        LastName = "Cole",
                        HireDate = new DateTime(2017, 11, 2),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 103200m
                },
                new Employee
                {
                        Id = 1002,
                        FirstName = "Jaclyn",
                        LastName = "Wolfe",
                        HireDate = new DateTime(2018, 4, 14),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 192400m
                },
                new Employee
                {
                        Id = 1003,
                        FirstName = "Warner",
                        LastName = "Jones",
                        HireDate = new DateTime(2016, 12, 13),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 172800m
                },
                new Employee
                {
                        Id = 1004,
                        FirstName = "Hester",
                        LastName = "Evans",
                        HireDate = new DateTime(2016, 8, 17),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 155500m
                },
                new Employee
                {
                        Id = 1005,
                        FirstName = "Wallace",
                        LastName = "Buck",
                        HireDate = new DateTime(2014, 5, 12),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 315800m
                },
                new Employee
                {
                        Id = 1006,
                        FirstName = "Acevedo",
                        LastName = "Wall",
                        HireDate = new DateTime(2020, 10, 30),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 343700m
                },
                new Employee
                {
                        Id = 1007,
                        FirstName = "Jacqueline",
                        LastName = "Pickett",
                        HireDate = new DateTime(2021, 2, 17),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 370000m
                },
                new Employee
                {
                        Id = 1008,
                        FirstName = "Oconnor",
                        LastName = "Espinoza",
                        HireDate = new DateTime(2017, 3, 12),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 155600m
                },
                new Employee
                {
                        Id = 1009,
                        FirstName = "Allie",
                        LastName = "Elliott",
                        HireDate = new DateTime(2020, 4, 20),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 315400m
                },
                new Employee
                {
                        Id = 1010,
                        FirstName = "Elva",
                        LastName = "Decker",
                        HireDate = new DateTime(2016, 9, 6),
                        Gender = "female",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 345900m
                },
                new Employee
                {
                        Id = 1011,
                        FirstName = "Hayes",
                        LastName = "Beasley",
                        HireDate = new DateTime(2020, 4, 25),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 372700m
                },
                new Employee
                {
                        Id = 1012,
                        FirstName = "Florine",
                        LastName = "Cervantes",
                        HireDate = new DateTime(2015, 3, 25),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 338700m
                },
                new Employee
                {
                        Id = 1013,
                        FirstName = "Bullock",
                        LastName = "Carney",
                        HireDate = new DateTime(2017, 1, 3),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 214400m
                },
                new Employee
                {
                        Id = 1014,
                        FirstName = "Carroll",
                        LastName = "Cantu",
                        HireDate = new DateTime(2021, 5, 26),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 343200m
                },
                new Employee
                {
                        Id = 1015,
                        FirstName = "Debra",
                        LastName = "Hogan",
                        HireDate = new DateTime(2019, 10, 4),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 249100m
                },
                new Employee
                {
                        Id = 1016,
                        FirstName = "Winnie",
                        LastName = "Mccall",
                        HireDate = new DateTime(2019, 7, 17),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 287300m
                },
                new Employee
                {
                        Id = 1017,
                        FirstName = "Manuela",
                        LastName = "Berger",
                        HireDate = new DateTime(2015, 12, 11),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 172500m
                },
                new Employee
                {
                        Id = 1018,
                        FirstName = "Lakeisha",
                        LastName = "Lowe",
                        HireDate = new DateTime(2017, 1, 18),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 314300m
                },
                new Employee
                {
                        Id = 1019,
                        FirstName = "Stewart",
                        LastName = "Lott",
                        HireDate = new DateTime(2016, 12, 12),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 146600m
                },
                new Employee
                {
                        Id = 1020,
                        FirstName = "Stafford",
                        LastName = "Peck",
                        HireDate = new DateTime(2014, 9, 25),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 320700m
                },
                new Employee
                {
                        Id = 1021,
                        FirstName = "Barron",
                        LastName = "Bird",
                        HireDate = new DateTime(2020, 5, 18),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 151200m
                },
                new Employee
                {
                        Id = 1022,
                        FirstName = "Nona",
                        LastName = "Brooks",
                        HireDate = new DateTime(2015, 12, 4),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 136500m
                },
                new Employee
                {
                        Id = 1023,
                        FirstName = "Clara",
                        LastName = "Reeves",
                        HireDate = new DateTime(2014, 12, 6),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 245800m
                },
                new Employee
                {
                        Id = 1024,
                        FirstName = "Karin",
                        LastName = "Blanchard",
                        HireDate = new DateTime(2018, 1, 20),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 341200m
                },
                new Employee
                {
                        Id = 1025,
                        FirstName = "Burris",
                        LastName = "Morgan",
                        HireDate = new DateTime(2019, 7, 6),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 360300m
                },
                new Employee
                {
                        Id = 1026,
                        FirstName = "Owen",
                        LastName = "Cortez",
                        HireDate = new DateTime(2021, 12, 9),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 193700m
                },
                new Employee
                {
                        Id = 1027,
                        FirstName = "Letha",
                        LastName = "Finch",
                        HireDate = new DateTime(2016, 12, 18),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 357200m
                },
                new Employee
                {
                        Id = 1028,
                        FirstName = "Sondra",
                        LastName = "Rojas",
                        HireDate = new DateTime(2016, 4, 22),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 309700m
                },
                new Employee
                {
                        Id = 1029,
                        FirstName = "Hoover",
                        LastName = "Cook",
                        HireDate = new DateTime(2020, 12, 17),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 282200m
                },
                new Employee
                {
                        Id = 1030,
                        FirstName = "Wanda",
                        LastName = "Bender",
                        HireDate = new DateTime(2021, 6, 17),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 294200m
                },
                new Employee
                {
                        Id = 1031,
                        FirstName = "Sanford",
                        LastName = "Craig",
                        HireDate = new DateTime(2020, 2, 27),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 278200m
                },
                new Employee
                {
                        Id = 1032,
                        FirstName = "C3isty",
                        LastName = "Middleton",
                        HireDate = new DateTime(2021, 4, 2),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 377400m
                },
                new Employee
                {
                        Id = 1033,
                        FirstName = "Day",
                        LastName = "Brady",
                        HireDate = new DateTime(2019, 1, 23),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 142600m
                },
                new Employee
                {
                        Id = 1034,
                        FirstName = "Powers",
                        LastName = "Beard",
                        HireDate = new DateTime(2014, 4, 25),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 224000m
                },
                new Employee
                {
                        Id = 1035,
                        FirstName = "Arline",
                        LastName = "Pratt",
                        HireDate = new DateTime(2017, 8, 12),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 360300m
                },
                new Employee
                {
                        Id = 1036,
                        FirstName = "Sharpe",
                        LastName = "Cardenas",
                        HireDate = new DateTime(2017, 11, 28),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 266100m
                },
                new Employee
                {
                        Id = 1037,
                        FirstName = "Madeleine",
                        LastName = "Stanton",
                        HireDate = new DateTime(2020, 7, 17),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 198300m
                },
                new Employee
                {
                        Id = 1038,
                        FirstName = "Spears",
                        LastName = "Noble",
                        HireDate = new DateTime(2014, 10, 6),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 176300m
                },
                new Employee
                {
                        Id = 1039,
                        FirstName = "Gonzalez",
                        LastName = "Gilliam",
                        HireDate = new DateTime(2021, 4, 29),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 394300m
                },
                new Employee
                {
                        Id = 1040,
                        FirstName = "Abigail",
                        LastName = "Bradford",
                        HireDate = new DateTime(2018, 4, 2),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 296100m
                },
                new Employee
                {
                        Id = 1041,
                        FirstName = "Ashlee",
                        LastName = "Farmer",
                        HireDate = new DateTime(2020, 9, 24),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 125300m
                },
                new Employee
                {
                        Id = 1042,
                        FirstName = "Glover",
                        LastName = "Lloyd",
                        HireDate = new DateTime(2014, 2, 15),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 123000m
                },
                new Employee
                {
                        Id = 1043,
                        FirstName = "Cleo",
                        LastName = "Mays",
                        HireDate = new DateTime(2018, 4, 24),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 214900m
                },
                new Employee
                {
                        Id = 1044,
                        FirstName = "Patrice",
                        LastName = "House",
                        HireDate = new DateTime(2021, 10, 16),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 124500m
                },
                new Employee
                {
                        Id = 1045,
                        FirstName = "Atkins",
                        LastName = "Shannon",
                        HireDate = new DateTime(2015, 9, 26),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 136600m
                },
                new Employee
                {
                        Id = 1046,
                        FirstName = "Luisa",
                        LastName = "Hopkins",
                        HireDate = new DateTime(2016, 8, 1),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 192900m
                },
                new Employee
                {
                        Id = 1047,
                        FirstName = "Kaufman",
                        LastName = "Gross",
                        HireDate = new DateTime(2016, 7, 24),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 223600m
                },
                new Employee
                {
                        Id = 1048,
                        FirstName = "William",
                        LastName = "Clay",
                        HireDate = new DateTime(2014, 8, 24),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 237500m
                },
                new Employee
                {
                        Id = 1049,
                        FirstName = "Alison",
                        LastName = "Kirby",
                        HireDate = new DateTime(2014, 7, 14),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 354800m
                },
                new Employee
                {
                        Id = 1050,
                        FirstName = "Morrow",
                        LastName = "Lynch",
                        HireDate = new DateTime(2014, 6, 4),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 281400m
                },
                new Employee
                {
                        Id = 1051,
                        FirstName = "Roach",
                        LastName = "Bright",
                        HireDate = new DateTime(2019, 9, 14),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 326700m
                },
                new Employee
                {
                        Id = 1052,
                        FirstName = "Carolyn",
                        LastName = "Justice",
                        HireDate = new DateTime(2019, 8, 29),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 143100m
                },
                new Employee
                {
                        Id = 1053,
                        FirstName = "Cat3yn",
                        LastName = "Mathews",
                        HireDate = new DateTime(2016, 5, 31),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 366000m
                },
                new Employee
                {
                        Id = 1054,
                        FirstName = "Lindsay",
                        LastName = "Pru2t",
                        HireDate = new DateTime(2016, 6, 9),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 107300m
                },
                new Employee
                {
                        Id = 1055,
                        FirstName = "Cummings",
                        LastName = "Webster",
                        HireDate = new DateTime(2016, 1, 24),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 222700m
                },
                new Employee
                {
                        Id = 1056,
                        FirstName = "Cannon",
                        LastName = "Pace",
                        HireDate = new DateTime(2017, 7, 29),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 345000m
                },
                new Employee
                {
                        Id = 1057,
                        FirstName = "Barber",
                        LastName = "Singleton",
                        HireDate = new DateTime(2017, 5, 8),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 192400m
                },
                new Employee
                {
                        Id = 1058,
                        FirstName = "Aileen",
                        LastName = "Sweet",
                        HireDate = new DateTime(2018, 7, 4),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 262400m
                },
                new Employee
                {
                        Id = 1059,
                        FirstName = "Lindsey",
                        LastName = "Hughes",
                        HireDate = new DateTime(2014, 4, 26),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 370000m
                },
                new Employee
                {
                        Id = 1060,
                        FirstName = "Stout",
                        LastName = "Phillips",
                        HireDate = new DateTime(2019, 6, 19),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 151000m
                },
                new Employee
                {
                        Id = 1061,
                        FirstName = "Benjamin",
                        LastName = "Stephens",
                        HireDate = new DateTime(2021, 5, 7),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 399600m
                },
                new Employee
                {
                        Id = 1062,
                        FirstName = "Mandy",
                        LastName = "Odom",
                        HireDate = new DateTime(2018, 10, 28),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 226400m
                },
                new Employee
                {
                        Id = 1063,
                        FirstName = "Hays",
                        LastName = "Austin",
                        HireDate = new DateTime(2017, 5, 28),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 292000m
                },
                new Employee
                {
                        Id = 1064,
                        FirstName = "Jean",
                        LastName = "Salas",
                        HireDate = new DateTime(2020, 10, 27),
                        Gender = "female",
                        DepartmentId = 3,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 211600m
                },
                new Employee
                {
                        Id = 1065,
                        FirstName = "Luann",
                        LastName = "Hubbard",
                        HireDate = new DateTime(2021, 7, 17),
                        Gender = "female",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 301600m
                },
                new Employee
                {
                        Id = 1066,
                        FirstName = "Eaton",
                        LastName = "Lyons",
                        HireDate = new DateTime(2021, 7, 3),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 237600m
                },
                new Employee
                {
                        Id = 1067,
                        FirstName = "Beck",
                        LastName = "Ortiz",
                        HireDate = new DateTime(2015, 5, 13),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 192900m
                },
                new Employee
                {
                        Id = 1068,
                        FirstName = "Patty",
                        LastName = "Knight",
                        HireDate = new DateTime(2017, 8, 22),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 173100m
                },
                new Employee
                {
                        Id = 1069,
                        FirstName = "Bowman",
                        LastName = "Hampton",
                        HireDate = new DateTime(2017, 10, 10),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 145200m
                },
                new Employee
                {
                        Id = 1070,
                        FirstName = "Pace",
                        LastName = "Bryant",
                        HireDate = new DateTime(2019, 3, 1),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 160100m
                },
                new Employee
                {
                        Id = 1071,
                        FirstName = "Watts",
                        LastName = "Green",
                        HireDate = new DateTime(2016, 10, 17),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 330300m
                },
                new Employee
                {
                        Id = 1072,
                        FirstName = "Sonia",
                        LastName = "Clarke",
                        HireDate = new DateTime(2014, 9, 15),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 201800m
                },
                new Employee
                {
                        Id = 1073,
                        FirstName = "Donovan",
                        LastName = "Brennan",
                        HireDate = new DateTime(2018, 5, 18),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 243600m
                },
                new Employee
                {
                        Id = 1074,
                        FirstName = "Rutledge",
                        LastName = "Harris",
                        HireDate = new DateTime(2016, 7, 10),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 153300m
                },
                new Employee
                {
                        Id = 1075,
                        FirstName = "Buckley",
                        LastName = "Meyers",
                        HireDate = new DateTime(2021, 10, 16),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 342000m
                },
                new Employee
                {
                        Id = 1076,
                        FirstName = "Reynolds",
                        LastName = "Hammond",
                        HireDate = new DateTime(2019, 10, 9),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 232600m
                },
                new Employee
                {
                        Id = 1077,
                        FirstName = "Butler",
                        LastName = "Bowen",
                        HireDate = new DateTime(2019, 8, 13),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 239100m
                },
                new Employee
                {
                        Id = 1078,
                        FirstName = "Karina",
                        LastName = "Miles",
                        HireDate = new DateTime(2018, 11, 20),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 185500m
                },
                new Employee
                {
                        Id = 1079,
                        FirstName = "Fulton",
                        LastName = "Conner",
                        HireDate = new DateTime(2018, 7, 12),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 198100m
                },
                new Employee
                {
                        Id = 1080,
                        FirstName = "Jewell",
                        LastName = "Tran",
                        HireDate = new DateTime(2019, 6, 22),
                        Gender = "female",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 264800m
                },
                new Employee
                {
                        Id = 1081,
                        FirstName = "Avis",
                        LastName = "Herrera",
                        HireDate = new DateTime(2017, 11, 17),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 298800m
                },
                new Employee
                {
                        Id = 1082,
                        FirstName = "Nora",
                        LastName = "Dale",
                        HireDate = new DateTime(2021, 7, 26),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 368900m
                },
                new Employee
                {
                        Id = 1083,
                        FirstName = "Hillary",
                        LastName = "Duran",
                        HireDate = new DateTime(2017, 2, 19),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 282200m
                },
                new Employee
                {
                        Id = 1084,
                        FirstName = "Hamilton",
                        LastName = "Macias",
                        HireDate = new DateTime(2017, 10, 21),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 237300m
                },
                new Employee
                {
                        Id = 1085,
                        FirstName = "Kent",
                        LastName = "Parsons",
                        HireDate = new DateTime(2018, 3, 30),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 176400m
                },
                new Employee
                {
                        Id = 1086,
                        FirstName = "Dunn",
                        LastName = "Oliver",
                        HireDate = new DateTime(2018, 9, 3),
                        Gender = "male",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 244400m
                },
                new Employee
                {
                        Id = 1087,
                        FirstName = "Betsy",
                        LastName = "Dean",
                        HireDate = new DateTime(2018, 11, 23),
                        Gender = "female",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 196900m
                },
                new Employee
                {
                        Id = 1088,
                        FirstName = "Kay",
                        LastName = "May",
                        HireDate = new DateTime(2020, 9, 8),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 224000m
                },
                new Employee
                {
                        Id = 1089,
                        FirstName = "Farley",
                        LastName = "Bartlett",
                        HireDate = new DateTime(2014, 7, 3),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 369600m
                },
                new Employee
                {
                        Id = 1090,
                        FirstName = "Agnes",
                        LastName = "Riggs",
                        HireDate = new DateTime(2016, 11, 20),
                        Gender = "female",
                        DepartmentId = 5,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 106800m
                },
                new Employee
                {
                        Id = 1091,
                        FirstName = "Whe",
                        LastName = "Figueroa",
                        HireDate = new DateTime(2014, 6, 30),
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 226400m
                },
                new Employee
                {
                        Id = 1092,
                        FirstName = "Estes",
                        LastName = "Stone",
                        HireDate = new DateTime(2016, 7, 10),
                        Gender = "male",
                        DepartmentId = 5,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 293800m
                },
                new Employee
                {
                        Id = 1093,
                        FirstName = "Julia",
                        LastName = "Contreras",
                        HireDate = new DateTime(2017, 7, 1),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 203800m
                },
                new Employee
                {
                        Id = 1094,
                        FirstName = "Cecilia",
                        LastName = "Cooper",
                        HireDate = new DateTime(2017, 3, 31),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 329400m
                },
                new Employee
                {
                        Id = 1095,
                        FirstName = "Zelma",
                        LastName = "Frank",
                        HireDate = new DateTime(2015, 11, 29),
                        Gender = "female",
                        DepartmentId = 4,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 311100m
                },
                new Employee
                {
                        Id = 1096,
                        FirstName = "Peters",
                        LastName = "Morales",
                        HireDate = new DateTime(2021, 5, 19),
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 120300m
                },
                new Employee
                {
                        Id = 1097,
                        FirstName = "Leigh",
                        LastName = "Moss",
                        HireDate = new DateTime(2016, 8, 2),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 167100m
                },
                new Employee
                {
                        Id = 1098,
                        FirstName = "Megan",
                        LastName = "Bailey",
                        HireDate = new DateTime(2014, 3, 4),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 232500m
                },
                new Employee
                {
                        Id = 1099,
                        FirstName = "Juliana",
                        LastName = "Pope",
                        HireDate = new DateTime(2020, 7, 3),
                        Gender = "female",
                        DepartmentId = 1,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 305300m
                },
                new Employee
                {
                        Id = 1100,
                        FirstName = "Cervantes",
                        LastName = "Wong",
                        HireDate = new DateTime(2019, 11, 8),
                        Gender = "male",
                        DepartmentId = 2,
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 235100m
                }
            };
        }

    }
}
