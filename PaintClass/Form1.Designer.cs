
namespace PaintClass
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPintar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pBPapel = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnBAll = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTamanioPincel = new System.Windows.Forms.Label();
            this.btnElip = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnLin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(257, 7);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(75, 23);
            this.btnPintar.TabIndex = 0;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(163, 7);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pBPapel
            // 
            this.pBPapel.BackColor = System.Drawing.SystemColors.Control;
            this.pBPapel.Location = new System.Drawing.Point(73, 62);
            this.pBPapel.Name = "pBPapel";
            this.pBPapel.Size = new System.Drawing.Size(718, 377);
            this.pBPapel.TabIndex = 2;
            this.pBPapel.TabStop = false;
            this.pBPapel.Paint += new System.Windows.Forms.PaintEventHandler(this.pBPapel_Paint);
            this.pBPapel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBPapel_MouseDown);
            this.pBPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBPapel_MouseMove);
            this.pBPapel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBPapel_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(350, 7);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(441, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(73, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(19, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(19, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 32);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(19, 79);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(48, 20);
            this.txtR.TabIndex = 10;
            this.txtR.Text = "0";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(19, 105);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(48, 20);
            this.txtG.TabIndex = 11;
            this.txtG.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(19, 134);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(48, 20);
            this.txtB.TabIndex = 12;
            this.txtB.Text = "0";
            // 
            // btnBAll
            // 
            this.btnBAll.Location = new System.Drawing.Point(163, 36);
            this.btnBAll.Name = "btnBAll";
            this.btnBAll.Size = new System.Drawing.Size(75, 23);
            this.btnBAll.TabIndex = 13;
            this.btnBAll.Text = "Borrar All";
            this.btnBAll.UseVisualStyleBackColor = true;
            this.btnBAll.Click += new System.EventHandler(this.btnBAll_Click);
            // 
            // lblTamanioPincel
            // 
            this.lblTamanioPincel.AutoSize = true;
            this.lblTamanioPincel.Location = new System.Drawing.Point(432, 44);
            this.lblTamanioPincel.Name = "lblTamanioPincel";
            this.lblTamanioPincel.Size = new System.Drawing.Size(35, 13);
            this.lblTamanioPincel.TabIndex = 14;
            this.lblTamanioPincel.Text = "label4";
            // 
            // btnElip
            // 
            this.btnElip.Location = new System.Drawing.Point(0, 261);
            this.btnElip.Name = "btnElip";
            this.btnElip.Size = new System.Drawing.Size(76, 26);
            this.btnElip.TabIndex = 15;
            this.btnElip.Text = "Elipse";
            this.btnElip.UseVisualStyleBackColor = true;
            this.btnElip.Click += new System.EventHandler(this.btnElip_Click);
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(0, 293);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(76, 23);
            this.btnRec.TabIndex = 16;
            this.btnRec.Text = "Rectangulo";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnLin
            // 
            this.btnLin.Location = new System.Drawing.Point(0, 326);
            this.btnLin.Name = "btnLin";
            this.btnLin.Size = new System.Drawing.Size(76, 24);
            this.btnLin.TabIndex = 17;
            this.btnLin.Text = "Linea";
            this.btnLin.UseVisualStyleBackColor = true;
            this.btnLin.Click += new System.EventHandler(this.btnLin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLin);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.btnElip);
            this.Controls.Add(this.lblTamanioPincel);
            this.Controls.Add(this.btnBAll);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pBPapel);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnPintar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pBPapel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnBAll;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTamanioPincel;
        private System.Windows.Forms.Button btnElip;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnLin;
    }
}

