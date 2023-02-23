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

        public PlayerBiosModel[] player = new PlayerBiosModel[6];

        

        

        /*public PlayerBiosModel(string name, string twitter, string ig, string facebook, int age, string occupation, string almaMater, string flagYears, double handicap, string bootYears) 
        {
            Name = name;
            Twitter = twitter;
            IG = ig;
            Facebook = facebook;
            Age = age;
            Occupation = occupation;
            AlmaMater = almaMater;
            FlagYears = flagYears;
            Handicap = handicap;
            BootYears = bootYears;
        }*/

        //readonly PlayerBiosModel player1 = new PlayerBiosModel("Jordan Stotts", "@johnsmith", "johnsmith_ig", "johnsmith_fb", 25, "Software Engineer", "University of XYZ", "none", 5.2, "2013 | 2015");

        public void OnGet()
        {
            
        }

        /*   public void OnGet()
           {
               Name = "Jordan Stotts";
           }*/

        /* public IActionResult Index()
         {
             PlayerBiosModel player = new PlayerBiosModel("John Smith", "@johnsmith", "johnsmith_ig", "johnsmith_fb", 25, "Software Engineer", "University of XYZ", "none", 5.2, "2013 | 2015");

         }*/


    }
}
