using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Diagnostics.Eventing.Reader;

namespace ytongakademicom.Controllers
{
	public class AuthController : Controller
	{
		private readonly IToastNotification _toastNotification;
        public AuthController(IToastNotification toastNotification)
        {
			_toastNotification = toastNotification;
		}
        [Route("login")]
		[Route("y-a-login.html")]
		[Route("y-m-login.html")]
		public IActionResult Index()
		{
			return View();
		}
		[Route("login")]
		[Route("y-a-login.html")]
		[Route("y-m-login.html")]
		[HttpPost]
		public IActionResult Index(string username, string password)
		{
			if (username== "yildizteknik" && password== "ytu311973")
			{
				HttpContext.Session.SetString("Yildiz","var");
				return Redirect("yildiz-teknik-universitesi");
			}
			if (username== "mimarsinan" && password== "msgsu104269")
			{
				HttpContext.Session.SetString("Mimar", "var");
				return Redirect("mimar-sinan-guzel-sanatlar-universitesi");
			}
			_toastNotification.AddErrorToastMessage("Kontrol edip tekrar deneyin.", new ToastrOptions
			{
				Title = "Girdiğiniz şifre, kullanıcı adı eksik veya hatalı."
			});
			return View();
		}
	}
}
