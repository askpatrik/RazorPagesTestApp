using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Models;
using System.Net;

namespace RazorPagesUI.Pages.Forms
{
    public class AddPersonalModel : PageModel
    {
		[BindProperty]
		public PersonalModel Personal { get; set; }
		public void OnGet()
        {
        }

		public IActionResult OnPost()
		{
			if (ModelState.IsValid == false)
				return Page();

			return RedirectToPage("/Index", new {Personal.Name});
		}
	}
}
