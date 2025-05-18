using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Mech
{
    public interface IViewF2
    {
        int r1 { get; set; }
        int R1 { get; set; }

        void Show();

        event EventHandler GetValues;
        event EventHandler GetChangedValues;
    }
}
