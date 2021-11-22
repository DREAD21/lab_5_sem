using SharpGL;
using SharpGL.SceneGraph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Краснов М80-303Б-19
//Вариант 13. Усеченный прямой круговой цилиндр
namespace lab3_4ern_2_
{
    public partial class Form1 : Form
    {
        public float perspective = 20.0f;
        public float rotation = 0.0f;
        public float xc = 0.0f;
        public float yc = 0;
        public float zc = 0;
        const float Pi = (float)(Math.PI * 2.0);
        public float angle = 0.0f;
        public float angle_stepsize = 0.1f;
        public float radius = 0.4f;
        public float height = 1.0f;
        public float x = 0.0f;
        public float y = 0.0f;
        public float light_step = 0.0f;
        public float height2 = 1.5f;
        public Form1()
        {
            InitializeComponent();
        }
        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openglControl1.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(perspective, (double)Width / (double)Height, 0.01, 100.0);
            gl.LookAt(0, -10, -5, 
                         0, 0, 1,  
                         0, 1, 0);        
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.Rotate(rotation, xc, yc, zc);
            gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_FILL);
            float[] pos1 = { light_step , 1f, 1f, 1f }; // 3 - весь
            gl.Enable(OpenGL.GL_COLOR_MATERIAL);
            gl.Enable(OpenGL.GL_DEPTH_TEST);
            gl.Enable(OpenGL.GL_LIGHTING);
            gl.Enable(OpenGL.GL_LIGHT0);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, pos1);
           
            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(1.0f, 1.0f, 0.0f, 0.0f);
            angle = 0.0f;
            height = 2.0f;
            while (angle < 2 * Pi)
            {
                x = (float)(radius * Math.Cos(angle));
                y = (float)(radius * Math.Sin(angle));
                gl.Vertex(x, y, height);
                gl.Vertex(x, y, 0.0f);
                angle = angle + angle_stepsize;
            }
            gl.End();
            gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_FILL);
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 1.0f, 0.0f, 0.0f);        
            angle = 0.0f;
            while (angle < Pi)
            {
                x = (float)(radius * Math.Cos(angle));
                y = (float)(radius * Math.Sin(-angle));
                gl.Vertex(x, y, height);
                angle = angle + angle_stepsize;
            }
            gl.Vertex(radius, 0.0f, height);
            gl.End();
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 1.0f, 0.0f, 0.0f);
            angle = 0.0f;
            while (angle < Pi)
            {
                x = (float)(radius * Math.Cos(angle));
                y = (float)(radius * Math.Sin(-angle));
                gl.Vertex(x, y, 0);
                angle = angle + angle_stepsize;
            }
            gl.Vertex(radius, 0.0f, height);
            gl.End();
        }
        private void openglControl1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = (int)10.0;
            trackBar1.Minimum = (int)1.0;
            trackBar1.TickFrequency = 1;
            radius = (trackBar1.Value / 10.0f);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Minimum = (int)1.0f;
            trackBar2.Maximum = (int)15.0f;
            trackBar2.TickFrequency = 1;
            angle_stepsize = (trackBar2.Value / 10.0f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer1.Enabled = true;
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Stop();
            timer3.Stop();
            timer4.Stop();
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer4.Stop();
            timer3.Enabled = true;
            timer3.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Enabled = true;
            timer4.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rotation = 0;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            OpenGL gl = new OpenGL();
            rotation = 6f;
            yc = 0.0f;
            xc = 0.0f;
            zc = -1.0f;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            rotation = -6f;
            yc = 0.0f;
            xc = 0.0f;
            zc = -1.0f;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            rotation = 1.5f;
            yc = 0.0f;
            xc = -1.0f;
            zc = 0.0f;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            rotation = -1.5f;
            yc = 0.0f;
            xc = -1.0f;
            zc = 0.0f;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            perspective -= 5.0f;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            perspective += 5.0f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll_1(object sender, EventArgs e)
        {
            trackBar3.Minimum = (int)0.0f;
            trackBar3.Maximum = (int)4.0f;
            trackBar3.TickFrequency = 1;
            light_step = trackBar3.Value;
        }
    }
}
