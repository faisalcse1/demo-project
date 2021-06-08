using EmailClient.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using QuickMailer;
using MailMessage = EmailClient.Models.MailMessage;

namespace EmailClient.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Send(MailMessage mailMessage)
        {
            try
            {
                List<string>toMailAddress=new List<string>();
                List<string> ccMailAddress = new List<string>();
                List<string> bccMailAddress = new List<string>();
                Email email = new Email("",25,false);
                toMailAddress = GetValidMail(mailMessage.To);
                ccMailAddress = GetValidMail(mailMessage.Cc);
                bccMailAddress = GetValidMail(mailMessage.Bcc);
                string mgs = "Email send failed.";

                List<Attachment>attachments=new List<Attachment>();
                if(mailMessage.File!=null)
                {
                    Attachment attachment=new Attachment(mailMessage.File.OpenReadStream(),mailMessage.File.FileName);
                    attachments.Add(attachment);
                }
                
                bool isSend = email.SendEmail(toMailAddress, Credential.Email, Credential.Password, mailMessage.Subject,
                     mailMessage.Body,ccMailAddress,bccMailAddress,attachments);
                if (isSend)
                {
                    mgs = "Email has been send.";
                    ModelState.Clear();
                }

                ViewBag.Mgs = mgs;
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public List<string>GetValidMail(List<string>mails)
        {
            List<string>validMails=new List<string>();
            Email email = new Email();
            if(mails==null)
            {
                return validMails;
            }
            if (mails.Any())
            {

                foreach (var mail in mails)
                {
                    bool isValid = email.IsValidEmail(mail);
                    if (isValid)
                    {
                        validMails.Add(mail);
                    }
                }
            }

            return validMails;
        }
    }
}
