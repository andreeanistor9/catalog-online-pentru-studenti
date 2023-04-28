using Microsoft.AspNetCore.Identity;

namespace WebApp1.Data
{
    public class IdentitySeedData
    {
        public static async Task Initialize(ApplicationDbContext context,
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            string adminRole = "moderator";
            string studentRole = "student";
            string profesorRole = "profesor";
            string secretarRole = "secretar";
            string password4All = "Parola1!";
            
            if(await roleManager.FindByNameAsync(adminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
            }
            if(await roleManager.FindByNameAsync(studentRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(studentRole));
            }
            if(await roleManager.FindByNameAsync(profesorRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(profesorRole));
            }
            if(await roleManager.FindByNameAsync(secretarRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(secretarRole));
            }
            if(await userManager.FindByNameAsync("aa@aa.aa") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "aa@aa.aa",
                    Email = "aa@aa.aa",
                    PhoneNumber = "6902341234"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4All);
                    await userManager.AddToRoleAsync(user, adminRole);
                }
            }

            if (await userManager.FindByNameAsync("ss@ss.ss") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "ss@ss.ss",
                    Email = "ss@ss.ss",
                    PhoneNumber = "0342223333"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4All);
                    await userManager.AddToRoleAsync(user, studentRole);
                }
            }

            if (await userManager.FindByNameAsync("pp@pp.pp") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "pp@pp.pp",
                    Email = "pp@pp.pp",
                    PhoneNumber = "1110003333"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4All);
                    await userManager.AddToRoleAsync(user, profesorRole);
                }
            }

            if (await userManager.FindByNameAsync("bb@bb.bb") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "bb@bb.bb",
                    Email = "bb@bb.bb",
                    PhoneNumber = "1112224444"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4All);
                    await userManager.AddToRoleAsync(user, secretarRole);
                }
            }

        }
    }
}
