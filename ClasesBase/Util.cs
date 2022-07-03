using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using iTextSharp.text;
using System.Data;
using iTextSharp.text.pdf;

namespace ClasesBase
{
    public class Util
    {
        public static byte[] ImageToByte(System.Drawing.Image img)
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

        public static System.Drawing.Image ByteToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                System.Drawing.Image img = System.Drawing.Image.FromStream(memstr);
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

        public static int PDFWriter(DataTable dt, string nombrePdf)
        {
            try
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(nombrePdf, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(dt.Columns.Count);
                table.WidthPercentage = 100;

                //Set columns names in the pdf file
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dt.Columns[k].ColumnName));

                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                    table.AddCell(cell);
                }

                //Add values of DataTable in pdf file
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(dt.Rows[i][j].ToString()));

                        //Align the cell in the center
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                        table.AddCell(cell);
                    }
                }
                document.Add(table);
                document.Close();

                return 0;

            }
            catch (Exception)
            {
                return 1;
            }

        }
    }
}
