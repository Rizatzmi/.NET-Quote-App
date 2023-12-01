using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace attempt_2.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> Quotes { get; set; }

        public void OnGet()
        {
            Quotes = System.IO.File.ReadAllLines("quotes.txt").ToList();
        }
    }
}