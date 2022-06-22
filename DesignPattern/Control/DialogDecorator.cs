using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVIDefectImageReview.Controls
{
    abstract class DialogDecorator : DialogComponent
    {
        protected DialogComponent _component;

        public DialogDecorator(DialogComponent component)
        {
            this._component = component;
        }

        public override void addComponent(Panel panel)
        {
            _component.addComponent(panel);
        }
    }
}
