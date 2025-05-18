using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Mech
{
    public partial class Form3 : Form, IViewF3
    {
        public double W1 { get; set; }//crank speed

        public double W2 { get; set; }//big wheel speed
        new public void Show()
        {
            this.ShowDialog();
        }

        public event EventHandler GetValues;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                try
                {
                    W1 = Convert.ToDouble(textBox1.Text);
                    W2 = Convert.ToDouble(textBox2.Text);
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                }
                if (GetValues != null)
                    GetValues(this, EventArgs.Empty);
            }
        }
    }
}
