using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web.Http;

namespace Api_Mail.Controllers
{
    public class ValuesController : ApiController
    {



        // POST api/values
        //[HttpPost]
        //[Route("Values/SendEmail/{from}/{to}")]
        public void SendEmail(string from, string msje)
        {
            string mail = "gonzalotardini@gmail.com";
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(mail, "hugogladyshemorroides");
            msje = "<b>Has recibido una consulta de:</b> " + from + " "+ "<br>" + "Mensaje:  <br>" + msje ;
            MailMessage mm = new MailMessage(mail, mail, "Consulta en Sitio Web", msje);
            mm.IsBodyHtml = true;
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }        
       
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
