namespace tester;
using MyFirstProject;
public class Tester
{
    public static void Main(String[] args)
    {

        Student student = new Student(10, "Privin Nirmal", "pravin@gmail.com", 1520.30);
        //Console.WriteLine(student);

        //Console.WriteLine(student.Name);
        //student.Name = "ganesh patil";

        //string s = string.Format("{0},{1},{2}", student.Name, student.id, student.Email);

        //Console.WriteLine(s);

        List<Student> list = new List<Student>();
        list.Add(student);
        foreach(Student l in list)
        {
            Console.WriteLine(l);
        }



    }
}
