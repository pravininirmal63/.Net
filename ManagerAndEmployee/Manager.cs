namespace com.mgr;
using com.emp;
public class Manager : Employee
{

    // private int id;
    // private string name;
    // private double salary;
    private double bonus;


    public Manager()
    {
        Console.WriteLine("default costructor..");
    }


    public Manager(string name, double salary, double bonus) : base(name, salary)
    {
        Console.WriteLine("Manager's parameterised costructor..");

        this.bonus = bonus;
    }


    public override string ToString()
    {
        return "" + base.ToString() + ", bonus: " + this.bonus;
    }
    // public void display(){
    //     Console.WriteLine("id:"+id+", name:"+name+", salary:"+salary);
    // }

    public double ComputeSalary()
    {
        double totalSalary = base.ComputeSalary() + this.bonus;
        return totalSalary;
    }

}