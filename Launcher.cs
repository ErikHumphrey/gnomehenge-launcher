using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace gnomehenge_launcher
{
    public partial class frmGnomeHenge : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        
        public frmGnomeHenge()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        private void frmSkinhaven_Load(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(prgDownload, 3);
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
                SoundPlayer ready = new SoundPlayer(Properties.Resources.sfxBoom);
                ready.Play();
                lblStatusMessage.Text = "GnomeHenge is up-to-date.";
            }
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("ayy lmao");
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = System.Drawing.Color.White;
        }

        private void lblClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void lblLink1_MouseLeave(object sender, EventArgs e)
        {
            lblLink1.BackColor = Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
        }

        private void lblLink2_MouseLeave(object sender, EventArgs e)
        {
            lblLink2.BackColor = Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
        }

        private void lblLink3_MouseLeave(object sender, EventArgs e)
        {
            lblLink3.BackColor = Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
        }

        private void lblLink1_MouseEnter(object sender, EventArgs e)
        {
            lblLink1.BackColor = Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(41)))), ((int)(((byte)(33)))));
        }

        private void lblLink2_MouseEnter(object sender, EventArgs e)
        {
            lblLink2.BackColor = Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(41)))), ((int)(((byte)(33)))));
        }

        private void lblLink3_MouseEnter(object sender, EventArgs e)
        {
            lblLink3.BackColor = Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(41)))), ((int)(((byte)(33)))));
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
