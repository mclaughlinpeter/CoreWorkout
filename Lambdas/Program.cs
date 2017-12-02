using System;
using System.Collections.Generic;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRegister myRegister = new PersonRegister(
                new List<Person> {
                    new Person { FirstName = "Joe", LastName = "Bloggs", Age = 20 },
                    new Person { FirstName = "Steven", LastName = "Preece", Age = 25 },
                    new Person { FirstName = "Jim", LastName = "Chap", Age = 30 },
                    new Person { FirstName = "Andy", LastName = "Barrow", Age = 35 }
                }                                    
            );

            foreach (Person p in myRegister) 
            {
                Console.Write(p.ToString());
            }
            Console.WriteLine();

            foreach (Person p in myRegister.Filter(p => (p?.Age ?? 0) > 20)) 
            {
                Console.Write(p.ToString());
            }   
            Console.WriteLine();    
        }
    }
}
