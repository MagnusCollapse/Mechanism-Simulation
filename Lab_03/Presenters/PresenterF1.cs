using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Mech
{
    public class PresenterF1
    {
        private Model _model;
        private IViewF1 _viewF0;

        public event EventHandler GetForm2;
        public event EventHandler GetForm3;

        public PresenterF1(IViewF1 v, Model m)
        {
            _model = m;
            _viewF0 = v;
            v.W1 = _model.W1;
            v.r1 = _model.r1;
            v.R1 = _model.R1;
            v.W2 = _model.W2;

            v.GetValues += new EventHandler(OnGetValues);
            v.GetPicture += new EventHandler(OnGetPicture);
            v.GetTrajectory += new EventHandler(OnGetTraek);
            v.CallForm2 += new EventHandler(OnCallForm2);
            v.CallForm3 += new EventHandler(OnCallForm3);
        }
        public void Run()
        {
            _viewF0.Run();
        }
        public void OnGetValues(Object sender, EventArgs e)
        {
            _viewF0.W1 = _model.W1;
            _viewF0.r1 = _model.r1;
            _viewF0.R1 = _model.R1;
            _viewF0.W2 = _model.W2;
        }
        public void OnGetPicture(Object sender, EventArgs e)
        {
            if(_model.Picture(_viewF0.check, _viewF0.g, _viewF0.Center, _viewF0.t))
            {
                _viewF0.stopDraw = true;
            }
        }
        public void OnGetTraek(Object sender, EventArgs e)
        {
            _model.Traek( _viewF0.g, _viewF0.Center, _viewF0.t, _viewF0.newLines, _viewF0.a, _viewF0.b);
        }
        public void OnCallForm2(Object sender, EventArgs e)
        {
            if (GetForm2 != null)
                GetForm2(this, EventArgs.Empty);
            _viewF0.r1 = _model.r1;
            _viewF0.R1 = _model.R1;
        }
        public void OnCallForm3(Object sender, EventArgs e)
        {
            if (GetForm3 != null)
                GetForm3(this, EventArgs.Empty);
            _viewF0.W1 = _model.W1;
            _viewF0.W2 = _model.W2;
        }
    }
}
