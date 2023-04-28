using Microsoft.AspNetCore.Identity;

namespace WebApp1.Models
{
    public class Curs
    {
        public int? Id { get; set; }
        public string? Denumire { get; set; }
        public int? An { get; set; }
        
        public string ProfesorId { get; set; }
        public IdentityUser? Profesor { get; set; }
    }
}
