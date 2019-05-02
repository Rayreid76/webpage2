using System.ComponentModel.DataAnnotations;

namespace frontend.Models
{
    public class Contact
    {
        [Key]
        public int contact_id {get; set;}
        [Required]
        [Display(Name = "Name:")]
        [MinLength(3, ErrorMessage="Name needs to be longer than 3 characters!")]
        public string Name {get; set;}
        [Required]
        [Display(Name="Email:")]
        [EmailAddress]
        public string Email{get;set;}
        [Required]
        [Display(Name="Your Message For Me:")]
        [MinLength(10, ErrorMessage="Message is to Short. Thank you, Raymond")]
        public string Message{get; set;}
    }
    
}