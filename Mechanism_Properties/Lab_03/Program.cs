using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Mech
{
    static class Program
    {
        /// <summary>
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            Model m = new Model();
            PresenterF1 p1 = new PresenterF1(f1, m);
            PresenterF2 p2 = new PresenterF2(f2, m);
            PresenterF3 p3 = new PresenterF3(f3, m);
            p1.GetForm2 += p2.OnGetAForm2;
            p1.GetForm3 += p3.OnGetAForm3;
            p1.Run();
        }
    }
}
