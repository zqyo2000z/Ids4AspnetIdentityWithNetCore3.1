using System;
using System.IO;
using MimeKit;

namespace Common.MailKit
{
    #region 邮件附件
    /// <summary>
    /// 邮件附件
    /// </summary>
    public class MailKitAttachmentInfo: IDisposable
    {
        /// <summary>
        /// 附件类型，比如application/pdf
        /// </summary>
        public string ContentType { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件传输编码方式，默认ContentEncoding.Default
        /// </summary>
        public ContentEncoding ContentTransferEncoding { get; set; } = ContentEncoding.Default;
        /// <summary>
        /// 文件数组
        /// </summary>
        public byte[] Data { get; set; }
        private Stream stream;
        /// <summary>
        /// 文件数据流，获取数据时优先采用此部分
        /// </summary>
        public Stream Stream
        {
            get
            {
                if (this.stream == null && this.Data != null)
                {
                    stream = new MemoryStream(this.Data);
                }
                return this.stream;
            }
            set { this.stream = value; }
        }
        /// <summary>
        /// 释放Stream
        /// </summary>
        public void Dispose()
        {
            if (this.stream != null)
            {
                this.stream.Dispose();
            }
        }

    }
    #endregion
}
