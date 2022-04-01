using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Person
    {
        public string name { get; set; }

        public override string ToString()
        {
            return "My name is " +name;
        }
    }
}
