using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKiemTraThe_Click(object sender, EventArgs e)
        {
            _SYSTEM.frmKiemTraThe fKiemtraThe = new _SYSTEM.frmKiemTraThe();
            fKiemtraThe.Show();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            _SYSTEM.frmXemThongTin fXemtt = new _SYSTEM.frmXemThongTin();
            fXemtt.Show();
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
            //picResult.Image = result;
        }

        private void btnQLThongTin_Click(object sender, EventArgs e)
        {
            _QUANLY.frmQuanLyThongTin fqltt = new _QUANLY.frmQuanLyThongTin();
            fqltt.Show();
        }

        private void btnInThe_Click(object sender, EventArgs e)
        {
            _SYSTEM.frmInThe finthe = new _SYSTEM.frmInThe();
            finthe.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
