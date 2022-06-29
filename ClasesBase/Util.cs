using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

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
    }
}
