using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.Data.Linq;


namespace FirstProject.Assignments
{
    internal class Assignment8
    {
        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }

            public Employee(int ID, string Name, string Department)
            {
                this.ID = ID;
                this.Name = Name;
                this.Department = Department;
            }
        }
        public void LinqToArray()
        {
            Console.WriteLine("Linq To Array");

            int[] numbers = { 10, 5, 8, 3, 15, 20, 7 };

                // LINQ query to filter and sort numbers greater than 5
                var result = numbers.Where(n => n > 5).OrderBy(n => n);

                Console.WriteLine("Filtered and Sorted Numbers:");
                foreach (var num in result)
                {
                    Console.WriteLine(num);
                }
            }

        public void LinqToXML()
        {
            Console.WriteLine("Linq To XML");

            // Creating XML data
            XElement employees = new XElement("Employees",
                new XElement("Employee", new XAttribute("ID", 1), new XElement("Name", "Alice"), new XElement("Department", "IT")),
                new XElement("Employee", new XAttribute("ID", 2), new XElement("Name", "Bob"), new XElement("Department", "HR"))
            );

            // Querying XML
            var result = from emp in employees.Elements("Employee")
                         where emp.Element("Department").Value == "IT"
                         select emp.Element("Name").Value;

            Console.WriteLine("Employees in IT Department:");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        //public void LinqToSQL()
        //{
        //    Console.WriteLine("Linq To SQL");

        //    string connectionString = "Data Source=Harish;Initial Catalog=harish_test_db;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        //        DataContext db = new DataContext(connectionString);

        //        // Assuming a table named "Employees" exists in the database
        //        var employees = from e in db.GetTable<Employee>()
        //                        where e.Department == "IT"
        //                        select e;

        //        Console.WriteLine("Employees in IT Department:");
        //        foreach (var emp in employees)
        //        {
        //            Console.WriteLine($"{emp.ID} - {emp.Name}");
        //        }
        //    }

        public void LinqToCollection()
        {
            Console.WriteLine("Linq To Collection");

            Employee emp1 = new Employee(1, "Harish", "CSE");
            Employee emp2 = new Employee(1, "Ganesh", "CS");
            Employee emp3 = new Employee(1, "Arin", "IT");

            List<Employee> employees = new List<Employee>{emp1,emp2,emp3};

                // LINQ query to get employees in IT department
                var result = employees.Where(e => e.Department == "IT").OrderBy(e => e.Name);

                Console.WriteLine("Employees in IT Department:");
                foreach (var emp in result)
                {
                    Console.WriteLine($"{emp.ID} - {emp.Name}");
                }
            }
   
        public void TestAssignment8()
        {
            LinqToArray();
            LinqToXML();
            //LinqToSQL();
            LinqToCollection();


        }
    
    }
}
