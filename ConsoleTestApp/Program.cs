using System;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student s = new Student()
            {
                FirstName = "Stan"
            };

            Console.WriteLine(s.FirstName);
        }
    }
}
