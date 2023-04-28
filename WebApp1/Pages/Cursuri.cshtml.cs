using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;
using System;

namespace WebApp1.Pages
   
{
    [Authorize(Roles = "student, profesor")]
    public class CursuriModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDbContext;
      
        public Curs[] cursuri;
        public Curs? Curs { get; set; }

        public string CurrentSort { get; set; }

        public IList<Curs> Courses { get; set; }
        public string NameSortAsc { get;  set; }
        public string NameSortDesc { get; set; }
        public CursuriModel(ApplicationDbContext applicationDbContext)
        { _applicationDbContext = applicationDbContext;
           
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            // using System;
            NameSortAsc = String.IsNullOrEmpty(sortOrder) ? "name_asc" : "";
            NameSortDesc = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            IQueryable<Curs> courses = from s in _applicationDbContext.Curs
                                             select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                courses = courses.Where(s => s.Denumire.Contains(SearchString) || s.Profesor.UserName.Contains(SearchString));
                
            }

            switch (sortOrder)
            {
                case "name_asc":
                    courses = courses.OrderBy(s => s.Denumire);
                    break;
                case "name_desc":
                    courses = courses.OrderByDescending(s => s.Denumire);
                    break;
                default:
                    cursuri = _applicationDbContext.Curs.Include(x => x.Profesor).ToArray();
                    break;
            }

            Courses = await courses.AsNoTracking().ToListAsync();
        }


        



    }

    

}
