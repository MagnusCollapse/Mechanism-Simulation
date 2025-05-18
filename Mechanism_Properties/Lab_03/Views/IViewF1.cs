using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Mech
{
    public interface IViewF1
    {
        double W1 { get; set; }
        int r1 { get; set; }
        int R1 { get; set; }
        double W2 { get; set; }

        Point Center { get; set; }
        double t { get; set; }
        Graphics g { get; set; }
        bool check { get; set; }

        bool newLines { get; set; }
        bool stopDraw { get; set; }
        bool a { get; set; }
        bool b { get; set; }


        void Run();

        event EventHandler GetValues;
        event EventHandler GetPicture;
        event EventHandler GetTrajectory;
        event EventHandler CallForm2;
        event EventHandler CallForm3;
    }
}
