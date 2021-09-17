using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;

using Twilio.AspNet.Mvc;
using System.Configuration;


namespace SMSSending.Controllers
{
    public class SendSMSController : TwilioController
    {
        
        public ActionResult SendSMS()
        {
            var accountsid = "AC4f2f81516274888281741e0ab1171416";
            var authToken = "962290bed18cc62efb05e5007624f382";
            TwilioClient.Init(accountsid, authToken);
            /*var to = new PhoneNumber("+923354883191");*/
            var to = new PhoneNumber("+12057459526");
            /*var from = new PhoneNumber("+17162192114");*/
            var from = new PhoneNumber("+17162192114");
            
            var message = MessageResource.Create(
                to: to,
                from: from,
                body: "Sending SMS to shazia from twilio test Account"
                );
            return Content(message.Sid);

        }
    }
}