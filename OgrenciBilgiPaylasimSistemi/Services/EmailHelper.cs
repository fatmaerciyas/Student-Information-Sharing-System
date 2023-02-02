using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OgrenciBilgiPaylasimSistemi.Services
{
    public class EmailHelper
    {
        public bool SendEmail(string userEmail, string confirmationLink)
        {
            //MailMessage mailMessage = new MailMessage();
            //mailMessage.From = new MailAddress("fatmaerciyas22@gmail.com");
            //mailMessage.To.Add(new MailAddress(userEmail));

            //mailMessage.Subject = "Confirm your email";
            //mailMessage.IsBodyHtml = true;
            //mailMessage.Body = confirmationLink;

            SmtpClient client = new SmtpClient();

            client.Port = 587;
            client.Host = "smtp.gmail.com"; //or another email sender provider
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            client.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "fatmaerciyas22@gmail.com",
                Password = "17366875104"
            };

            MailAddress FromEmail = new MailAddress("fatmaerciyas22@gmail.com", "Fatma Erciyas");
            MailAddress ToEmail = new MailAddress(userEmail, "Birisi");

            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "E-Postanı onayla",
                Body = confirmationLink

            };
            Message.To.Add(ToEmail);
            try
            {
                client.SendMailAsync(Message);
                return true;

            }
            catch (Exception ex)
            {
                // log exception
                return false;
            }


        }
    }
}
