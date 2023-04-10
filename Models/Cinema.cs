using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        public string Logo { get; set; }

        [Display(Name ="Hall Name")]
        public string Name { get; set; }

        [Display(Name = "Descrition")]
        public string Description { get; set; }

        //Relationships

        public List<Movie> movies { get; set; }
    }
}
