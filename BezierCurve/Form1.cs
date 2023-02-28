using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace Musa_Berk_ISKAL_1200505026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void koordinat_Click(object sender, MouseEventArgs e)
        {
            System.Drawing.Graphics grafiknesne;
            grafiknesne = this.CreateGraphics();
            Pen firca = new Pen(System.Drawing.Color.Green, 3);
            //X Düzlemi
            grafiknesne.DrawLine(firca, 0, 250, 800, 250);
            //Y Düzlemi
            grafiknesne.DrawLine(firca, 400, 0, 400, 500);

            Brush firca1= new SolidBrush(System.Drawing.Color.Red);
            Font yazis = new System.Drawing.Font("Helvetica", 8);
            //System.Drawing.Graphics elips;
            //elips = this.CreateGraphics();
        }

        private void bezier_Click(object sender, MouseEventArgs e)
        {
            //BezierEğrisi3
            System.Drawing.Graphics Graphics;
            Graphics = this.CreateGraphics();
            PointF p0 = new PointF(400, 250);
            PointF p1 = new PointF(475, 55);
            PointF p2 = new PointF(675, 185);
            PointF p3 = new PointF(640, 250);

            Pen bezier = new Pen(System.Drawing.Color.Black, 2);
          

            //BezierEğrisi2
            Point[] p = {
            new Point(10, 100),   
            new Point(75, 10),    
            new Point(80, 50),    
            new Point(100, 150),  
            new Point(125, 80),   
            new Point(175, 200), 
            new Point(200, 80)}; 

            Pen pen = new Pen(Color.Blue);
            Graphics.DrawBezier(bezier, p0, p1, p2, p3);
            //


        }

        private void noktalar_Click(object sender, EventArgs e)
        {
            Pen firca = new Pen(System.Drawing.Color.Red, 3);
            System.Drawing.Graphics elips;
            elips = this.CreateGraphics();

            //Elips
            //Kontrol Noktası0
            Pen p0 = new Pen(System.Drawing.Color.Red, 3);
            elips.DrawEllipse(firca, 390, 240, 20, 20);
            //Kontrol Noktası1
            Pen p1 = new Pen(System.Drawing.Color.Red, 3);
            elips.DrawEllipse(firca, 470, 60, 20, 20);
            //Kontrol Noktası2
            Pen p2 = new Pen(System.Drawing.Color.Red, 3);
            elips.DrawEllipse(firca, 670, 180, 20, 20);
            //Kontrol Noktası3
            Pen p3 = new Pen(System.Drawing.Color.Red, 3);
            elips.DrawEllipse(firca, 630, 240, 20, 20);


            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //BezierEğrisi3
            Point p1 = new Point(10, 100);   
            Point c1 = new Point(100, 10);   
            Point c2 = new Point(150, 150);  
            Point p2 = new Point(200, 100);  

            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255));
            
        }

       
    }
}
