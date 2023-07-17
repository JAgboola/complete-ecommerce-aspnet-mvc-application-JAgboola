using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string? ProfilePictureURL { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }

        //Calling the specific classes for each property to show their relationships to each

        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }

    }
}
