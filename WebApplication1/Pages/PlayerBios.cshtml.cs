using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class PlayerBiosModel : PageModel
    {
        public string? Name { get; set; }
        public string? Twitter { get; set; }
        public string? IG { get; set; }
        public string? Facebook { get; set; }
        public int Age { get; set; }
        public string? Occupation { get; set; }
        public string? AlmaMater { get; set; }
        public string? FlagYears { get; set; }
        public double Handicap { get; set; }
        public string? BootYears { get; set; }


        public void OnGet()
        {

        }

    }
}
