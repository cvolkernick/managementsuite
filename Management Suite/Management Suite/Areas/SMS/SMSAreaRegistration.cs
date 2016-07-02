using System.Web.Mvc;

namespace Management_Suite.Areas.SMS
{
    public class SMSAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SMS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SMS_default",
                "SMS/{controller}/{action}/{id}",
                new { controller = "SMS", action = "Index", id = UrlParameter.Optional }
            );            
        }
    }
}