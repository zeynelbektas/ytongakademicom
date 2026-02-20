using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading.Tasks;
using ytongakademicom.Data;
using ytongakademicom.Helper;
using ytongakademicom.Models;

namespace ytongakademicom.Controllers
{
    public class HomeController : Controller
    {
		private readonly IToastNotification _toastNotification;
		private readonly ILogger<HomeController> _logger;
		private readonly DatabaseContext db;
		public HomeController(ILogger<HomeController> logger, DatabaseContext _db, IToastNotification toastNotification)
        {
            _logger = logger;
			db = _db;
			_toastNotification = toastNotification;
		}

        public IActionResult Index()
        {
            return View();
        }

		[Route("kazananlar")]
		[Route("kazananlar.html")]
		public IActionResult Kazananlar2023()
		{
			return View();
		}
		
		[Route("iletisim")]
		[Route("iletisim.html")]
		public IActionResult Iletisim()
		{
			return View();
		}
		[HttpPost]
		[Route("iletisim")]
		public IActionResult Iletisim(string ad, string soyad, string eposta, string telefon, string konu, string mesaj)
		{
			
			string mkonu = "ytongakademi.com - İletişim Formu";
			var mail = new MailMessage();
			var client = new SmtpClient("mail.smtp2go.com", 2525)
			{
				Credentials = new NetworkCredential("webforms-ean", "OHNzOWU5Zjg5c2Mw"),
				EnableSsl = true
			};
			mail.From = new MailAddress("webforms@easyasnet.com");
			mail.To.Add("akademi@ytong.com.tr");
			mail.Bcc.Add("zeynelbektas95@gmail.com");
			mail.Subject = mkonu;
			mail.BodyEncoding = System.Text.Encoding.UTF8;
			string htmlBody = $@"
			<html lang=""en"">
				<head>    
					<meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type"">
					<title>
						Upcoming topics
					</title>
				</head>
				<body>
					<table>
				<tr>
					<td style=""padding: 0 0 30px 0;"">ytongakademi.com İletişim formu kullanılarak gönderilen 1 yeni mesajınız var. Mesaj detayları aşagıdaki gibidir.</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Gönderen:</strong> {ad} {soyad}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>E-posta:</strong> {eposta}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Telefonu:</strong> {telefon}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Konu:</strong> {konu}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Mesajı:</strong> {mesaj}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;"">ytongakademi.com</td>
				</tr>
			</table>
			   </body>
			</html>";

			var htmlview = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
			mail.IsBodyHtml = true;
			mail.AlternateViews.Add(htmlview);
			try
			{
				client.Send(mail);
				_toastNotification.AddSuccessToastMessage("Mesajınız bize ulaştı.<br/>Kısa sürede sizinle irtibata geçeceğiz.", new ToastrOptions
				{
					Title = "Teşekkür ederiz."
				});
				return RedirectToAction("Iletisim");
			}
			catch (System.Exception ex)
			{

				//
			}

			return View();
		}

		[Route("projelerdone")]
		public IActionResult Projeler()
		{
			var parameterHelper = new DbParameterHelper(db);
			var ISLEM_KODU = parameterHelper.CreateParameter("@ISLEM_KODU", 'R', System.Data.DbType.AnsiString);
			var PId = parameterHelper.CreateParameter("@Id", 0, System.Data.DbType.Int32);
			var datas = db.basvuruDtoLists
				.FromSqlRaw("execute SP_CRUD_YTONGBASVURU @ISLEM_KODU,@Id", ISLEM_KODU, PId)
				.ToList();
			for (int i = 0; i < datas.Count; i++)
			{
				datas[i].KapakDosyasi = "/basvuruGorsel/" + datas[i].KapakDosyasi;
			}
			return View(datas.Where(o=>o.OnayDurumu==1).ToList());
		
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
    }
}
