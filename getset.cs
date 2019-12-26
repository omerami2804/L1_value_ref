using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.Age = 8;
            per.firstName = ;
            Console.WriteLine(per.Age);
            


        }
    }
    public class Person
    {
        public string firstName;
        int age;

        public string FirstName
        {
            get
            {
                if (age < 18)
                {
                    Console.WriteLine("go to hell");
                }
                else
                {
                    Console.WriteLine(firstName);
                }
            }
            set { firstName = value; }
        }
        public int Age
        {
            get { return age;}
            set { age = value; }
        }

        public string LastName { get; set; }
        //in short version you can't edit the properties, i.e add if else loop

    }

    }
}
