using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Portfolio.Services;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Portfolio.Services
{
    public class EmailService
    {
        private readonly MailjetOptions _options;

        public EmailService(IOptions<MailjetOptions> options)
        {
            _options = options.Value;
        }


        public async Task SendMail(EmailModel model)
        {
            MailjetClient client = new MailjetClient(_options.Key, _options.Secret);
            MailjetRequest request = new MailjetRequest
            {
                Resource = SendV31.Resource,
            }.Property(Send.Messages, new JArray
            {
                new JObject
                {
                    {"From", new JObject{
                        {"Email", "emeka.ewelike@thebulbafrica.institute" },
                        {"Name", "new mail from my portfolio" }
                    } },

                    {"To", new JArray {
                        new JObject
                        {
                            {"Email", "emekaewelike@gmail.com" },
                            {"Name", "Friend" }
                        }

                    } },
                    {"Subject", model.Title},
                    {"TextPart", model.Body},
                    {"HTMLPart", model.Body}
                }
            });
            MailjetResponse response = await client.PostAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(string.Format("Total: {0}, Count: {1}\n", response.GetTotal(), response.GetCount()));
                Console.WriteLine(response.GetData());
            }
            else
            {
                Console.WriteLine(string.Format("StatusCode: {0}\n", response.StatusCode));
                Console.WriteLine(string.Format("ErrorInfo: {0}\n", response.GetErrorInfo()));
                Console.WriteLine(response.GetData());
                Console.WriteLine(string.Format("ErrorMessage: {0}\n", response.GetErrorMessage()));
            }
        }
    }
}