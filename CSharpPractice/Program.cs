using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int cout = 3;

            Person[] person = new Person[cout];

            for(int i=0; i<3; i++)
            {
                person[i] = new Person() { name = Console.ReadLine() };
            }

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(person[i].ToString());
                
            }

            Console.ReadKey();
        }
    }
}
