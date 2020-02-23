using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Common;
using Entities.Helpers;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

namespace Common.MailKit
{
    /// <summary>
    /// 邮件服务工具类
    /// </summary>
    public class MailKitManager 
    {
        private readonly MailKitConfig _mailKitConfig;
       

        #region 配置服务
        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="mailKitConfig"></param>
        public MailKitManager(MailKitConfig mailKitConfig)
        {
            _mailKitConfig = mailKitConfig;
        }
        #endregion

       
      
        
        private static string ConvertToBase64(string inputStr, Encoding encoding)
        {
            return Convert.ToBase64String(encoding.GetBytes(inputStr));
        }

        private static string ConvertHeaderToBase64(string inputStr, Encoding encoding)
        { 
            var encode = !string.IsNullOrEmpty(inputStr) && inputStr.Any(c => c > 127);
            if (encode)
            {
                return "=?" + encoding.WebName + "?B?" + ConvertToBase64(inputStr, encoding) + "?=";
            }
            return inputStr;
        }
       


        public async Task SendEMailAsync(string subject, string content, IEnumerable<MailboxAddress> toAddress, TextFormat textFormat = TextFormat.Plain,
            IEnumerable<MailKitAttachmentInfo> attachments = null, bool dispose = true)
        {
            await SendEMailAsync(subject, content, new MailboxAddress[] { new MailboxAddress(_mailKitConfig.UserName, _mailKitConfig.UserAddress) }, toAddress, textFormat, attachments, dispose).ConfigureAwait(false);

        }

        public async Task SendEMailAsync(string subject, string content, MailboxAddress fromAddress, IEnumerable<MailboxAddress> toAddress,
            TextFormat textFormat = TextFormat.Plain, IEnumerable<MailKitAttachmentInfo> attachments = null, bool dispose = true)
        {
            await SendEMailAsync(subject, content, new MailboxAddress[] { fromAddress }, toAddress, textFormat, attachments, dispose).ConfigureAwait(false);

        }

        public async Task SendEMailAsync(string subject, string content, IEnumerable<MailboxAddress> fromAddress, IEnumerable<MailboxAddress> toAddress,
            TextFormat textFormat = TextFormat.Plain, IEnumerable<MailKitAttachmentInfo> attachments = null, bool dispose = true)
        {
            var message = new MimeMessage();
            message.From.AddRange(fromAddress);
            message.To.AddRange(toAddress);
            message.Subject = subject;
            var body = new TextPart(textFormat)
            {
                Text = content
            };
            MimeEntity entity = body;
            if (attachments != null)
            {
                var mult = new Multipart("mixed")
                {
                    body
                };
                foreach (var att in attachments)
                {
                    if (att.Stream != null)
                    {
                        var attachment = string.IsNullOrWhiteSpace(att.ContentType) ? new MimePart() : new MimePart(att.ContentType);
                        attachment.Content = new MimeContent(att.Stream);
                        attachment.ContentDisposition = new ContentDisposition(ContentDisposition.Attachment);
                       // attachment.ContentTransferEncoding = att.ContentTransferEncoding;
                        attachment.FileName = ConvertHeaderToBase64(att.FileName, Encoding.UTF8);//解决附件中文名问题
                        mult.Add(attachment);
                    }
                }
                entity = mult;
            }
            message.Body = entity;
            message.Date = DateTime.Now;
            using (var client = new SmtpClient())
            {
                //创建连接
                await client.ConnectAsync(_mailKitConfig.Host, _mailKitConfig.Port, _mailKitConfig.UseSsl).ConfigureAwait(false);
                await client.AuthenticateAsync(_mailKitConfig.UserAddress, _mailKitConfig.Password).ConfigureAwait(false);
                await client.SendAsync(message).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
                if (dispose && attachments != null)
                {
                    foreach (var att in attachments)
                    {
                        att.Dispose();
                    }
                }
            }
        }
    }
}
