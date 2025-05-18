using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Mech
{
    public partial class Form1 : Form, IViewF1
    {
       

        public double W1 { get; set; }
        public int r1 { get; set; }
        public int R1 { get; set; }
        public double W2 { get; set; }

        public Point Center { get; set; }
        public double t { get; set; } = 0;
        public Graphics g { get; set; } = null;
        public bool check { get; set; } = false;

        public bool newLines { get; set; } = true;
        public bool stopDraw { get; set; } = false;
        public bool a { get; set; } = false;
        public bool b { get; set; } = false;

        public void Run()
        {
            Form1_Load(this, EventArgs.Empty);
            Application.Run(this);
        }

        public event EventHandler GetValues;
        public event EventHandler GetPicture;
        public event EventHandler GetTrajectory;
        public event EventHandler CallForm2;
        public event EventHandler CallForm3;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (GetValues != null)
                GetValues(this, EventArgs.Empty);
            pictureBox1.Location = new Point(0, menuStrip1.ClientSize.Height);
            pictureBox1.Width = this.ClientSize.Width;
            pictureBox1.Height = this.ClientSize.Height - panel1.Height - menuStrip1.ClientSize.Height;
            Center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2 );
            g = pictureBox1.CreateGraphics();
            label1.Text = "Angular speed of the crank= " + Convert.ToString(W1);
            label4.Text = "Angluar speed of the big wheel= " + Convert.ToString(W2);
            label2.Text = "Small wheel radius= " + Convert.ToString(r1);
            label3.Text = "Big wheel radius= " + Convert.ToString(R1);

            timer1.Interval = 10;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Dispose();
            Close();
        }


        private void нарисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = 0;
            check = true;
            if (GetPicture != null)
                GetPicture(this, EventArgs.Empty);
            стеретьToolStripMenuItem.Enabled = true;
            начатьToolStripMenuItem.Enabled = true;
            нарисоватьToolStripMenuItem.Enabled = false;
            check = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            check = false;
            if (GetPicture != null)
                GetPicture(this, EventArgs.Empty);
            t = t + 0.1;
            check = true;
            if (GetPicture != null)
                GetPicture(this, EventArgs.Empty);

            newLines = false;
            if (GetTrajectory != null)
                GetTrajectory(this, EventArgs.Empty);

            if (stopDraw == true) остановитьToolStripMenuItem_Click(this, e);
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            нарисоватьToolStripMenuItem.Enabled = false;

            геометрическиеToolStripMenuItem.Enabled = false;
            кинематическиеToolStripMenuItem.Enabled = false;
            начатьToolStripMenuItem.Enabled = false;
            остановитьToolStripMenuItem.Enabled = true;
            стеретьToolStripMenuItem.Enabled = false;
            Cleaning();
            check = true;

            timer1.Enabled = true;
            if (GetPicture != null)
                GetPicture(this, EventArgs.Empty);

            if (GetTrajectory != null)
                GetTrajectory(this, EventArgs.Empty);

            if (stopDraw == true) остановитьToolStripMenuItem_Click(this, e);
        }
        private void Cleaning()
        {
            SolidBrush SBr = new SolidBrush(Color.White);
            g.FillRectangle(SBr, 0, 0, pictureBox1.ClientRectangle.Width, pictureBox1.ClientRectangle.Height);
            SBr.Dispose();
            check = false;
        }

        private void остановитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            стеретьToolStripMenuItem.Enabled = true;
            геометрическиеToolStripMenuItem.Enabled = true;
            кинематическиеToolStripMenuItem.Enabled = true;
            остановитьToolStripMenuItem.Enabled = false;
            начатьToolStripMenuItem.Enabled = true;
            timer1.Enabled = false;
        }

        private void точкаАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            точкаАToolStripMenuItem.Checked = !точкаАToolStripMenuItem.Checked;
            a = !a;
        }

        private void стеретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cleaning();
            newLines = true;
            stopDraw = false;
            нарисоватьToolStripMenuItem.Enabled = true;
            стеретьToolStripMenuItem.Enabled = false;
            начатьToolStripMenuItem.Enabled = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (check)
                if (GetPicture != null)
                    GetPicture(this, EventArgs.Empty);
        }

        private void геометрическиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CallForm2 != null)
                CallForm2(this, EventArgs.Empty);

            label2.Text = "Small wheel radius= " + Convert.ToString(r1);
            label3.Text = "Big wheel radius= " + Convert.ToString(R1);

            стеретьToolStripMenuItem_Click(sender, e);
            нарисоватьToolStripMenuItem_Click(sender, e);
        }

        private void точкаВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            точкаВToolStripMenuItem.Checked = !точкаВToolStripMenuItem.Checked;
            b = !b;
        }

        private void кинематическиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CallForm3 != null)
                CallForm3(this, EventArgs.Empty);

                timer1.Interval = 10;
            label1.Text = "Angular speed of the crank= " + Convert.ToString(W1);
            label4.Text = "Angluar speed of the big wheel= " + Convert.ToString(W2);

            стеретьToolStripMenuItem_Click(sender, e);
            нарисоватьToolStripMenuItem_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
