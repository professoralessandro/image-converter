using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POCPDFtoImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LINHAS DE TESTE
            // var fn = "Fatura1.pdf";
            // string sourcePdf = @"C:\Users\profe\source\repos\TestesPDFtoImage\POCPDFtoImageV1\POCPDFtoImage\PDFs";
            this.ExtractJpeg();
        }
        // METHOD 5
        void ExtractJpeg()
        {
            try
            {
                // LINHAS DE TESTE
                // var dir1 = @"C:\Users\profe\source\repos\TestesPDFtoImage\POCPDFtoImageV1\POCPDFtoImage\PDFs\";
                // var fn = "Fatura1.pdf";
                var dir2 = @"C:\Users\profe\source\repos\TestesPDFtoImage\POCPDFtoImageV1\POCPDFtoImage\images\";
                var dir3 = @"C:\Users\profe\source\repos\TestesPDFtoImage\POCPDFtoImageV1\POCPDFtoImage\PDFs\Fatura2.pdf";
                if (!Directory.Exists(dir2)) Directory.CreateDirectory(dir2);

                var pdf = new PdfReader(dir3);
                int n = pdf.NumberOfPages;
                for (int i = 1; i <= n; i++)
                {
                    var pg = pdf.GetPageN(i);
                    var res = PdfReader.GetPdfObject(pg.Get(PdfName.RESOURCES)) as PdfDictionary;
                    var xobj = PdfReader.GetPdfObject(res.Get(PdfName.XOBJECT)) as PdfDictionary;
                    if (xobj == null) continue;

                    var keys = xobj.Keys;
                    if (keys.Count == 0) continue;

                    var obj = xobj.Get(keys.ElementAt(0));
                    if (!obj.IsIndirect()) continue;

                    var tg = PdfReader.GetPdfObject(obj) as PdfDictionary;
                    var type = PdfReader.GetPdfObject(tg.Get(PdfName.SUBTYPE)) as PdfName;
                    if (!PdfName.IMAGE.Equals(type)) continue;

                    int XrefIndex = (obj as PRIndirectReference).Number;
                    var pdfStream = pdf.GetPdfObject(XrefIndex) as PRStream;
                    var data = PdfReader.GetStreamBytesRaw(pdfStream);
                    var jpeg = dir2 + string.Format("{0:0000}.jpg", i);
                    File.WriteAllBytes(jpeg, data);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
