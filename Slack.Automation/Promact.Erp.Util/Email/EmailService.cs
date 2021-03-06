﻿using Promact.Erp.DomainModel.ApplicationClass;
using Promact.Erp.Util.EnvironmentVariableRepository;
using System;
using System.Net.Mail;
using System.Text;

namespace Promact.Erp.Util.Email
{
    public class EmailService : IEmailService
    {
        private readonly IEnvironmentVariableRepository _envVariableRepository;

        #region Constructor

        public EmailService(IEnvironmentVariableRepository envVariableRepository)
        {
            _envVariableRepository = envVariableRepository;
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
                client.Host = _envVariableRepository.Host;
                client.Port = Convert.ToInt32(_envVariableRepository.Port);
                client.Credentials = new System.Net.NetworkCredential(_envVariableRepository.From, _envVariableRepository.Password);
                client.EnableSsl = Convert.ToBoolean(_envVariableRepository.EnableSsl);
                client.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

