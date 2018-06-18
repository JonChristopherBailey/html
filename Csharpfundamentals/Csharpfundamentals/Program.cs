using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Csharpfundamentals.Math;


namespace Csharpfundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Julian";
            var lastName = "Hansen";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            System.Console.WriteLine(formattedNames);
            Console.ReadKey();

            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            //returns jack true all else false. 

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var mynames = new string[3] {"Bill ", "Ted", "Jacoby"};

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
            Console.ReadKey();

            Calculator calculator = new Calculator();

            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}