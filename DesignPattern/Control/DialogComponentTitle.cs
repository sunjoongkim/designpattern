using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVIDefectImageReview.Controls
{
    class DialogComponentTitle : DialogDecorator
    {
        public DialogComponentTitle(DialogComponent component) : base(component)
        {
            
        }

        public override void addComponent(Panel panel)
        {
            Label label = new Label();
            label.Text = "Title area";
            panel.Controls.Add(label);            
        }
    }
}
