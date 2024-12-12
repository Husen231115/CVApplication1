using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication9.DB_Model;
using WebApplication9.Model;
using WebApplication9.Services;

namespace WebApplication9.Pages
{
    public class SummaryModel : PageModel
    {
        private readonly CVservice _service;
        public CV cv { get; set; }

        public string? PhotoName { get; set; }
        public SummaryModel( CVservice service) {
        _service= service;
                }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            PhotoName = TempData["PhotoName"].ToString();
           cv= await _service.GetCVbyId(id);
            return Page();
        }
        
    }
}
