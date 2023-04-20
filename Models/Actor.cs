using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor

    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required (ErrorMessage ="Profile Picture is Required.")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Actor's full name is Required.")]
        [StringLength(100, MinimumLength =5, ErrorMessage ="Please enter a Valid name with more characters.")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
