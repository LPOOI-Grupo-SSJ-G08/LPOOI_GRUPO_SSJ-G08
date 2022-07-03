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

        public static int PDFWriter(DataTable dt, string nombrePdf, string contenido)
        {
            try
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(nombrePdf, FileMode.Create));
                document.Open();

                string Titulo = "REGISTROS DE " + contenido;
                string fechaActual = DateTime.Now.ToShortDateString();
                string horaActual = DateTime.Now.ToString("h:mm tt");

                //Primer tabla con Fecha y Hora
                PdfPTable tabla1 = new PdfPTable(2);
                tabla1.DefaultCell.Padding = 3;
                tabla1.SpacingBefore = 10;
                tabla1.WidthPercentage = 80;
                tabla1.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell cCodigo = new PdfPCell(new Phrase(1, "FECHA DE EMISIÓN: " + fechaActual));
                cCodigo.Border = PdfPCell.NO_BORDER;
                cCodigo.HorizontalAlignment = Element.ALIGN_LEFT;
                tabla1.AddCell(cCodigo);
                PdfPCell cFecha = new PdfPCell(new Phrase(2, "HORA DE EMISIÓN: " + horaActual));
                cFecha.Border = PdfPCell.NO_BORDER;
                cFecha.HorizontalAlignment = Element.ALIGN_RIGHT;
                tabla1.AddCell(cFecha);

                //Creacion de titulos
                Paragraph titulo = new Paragraph(string.Format(Titulo), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(27, 153, 139)));
                titulo.Alignment = Element.ALIGN_CENTER;

                
                //Cracion de Tabla 
                PdfPTable table = new PdfPTable(dt.Columns.Count);
                table.WidthPercentage = 100;

                //Set columns names in the pdf file
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dt.Columns[k].ColumnName));

                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(27, 153, 139);

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

                document.Add(tabla1);
                document.Add(new Chunk());
                document.Add(titulo);
                document.Add(new Chunk());
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
