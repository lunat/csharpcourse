using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Northwind.Web.Pages
{
    public class IndexModel : PageModel
    {
        public string? DayName { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Application";
            ViewData["Pippo"] = "pippo";
            DayName = DateTime.Now.ToString("dddd");
        }
    }
}
