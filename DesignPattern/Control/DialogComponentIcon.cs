using System.Windows.Forms;
using System.Drawing;

namespace AVIDefectImageReview.Controls
{
    class DialogComponentIcon : DialogDecorator
    {
        private Image _image;

        public DialogComponentIcon(DialogComponent component) : base(component)
        {
            
        }

        public override void addComponent(Panel panel)
        {
            
            PictureBox icon = new PictureBox();
            icon.Image = _image;
            panel.Controls.Add(icon);            
        }

        public void setImage(Image image)
        {
            this._image = image;
        }
    }
}
