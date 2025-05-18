using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Mech
{
    public class PresenterF3
    {
        private Model _model;
        private IViewF3 _viewF3;

        public PresenterF3(IViewF3 v, Model m)
        {
            _model = m;
            _viewF3 = v;
            _viewF3.W1 = _model.W1;
            _viewF3.W2 = _model.W2;

            v.GetValues += new EventHandler(OnGetNewValues);
        }
        public void OnGetNewValues(Object sender, EventArgs e)
        {
            _model.W1 = _viewF3.W1;
            _model.W2 = _viewF3.W2;
        }
        public void OnGetAForm3(Object sender, EventArgs e)
        {
            _viewF3.Show();
        }
    }
}
