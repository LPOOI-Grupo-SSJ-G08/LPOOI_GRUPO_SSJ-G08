using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Net.Mail;

namespace ClasesBase
{
    public class Util
    {
        public static byte[] ImageToByte(Image img)
        {
            if (img != null)
            { 
                byte[] byteArray = new byte[0];
                using (MemoryStream stream = new MemoryStream())
                {
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    stream.Close();

                    byteArray = stream.ToArray();
                }
                return byteArray;
            }
            return null;
        }

        public static Image ByteToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        public static string CompleteImagePath(string nombreImg)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            var VistasDirectory = CurrentDirectory.Substring(0, CurrentDirectory.Length - 9);
            return VistasDirectory + "\\Resources\\" + nombreImg;
        }

        public static string CompleteSoundPath(string nombre)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            var VistasDirectory = CurrentDirectory.Substring(0, CurrentDirectory.Length - 9);
            return VistasDirectory + "\\Resources\\sounds\\" + nombre;
        }

        public static void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
    {
        string Text = "";
        SmtpClient mailClient = new SmtpClient("Mailhost");
        MailMessage msgMail;
        Text = "Stuff";
        msgMail = new MailMessage();
        msgMail.From = _from;
        msgMail.To.Add(_to);
        foreach (MailAddress addr in _cc)
        {
            msgMail.CC.Add(addr);
        }
        if (_bcc != null)
        {
            foreach (MailAddress addr in _bcc)
            {
                msgMail.Bcc.Add(addr);
            }
        }
        msgMail.Subject = _subject;
        msgMail.Body = Text;
        msgMail.IsBodyHtml = true;
        mailClient.Send(msgMail);
        msgMail.Dispose();
            }
    }
}
