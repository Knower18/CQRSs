using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.repos
{
    public class email : emailservice
    {
        public async Task sendemail(string mail, string sub, string bod)
        {
            var fromAddress = new MailAddress("teamengineering30@gmail.com", "Istanbul Kargo Website ");
            var toAddress = new MailAddress(mail, "User");
            const string fromPassword = "vsxcrtxmpcoijiay";
            string userToken = Guid.NewGuid().ToString(); // You can store this in DB for later verification
            string resetUrl = $"https://localhost:44333/conf_code.aspx?token={userToken}";



            string body = $@"
              <h3>Hello!</h3>
             <p> {sub}.</p>
               <h1>' {bod}'</h1>
                 ";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = sub,
                Body = body,
                IsBodyHtml = true,
            })
            {
                 smtp.Send(message);
            }
        }
    }
}
