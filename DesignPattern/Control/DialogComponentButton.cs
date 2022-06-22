using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVIDefectImageReview.Controls
{
    class DialogComponentButton : DialogDecorator
    {
        public DialogComponentButton(DialogComponent component) : base(component)
        {
            
        }

        public override void addComponent(Panel panel)
        {
            Button button = new Button();
            button.Text = "OK";
            panel.Controls.Add(button);            
        }
    }
}
