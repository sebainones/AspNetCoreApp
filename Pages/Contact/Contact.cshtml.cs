using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreApp.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        public string Author { get; set; }

        public void OnGet()
        {
            Message = "Página de contacto";
            Author= "Sebastian Inones";
        }
    }
}
