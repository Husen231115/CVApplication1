using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication9.DB_Model;
using WebApplication9.Model;
using WebApplication9.Services;

namespace WebApplication9.Pages
{
    public class CvViewModel : PageModel
    {
        private readonly CVservice _SERVICE ; 
        public ViewModel Input { get; set; }

        [BindProperty]
        public BindModels Cvmodel { get; set; }



        public IEnumerable<SelectListItem> Items { get; set; } = new List<SelectListItem>
{
    new SelectListItem { Value = "", Text = "-- Select Nationality --" }, 
    new SelectListItem { Value = "Lebanese", Text = "Lebanon" },
    new SelectListItem { Value = "Syrian", Text = "Syria" },
    new SelectListItem { Value = "Palestinian", Text = "Palestine" },
    new SelectListItem { Value = "Iraqi", Text = "Iraq" },
    new SelectListItem { Value = "Russian", Text = "Russia" },
    new SelectListItem { Value = "yemenis", Text = "Yemen" }
};
        public CvViewModel(CVservice service)
        {

            _SERVICE = service; 
        
        
        }

        public IEnumerable<string> Skills { get; set; } = new List<string>
        {
            "Java",
            "Python",
            "Asp"
        };
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Error in Binding"); 
                return Page();
            }

            string fileName = null;
            if (Cvmodel.Photo != null)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                fileName = Path.GetFileName(Cvmodel.Photo.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Cvmodel.Photo.CopyToAsync(stream);
                }
            }

            CV cv = new CV()
            {
                FirstName= Cvmodel.FirstName,  
                LastName = Cvmodel.LastName,
                Skills = string.Join(", ", Cvmodel.Skills),
                PhoneNumber= Cvmodel.PhoneNumber,
                Birthday= Cvmodel.Birthday,
                Password= Cvmodel.Password,
                Email= Cvmodel.Email,
                Photo=fileName,
                Nationality=Cvmodel.Nationality,

            };


              int id= await  _SERVICE.CreateCv(cv);

            TempData["PhotoName"] = fileName;
            return RedirectToPage("/Summary" , new {id = id});
        }

    }
}