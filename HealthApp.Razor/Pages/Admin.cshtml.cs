using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthApp.Razor.Pages
{
    [Authorize(Roles ="Admin")]
    public class AdminModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "Test";
        }
    }
}
