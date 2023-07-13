using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public double? Price { get; set; }
        public string? CinemaName { get; set; }
        public string? MovieActors { get; set; }
        public string? MovieCategory { get; set; }
        public string? MovieProducer { get; set; }

    }
}
