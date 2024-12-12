using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Model
{
   
    public class ViewModel
    {
        [Required(ErrorMessage ="Please enter your name ") ]
        [StringLength(100 , ErrorMessage = "Maximum Length is 100")]
        [Display(Name=" FirstName ")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Please enter your name ")]
        [StringLength(100, ErrorMessage = "Maximum Length is 100")]
        [Display(Name = " LastName ")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Please enter your phone number ")]
        [StringLength(20)]
        [Display(Name =" PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }






        [Required]
        [DataType(DataType.Date)]
        [Display(Name=" Birthday")]
        public DateTime Birthday { get; set; }



        [Required(ErrorMessage = "Password field required")]
        [Display(Name ="Password")]
        [StringLength(100 , MinimumLength =8 ,ErrorMessage ="The password must be longer than 8 characters ")]
        [RegularExpression(@"(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).*$", ErrorMessage = "password must contain at least one letter" +
            " ,one digit ,and one special character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email field required")]
  
        [Display(Name =" Email ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Sex field required")]
        [StringLength(10)]
        [Display(Name ="Sex")]
        public string Sex { get; set; }



        [Required (ErrorMessage ="Skills field required")]
        [Display(Name =" Skills")]
        
        public IEnumerable< string >  Skills { get; set; }

        [Required]
        [Display(Name ="Value1")]
        public int V1 { get; set; }

        [Required]
        [Display(Name = "Value1")]
        public int V2 { get; set; }

        [Required]
        [Display(Name = "Value1")]
        public int V3 { get; set; }

        [Required(ErrorMessage = "EmailConformation field required")]
        [Display(Name ="EmailConformation")]
        [Compare("Email" , ErrorMessage ="The email confirmation and email do not match .")]
        public string EmailCon { get; set; }



        [Required(ErrorMessage = "Nationality field required")]
        [StringLength(50, ErrorMessage = "Maximum Length is 100")]
        [Display(Name = "Your Nationality")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name ="Your Photo")]
        [DataType (DataType.Upload)]
        public IFormFile Photo { get; set; }


    }
}
