using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        public string? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        //Relationships 
        //Calling the specific classes for each property to show their relationships to each other
        public List<Movie>? Movies { get; set; }

    }
}
