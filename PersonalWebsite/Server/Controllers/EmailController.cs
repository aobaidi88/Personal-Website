using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Shared;
using System.Net.Mail;
using System.Net;
using PersonalWebsite.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace PersonalWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpGet]
        public string GetEmail()
        {
            return "Hello from email Controller";
        }

        [HttpPost]
        public IActionResult PostEmail(ContactInfo contact)
        {
            const string smtpAddress = "smtp.gmail.com";
            const int portNumber = 587;
            string mess = "ID: " + contact.ContactInfoID + "From: " + contact.FirstName + " " + contact.lastName + "Message: " +
                           contact.Comments + "Web App: " + contact.IsWebApp + "Windows App: " + contact.IsWindows + "Phone App: " + contact.IsPhoneApp;
            const string emailFromAddress = "blazorclass2020@gmail.com"; //Sender Email Address  
            const string password = "Q,q,2181988"; //Sender Password             
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(contact.Email);
                    mail.To.Add(emailFromAddress);
                    mail.Subject = contact.TypeOfRequest;
                    mail.Body = mess;
                    mail.IsBodyHtml = true;
                    
                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                return Ok();
            }
            catch (Exception exc)
            {
                return NotFound(exc.Message);
            }
        }
    }
}




