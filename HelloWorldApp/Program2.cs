// See https://aka.ms/new-console-template for more information
namespace app;
class NewClass
{

    public NewClass()
    {
        Console.WriteLine("in the coinstructor of NewClass...!!");
    }

    public static int add(int a, int b)
    {
        Console.WriteLine("in add method(static method)");
        return a + b;
    }

    public double substract(double a, double b)
    {
        Console.WriteLine("in substracyt method");
        return (b - a);
    }
}

