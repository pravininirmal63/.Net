using day4Practice;
using System.Diagnostics;
using System.Drawing;

namespace tst;

public class Tester
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello world");

        string[] list = { "pravin", "saurabh", "ganesh", "prashant", "aniket" };
        foreach(string l in list)
        {
            Console.WriteLine(l);
        }
        Console.WriteLine();
        Array.Sort(list);
        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine(list[i]);
        }

        //Console.WriteLine("Enter the size of the array: ");
        //int[] numbers = new int[int.Parse(Console.ReadLine())];

        //Console.WriteLine("Enter the elements in the aray: ");

        //for(int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        //Array.Sort(numbers);
        //foreach(int n in numbers)
        //{
        //    Console.WriteLine(n);
        //}

        ClassA abc = new ClassA();
        int res=abc.Add(10, 20);
        Console.WriteLine("Addition is :"+res);

        Console.WriteLine(abc.Add(10, 20, 30));
        Console.WriteLine(abc.Add(10,20,30,70,80));

        //Cars maruti = new Cars();
        //Console.WriteLine("Enter id color and the price: ");
        //Cars ferrari = new Cars(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()));

        //ferrari.MyProperty = 10;
        //Console.WriteLine(ferrari.MyProperty);
        Ferrari f = new Ferrari(20, "blue", 45000, 5);
        Console.WriteLine(f);
    }

}