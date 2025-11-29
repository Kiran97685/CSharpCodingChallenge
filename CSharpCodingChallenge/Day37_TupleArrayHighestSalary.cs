using System;

namespace CSharpCodingChallenge
{
    internal class Day37_TupleArrayHighestSalary
    {
        public void FindHighestPaidEmployee()
        {
            // Tuple format: (Name, Department, Salary)
            Tuple<string, string, double>[] employees =
            {
                Tuple.Create("John", "IT", 75000.50),
                Tuple.Create("Sara", "HR", 68000.00),
                Tuple.Create("Michael", "Finance", 82000.75),
                Tuple.Create("Emma", "IT", 79000.25),
                Tuple.Create("David", "Sales", 72000.40),
            };

            Tuple<string, string, double> highest = employees[0];

            for (int i = 1; i < employees.Length; i++)
            {
                if (employees[i].Item3 > highest.Item3)
                {
                    highest = employees[i];
                }
            }

            Console.WriteLine("Highest Paid Employee:");
            Console.WriteLine("Name: " + highest.Item1);
            Console.WriteLine("Department: " + highest.Item2);
            Console.WriteLine("Salary: " + highest.Item3);
        }
    }
}
