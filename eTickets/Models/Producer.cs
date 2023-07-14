using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        public string? ProfilePictureURL { get; set;}
        public string? FullName { get; set; }
        public string? Bio { get; set; }

        //Relationships
        //Calling the specific classes for each property to show their relationships to each
        public List<Movie>? Movies { get; set; }

    }
}
