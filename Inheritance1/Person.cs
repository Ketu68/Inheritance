using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string FirstName = "Phillip", LastName = "Beaver";
            Console.WriteLine("Full name is: "+FirstName+" "+LastName);
        }
        public void SayName(string fname, string lname)
        {
            Console.WriteLine("Full name is: " + fname + " " + lname);
        }
    }

    public class Employee : Person   //------------------------- INHERITED FROM PERSON CLASS --------------------------------
    {
        int ID;
    }

}
