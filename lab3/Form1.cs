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
        public float radius = 0.3f;
        public float height = 1.0f;
        public float x = 0.0f;
        public float y = 0.0f;
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

            gl.LookAt(0, 8, 5,  // (x,y,z)
                         0, 0, 1,  // (направление)
                         0, 1, 0); // (верх камеры)        
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.ClearColor(1.0f, 1.0f, 1.0f, 0.0f);   
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            //gl.LoadIdentity();
            //gl.Translate(0.0, -0.4, -3.0);
            gl.Rotate(rotation, xc, yc, zc);
            gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK,OpenGL.GL_LINE);
            // tube
            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(0.1f, 0.1f, 0.1f);
            angle = 0.0f;
            height = 1.0f;
            while (angle <  Pi/2)
            {
                x = (float)(radius * Math.Cos(angle));
                y = (float)(radius * Math.Sin(angle));
                gl.Vertex(x, y, height);
                gl.Vertex(x, y, 0.0f);
                angle = angle + angle_stepsize;
            }
            gl.Vertex(radius, 0.0, height);
            gl.Vertex(radius, 0.0f, 0.0f);
            gl.End();
            //круг сверху цилиндра
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 0.0f, 0.0f, 0.0f);
            angle = 0.0f;
            while(angle < Pi/2)
            {
                x = (float)(radius * Math.Cos(angle));
                y = (float)(radius * Math.Sin(angle));
                gl.Vertex(x, y, height);
                angle = angle + angle_stepsize;
            }
            gl.Vertex(radius, 0.0f, height);
            gl.End();
            // кргу снизу цилиндра
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 0.0f, 0.0f, 0.0f);
            angle = 0.0f;
            height = 0.0f;
            while (angle < Pi/2)
            {
                x = (float)(radius * Math.Cos(angle));
                y = (float)(radius * Math.Sin(angle));
                gl.Vertex(x, y, height);
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
            textBox1.Text = radius.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Minimum = (int)1.0f;
            trackBar2.Maximum = (int)15.0f;
            trackBar2.TickFrequency = 1;
            angle_stepsize = (trackBar2.Value / 10.0f);
            textBox2.Text = angle_stepsize.ToString();
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
            rotation = 1.5f;
            yc = 0.0f;
            xc = 0.0f;
            zc = -1.0f;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            rotation = -1.5f;
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
    }
}
