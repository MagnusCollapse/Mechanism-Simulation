using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Mech
{
    public class PresenterF2
    {
        private Model _model;
        private IViewF2 _viewF2;

        public PresenterF2(IViewF2 v, Model m)
        {
            _model = m;
            _viewF2 = v;
            v.r1 = _model.r1;
            v.R1 = _model.R1;

            v.GetValues += new EventHandler(OnGetValues);
            v.GetChangedValues += new EventHandler(OnGetNewValues);
        }
        public void OnGetValues(Object sender, EventArgs e)
        {
            _viewF2.r1 = _model.r1;
            _viewF2.R1 = _model.R1;
        }
        public void OnGetNewValues(Object sender, EventArgs e)
        {
            _model.r1 = _viewF2.r1;
            _model.R1 = _viewF2.R1;
        }
        public void OnGetAForm2(Object sender, EventArgs e)
        {
            _viewF2.Show();
        }
    }
}
