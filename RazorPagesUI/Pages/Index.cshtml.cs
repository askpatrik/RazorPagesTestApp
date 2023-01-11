using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        

        //Properties that can be read by the index page
        //If you want to write in URL them you need to use BindProperty(SupportsGet). 
        
        [BindProperty(SupportsGet = true)]
        public string City { get; set; }
		[BindProperty(SupportsGet = true)]
		public string Name { get; set; }
     

        //Renders Index.cshtml. The C# code that runs when you ask for a index page. 
        //Eg posts a form
      
        public void OnGet()
        {
             if (string.IsNullOrWhiteSpace(City))
             City = "The Web";
			if (string.IsNullOrWhiteSpace(Name))
				Name = "Unknown User";
        }
        
        //Run whenever you post data to this page
        //Eg captures data from the form
        public void OnPost()
        {

        }
    }
}