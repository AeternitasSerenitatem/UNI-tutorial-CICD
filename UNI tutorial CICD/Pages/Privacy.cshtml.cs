using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UNI_tutorial_CICD.Pages
{
	public class PrivacyModel : PageModel
	{
		private readonly ILogger<PrivacyModel> _logger;

		public PrivacyModel(ILogger<PrivacyModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}
	}
}