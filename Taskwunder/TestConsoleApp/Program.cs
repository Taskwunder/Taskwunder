using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbClasses;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TWContext())
            {
                context.Users.Add(new User()
                {
                    Firstname = "Jürgen",
                    Lastname = "Schöner",
                    Email = "juergen.schoener@gmx.net",
                    Company = "JS AG",
                });

                context.SaveChanges();

                foreach (var user in context.Users)
                {
                    Console.WriteLine(user.Firstname);
                }
            }
            
        }
    }
}
