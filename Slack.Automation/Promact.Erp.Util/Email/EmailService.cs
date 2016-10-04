﻿using Promact.Erp.DomainModel.ApplicationClass;
using System;
using System.Net.Mail;
using System.Text;

namespace Promact.Erp.Util.Email
{
    public class EmailService : IEmailService
    {
        private readonly EnvironmentVariableStore _envVariableStore;

        #region Constructor

        public EmailService(EnvironmentVariableStore envVariableStore)
        {
            _envVariableStore = envVariableStore;
        }

        #endregion

        /// <summary>
        /// Method used to send e-mails
        /// </summary>
        /// <param name="email">email.from, email.to, email.body, email.subject</param>
        public void Send(EmailApplication email)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(email.From);
                message.To.Add(new MailAddress(email.To));
                message.Subject = email.Subject;
                message.Body = email.Body;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();
                client.Host = _envVariableStore.FetchEnvironmentVariableValues(StringConstant.ScrumBotToken);
                client.Port = Convert.ToInt32(_envVariableStore.FetchEnvironmentVariableValues(StringConstant.Port));
                client.Credentials = new System.Net.NetworkCredential(_envVariableStore.FetchEnvironmentVariableValues(StringConstant.From), _envVariableStore.FetchEnvironmentVariableValues(StringConstant.Password));
                client.EnableSsl = Convert.ToBoolean(_envVariableStore.FetchEnvironmentVariableValues(StringConstant.EnableSsl));
                client.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

