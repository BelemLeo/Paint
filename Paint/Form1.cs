using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public enum Acciones
        {
            Lapiz,
            Pluma,
            Borrador,
            Circulo,
            Cuadrado,
            Linea,
            Brush,
            Relleno,
            Triangulo
        }
        public Acciones accionActiva;
        public Boolean isPainting;
        Graphics graficos;
        Pen lapizDibujo;
        Bitmap canvas;
        Point[] puntos;
        public int primerX, primerY, segundoX, segundoY;
        public int index;
        public Form1()
        {
            InitializeComponent();
            this.graficos = null;
            isPainting = false;
            puntos = new Point[0];
            this.canvas = new Bitmap(imgdibujo.Width, imgdibujo.Height);
            lblStatus.Text = "Esperando Accion...";
            lblCoordenada.Text = "X: NA , Y: NA";
            accionActiva = Acciones.Lapiz;


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgdibujo_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordenada.Text = "X:" + e.X.ToString() + ", Y:" + e.Y.ToString();

            imgdibujo.Image = (Image)canvas;
            graficos = Graphics.FromImage(canvas);

            lapizDibujo = new Pen(btnColor.BackColor, (float)nudGrosor.Value);

            switch (accionActiva)
            {
                case Acciones.Lapiz:
                    if (isPainting)
                    {
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            graficos.DrawLines(lapizDibujo, puntos);
                        }
                    }

                    break;
                case Acciones.Pluma:
                    break;
                case Acciones.Borrador:
                    Pen borrador = new Pen(imgdibujo.BackColor, (float)nudGrosor.Value);
                    if (isPainting)
                    {
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            graficos.DrawLines(borrador, puntos);
                        }
                    }
                    break;
                case Acciones.Circulo:
                    break;
                case Acciones.Cuadrado:
                    break;
                case Acciones.Linea:
                    break;
                case Acciones.Brush:
                    break;
                case Acciones.Triangulo:
                    break;
                case Acciones.Relleno:

                    break;
            }
        }
        public void AgregarPuntos(Point nuevoPunto)
        {
            Point[] temp = new Point[puntos.Length + 1];
            puntos.CopyTo(temp, 0);
            puntos = temp;
            puntos[puntos.Length - 1] = nuevoPunto;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void imgdibujo_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
            lblStatus.Text = "Pintando...";
            primerX = e.X;
            primerY = e.Y;
        }

        private void imgdibujo_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;
            lblStatus.Text = "Esperando Accion...";
            puntos = new Point[0];
            segundoX = e.X;
            segundoY = e.Y;


            imgdibujo.Image = (Image)canvas;
            graficos = Graphics.FromImage(canvas);

            lapizDibujo = new Pen(btnColor.BackColor, (float)nudGrosor.Value);

            switch (accionActiva)
            {
                case Acciones.Circulo:
                    graficos.DrawEllipse(lapizDibujo,
                        primerX,
                        primerY,
                        segundoX - primerX,
                        segundoY - primerY);
                    break;
                case Acciones.Cuadrado:
                    graficos.DrawRectangle(lapizDibujo,
                        primerX,
                        primerY,
                        segundoX - primerX,
                        segundoY - primerY);
                    break;
                case Acciones.Linea:
                    if (cbxDots.Checked)
                    {
                        lapizDibujo.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                        lapizDibujo.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                    }
                    graficos.DrawLine(lapizDibujo, new Point(primerX, primerY),
                        new Point(segundoX, segundoY));
                    break;
                case Acciones.Brush:
                    break;
                case Acciones.Triangulo:
                    Point point1 = new Point(primerX, primerY);
                    Point point2 = new Point(segundoX, segundoY);
                    Point point3 = new Point((primerX - (segundoX - primerX)), segundoY);
                    Point[] triangulo =
                                 {
                         point1,
                         point2,
                         point3,
                             };
                    graficos.DrawPolygon(lapizDibujo, triangulo);
                    break;
                case Acciones.Relleno:
                    Color color = canvas.GetPixel(primerX, primerY);
                    Stack<Point> pixel = new Stack<Point>();
                    pixel.Push(new Point(primerX, primerY));
                    canvas.SetPixel(primerX, primerY, btnColor.BackColor);
                    if (color == btnColor.BackColor) return;

                    while (pixel.Count > 0)
                    {
                        Point puntos = (Point)pixel.Pop();
                        if (puntos.X > 0 && puntos.Y > 0 && puntos.X < canvas.Width - 1 && puntos.Y < canvas.Height - 1)
                        {
                            validate(canvas, pixel, puntos.X - 1, puntos.Y, color, btnColor.BackColor);
                            validate(canvas, pixel, puntos.X, puntos.Y - 1, color, btnColor.BackColor);
                            validate(canvas, pixel, puntos.X + 1, puntos.Y, color, btnColor.BackColor);
                            validate(canvas, pixel, puntos.X, puntos.Y + 1, color, btnColor.BackColor);
                        }

                    }

                    break;
            }
        }

        private void btnlapiz_Click(object sender, EventArgs e)
        {
            accionActiva = Acciones.Lapiz;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imgColores_Click(object sender, EventArgs e)
        {
            if (cdgColores.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = cdgColores.Color;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graficos.Clear(Color.White);
            puntos = new Point[0];
            isPainting = false;
            canvas = new Bitmap(imgdibujo.Width, imgdibujo.Height);
            lblStatus.Text = "Esperando Accion...";
            lblCoordenada.Text = "X:NA, Y:NA";
            accionActiva = Acciones.Lapiz;
            imgdibujo.Image = null;
        }

        private void btnlinea_Click(object sender, EventArgs e)
        {
            accionActiva = Acciones.Linea;

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardarComo.Filter = "Archivo Imagen (*.jpeg, *.bmp) | (*.jpeg, *.bmp)";

        }

        private void btnhexagono_Click(object sender, EventArgs e)
        {

        }

        private void btnborrador_Click(object sender, EventArgs e)
        {
            accionActiva = Acciones.Borrador;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            accionActiva = Acciones.Triangulo;
        }

        private void btncirculo_Click(object sender, EventArgs e)
        {
            accionActiva = Acciones.Circulo;
        }



        private void btncuadro_Click(object sender, EventArgs e)
        {
            accionActiva = Acciones.Cuadrado;
        }
        static Point set_Point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            accionActiva = Acciones.Relleno;
        }

        private void validate(Bitmap canvas, Stack<Point> sp, int x, int y, Color color, Color new_color)
        {
            Color cx = canvas.GetPixel(x, y);
            if (cx == color)
            {
                sp.Push(new Point(x, y));
                canvas.SetPixel(x, y, new_color);
            }
        }
        //public void Fill(object sender, EventArgs e)
        //{
        //    Color color = bm.GetPixel(x, y);
        //    Stack<Point> pixel = new Stack<Point>();
        //    pixel.Push(new Point(x, y));
        //    bm.SetPixel(x, y, new_color);
        //    if (color == new_color) return;

        //    while (pixel.Count > 0)
        //    {
        //        Point puntos = (Point)pixel.Pop();
        //        if (puntos.X > 0 && puntos.Y > 0 && puntos.X < bm.Width - 1 && puntos.Y < bm.Height - 1)
        //        {
        //            validate(bm, pixel, puntos.X - 1, puntos.Y, color, new_color);
        //            validate(bm, pixel, puntos.X, puntos.Y - 1, color, new_color);
        //            validate(bm, pixel, puntos.X + 1, puntos.Y, color, new_color);
        //            validate(bm, pixel, puntos.X, puntos.Y + 1, color, new_color);
        //        }

        //    }

        //}
        //private void imgdibujo_Click(object sender, MouseEventArgs e)
        //{
        //    if (index == 7)
        //    {
        //        Point puntos = set_Point(imgdibujo, e.Location);
        //       Acciones.Relleno(canvas, puntos.X, puntos.Y, btnColor.BackColor);

            }
        }

//    }

//}
