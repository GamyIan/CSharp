using System.ComponentModel.DataAnnotations;

namespace Data_Structures
{

    public class Employee
    {
        public int eno,age;
        public String name;
        public double salary;

        public Employee(int eno, String name, int age, double salary) {
            this.eno = eno;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            employees[0] = new Employee(100, "Ian", 20, 70000);
            employees[1] = new Employee(101, "Saksham", 40, 80000);
            employees[2] = new Employee(102, "Ona", 70, 50000);
            employees[3] = new Employee(103, "Eshaan", 50, 30000);
            employees[4] = new Employee(104, "Vernon", 20, 10000);
            employees[5] = new Employee(105, "Krutansh", 20, 100000);
            employees[6] = new Employee(106, "Shreyas", 53, 90000);
            employees[7] = new Employee(107, "Siddharth", 67, 70000);
            employees[8] = new Employee(108, "Gladwin", 69, 10000);
            employees[9] = new Employee(109, "Manthan", 30, 1000);

            Employee max = employees[0];

            Console.WriteLine("Employees over the age of 50");
            foreach (Employee employee in employees)
            {

                if (employee.age > 50)
                {
                    Console.WriteLine(employee.name);
                    Console.WriteLine(employee.age);
                }
                if (employee.salary > max.salary)
                {
                    max = employee;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Max:" + max.name);
            Console.WriteLine("Max Salary:" + max.salary);
        }
    }
}
