using GraceFellowShipRetreat2020.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using GraceFellowShipRetreat2020.DAL;

namespace GraceFellowShipRetreat2020.Controllers
{
    public class ContactUsController : Controller
    {
        [HttpPost]
        [AllowAnonymous]
        public JsonResult Contact(ContactUsModel cuModel)
        {

            SaveContactToDB(cuModel);
            SendEmailToAdmin(cuModel.ContactName,cuModel.ContactEmail,cuModel.ContactMessage);
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
            //return Redirect(cuModel.CurrentURL);
        }
        /*
        public  bool SendEmailToAdmin(string contactName, string contactEmail, string contactMessage)
        {
            try
            {
               // var myMessage = new SendGrid.SendGridMessage();
                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new System.Net.Mail.MailAddress(ConfigurationManager.AppSettings["emailAdminFrom"]);
                mailMessage.To.Add(new System.Net.Mail.MailAddress(ConfigurationManager.AppSettings["emailAdmin"]));
                //testing  mailMessage.To.Add(new System.Net.Mail.MailAddress("amanullaha@chrc.net"));
                mailMessage.Subject = "Potential Customer contacting Bridgelink International";

                mailMessage.IsBodyHtml = true;
                //AlternateView htmlView = AlternateView.CreateAlternateViewFromString(GetRegistrationEmailBody(string.Empty, string.Empty, string.Empty, string.Empty), null, "text/html");
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString("Contact Name: " + contactName + "<br/>" + "Contact Email: " + contactEmail + "<br/>" + "Message: " + contactMessage, null, "text/html");

               
               

                mailMessage.AlternateViews.Add(htmlView);
                //  mailMessage.Attachments.Add(new Attachment(Server.MapPath("~/pdf/CHOLESTABETES Needs Assessment.pdf")));

                SendMail(mailMessage);
                return true;


            }

            catch (Exception e)
            {
                // Response.Write("fail in sendEmailNotification+++++" + e.Message.ToString());

                return false;
            }
        }
        */
        private bool SaveContactToDB(ContactUsModel cuModel)
        {

            SaveDBRepository sdbRepo = new SaveDBRepository();
            sdbRepo.SaveContact(cuModel);
            return true;

        }
        public bool SendEmailToAdmin(string contactName, string contactEmail, string contactMessage)
        {
            try
            {

                //create an account in sendgrid
                //https://app.sendgrid.com/account/details
                //use your account login/password to send through through their smtp server
                //confirm the sender email andrewlai@bridgelinkhk.com  - you cannot use anyone else as the from address.
               
                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new System.Net.Mail.MailAddress(ConfigurationManager.AppSettings["emailAdminFrom"]);
                mailMessage.To.Add(new System.Net.Mail.MailAddress(ConfigurationManager.AppSettings["emailAdmin"]));
                //testing  mailMessage.To.Add(new System.Net.Mail.MailAddress("amanullaha@chrc.net"));
                mailMessage.Subject = "Potential Customer contacting Bridgelink International";

                mailMessage.IsBodyHtml = true;
                //AlternateView htmlView = AlternateView.CreateAlternateViewFromString(GetRegistrationEmailBody(string.Empty, string.Empty, string.Empty, string.Empty), null, "text/html");
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString("Contact Name: " + contactName + "<br/>" + "Contact Email: " + contactEmail + "<br/>" + "Message: " + contactMessage + "<br/>Location: bridgelinkhk.com", null, "text/html");




                mailMessage.AlternateViews.Add(htmlView);
                //  mailMessage.Attachments.Add(new Attachment(Server.MapPath("~/pdf/CHOLESTABETES Needs Assessment.pdf")));

                SendGridMail(mailMessage);
                return true;


            }

            catch (Exception e)
            {
                // Response.Write("fail in sendEmailNotification+++++" + e.Message.ToString());

                return false;
            }
        }
        public void SendMail(MailMessage Message)
        {
            SmtpClient client = new SmtpClient();
            try
            {

                client.Host = ConfigurationManager.AppSettings["smtpServer"];

                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                var SendGridKey = ConfigurationManager.AppSettings["SendGridKey"];
              //  var client = new SendGridClient(apiKey);

                
                // NetworkCred.UserName = "webmaster@questionaf.ca";
                //NetworkCred.Password = "xkc232v";
                NetworkCred.UserName = ConfigurationManager.AppSettings["smtpUser"];
                NetworkCred.Password = ConfigurationManager.AppSettings["smtpPassword"];
                
                client.UseDefaultCredentials = false;
                client.Credentials = NetworkCred;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
               client.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
              
                // client.Port = 25;
                client.Port = Convert.ToInt32(ConfigurationManager.AppSettings["smtpPort"]);

                client.Timeout = 20000;
                client.Send(Message);
                

            }
            catch (Exception e)
            {
                
                String Error = e.Message.ToString();
                //Utility.WriteToLog("SendMail Error: " + Error);
            }

        }

        public void SendGridMail(MailMessage Message)
        {
            SmtpClient client = new SmtpClient();
            try
            {
                //create an account in sendgrid
                //https://app.sendgrid.com/account/details
                //use your account login/password to send through through their smtp server
                //confirm the sender email andrewlai@bridgelinkhk.com  - you cannot use anyone else as the from address.
      
                SmtpClient smtpClient = new SmtpClient(ConfigurationManager.AppSettings["smtpServer"], Convert.ToInt32(ConfigurationManager.AppSettings["smtpPort"]));
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["smtpUser"], ConfigurationManager.AppSettings["smtpPassword"]);
                smtpClient.Credentials = credentials;
                // var SendGridKey = ConfigurationManager.AppSettings["SendGridKey"];
                //  var client = new SendGridClient(apiKey);


                // NetworkCred.UserName = "webmaster@questionaf.ca";
                //NetworkCred.Password = "xkc232v";
                smtpClient.Send(Message);


            }
            catch (Exception e)
            {

                String Error = e.Message.ToString();
                //Utility.WriteToLog("SendMail Error: " + Error);
            }

        }

    }
}