using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        //edit 7/14
        public MovieCategory? MovieCategory { get; set; }
        public double? Price { get; set; }
        public string? CinemaName { get; set; }
        public string? MovieActors { get; set; }
        
        public string? MovieProducer { get; set; }

    }
}
