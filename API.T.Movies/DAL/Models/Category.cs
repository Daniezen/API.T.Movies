using System.ComponentModel.DataAnnotations;

namespace API.T.Movies.DAL.Models
{
    public class Category : AuditBase
    {
        [Required] // Este decorator indica que el campo es obligatorio (no acepta nulls)
        public string Name { get; set; }
    }
}