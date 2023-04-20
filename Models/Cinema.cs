using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [Required(ErrorMessage ="Logo URL is required.")]
        public string Logo { get; set; }

        [Display(Name ="Hall Name")]
        [Required(ErrorMessage ="Name is required.")]
        [StringLength(100, MinimumLength =5, ErrorMessage ="The Name should be More than 5 Characters. ")]
        public string Name { get; set; }

        [Display(Name = "Descrition")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        //Relationships

        public List<Movie> movies { get; set; }
    }
}
