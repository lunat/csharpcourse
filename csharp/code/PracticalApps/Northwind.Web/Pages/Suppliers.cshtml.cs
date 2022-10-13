using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Northwind.Web.Pages
{
    public class SuppliersModel : PageModel
    {
        public IEnumerable<string>? Suppliers { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Application - Suppliers";
            Suppliers = new[]
            {
                "Alpha",
                "Beta",
                "Gamma"
            };
        }
    }
}
