using Albinjose1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Numerics;
using System.Xml.Linq;
using System.Web;
using System.Reflection;

namespace Albinjose1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Albin()
        {
            CONTACTUS mObj = new CONTACTUS();
            return View(mObj);
        }
        public IActionResult SubmitContactus(CONTACTUS mObj)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                var message = new MailMessage();
                message.To.Add(new MailAddress("albinjoseandco@gmail.com")); // replace with receiver's email id     
                message.From = new MailAddress("noreplyquickpulse@gmail.com"); // replace with sender's email id     
                message.Subject = "Website Contact US request from " + mObj.NAME;
                message.Body = "Name: " + mObj.NAME + "\r\n Email: " + mObj.EMAIL + "\r\n Phone: " + mObj.PHONE + "\r\n" + mObj.MESSAGE;
                message.IsBodyHtml = true;
                try
                {
                    using (var smtp = new SmtpClient())
                    {
                        var credential = new NetworkCredential
                        {
                            UserName = "noreplyquickpulse@gmail.com", // replace with sender's email id     
                            Password = "kshbmbcdoanyjnab" // replace with password     
                        };
                        smtp.Credentials = credential;
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Send(message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                ViewBag.SuccessMessage = "We received tthe request and will update you shortly";
                return RedirectToAction("Albin", "Home");

            }
            else
            {
                ViewBag.SuccessMessage = "Please submit all mandatory fields";
                return View("Albin", mObj);
            }
        }
        public IActionResult Jose()
        {
            return View();
        }
        public IActionResult career()
        {
            return View();
        }
        public IActionResult SubmitCareer(CAREERMOD cwwus)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress("albinjoseandco@gmail.com")); // replace with receiver's email id     
            message.From = new MailAddress("noreplyquickpulse@gmail.com"); // replace with sender's email id     
            message.Subject = "Come Work With Us" + cwwus.NAME;
            message.Body = "FirstName: " + cwwus.FIRSTNAME + "\r\n LastName: " + cwwus.LASTNAME + "\r\n Email: " + cwwus.EMAIL 
                + "\r\n Phone: " + cwwus.PHONE + "\r\n Position: " + cwwus.POSITION + "\r\n" + cwwus.MESSAGE;
            try
            {
                message.Attachments.Add(new Attachment(cwwus.AttachmentCareer.OpenReadStream(), cwwus.AttachmentCareer.FileName));
            }
            catch (Exception ex) { }
            message.IsBodyHtml = true;
            try
            {
                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "noreplyquickpulse@gmail.com", // replace with sender's email id     
                        Password = "kshbmbcdoanyjnab" // replace with password     
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("Albin", "Home");
        }
        public IActionResult SubmitArticle(CAREERMOD aRticle)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress("albinjoseandco@gmail.com")); // replace with receiver's email id     
            message.From = new MailAddress("noreplyquickpulse@gmail.com"); // replace with sender's email id     
            message.Subject = "Articleship " + aRticle.NAME;
            message.Body = "First Name: " + aRticle.FIRSTNAME + "\r\n Last Name: " + aRticle.LASTNAME + "\r\n Email: " + aRticle.EMAIL 
                + "\r\n Phone: " + aRticle.PHONE + "\r\n Position: " + aRticle.POSITION + "\r\n Location: " + aRticle.LOCATION + "\r\n" + aRticle.MESSAGE;
            try
            {
                message.Attachments.Add(new Attachment(aRticle.AttachmentCareer.OpenReadStream(), aRticle.AttachmentCareer.FileName));
            }
            catch (Exception ex) { }
            message.IsBodyHtml = true;
            try
            {
                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "noreplyquickpulse@gmail.com", // replace with sender's email id     
                        Password = "kshbmbcdoanyjnab" // replace with password     
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("Albin", "Home");
        }
    }
}