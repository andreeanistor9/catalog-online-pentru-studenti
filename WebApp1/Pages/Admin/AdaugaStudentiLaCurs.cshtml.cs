using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;

namespace WebApp1.Pages.Admin
{
    public class AdaugaStudentiLaCursModel : PageModel
    {

        [BindProperty]
        public Nota Nota { get; set; }
        public Curs Curs { get; set; }
        public Curs[] cursuri;
        public List<SelectListItem> student { get; set; }
        public List<SelectListItem> curs { get; set; }
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        
        public AdaugaStudentiLaCursModel(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;

            
            student = userManager.Users.Select(x =>  new SelectListItem { Text = x.UserName, Value = x.Id.ToString() }).ToList();
            curs = _applicationDbContext.Curs.Include(x => x.Profesor).Select(x => new SelectListItem { Text = x.Denumire, Value = x.Id.ToString() }).ToList();


        }
        public void OnGet()
        {
            Nota = new Nota();
        }
        public IActionResult OnPost()
        {
            _applicationDbContext.Add(Nota);
            _applicationDbContext.SaveChanges();
            return RedirectToPage("CursuriStudenti");
        }
    }
}
