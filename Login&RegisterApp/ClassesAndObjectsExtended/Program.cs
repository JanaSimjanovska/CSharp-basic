using ClassesAndObjectsExtended.Models;
using System;

namespace ClassesAndObjectsExtended
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person student01 = new Person();
            student01.FirstName = "Bob";
            student01.LastName = "Bobski";
            Console.WriteLine(student01.PersonInfo());

            Person student02 = new Person("Blazo", "Blazov");
            Console.WriteLine(student02.PersonInfo());

            Person[] students = new Person[]
            {
                new Person("Jana", "Simjanovska"),
                new Person("Leart", "Kamberi"),
                new Person("Ivan", "Jamandilovski")
            };
            foreach (Person item in students)
            {
                Console.WriteLine($"{item.FirstName}");
            }



            Console.ReadLine();
        }
    }
}
