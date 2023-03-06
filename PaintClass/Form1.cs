using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintClass
{
    public partial class Form1 : Form
    {
        Graphics papel;
        Graphics foto;
        Bitmap surface;
        int x = 0;
        int y = 0;
        int sX, sY, cX, cY;
        int index;
        int R = 0;
        int G = 0;
        int B = 0;
        int tamanioPincel = 3;
        bool moviendo = false;
        Pen pen;
        bool pintar = false;
        bool borrar = false;
        public Form1()
        {
            InitializeComponent();
            papel = pBPapel.CreateGraphics();
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tamanioPincel = trackBar1.Value;
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            pen = new Pen(Color.FromArgb(R, G, B), tamanioPincel);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            surface = new Bitmap(pBPapel.Width,pBPapel.Height);
            foto = Graphics.FromImage(surface);
            
            pBPapel.BackgroundImage = surface;
            pBPapel.BackgroundImageLayout = ImageLayout.None;
            foto.Clear(Color.White);
        }
        //Evento que se dispara al hacer clic y sostenerlo
        private void pBPapel_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true;
            x = e.X;
            y = e.Y;
            cX = e.X;
            cY = e.Y;
            //Cambiamos cursor por una crus
            pBPapel.Cursor = Cursors.Cross;
        }
        //Eeento que ocurre cunado movemos nuestros cursor sobre el pictureBox
        private void pBPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo && pintar)
            {
                //Llamar funcion para cambiar las propiedades del pincel
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                //Dibujar una linea posicion actual hacia donde nos movemos
                papel.DrawLine(pen, new Point(x, y), e.Location);
                foto.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            if (moviendo && borrar)
            {
                cambiarPincel(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                foto.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }
        //Evento que se dispara al dejar de hacer clic 
        private void pBPapel_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
            sX = x - cX;
            sY = y - cY;
            if (index==3)
            {
                papel.DrawEllipse(pen,cX,cY,sX,sY);
                foto.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                papel.DrawRectangle(pen, cX, cY, sX, sY);
                foto.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                papel.DrawLine(pen, cX, cY, sX, sY);
                foto.DrawLine(pen, cX, cY, sX, sY);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }
        //PictureBox que muestra el colorDialog
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog() mostramos el colorDialog
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTamanioPincel.Text = trackBar1.Value.ToString();
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pintar = false;
            borrar = true;
        }

        private void btnElip_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLin_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pBPapel_Paint(object sender, PaintEventArgs e)
        {
            Graphics papel = e.Graphics;
            Graphics foto = e.Graphics;
            if (pintar)
            {
                if (index == 3)
                {
                    papel.DrawEllipse(pen, cX, cY, sX, sY);
                    foto.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    papel.DrawRectangle(pen, cX, cY, sX, sY);
                    foto.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    papel.DrawLine(pen, cX, cY, sX, sY);
                    foto.DrawLine(pen, cX, cY, sX, sY);
                }
            }
        }

        private void btnBAll_Click(object sender, EventArgs e)
        {
            papel.Clear(Color.White);
            foto.Clear(Color.White);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png File (*png) | *.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void cambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackBar1.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }   
    }
    //TODO: pasar las figuras a este programa
    /*PLUS: dibujar figuras con dos puntos
     * PLUSPLUS: dibujar figuras en tiempo real
     * TODO: boton para guardar el dibujo en el formato
     */
}
