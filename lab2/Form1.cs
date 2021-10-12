using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

namespace lab2
{

    public partial class Параллелепипед : Form
    {

        float rotation = 0.0f;
        float rotationx = 0;
        float rotationy = 0;
        float xcc = 1.5f;
        float y = 0.0f;
        float x = 0.0f;
        float z = 0.0f;
        float yc =- 1.0f;
        float xc = 7;
        bool right;
        bool left;
        //bool up;
        //bool down;
        public Параллелепипед()
        {
            InitializeComponent();
        }
        //public void OpenglControl1_Resized(object sender, EventArgs e)
        //{
        //    OpenGL gl = openglControl1.OpenGL;
        //    gl.MatrixMode(OpenGL.GL_PROJECTION);
        //    gl.LoadIdentity();
        //    gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);
        //    if (left == false)
        //    {
        //        gl.LookAt(7, 1, 0,  // (x,y,z)
        //                 1, 0, 0,  // (направление)
        //                 0, 1, 0); // (верх камеры)
        //    }
        //    else
        //    {
        //        gl.LookAt(xc, 1, 0,  // (x,y,z)
        //              1, 0, 0,  // (направление)
        //              0, 1, 0); // (верх камеры)
        //    }

        //    gl.MatrixMode(OpenGL.GL_MODELVIEW);
        //}
        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openglControl1.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);
            if (left == false)
            {
                gl.LookAt(7, 1, 0,  // (x,y,z)
                         1, 0, 0,  // (направление)
                         0, 1, 0); // (верх камеры)
            }
            else
            {
                gl.LookAt(xc, 1, 0,  // (x,y,z)
                      1, 0, 0,  // (направление)
                      0, 1, 0); // (верх камеры)
            }

            gl.MatrixMode(OpenGL.GL_MODELVIEW);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.ClearColor(1.0f, 1.0f, 1.0f, 0.0f);

            //  Указываем оси вращения (x, y, z)
            gl.Rotate(rotation, x, y, z);

            gl.PolygonMode(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_FILL);
            


            gl.LineWidth(2);
            gl.Color(0.0f, 0.0f, 0.0f);
            gl.Begin(OpenGL.GL_POLYGON);

            gl.Vertex(0f, 0f, -1f);
            gl.Vertex(0f, 0f, 1f);

            gl.Vertex(0f, 1.5f, 1f);
            gl.Vertex(0f, 1.5f, -1f);

            gl.End();
            //Передняя грань

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(2f, 0f, -1f);
            gl.Vertex(2f, 0f, 1f);

            gl.Vertex(2f, 1.5f, 1f);
            gl.Vertex(2f, 1.5f, -1f);

            gl.End();
            // Левая грань

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(2f, 0f, 1f);
            gl.Vertex(0f, 0f, 1f);

            gl.Vertex(0f, 1.5f, 1f);
            gl.Vertex(2f, 1.5f, 1f);

            gl.End();
            //Правая грань


            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(2f, 0f, -1f);
            gl.Vertex(0f, 0f, -1f);

            gl.Vertex(0f, 1.5f, -1f);
            gl.Vertex(2f, 1.5f, -1f);

            gl.End();
            //нижняя часть


            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(0f, 0f, -1f);
            gl.Vertex(0f, 0f, 1f);

            gl.Vertex(2f, 0f, 1f);
            gl.Vertex(2f, 0f, -1f);
            gl.End();
            //верхняя часть


            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(0f, 1.5f, -1f);
            gl.Vertex(0f, 1.5f, 1f);

            gl.Vertex(2f, 1.5f, 1f);
            gl.Vertex(2f, 1.5f, -1f);
            gl.End();

            gl.LineWidth(3);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(0f, 0f, -1f);
            gl.Vertex(0f, 0f, 1f);
            gl.End();

            gl.LineWidth(3);
            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(0f, 1.5f, -1f);
            gl.Vertex(0f, 1.5f, 1f);

            gl.End();
            gl.LineWidth(3);

            gl.Begin(OpenGL.GL_LINES);
 
            gl.Vertex(2f, 1.5f, -1f);
            gl.Vertex(2f, 1.5f, 1f);
            gl.End();

            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(2f, 0f, -1f);
            gl.Vertex(2f, 0f, 1f);
            gl.End();

            gl.Begin(OpenGL.GL_LINES);
   
            gl.Vertex(2f, 1.5f, 1f);
            gl.Vertex(0f, 1.5f, 1f);

            gl.Vertex(2f, 0f, 1f);
            gl.Vertex(0f, 0f, 1f);
            gl.End();

            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(2f, 1.5f, -1f);
            gl.Vertex(0f, 1.5f, -1f);

            gl.Vertex(2f, 0f, -1f);
            gl.Vertex(0f, 0f, -1f);

            gl.End();

            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(0f, 0f, 1f);
            gl.Vertex(0f, 1.5f, 1f);

            gl.Vertex(0f, 0f, -1f);
            gl.Vertex(0f, 1.5f, -1f);

            gl.End();

            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(2f, 0f, 1f);
            gl.Vertex(2f, 1.5f, 1f);

            gl.Vertex(2f, 0f, -1f);
            gl.Vertex(2f, 1.5f, -1f);

            gl.End();

            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(0f, 0f, -1f);
            gl.Vertex(0f, 1.5f, -1f);

            gl.Vertex(0f, 0f, -1f);
            gl.Vertex(0f, 1.5f, -1f);

            gl.End();

            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(2f, 0f, -1f);
            gl.Vertex(2f, 1.5f, -1f);

            gl.Vertex(2f, 0f, -1f);
            gl.Vertex(2f, 1.5f, -1f);

            gl.End();
        }


        private void openglControl1_Load(object sender, EventArgs e)
        {

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
        private void timer1_Tick(object sender, EventArgs e)
        {

            OpenGL gl = new OpenGL();
            rotation = -1.5f;
            rotationx += 1.5f;
            if (rotationx > 180)
            {
                rotationx = 0;
            }
            if (rotationx < 0)
            {
                rotationx = 180;
            }

          
            y = -1.0f;
            x = 0.0f;
            z = 0.0f;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            OpenGL gl = new OpenGL();
            rotation = 1.5f;
            rotationx -= 1.5f;


            if (rotationx > 180)
            {
                rotationx = 0;
            }
            if (rotationx < 0)
            {
                rotationx = 180;
            }
            y = -1.0f;
            x = 0.0f;
            z = 0.0f;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            OpenGL gl = new OpenGL();
            rotationy += 1.5f;
            rotation = 1.5f;
            y = 0.0f;
            z = 1.0f;
            x = 0.0f;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            OpenGL gl = new OpenGL();
            rotation = -1.5f;
            rotationy -= 1.5f;
            y = 0.0f;
            z = 1.0f;
            x = 0.0f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenGL gl = openglControl1.OpenGL;
            //gl.Enable(OpenGL.GL_CULL_FACE);
            //gl.CullFace(OpenGL.GL_FRONT);
            rotation = 0;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            right = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            right = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            left = true;
            xc += 1.5f;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            left = true;
            xc -= 1.5f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openglControl2_Load(object sender, EventArgs e)
        {

        }
    }
}