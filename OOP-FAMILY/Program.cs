using System;
using System.Collections.Generic;

namespace OOP_FAMILY
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>
            {
                new Member("Mickley", 16, 182, 50, ""),
                new Member("Stefan", 85, 148, 80, ""),
                new Member("Luky", 20, 175, 85, ""),
                new Member("Peter", 59, 180, 80, ""),
            };

            var family = new Family(members);
            Console.WriteLine("Choose one of the following members: Mickley, Stefanie, Luky, Peter. ");
            var input = Console.ReadLine();
            family.Info(input);
        }
    }
}
