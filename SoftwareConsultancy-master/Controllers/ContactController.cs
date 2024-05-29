using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Services;
using WitSolutions.ViewModels;


namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        public readonly IEmailService _emailservice;
        public readonly SendGridSettings _sendgrid;



        public ContactController(IEmailService email, IOptions<SendGridSettings> options)
        {
            _emailservice = email;
            _sendgrid = options.Value;


        }


        public IActionResult Index()
        {
            //
            ViewBag.Class = "Contact";
            return View(new ClientQueryVM());

        }
        [HttpPost]
        public async Task<IActionResult> Contactus(ClientQueryVM client)
        {
            await _emailservice.SendEmailAsync(client.email, client.subject, client.message, client.Name, true);

            await _emailservice.SendEmailAsync(client.email, client.subject, client.message, client.Name, false);


            TempData["success"] = "Thanks for contacting us";

            return Redirect("/");

        }

    }
}
