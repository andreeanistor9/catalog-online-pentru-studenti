using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;

namespace WebApp1.Pages.Secretar
{
    public class CursuriStudentiModel : PageModel
    {
       
            private readonly ApplicationDbContext _context;
            public Nota[] Note;
            public Nota Nota;

            public CursuriStudentiModel(ApplicationDbContext context)
            {
                _context = context;
            }

            public void OnGet()
            {
                Note = _context.Nota.Include(x => x.Student).Include(x => x.Curs).ToArray();
            }
        
    }
}
