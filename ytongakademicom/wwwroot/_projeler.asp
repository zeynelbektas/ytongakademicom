<%@LANGUAGE="VBSCRIPT" CodePage="65001"%>
<!--#include file="fonk.asp"-->
<%

Response.Buffer=TRUE
Session.Timeout=60
Server.ScriptTimeout=1200
Session.CodePage = 65001
Session.LCID = 1055
%>

<!DOCTYPE html>
<html dir="ltr" lang="en-US">
<head>

	<meta http-equiv="content-type" content="text/html; charset=utf-8" />
	<meta name="author" content="SemiColonWeb" />

	<!-- Stylesheets
	============================================= -->
	<link href="https://fonts.googleapis.com/css?family=Lato:300,400,400i,700|Raleway:300,400,500,600,700|Crete+Round:400i" rel="stylesheet" type="text/css" />
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
	<link rel="stylesheet" href="css/bootstrap.css" type="text/css" />
	<link rel="stylesheet" href="style.css" type="text/css" />
	<link rel="stylesheet" href="css/dark.css" type="text/css" />
	<link rel="stylesheet" href="css/font-icons.css" type="text/css" />
	<link rel="stylesheet" href="css/animate.css" type="text/css" />
	<link rel="stylesheet" href="css/magnific-popup.css" type="text/css" />

	<link rel="stylesheet" href="css/responsive.css" type="text/css" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />

	<!-- Document Title
	============================================= -->
	<title>Projeler | Ytong Akademi</title>
	
	<!-- Google tag (gtag.js) (Google Analytics) -->
	<script async src="https://www.googletagmanager.com/gtag/js?id=UA-113257663-1"></script>
	<script>
	  window.dataLayer = window.dataLayer || [];
	  function gtag(){dataLayer.push(arguments);}
	  gtag('js', new Date());

	  gtag('config', 'UA-113257663-1');
	</script>

</head>

<body class="stretched">

	<!-- Document Wrapper
	============================================= -->
	<div id="wrapper" class="clearfix">

		<!-- Header
		============================================= -->
		<header id="header" class="transparent-header">

			<div id="header-wrap">

				<div class="container clearfix">

					<div id="primary-menu-trigger"><i class="icon-reorder"></i></div>

					<!-- Logo
					============================================= -->
					<div id="logo">
						<a href="index.html" class="standard-logo" data-dark-logo="images/akademi_l.png"><img src="images/akademi_l.png" alt="Ytong Akademi Logo"></a>
						<a href="index.html" class="retina-logo" data-dark-logo="images/akademi_l.png"><img src="images/akademi_l.png" alt="Ytong Akademi Logo"></a>
					</div><!-- #logo end -->

					<!-- Primary Navigation
					============================================= -->
					<nav id="primary-menu">

						<ul>
							<li class="mega-menu"><a href="akademi.html"><div>AKADEMİ</div></a></li>
							<li>
								<a href="#"><div>DERSLER</div></a>
								<ul>
									<li><a href="y-a-login.html"><div><i class="icon-stack"></i>YILDIZ TEKNİK ÜNİVERSİTESİ</div></a></li>
									<li><a href="y-m-login.html"><div><i class="icon-stack"></i>MİMAR SİNAN GÜZEL SANATLAR ÜNİVERSİTESİ</div></a></li>
								</ul>
							</li>
							<li class="mega-menu">
								<a href="#"><div>MİMARİ FİKİR YARIŞMASI</div></a>
								<div class="mega-menu-content style-2 clearfix">
									<ul class="mega-menu-column col-lg-4">
										<li class="mega-menu-title">
											<a href="#"><div>KATILIM</div></a>
											<ul>
												<!-- <li><a href="sartname.html"><div>ŞARTNAME</div></a></li> -->
												<li><a href="https://basvuru.ytongakademi.com/" target="_blank"><div>BAŞVURU FORMU</div></a></li>
											</ul>
										</li>
									</ul>
									<ul class="mega-menu-column col-lg-4">
										<li class="mega-menu-title">
											<a href="#"><div>KAYNAKLAR</div></a>
											<ul>
												<li><a href="juri.html"><div>JÜRİ</div></a></li>
												<li><a href="oduller.html"><div>ÖDÜLLER</div></a></li>
												<li><a href="videolar.html"><div>JÜRİ VİDEOLARI</div></a></li>
												<li><a href="sss.html"><div>SORU/YANIT?</div></a></li>
												<li><a href="raportorluk.html"><div>RAPORTÖRLÜK</div></a></li>
											</ul>
										</li>
									</ul>
									<ul class="mega-menu-column col-lg-4">
										<li class="mega-menu-title">
											<a href="#"><div>SONUÇLAR</div></a>
											<ul>
												<li><a href="sonuclar.html"><div>SONUÇLAR</div></a></li>
												<li><a href="odullu-projeler.html"><div>ÖDÜLLÜ PROJELER</div></a></li>
												<!-- <li><a href="projeler.asp"><div>PROJELER</div></a></li> -->
											</ul>
										</li>
									</ul>
								</div>
							</li>
							<li>
								<a href="#"><div>EĞİTİM VE ETKİNLİKLER</div></a>
								<ul>
									<li><a href="universite-seminerleri.html"><div><i class="icon-stack"></i>ÜNİVERSİTE SEMİNERLERİ</div></a></li>
									<li><a href="sirket-kurum-seminerleri.html"><div><i class="icon-stack"></i>ŞİRKET/KURUM SEMİNERLERİ</div></a></li>
								</ul>
							</li>
							<li><a href="iletisim.html"><div>İLETİŞİM</div></a></li>
							<li><a href="dijital-kolokyum.html"><div>DİJİTAL KOLOKYUM</div></a></li>
						</ul>

					</nav><!-- #primary-menu end -->

				</div>

			</div>

		</header><!-- #header end -->
		
		<!-- Page Title
		============================================= -->
		<section id="page-title">

			<div class="container clearfix">
				<h1>PROJELER</h1>
				<ol class="breadcrumb">
					<li class="breadcrumb-item"><a href="index.html">Anasayfa</a></li>
					<li class="breadcrumb-item"><a href="#">Mimari Fikir Yarışması</a></li>
					<li class="breadcrumb-item active" aria-current="page">Projeler</li>
				</ol>
			</div>

		</section><!-- #page-title end -->

		<!-- Content
		============================================= -->
		<section id="content">

			<div class="content-wrap nopadding">

				<!-- Portfolio Items
				============================================= -->
				<div id="portfolio" class="portfolio portfolio-6 grid-container portfolio-nomargin portfolio-full portfolio-masonry mixed-masonry grid-container clearfix">

