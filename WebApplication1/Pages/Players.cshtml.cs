using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class PlayersModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "Jordan Stotts";
        }
    }
}
