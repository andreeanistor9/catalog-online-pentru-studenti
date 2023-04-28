using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp1.Data;
using WebApp1.Models;
using static WebApp1.Areas.Identity.Pages.Account.RegisterModel;

namespace WebApp1.Pages.Admin
{
    public class UsersModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IdentityUser[] Utilizatori;
        public IdentityUser Utilizator;
        public IdentityRole[] Role;

        private readonly UserManager<IdentityUser> _userManager;
        

        public UsersModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        public async void OnGet(string id)
        {
            Utilizatori = _userManager.Users.ToArray();
            /*var user = await _userManager.FindByIdAsync(id);
            if(await _userManager.IsInRoleAsync(user, "student"))
            {
                Utilizatori = _userManager.Users.ToArray();
            }
            if (await _userManager.IsInRoleAsync(user, "profesor"))
            {
                Utilizatori = _userManager.Users.ToArray();
            }
            if (await _userManager.IsInRoleAsync(user, "moderator"))
            {
                Utilizatori = _userManager.Users.ToArray();
            }
            if (await _userManager.IsInRoleAsync(user, "secretar"))
            {
                Utilizatori = _userManager.Users.ToArray();
            }*/


        }

       
    }
}
