using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Instantiate mime message
            var message = new MimeMessage();

            // from address
            message.From.Add(new MailboxAddress("Tien Nguyen", "nguyenminhtien28031997@gmail.com"));
            // to address
            message.To.Add(new MailboxAddress("Leader", "TienNMSE62756@fpt.edu.vn"));
            //subject
            message.Subject = "I do demo about sending email !";
            //body
            message.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = @"
            <p style='background-color:#ffc;color:black;'> Bảng Lương FPT University : </p>
            <table style='width:100%;border: 1px solid black;border-collapse: collapse;'>
            <caption> Lương Tháng 12</caption>
            <tr>
                <th style='border: 1px solid black;'>Name</th>
                <th style='border: 1px solid black;'>Salary</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
                <th style='border: 1px solid black;'>Test</th>
            </tr>
            <tr>
                <td style='border: 1px solid black;'>Nguyen Minh Tien</td>
                <td style='border: 1px solid black;'>18.000.000</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>

            </tr>
            <tr>
                <td style='border: 1px solid black;'>Nguyen Minh Tien</td>
                <td style='border: 1px solid black;'>18.000.000</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>

            </tr>
            <tr>
                <td style='border: 1px solid black;'>Nguyen Minh Tien</td>
                <td style='border: 1px solid black;'>18.000.000</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>

            </tr>
            <tr>
                <td style='border: 1px solid black;'>Nguyen Minh Tien</td>
                <td style='border: 1px solid black;'>18.000.000</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>

            </tr>
            <tr>
                <td style='border: 1px solid black;'>Nguyen Minh Tien</td>
                <td style='border: 1px solid black;'>18.000.000</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>

            </tr>
            <tr>
                <td style='border: 1px solid black;'>Nguyen Minh Tien</td>
                <td style='border: 1px solid black;'>18.000.000</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>

            </tr>
            <tr>
                <td style='border: 1px solid black;'>Nguyen Minh Tien</td>
                <td style='border: 1px solid black;'>18.000.000</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>

            </tr>
            <tr>
                <td style='border: 1px solid black;'>Nguyen Minh Tien</td>
                <td style='border: 1px solid black;'>18.000.000</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>
                <td style='border: 1px solid black;'>Test</td>

            </tr>
            </table>"
            };



            // configer and send email 
            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                //host , port , usse
                client.Connect("smtp.gmail.com", 465, true);

                client.Authenticate("nguyenminhtien28031997@gmail.com", "haidenchin.123@");
                client.Send(message);
                client.Disconnect(true);
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
