using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ytongakademicom.Controllers
{
	public class LessonsController : Controller
	{
		[Route("yildiz-teknik-universitesi")]
		[Route("ytu.asp")]
		public IActionResult yildizTeknikUniversitesi()
		{
			if (String.IsNullOrEmpty(HttpContext.Session.GetString("Yildiz")))
			{
				return Redirect("login");
			}
			return View();
		}

		[Route("mimar-sinan-guzel-sanatlar-universitesi")]
		[Route("msgsu.asp")]
		public IActionResult mimarSinanGuzelSanatlarUniversitesi()
		{
			if (String.IsNullOrEmpty(HttpContext.Session.GetString("Mimar")))
			{
				return Redirect("login");
			}
			return View();
		}
	}
}
