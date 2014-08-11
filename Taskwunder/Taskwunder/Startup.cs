using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using DbClasses;

[assembly: OwinStartup(typeof(Taskwunder.Startup))]

namespace Taskwunder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

/*            using (var context = new TWContext())
            {
                context.Users.Add(new User()
                {
                    Firstname = "Jürgen",
                    Lastname = "Schöner",
                    Email = "juergen.schoener@gmx.net",
                    Company = "JS AG",
                });

                context.SaveChanges();

            }
 */
        }
    }
}
