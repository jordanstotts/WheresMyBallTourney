using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class PlayerBiosModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "Jordan Stotts";
        }
    }
}
