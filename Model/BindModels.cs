using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Model
{
    public class BindModels
    {

        [Required (ErrorMessage ="FirstName is required")]
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
        public DateTime Birthday { get; set; }

        
        public string PhoneNumber { get; set; }

       
        public string Password { get; set; }

        
        public string Email { get; set; }

        
        public string Sex { get; set; }



        
        
        public IEnumerable <string> Skills { get; set; }

        
        public int V1 { get; set; }

        
        public int V2 { get; set; }

        
        public int V3 { get; set; }

       
        public string EmailCon { get; set; }



        
        public string Nationality { get; set; }

        
        public IFormFile Photo { get; set; }


    }


}

