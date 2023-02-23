using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class BootRecipientsModel : PageModel
    {
        public string? Name { get; set; }
        public string? Course { get; set; }
        public int Year { get; set; }

        BootRecipientsModel[] bootWinner = new BootRecipientsModel[6];

        public void OnGet()
        {
        }
    }
}
