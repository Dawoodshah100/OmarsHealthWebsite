using OmarsHealthWebsite.Models;
//using System.Net;
//using System.Net.Mail;
using System.Web.Mvc;

namespace OmarsHealthWebsite.Controllers
{
    public class ClaimController : Controller
    {
        bool ClaimCall = false;
        [HttpGet]
        public ActionResult ClaimOnline()
        {
           
            
            return View();
        }

         [HttpPost]
        public ActionResult ClaimOnline(ClaimOnline claimOnline)
        {
            ClaimCall = true;
            //SendEmail(claimOnline);
            
            return View();
        }

     
       public RedirectToRouteResult  CallMeBack(CallMeBack Model)
        {
            ClaimCall = false;
            //SendEmail(new ClaimOnline() {CallMeBack=Model });
            return RedirectToAction("Index", "Home");
           
        }

        //[NonAction]
        //protected void SendEmail(ClaimOnline Model)
        //{
        //    string ExtendedMessage="";
        //    if (ClaimCall)
        //    {
        //        ExtendedMessage = "More details are: Incident Happened at " + Model.TimeAffected;
        //        ExtendedMessage += ", I am in England/Wales:" + Model.InEnglandOrWalesInjury;
        //        ExtendedMessage += ", I am Injured:" + Model.IsInjured;
        //        ExtendedMessage += ", Injury Type" + Model.InjuryType;
        //        ExtendedMessage += ", Injured Part" + Model.InjuryParts;
        //        ExtendedMessage += ", Injury sub Parts" + Model.InjuryInnerParts;
        //        ExtendedMessage += ", Legal Advice Taken: " + Model.LegalAdvice;
        //        ExtendedMessage += ", Is Able to Work:" + Model.IsAbleToWork;
        //    }
            
        //    using (MailMessage mm = new MailMessage("MyEmailAddress@gmail.com", "ToEmailAddress@gmail.com"))
        //    {
        //        mm.Subject = "Could you Call me on "+Model.CallMeBack.PhoneNumber;
                
        //        mm.Body = "I am "+Model.CallMeBack.FirstName +" "+Model.CallMeBack.LastName+". "+ExtendedMessage;
        //        mm.IsBodyHtml = false;
        //        SmtpClient smtp = new SmtpClient();
        //        smtp.Host = "smtp.gmail.com";
        //        smtp.EnableSsl = true;
        //        NetworkCredential NetworkCred = new NetworkCredential("MyEmailAddress@gmail.com", "EmailPassword");
        //        smtp.UseDefaultCredentials = true;
        //        smtp.Credentials = NetworkCred;
        //        smtp.Port = 587;
        //        smtp.Send(mm);
        //    }
        //}
    }
}