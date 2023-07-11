// See https://aka.ms/new-console-template for more information

using com.mgr;
using com.emp;

class Tester
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Start of the application ");
        System.Console.WriteLine("Enter name and salary: ");
        string name = Console.ReadLine();
        double sal = int.Parse(Console.ReadLine());
        Employee emp1 = new Employee(name, sal);
        // Employee emp2 = new Employee("Saurabh", 1300);
        Console.WriteLine(emp1);
        System.Console.WriteLine("salary of Employee is :" + emp1.ComputeSalary());
        // Console.WriteLine(emp2);

        System.Console.WriteLine();
        System.Console.WriteLine("Enter name salary and bonus: ");
        name = Console.ReadLine();
        sal = double.Parse(Console.ReadLine());
        double bonus = double.Parse(Console.ReadLine());
        Manager mgr1 = new Manager(name, sal, bonus);
        System.Console.WriteLine(mgr1);
        System.Console.WriteLine("salary of the manager: " + mgr1.ComputeSalary());
    }
}
