using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using NToastNotify;

namespace ytongakademicom.Controllers
{
	public class EducationEventsController : Controller
	{
		private readonly IToastNotification _toastNotification;
		public EducationEventsController(IToastNotification toastNotification)
        {
			_toastNotification = toastNotification;
		}
        [Route("universite-seminerleri")]
        [Route("universite-seminerleri.html")]
		public IActionResult universiteSeminerleri()
		{
			return View();
		}
		[HttpPost]
		[Route("universite-seminerleri")]
		public IActionResult universiteSeminerleri(string adsoyad, string gorev, string eposta, string telefon, string sehir, string okul, int katilimci, string konular, string aciklama)
		{
			string konu = "ytongakademi.com - Üniversite Seminerleri Formu";
			var mail = new MailMessage();
			var client = new SmtpClient("mail.smtp2go.com", 2525)
			{
				Credentials = new NetworkCredential("webforms-ean", "OHNzOWU5Zjg5c2Mw"),
				EnableSsl = true
			};
			mail.From = new MailAddress("webforms@easyasnet.com");
			mail.To.Add("akademi@ytong.com.tr");
			mail.Subject = konu;
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
					<td style=""padding: 0 0 30px 0;"">ytongakademi.com Üniversite Seminer formu kullanılarak gönderilen 1 yeni mesajınız var. Mesaj detayları aşagıdaki gibidir.</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Gönderen:</strong> {adsoyad}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Görevi:</strong> {gorev}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>E-posta:</strong> {eposta}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Telefonu:</strong> {telefon}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Şehir:</strong> {sehir}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Okul:</strong> {okul}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Katılımcı Sayısı:</strong> {katilimci}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Tercih Edilen Seminer Konuları:</strong> {konular}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Mesajı:</strong> {aciklama}</td>
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
				return RedirectToAction("universiteSeminerleri");
			}
			catch (System.Exception ex)
			{

				//
			}
			
			return View();
		}

		[Route("sirket-kurum-seminerleri")]
		[Route("sirket-kurum-seminerleri.html")]
		public IActionResult sirketKurumSeminerleri()
		{
			return View();
		}

		[HttpPost]
		[Route("sirket-kurum-seminerleri")]
		public IActionResult sirketKurumSeminerleri(string adsoyad, string gorev, string eposta, string telefon, string sehir, string kurum_adi, int katilimci, string konular, string aciklama)
		{
			string konu = "ytongakademi.com - Şirket/Kurum Seminerleri Formu";
			var mail = new MailMessage();
			var client = new SmtpClient("mail.smtp2go.com", 2525)
			{
				Credentials = new NetworkCredential("webforms-ean", "OHNzOWU5Zjg5c2Mw"),
				EnableSsl = true
			};
			mail.From = new MailAddress("webforms@easyasnet.com");
			mail.To.Add("akademi@ytong.com.tr");
			mail.Subject = konu;
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
					<td style=""padding: 0 0 30px 0;"">ytongakademi.com Şirket/Kurum Seminerleri formu kullanılarak gönderilen 1 yeni mesajınız var. Mesaj detayları aşagıdaki gibidir.</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Gönderen:</strong> {adsoyad}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Görevi:</strong> {gorev}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>E-posta:</strong> {eposta}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Telefonu:</strong> {telefon}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Şehir:</strong> {sehir}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Şirket/Kurum Adı:</strong> {kurum_adi}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Katılımcı Sayısı:</strong> {katilimci}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Tercih Edilen Seminer Konuları:</strong> {konular}</td>
				</tr>
				<tr>
					<td style=""padding: 0 0 15px 0;""><strong>Mesajı:</strong> {aciklama}</td>
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
				return RedirectToAction("sirketKurumSeminerleri");
			}
			catch (System.Exception ex)
			{

				//
			}

			return View();
		}

	}
}