<%
'*****************************************
' Oku: START
'*****************************************
ConConnect_Ya_Kayit()

Set proje_goruntule = Server.Createobject("Adodb.Recordset")
SQL = "Select KAPAK_DOSYASI, PROJE_ADI, RUMUZ, OZET_DOSYASI, PROJE_DOSYASI from KAYITLAR_DBSI where YTONG_ONAYI = 1"
SQL = SQL & " order by ID desc;"
proje_goruntule.Open SQL, Conn_Ya_Kayit, 1
toplam_kayit = proje_goruntule.RecordCount
			
do while not proje_goruntule.eof
%>

					<article class="portfolio-item 2017_s">
						<div class="portfolio-image">
							<a href="#">
								<img src="https://ytongakademi.com/proje_gorsel/<%=proje_goruntule("KAPAK_DOSYASI")%>" alt="<%=proje_goruntule("PROJE_ADI")%>">
							</a>
							<div class="portfolio-overlay-proje">
								<div class="portfolio-desc">
									<h3><%=proje_goruntule("PROJE_ADI")%></h3>
									<span>Rumuz: <%=proje_goruntule("RUMUZ")%></span>
								</div>
								<a href="https://basvuru3.ytongakademi.com/proje_dosyalari_x/<%=proje_goruntule("OZET_DOSYASI")%>" style="font-size:14px; padding:0 5px; border-radius:0.25rem; width:50px !important" class="btn" target="_blank">özet</a>
								<a href="https://basvuru3.ytongakademi.com/proje_dosyalari_x/<%=proje_goruntule("PROJE_DOSYASI")%>" style="font-size:14px; padding:0 5px; border-radius:0.25rem; width:50px !important" class="btn" target="_blank" >proje</a>
							</div>
						</div>
					</article>

<%
	proje_goruntule.movenext
	loop
	proje_goruntule.Close
	set proje_goruntule = Nothing
