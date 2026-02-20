using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace ytongakademicom.Models
{
	public class Basvuru
	{
		[Key]
		public int Id { get; set; }
		public string ProjeAdi { get; set; }
		public bool Tamamlandi { get; set; }//hidden 0
		public DateTime Tarih { get; set; }//getdate 
		public string IpAdress { get; set; }//hidden
											//dosyalar
		public string OzetDosyasi { get; set; }
		public string TanitimDosyasi { get; set; }
		public string KapakDosyasi { get; set; }
		public string DiplamaDosyasi { get; set; }
		public string DiplamaDosyasi2 { get; set; }
		public string DiplamaDosyasi3 { get; set; }
		public string ProjeDosyasi { get; set; }
		//dosyalar
		public int ProjeDurumu { get; set; } //sonra hidden

		public string Rumuz { get; set; } //otomatik //başvuruno //hiddeb
										  //eular1  la zeynel ayırtmadı
		[DisplayName("ADI SOYADI")]
		public string Eu1Adi { get; set; }

		[DisplayName("ÖĞRENİM DURUMU")]
		public string Eu1Ogrenim { get; set; }

		[DisplayName("TELEFON")]
		public string Eu1Telefon { get; set; }

		[DisplayName("E-POSTA")]
		public string Eu1Mail { get; set; }

		[DisplayName("ÜNiVERSiTE")]
		public string Eu1Universite { get; set; }

		[DisplayName("FAKÜLTE")]
		public string Eu1Fakulte { get; set; }

		[DisplayName("BÖLÜM")]
		public string Eu1Bolum { get; set; }

		[DisplayName("İL")]
		public string Eu1Il { get; set; }

		[DisplayName("İLÇE")]
		public string Eu1Ilce { get; set; }

		[DisplayName("ADRES")]
		public string Eu1Adres { get; set; }

		//eular2
		//eular2  la zeynel ayırtmadı
		[DisplayName("ADI SOYADI")]
		public string Eu2Adi { get; set; }

		[DisplayName("ÖĞRENİM DURUMU")]
		public string Eu2Ogrenim { get; set; }

		[DisplayName("TELEFON")]
		public string Eu2Telefon { get; set; }

		[DisplayName("E-POSTA")]
		public string Eu2Mail { get; set; }

		[DisplayName("ÜNiVERSiTE")]
		public string Eu2Universite { get; set; }

		[DisplayName("FAKÜLTE")]
		public string Eu2Fakulte { get; set; }

		[DisplayName("BÖLÜM")]
		public string Eu2Bolum { get; set; }

		[DisplayName("İL")]
		public string Eu2Il { get; set; }

		[DisplayName("İLÇE")]
		public string Eu2Ilce { get; set; }

		[DisplayName("ADRES")]
		public string Eu2Adres { get; set; }
		//eular2
		//eular3  la zeynel ayırtmadı
		[DisplayName("ADI SOYADI")]
		public string Eu3Adi { get; set; }

		[DisplayName("ÖĞRENİM DURUMU")]
		public string Eu3Ogrenim { get; set; }

		[DisplayName("TELEFON")]
		public string Eu3Telefon { get; set; }

		[DisplayName("E-POSTA")]
		public string Eu3Mail { get; set; }

		[DisplayName("ÜNiVERSiTE")]
		public string Eu3Universite { get; set; }

		[DisplayName("FAKÜLTE")]
		public string Eu3Fakulte { get; set; }

		[DisplayName("BÖLÜM")]
		public string Eu3Bolum { get; set; }

		[DisplayName("İL")]
		public string Eu3Il { get; set; }

		[DisplayName("İLÇE")]
		public string Eu3Ilce { get; set; }

		[DisplayName("ADRES")]
		public string Eu3Adres { get; set; }
		//eular1
		public int YtongOnayi { get; set; }//hiddedn
	}
	public class BasvuruDto : Basvuru
	{
		//dosyalar
		public IFormFile OzetDosyasiFile { get; set; }
		public IFormFile TanitimDosyasiFile { get; set; }
		public IFormFile KapakDosyasiFile { get; set; }
		public IFormFile DiplamaDosyasiFile { get; set; }
		public IFormFile DiplamaDosyasiFile2 { get; set; }
		public IFormFile DiplamaDosyasiFile3 { get; set; }
		public IFormFile ProjeDosyasiFile { get; set; }
	}
	public class BasvuruDtoList
	{
		[Key]
		public int Id { get; set; }
		public string Rumuz { get; set; }
		public string Eposta { get; set; }
		public string ProjeAdi { get; set; }
		public string TanitimDosyasi { get; set; }
		public string KapakDosyasi { get; set; }
		public string OzetDosyasi { get; set; }
		public string DiplomaDosyasi { get; set; }
		public string ProjeDosyasi { get; set; }
		public DateTime Tarih { get; set; }
		public string AdSoyad { get; set; }
		public string Telefon { get; set; }
		public int OnayDurumu { get; set; }
	}
	public class BasvuruSingle
	{
		[Key]
		public int Id { get; set; }
		public string Rumuz { get; set; }
		public string Eposta { get; set; }
		public string ProjeAdi { get; set; }
		public string TanitimDosyasi { get; set; }
		public string KapakDosyasi { get; set; }
		public string OzetDosyasi { get; set; }
		public string DiplomaDosyasi { get; set; }
		public string ProjeDosyasi { get; set; }
		public DateTime Tarih { get; set; }
		public string AdSoyad { get; set; }
		public string Telefon { get; set; }
		public int OnayDurumu { get; set; }
		public string Test { get; set; }
	}
}
