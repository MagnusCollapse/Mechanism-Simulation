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
    public partial class Form2 : Form, IViewF2
    {
        public int r1 { get; set; }
        public int R1 { get; set; }

        new public void Show()
        {
            this.ShowDialog();
        }

        public event EventHandler GetValues;
        public event EventHandler GetChangedValues;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                r1 = Convert.ToInt32(numericUpDown1.Value);
                R1 = Convert.ToInt32(numericUpDown2.Value);
                if (GetChangedValues != null)
                    GetChangedValues(this, EventArgs.Empty);
            }
            else
            {
                numericUpDown1.Value = r1;
                numericUpDown2.Value = R1;
            }
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            if (GetValues != null)
                GetValues(this, EventArgs.Empty);
            numericUpDown1.Value = r1;
            numericUpDown2.Value = R1;
        }
    }
}
