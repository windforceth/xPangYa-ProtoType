using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xPangPrototype
{
    public partial class frmMain : Form
    {
        int screenWidth = Screen.PrimaryScreen.Bounds.Width/2;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height/2;
        int posX = 0;
        int posY = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            posX = screenWidth - 262;
            posY = screenHeight + 313;
        }

        private void btnSpinCurve_Click(object sender, EventArgs e)
        {
            try
            {
                int spin = (!string.IsNullOrEmpty(txtSpin.Text)) ? Int32.Parse(txtSpin.Text) : 0;
                int curve = (!string.IsNullOrEmpty(txtCurve.Text)) ? Int32.Parse(txtCurve.Text) : 0;                
                Cursor.Position = new Point(posX + curve, posY + spin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flexTime_Tick(object sender, EventArgs e)
        {
            int spin = Math.Abs( Cursor.Position.Y - posY);
            int curve = Math.Abs(Cursor.Position.X - posX);
            int px = Math.Abs(31 - Math.Abs(Cursor.Position.X - posX));
            decimal pb = (decimal)Math.Round(Math.Abs((screenWidth - Cursor.Position.X) / 36.00), 2);
            
            lblPb.Text = string.Format("PB - {0}", pb.ToString("#.##"));
            lblSpin.Text = (spin < 31) ? string.Format("Spin - {0}", spin) : "Spin -";
            lblCurve.Text = (curve < 31) ? string.Format("Curve - {0}", curve) : "Curve -";
            lblPx.Text = (curve < 31 && px != 31) ? string.Format("PX - {0}", px) : "PX -";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int pb = PbMove(0);
            Cursor.Position = new Point(pb, screenHeight - 50);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int pb = PbMove(1);
            Cursor.Position = new Point(pb, screenHeight - 50);
        }

        public int PbMove(int a)
        {
            try
            {
                decimal pb = decimal.Parse(txtPB.Text, CultureInfo.InvariantCulture);
                if (a == 0)
                {
                    pb = pb * -1;
                }
                int pbMove = (int)(screenWidth + (pb * 36));                                               
                return pbMove;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
