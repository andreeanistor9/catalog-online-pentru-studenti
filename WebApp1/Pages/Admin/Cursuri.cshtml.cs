using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;
namespace WebApp1.Pages.Admin
{
    public class CursuriModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Curs[] Cursuri;
        public Curs? Curs;
        
        public CursuriModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Cursuri = _context.Curs.Include(x => x.Profesor).ToArray();
           
        }
        public IActionResult OnGetDelete(int cursId)
        {
            Curs = _context.Curs.Include(x => x.Profesor).FirstOrDefault(x => x.Id == cursId);
            _context.Remove(_context.Curs.Find(cursId));
            _context.SaveChanges();
            return RedirectToPage("Cursuri");
        }
    }
}
