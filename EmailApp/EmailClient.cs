using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp
{
    public class EmailClient
    {
        public EmailClient()
        {
            
        }
        public static string GenerateOTP()
        {
            string otp = "123232";
            return otp;
        }
        public static void SendEmail (string toEmail)
        {
            using (SmtpClient client = new SmtpClient("smtp.freesmtpservers.com", 25))
            {
                MailMessage message = new MailMessage(
                                         "test@gmail.com", // From field  
                                         toEmail, // Recipient field  
                                         "Testing Email again", // Subject of the email message  
                                         $"You OTP Code is {GenerateOTP()}. The code is valid for 1 minute " // Email message body  
                                      );
                client.Send(message);

                Console.WriteLine("Email has been sent.");
                
            }
        }

        
    }
}
