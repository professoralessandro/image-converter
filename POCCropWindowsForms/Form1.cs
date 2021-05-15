using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCCropWindowsForms
{
    public partial class Form1 : Form
    {
        public static string path = @"C:\Users\profe\Pictures\AP - Imagens\";
        public static string mainFile = "170013218_1691096707739234_6392655146255409480_n";
        public static string mainFileType = ".jpg";
        public static string pathmainFileFull = path + mainFile + mainFileType;

        public static string pathOut = @"C:\Users\profe\Pictures\AP - Imagens\Imagens de saida\";
        public static string mainFileOut = "170013218_1691096707739234_6392655146255409480_n";
        public static string mainFileTypeOut = ".jpg";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // PREPARA OS CONTROLES
            
            this.textPathArquivo.Enabled = false;
            this.textPathArquivoSaida.Enabled = false;

            // VERIFICA O DIRETORIO DO PROGRAMA SE ELE EXISTE E SE NAO EXISTIR ELE E CRIADO
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            // AQUI VERIFICA SE O ARQUIVO RAIZ EXISTE PARA EXIBIR NO IMAGEDIALOG
            if (File.Exists(pathmainFileFull))
            {
                //Load image
                this.SetImageOnFrame(pathmainFileFull);
                this.textPathArquivo.Text = pathmainFileFull;
            }
            else
            {
                this.textPathArquivo.Text = path;
            }

            // TRATAMENTO DIRETORIO DE SAIDA
            if (!Directory.Exists(pathOut))
            {
                Directory.CreateDirectory(pathOut);
            }

            this.textPathArquivoSaida.Text = pathOut;
        }

        //declare some variable for crop coordinates
        int crpX, crpY, rectW, rectH;

        // Declare crop pen for cropping image
        public Pen crpPen = new Pen(Color.White);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                // set initial x,y co ordinates for crop rectangle
                //this is where we firstly click on image
                crpX = e.X;
                crpY = e.Y;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //here we declare mouse event handlers

            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);

            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);

            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            Controls.Add(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Dimensions :" + rectW + "," + rectH;
            Cursor = Cursors.Default;
            //Now we will draw the cropped image into pictureBox2
            Bitmap bmp2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp2, pictureBox1.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            pictureBox2.Image = (Image)crpImg;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnDiretorioSaida_Click(object sender, EventArgs e)
        {
            

            using (var openDlg = new FolderBrowserDialog())
            {
                openDlg.SelectedPath = pathOut;

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    // CAMINHO DA PASTA SELECIONADA
                    this.textPathArquivoSaida.Text = "";
                    pathOut = openDlg.SelectedPath;
                    this.textPathArquivoSaida.Text = pathOut;
                }
            }
        }

        private void BtnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openDlg = new OpenFileDialog())
                {
                    openDlg.InitialDirectory = path;
                    openDlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                    openDlg.CheckFileExists = true;
                    openDlg.CheckPathExists = true;
                    openDlg.FilterIndex = 2;
                    openDlg.RestoreDirectory = true;
                    openDlg.ReadOnlyChecked = true;
                    openDlg.ShowReadOnly = true;
                    openDlg.Multiselect = false;

                    if (openDlg.ShowDialog() == DialogResult.OK)
                    {
                        // CAMINHO DA PASTA SELECIONADA
                        this.textPathArquivo.Text = "";
                        pathmainFileFull = openDlg.FileName;
                        //Load image
                        this.SetImageOnFrame(pathmainFileFull);
                        this.textPathArquivo.Text = pathmainFileFull;
                        // path = openDlg.;
                        // this.textPathArquivo.Text = path;
                    }
                }
            }
            catch (SecurityException ex)
            {
                // O usuário  não possui permissão para ler arquivos
                MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                            "Mensagem : " + ex.Message + "\n\n" +
                                            "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                // Não pode carregar a imagem (problemas de permissão)
                MessageBox.Show("Não é possível exibir a imagem : " + pathmainFileFull
                                           + ". Você pode não ter permissão para ler o arquivo , ou " +
                                           " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
            }


        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        private void btnSelectCroppArea_Click(object sender, EventArgs e)
        {
            //here we declare mouse event handlers

            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);

            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);

            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            Controls.Add(pictureBox1);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Refresh();
                //set width and height for crop rectangle.
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

        // METODOS DA CLASSE
        private void SetImageOnFrame(string file)
        {
            Bitmap bmp = new Bitmap(file);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = (Image)bmp;
        }

        protected void GerarPDF()
        {
            //Definindo tamanho do documento
            Document document = new Document(new iTextSharp.text.Rectangle(3508, 2480),40,40,40,40);
            
            MemoryStream msDoc = new MemoryStream();
            
            //Criando documento
            PdfWriter writer = PdfWriter.GetInstance(document, msDoc);
            document.Open();

            //Pegando localização da imagem
            string localizacao = Server.MapPath("imagem.jpg");
            
            //Definindo resolução
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(localizacao);
            img.ScaleToFit(3428, 2400);
            
            IElement e = img;          
            doc.Add(e);         
            doc.Close();
            
            //Mandando a imagem para o navegador
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment;filename=Arquivo.pdf");
            Response.ContentType = "application/pdf";
            Response.BinaryWrite(msDoc.ToArray());
            Response.End(); 
            
        }
    }
}
