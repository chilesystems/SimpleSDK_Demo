using System.Windows.Forms;
using System.Drawing;

namespace SimpleSDK_Demo
{
    public class Loading
    {
        public static void ShowLoading(Control control)
        {
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));

            var pic = new PictureBox();
            pic.Name = "loaderPictureBox";
            //pic.Image = ((System.Drawing.Image)(resources.GetObject("loader_16x16.gif")));
            pic.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("loader_16x16");
            //pic.Image = Image.FromFile("Resources/loader_16x16.gif");
            pic.Parent = control.Parent;
            pic.Size = control.Size;
            pic.Location = control.Location;
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
            pic.BackColor = Color.Transparent;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Enabled = true;
            pic.Visible = true;
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            control.Parent?.Controls.Add(pic);
            control.Enabled = false;
            pic.BringToFront();
        }

        public static void HideLoading(Control control)
        {
            control.Parent?.Controls.RemoveByKey("loaderPictureBox");
            control.Enabled = true;
        }
    }
}
