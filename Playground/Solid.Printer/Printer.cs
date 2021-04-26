namespace Solid.Printer
{
    using RestSharp;
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Mail;
   

    public class Printer : IPrinter
    {
        private readonly Configuration configuration;

        public Printer(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public string Print(string content, int numberOfCopies = 3)
        {
            var aggregatedContent = Enumerable.Range(0, numberOfCopies)
                .Select(_ => content)
                .Aggregate((partialPhrase, newPart) => $"{partialPhrase}{Environment.NewLine}{newPart}");

            return aggregatedContent;
        }

        public void PrintAndSendNotification(string content, NotificationType notificationType)
        {
            this.SendNotification(() => this.Print(content), notificationType);
        }

        private void SendNotification(Func<string> execute, NotificationType notificationType)
        {
            var content = execute();

            if (notificationType == NotificationType.Email)
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = configuration.Email.Port,
                    Credentials = new NetworkCredential(
                        configuration.Email.MainEmail,
                        configuration.Email.MainPassword
                    ),
                    EnableSsl = false,
                };

                smtpClient.Send(
                    configuration.Email.MainEmail,
                    configuration.Email.MainEmail, 
                    "printed content",
                    content
                );
            }
            else if (notificationType == NotificationType.Sms)
            {
                var client = new RestClient("https://api.melroselabs.com/sms/message");
                client.Timeout = -1;

                var request = new RestRequest(Method.POST);

                request.AddHeader("x-api-key", configuration.Sms.ApiKey);
                request.AddHeader("Content-Type", "application/json");


                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(
                    new
                    {
                        destination = configuration.Sms.Destination,
                        message = content,
                        source = configuration.Sms.Source
                    }
                );

                client.Execute(request);
            }
        }
    }
}
