using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocVien._SYSTEM
{
    public partial class frmInThe : Form
    {
        public frmInThe()
        {
            InitializeComponent();
        }


        void ControlToBitmap(Control ctrol)
        {
            Size ctrlSize = ctrol.Size;
            Rectangle rect = new Rectangle(new Point(0, 0), ctrlSize);
            Bitmap bitmap = new Bitmap(ctrlSize.Width, ctrlSize.Height);
            ctrol.DrawToBitmap(bitmap, rect);
            Bitmap result = new Bitmap(ctrlSize.Width, ctrlSize.Height);
            Graphics g = Graphics.FromImage(result);
            rect.Size = ctrlSize;
            g.DrawImage(bitmap, rect);
            picResult.Image = result;
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
            picResult.Image.Save("D://test_image.png",format);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlToBitmap(panel1);
        }
    }
}
