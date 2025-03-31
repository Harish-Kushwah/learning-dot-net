using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Assignments
{

    // Interface definition
    interface IEmployee
    {
        double CalculateBonus();
        void DisplayDetails();
    }

    // Base class with different constructors
    abstract class Person
    {
        private string name;          // Private field
        protected int age;            // Protected field for inheritance
        public static int personCount; // Static field

        // Static constructor
        static Person()
        {
            personCount = 0;
            Console.WriteLine("Static constructor called: Person class initialized");
        }

        // Private constructor
        private Person()
        {
            name = "Unknown";
            age = 0;
            personCount++;
        }

        // Public constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            personCount++;
        }

        // Virtual method
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Abstract method
        public abstract string GetRole();
    }

    // Derived class implementing interface
    class Employee : Person, IEmployee
    {
        private double salary;
        private string department;

        public Employee(string name, int age, double salary, string department)
            : base(name, age)
        {
            this.salary = salary;
            this.department = department;
        }

        // Override virtual method from base class
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Salary: {salary}, Department: {department}");
        }

        // Implementation of abstract method
        public override string GetRole()
        {
            return "Employee";
        }

        // Interface implementations
        public double CalculateBonus()
        {
            return salary * 0.1; // 10% bonus
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\nEmployee Details:");
            ShowInfo();
            Console.WriteLine($"Bonus: {CalculateBonus()}");
        }
    }

    class Manager : Employee
    {
        private int teamSize;

        public Manager(string name, int age, double salary, string department, int teamSize)
            : base(name, age, salary, department)
        {
            this.teamSize = teamSize;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Manager Info - Team Size: {teamSize}");
            base.ShowInfo();
        }

        // Override abstract method
        public override string GetRole()
        {
            return "Manager";
        }

        // Override interface method
        public new double CalculateBonus()
        {
            return base.CalculateBonus() + (teamSize * 1000); // Additional bonus for team management
        }
    }

   public class Assignment3
    {
        public void TestAssignment3()
        {
            // Create Employee object
            Employee emp = new("John Doe", 30, 50000, "IT");
            Console.WriteLine("\n=== Employee Demo ===");
            emp.ShowInfo();           // Virtual method overridden
            emp.DisplayDetails();     // Interface method
            Console.WriteLine($"Role: {emp.GetRole()}");
            Console.WriteLine($"Total Persons: {Person.personCount}");

            // Create Manager object
            Manager mgr = new("Jane Smith", 40, 80000, "HR", 5);
            Console.WriteLine("\n=== Manager Demo ===");
            mgr.ShowInfo();           // New method hiding base implementation
            mgr.DisplayDetails();     // Interface method
            Console.WriteLine($"Role: {mgr.GetRole()}");
            Console.WriteLine($"Total Persons: {Person.personCount}");

            // Demonstrate polymorphism
            Console.WriteLine("\n=== Polymorphism Demo ===");
            Person[] people = [emp, mgr];
            foreach (Person p in people)
            {
                p.ShowInfo();         // Different implementations based on actual type
                Console.WriteLine($"Role: {p.GetRole()}");
                Console.WriteLine("-----------");
            }
        }
    }
}
