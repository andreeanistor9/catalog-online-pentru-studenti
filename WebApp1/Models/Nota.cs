using Microsoft.AspNetCore.Identity;

namespace WebApp1.Models
{
    public class Nota
    {
        public int? NotaId { get; set; }
        public int? Punctaj { get; set; }
        public string? StudentId { get; set; }

        public int CursId { get; set; } 
        public Curs? Curs { get; set; }
        
        public IdentityUser? Student { get; set; }
    }
}
