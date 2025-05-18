using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Mech
{
    public interface IViewF3
    {
        double W1 { get; set; }

        double W2 { get; set; }

        void Show();

        event EventHandler GetValues;
    }
}
