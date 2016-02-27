using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace gnomehenge_launcher
{
    public partial class frmGnomeHenge : Form
    {

        public frmGnomeHenge()
        {
            InitializeComponent();
        }



        public System.Drawing.Image x(int circleUpperLeftX, int circleUpperLeftY, int circleDiameter)
        {
            Bitmap SourceImage = new Bitmap(Properties.Resources.imgGnomeWinter);
            Rectangle CropRect = new Rectangle(circleUpperLeftX, circleUpperLeftY, circleDiameter, circleDiameter);
            Bitmap CroppedImage = SourceImage.Clone(CropRect, SourceImage.PixelFormat);
            TextureBrush TB = new TextureBrush(CroppedImage);
            Bitmap FinalImage = new Bitmap(circleDiameter, circleDiameter);
            Graphics G = Graphics.FromImage(FinalImage);
            G.FillEllipse(TB, 0, 0, circleDiameter, circleDiameter);
            return FinalImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmSkinhaven_Load(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(97)))), ((int)(((byte)(59)))));
            tmrDownload.Start();
            picAnnouncer.Image = x(0, 0, 184);
        }

        private void tmrSkinTimer_Tick(object sender, EventArgs e)
        {
            prgDownload.Value++;
            // label17.Text = prgDownload.Value.ToString();
            if (prgDownload.Value > 599)
                lblTimeRemaining.Text = "00:" + prgDownload.Value / 60 + "." + ((prgDownload.Value % 60) >= 10 ? (prgDownload.Value % 60).ToString() : "0" + prgDownload.Value % 60);
            else
                lblTimeRemaining.Text = "00:0" + prgDownload.Value / 60 + "." + ((prgDownload.Value % 60) >= 10 ? (prgDownload.Value % 60).ToString() : "0" + prgDownload.Value % 60);

            if (prgDownload.Value < 999 && prgDownload.Value > 149)
            {
                ModifyProgressBarColor.SetState(prgDownload, 3);
            }
            else if (prgDownload.Value < 150 && prgDownload.Value > 0)
            {
                ModifyProgressBarColor.SetState(prgDownload, 2);
            }
            else
            {
              //  ModifyProgressBarColor.SetState(prgDownload, 1);
            }

            if (prgDownload.Value == 1000)
            {
                ModifyProgressBarColor.SetState(prgDownload, 1);
                tmrDownload.Stop();
                btnPlay.Enabled = true;
                btnPlay.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
                lblStatusMessage.Text = "GnomeHenge is up-to-date.";
            }
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("ayy lmao");
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
