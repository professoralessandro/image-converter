
namespace POCCropWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSelecionarArquivo = new System.Windows.Forms.Button();
            this.textPathArquivo = new System.Windows.Forms.TextBox();
            this.textPathArquivoSaida = new System.Windows.Forms.TextBox();
            this.btnDiretorioSaida = new System.Windows.Forms.Button();
            this.BtnSaveImageToPDF = new System.Windows.Forms.Button();
            this.btnSelectCroppArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alessandro Programing - Image crop tool";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(121, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 247);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(715, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 247);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Selecionar area de recorte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Crop area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dimensions:";
            // 
            // BtnSelecionarArquivo
            // 
            this.BtnSelecionarArquivo.Location = new System.Drawing.Point(313, 457);
            this.BtnSelecionarArquivo.Name = "BtnSelecionarArquivo";
            this.BtnSelecionarArquivo.Size = new System.Drawing.Size(108, 20);
            this.BtnSelecionarArquivo.TabIndex = 6;
            this.BtnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.BtnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.BtnSelecionarArquivo.Click += new System.EventHandler(this.BtnSelecionarArquivo_Click);
            // 
            // textPathArquivo
            // 
            this.textPathArquivo.Location = new System.Drawing.Point(121, 457);
            this.textPathArquivo.Name = "textPathArquivo";
            this.textPathArquivo.Size = new System.Drawing.Size(186, 20);
            this.textPathArquivo.TabIndex = 7;
            // 
            // textPathArquivoSaida
            // 
            this.textPathArquivoSaida.Location = new System.Drawing.Point(121, 485);
            this.textPathArquivoSaida.Name = "textPathArquivoSaida";
            this.textPathArquivoSaida.Size = new System.Drawing.Size(186, 20);
            this.textPathArquivoSaida.TabIndex = 9;
            // 
            // btnDiretorioSaida
            // 
            this.btnDiretorioSaida.Location = new System.Drawing.Point(313, 485);
            this.btnDiretorioSaida.Name = "btnDiretorioSaida";
            this.btnDiretorioSaida.Size = new System.Drawing.Size(108, 20);
            this.btnDiretorioSaida.TabIndex = 8;
            this.btnDiretorioSaida.Text = "Diretório de saída";
            this.btnDiretorioSaida.UseVisualStyleBackColor = true;
            this.btnDiretorioSaida.Click += new System.EventHandler(this.btnDiretorioSaida_Click);
            // 
            // BtnSaveImageToPDF
            // 
            this.BtnSaveImageToPDF.Location = new System.Drawing.Point(121, 551);
            this.BtnSaveImageToPDF.Name = "BtnSaveImageToPDF";
            this.BtnSaveImageToPDF.Size = new System.Drawing.Size(300, 34);
            this.BtnSaveImageToPDF.TabIndex = 10;
            this.BtnSaveImageToPDF.Text = "Salvar imagem como PDF";
            this.BtnSaveImageToPDF.UseVisualStyleBackColor = true;
            // 
            // btnSelectCroppArea
            // 
            this.btnSelectCroppArea.Location = new System.Drawing.Point(121, 417);
            this.btnSelectCroppArea.Name = "btnSelectCroppArea";
            this.btnSelectCroppArea.Size = new System.Drawing.Size(300, 34);
            this.btnSelectCroppArea.TabIndex = 11;
            this.btnSelectCroppArea.Text = "Recortar Area Selecionada";
            this.btnSelectCroppArea.UseVisualStyleBackColor = true;
            this.btnSelectCroppArea.Click += new System.EventHandler(this.btnSelectCroppArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 607);
            this.Controls.Add(this.btnSelectCroppArea);
            this.Controls.Add(this.BtnSaveImageToPDF);
            this.Controls.Add(this.textPathArquivoSaida);
            this.Controls.Add(this.btnDiretorioSaida);
            this.Controls.Add(this.textPathArquivo);
            this.Controls.Add(this.BtnSelecionarArquivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSelecionarArquivo;
        private System.Windows.Forms.TextBox textPathArquivo;
        private System.Windows.Forms.TextBox textPathArquivoSaida;
        private System.Windows.Forms.Button btnDiretorioSaida;
        private System.Windows.Forms.Button BtnSaveImageToPDF;
        private System.Windows.Forms.Button btnSelectCroppArea;
    }
}

