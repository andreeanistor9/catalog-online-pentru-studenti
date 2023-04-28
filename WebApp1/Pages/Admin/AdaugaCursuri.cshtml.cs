using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp1.Data;
using WebApp1.Models;
namespace WebApp1.Pages.Admin
{
    [Authorize(Roles = "moderator")]
    public class AdaugaCursuriModel : PageModel
    {
        [BindProperty]
        public Curs Curs { get; set; }
        
        public List<SelectListItem> profesor { get; set; }
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        public AdaugaCursuriModel(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;

            profesor = userManager.Users.Select(x => new SelectListItem { Text = x.UserName, Value = x.Id.ToString() }).ToList();
        }
        public void OnGet()
        {
            Curs = new Curs();
        }
        public IActionResult OnPost()
        {
            if (Curs.Denumire!="" && Curs.An !=null)
            {
                _applicationDbContext.Add(Curs);
                _applicationDbContext.SaveChanges();
                return RedirectToPage("Cursuri");
            }
            return RedirectToPage("AdaugaCursuri");

        }
    }
}
