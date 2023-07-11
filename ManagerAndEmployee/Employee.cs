namespace com.emp;

public class Employee
{
    private static int idgen = 0;
    private int id;
    private string name;
    private double salary;

    public Employee()
    {
        Console.WriteLine("in the defalt constructor of Emploeyee");
    }

    public Employee(string name, double salary)
    {
        Console.WriteLine("int the parameterised constructor of Emploeyee");
        idgen++;
        this.id = idgen;
        this.name = name;
        this.salary = salary;
    }

    public override string ToString()
    {
        return "id: " + id + ", name: " + name + ", salary: " + salary;
    }

    public double ComputeSalary()
    {
        double totalSalary;
        totalSalary = this.salary;
        return totalSalary;
    }

}