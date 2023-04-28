using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;

namespace WebApp1.Pages
{
    public class CursModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public Curs? Curs { get; set; }

        public CursModel(ApplicationDbContext applicationDbContext)
        { _applicationDbContext = applicationDbContext; }
        public void OnGet(int cursId)
        {
           
            Curs = _applicationDbContext.Curs.Include(x=>x.Profesor).FirstOrDefault(x => x.Id == cursId);
         
        }
    }
}