ConClose_Ya_Kayit()
'*****************************************
' Oku: END
'*****************************************
%>
					

				</div><!-- #portfolio end -->

			</div>

		</section><!-- #content end -->

		<!-- Footer
		============================================= -->
		<footer id="footer" class="dark">

			<!-- Copyrights
			============================================= -->
			<div id="copyrights">

				<div class="container clearfix">

					<div class="col_half">
						<img src="images/ytong-akademi-logo-footer.png" alt="Footer Logo" class="footer-logo">
					</div>

					<div class="col_half col_last tright">
						<div class="copyrights-menu copyright-links fright clearfix">
							<a href="#">Anasayfa</a>/<a href="#">Akademi</a>/<a href="#">Dersler</a>/<a href="#">Yarışma</a>/<a href="#">Yayınlar</a>/<a href="#">İletişim</a>
						</div>
						<div class="fright clearfix">
							<a href="https://www.youtube.com/TurkYtong" target="_blank" class="social-icon si-small si-borderless nobottommargin si-youtube">
								<img src="images/icon/YoutubeW.png">
							</a>
							
							<a href="http://www.linkedin.com/company/turk-ytong?trk=top_nav_home" target="_blank" class="social-icon si-small si-borderless nobottommargin si-linkedin">
								<img src="images/icon/LinkedinW.png">
							</a>
							
							<a href="https://www.instagram.com/turkytong/" target="_blank" class="social-icon si-small si-borderless nobottommargin si-youtube">
								<img src="images/icon/InstagramW.png">
							</a>

							<a href="https://x.com/turkytong" target="_blank" class="social-icon si-small si-borderless nobottommargin si-twitter">
								<img src="images/icon/TwitterXW.png">
							</a>

							<a href="http://www.facebook.com/turkytong" target="_blank" class="social-icon si-small si-borderless nobottommargin si-facebook">
								<img src="images/icon/FacebookW.png">
							</a>
						</div>
					</div>

				</div>
				
				<div class="container clearfix">
					<div class="col_half col_last tright">
						Ytong &copy; 2019 Tüm hakları saklıdır.
					</div>
				</div>
				
				<div class="clearfix" style="padding-left: 5%;">
					<div class="col_half">
						<img src="images/logoNakkasHoldingFooter.png" alt="Footer Logo" class="footer-logo">
					</div>
					
					<div class="col_half col_last tright">
						&nbsp;
					</div>
				</div>

			</div><!-- #copyrights end -->

		</footer><!-- #footer end -->

	</div><!-- #wrapper end -->

	<!-- Go To Top
	============================================= -->
	<div id="gotoTop" class="icon-angle-up"></div>

	<!-- External JavaScripts
	============================================= -->
	<script src="js/jquery.js"></script>
	<script src="js/plugins.js"></script>

	<!-- Footer Scripts
	============================================= -->
	<script src="js/functions.js"></script>

	<!-- Charts JS
	============================================= -->
	<script src="js/chart.js"></script>
	<script src="js/chart-utils.js"></script>

	<script>

		var randomScalingFactor = function() {
			return Math.round(Math.random() * 100);
		};

		var config = {
			type: 'doughnut',
			data: {
				datasets: [{
					data: [
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
					],
					backgroundColor: [
						window.chartColors.red,
						window.chartColors.orange,
						window.chartColors.yellow,
						window.chartColors.green,
						window.chartColors.blue,
					],
					label: 'Dataset 1'
				}],
				labels: [
					"Red",
					"Orange",
					"Yellow",
					"Green",
					"Blue"
				]
			},
			options: {
				responsive: true,
				legend: {
					display: false,
					position: 'top',
				},
				title: {
					display: false,
					text: 'Doughnut Chart'
				},
				animation: {
					animateScale: true,
					animateRotate: true
				}
			}
		};


		// Radar Chart

		var color = Chart.helpers.color;
		var configRadar = {
			type: 'radar',
			data: {
				labels: [["Eating", "Dinner"], ["Drinking", "Water"], "Sleeping", ["Designing", "Graphics"], "Coding", "Cycling", "Running"],
				datasets: [{
					label: "My First dataset",
					backgroundColor: color(window.chartColors.red).alpha(0.2).rgbString(),
					borderColor: window.chartColors.red,
					pointBackgroundColor: window.chartColors.red,
					data: [
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor()
					]
				}, {
					label: "My Second dataset",
					backgroundColor: color(window.chartColors.blue).alpha(0.2).rgbString(),
					borderColor: window.chartColors.blue,
					pointBackgroundColor: window.chartColors.blue,
					data: [
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor(),
						randomScalingFactor()
					]
				},]
			},
			options: {
				legend: {
					display: false
				},
				title: {
					display: false
				},
				scale: {
				  ticks: {
					beginAtZero: true
				  }
				}
			}
		};

		window.onload = function() {
			var ctx = document.getElementById("chart-doughnut").getContext("2d");
			window.myDoughnut = new Chart(ctx, config);
			window.myRadar = new Chart(document.getElementById("chart-radar"), configRadar);
		};

	</script>

</body>
</html>