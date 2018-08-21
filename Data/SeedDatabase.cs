using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace JWT001.Data
{
    public class SeedDatabase
    {
        
        public static void Initialize(IServiceProvider serviceProvider){
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            context.Database.EnsureCreated();

            if (!context.Users.Any()){

                ApplicationUser user = new ApplicationUser() { 
                    Email="aaa@bbb.com",
                    SecurityStamp=Guid.NewGuid().ToString(),
                    UserName="Robert"
                };
                userManager.CreateAsync(user, "123456");
            }
        }
    }
}
