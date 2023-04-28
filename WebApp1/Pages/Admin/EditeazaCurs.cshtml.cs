using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;

namespace WebApp1.Pages.Admin
{
    public class EditeazaCursModel : PageModel
    {
        [BindProperty]
        public Curs Curs { get; set; }

        public List<SelectListItem> profesor { get; set; }
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        public EditeazaCursModel(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;

            profesor = userManager.Users.Select(x => new SelectListItem { Text = x.UserName, Value = x.Id.ToString() }).ToList();
        }
        public void OnGet(int cursId)
        {
            Curs = _applicationDbContext.Curs.Include(x => x.Profesor).FirstOrDefault(x => x.Id == cursId);
        }
        public IActionResult OnPost(int cursId)
        {
            Curs.Id = cursId;
            _applicationDbContext.Update(Curs);
            _applicationDbContext.SaveChanges();
            return RedirectToPage("Cursuri");
        }
    }
}
