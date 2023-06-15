using System.ComponentModel.DataAnnotations;

namespace FilmsStoreMvc.Models.Domain
{
    public class Genre
    {

        public int Id { get; set; }
        [Required]
        public string? GenreName { get; set; }
    }
}
