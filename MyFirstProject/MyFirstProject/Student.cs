using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Student
    {
        internal int id;
        private string name;
        private string email;
        private double salary;


        public Student()
        {
            Console.WriteLine("default constructor...!!!");
        }

        public Student(int id, string name, string email, double salary)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "id: " + id + ", name: " + name + ", mail: " + email;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        
    }
}
