using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;
using System;
using System.Data;

namespace WebApp1.Pages
{
    [Authorize(Roles = "student, profesor")]
    public class NoteModel : PageModel
    {
        
       
            private readonly ApplicationDbContext _applicationDbContext;

            public Nota[] Note;
            public Nota? Nota { get; set; }
            public string CurrentSort { get; set; }

            public IList<Nota> Grades { get; set; }
            public string PunctajSort { get; set; }
           
        public NoteModel(ApplicationDbContext applicationDbContext)
            {
                _applicationDbContext = applicationDbContext;

            }
            public void OnGet()
            {
                Note = _applicationDbContext.Nota.Include(x=>x.Student).Include(x=>x.Curs).ToArray();

            }


    }
}
