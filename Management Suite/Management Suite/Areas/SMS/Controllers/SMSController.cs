using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;

namespace Management_Suite.Areas.SMS.Controllers
{
    public class SMSController : Controller
    {
        // GET: SMS/SMS
        public ActionResult Index()
        {
            var accountSid = "AC3f2330952196144b403db274b0c07b5d"; // Your Account SID from www.twilio.com/console
            var authToken = "a7661390586369df9b2641ba31c0ce94";  // Your Auth Token from www.twilio.com/console

            var twilio = new TwilioRestClient(accountSid, authToken);
            var message = twilio.SendMessage(
                "+12078353128", // From (Replace with your Twilio number)
                "+12073100000", // To (Replace with your phone number)
                "Hello from C#"
                );
            ViewBag.OutputText = message.Sid;

            //Console.WriteLine(message.Sid);
            //Console.Write("Press any key to continue.");
            //Console.ReadKey();

            return View();
        }
    }
}