using AbstractClass;

Employee[] emp = new Employee[2];
//upcasting 
emp[0] = new Manager();
emp[1] = new SalesManager();

foreach (Employee e in emp)
{

    //downcasting
    e.GetEmployeeDetails();
    if (e is Manager)
    {
        ((Manager)e).ManagerInfo();
    }
    if(e is SalesManager)
    {
    ((SalesManager)e).SalesManagerInfo();
    }
}
const int a = 10;
Console.WriteLine(a);