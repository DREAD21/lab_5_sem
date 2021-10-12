
using System.Windows.Forms;

namespace lab2
{
    partial class Параллелепипед
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openglControl1 = new SharpGL.OpenGLControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openglControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // openglControl1
            // 
            this.openglControl1.BackColor = System.Drawing.SystemColors.Control;
            this.openglControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openglControl1.DrawFPS = true;
            this.openglControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openglControl1.Location = new System.Drawing.Point(0, 0);
            this.openglControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openglControl1.Name = "openglControl1";
            this.openglControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openglControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openglControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openglControl1.Size = new System.Drawing.Size(976, 450);
            this.openglControl1.TabIndex = 0;
            this.openglControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openglControl1.Load += new System.EventHandler(this.openglControl1_Load);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(901, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вправо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(697, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Влево";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 120;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(800, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Вверх";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.Location = new System.Drawing.Point(800, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Вниз";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 120;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 120;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 120;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.Location = new System.Drawing.Point(800, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "стоп";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.Location = new System.Drawing.Point(901, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Отдалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button9.Location = new System.Drawing.Point(697, 278);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Приблизить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Параллелепипед
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openglControl1);
            this.Name = "Параллелепипед";
            this.Text = "Параллелепипед";
            ((System.ComponentModel.ISupportInitialize)(this.openglControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openglControl1;
        private System.Windows.Forms.Button button1;
        private Button button2;
        private Timer timer1;
        private Button button3;
        private Button button4;
        private Timer timer2;
        private Timer timer3;
        private Timer timer4;
        private Button button5;
        private Button button8;
        private Button button9;
    }
}

