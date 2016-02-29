namespace gnomehenge_launcher
{
    partial class frmGnomeHenge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.picOpenID = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLink1 = new System.Windows.Forms.Label();
            this.lblLink3 = new System.Windows.Forms.Label();
            this.lblLink2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Label();
            this.pnlAnnounceFront = new System.Windows.Forms.Panel();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.picAnnouncer = new System.Windows.Forms.PictureBox();
            this.pnlPatcher = new System.Windows.Forms.Panel();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.prgDownload = new System.Windows.Forms.ProgressBar();
            this.pnlTradables = new System.Windows.Forms.Panel();
            this.lblFeaturedTradables = new System.Windows.Forms.Label();
            this.pnlBox6 = new System.Windows.Forms.Panel();
            this.lblItem6 = new System.Windows.Forms.Label();
            this.picTradable6 = new System.Windows.Forms.PictureBox();
            this.pnlBox5 = new System.Windows.Forms.Panel();
            this.lblItem5 = new System.Windows.Forms.Label();
            this.picTradable5 = new System.Windows.Forms.PictureBox();
            this.pnlBox3 = new System.Windows.Forms.Panel();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.picTradable3 = new System.Windows.Forms.PictureBox();
            this.pnlBox4 = new System.Windows.Forms.Panel();
            this.lblItem4 = new System.Windows.Forms.Label();
            this.picTradable4 = new System.Windows.Forms.PictureBox();
            this.pnlBox2 = new System.Windows.Forms.Panel();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.picTradable2 = new System.Windows.Forms.PictureBox();
            this.pnlBox1 = new System.Windows.Forms.Panel();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.picTradable1 = new System.Windows.Forms.PictureBox();
            this.tmrDownload = new System.Windows.Forms.Timer(this.components);
            this.pnlBlog = new System.Windows.Forms.Panel();
            this.picBlogImage = new System.Windows.Forms.PictureBox();
            this.lblBlogHeader = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlAnnounceFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnnouncer)).BeginInit();
            this.pnlPatcher.SuspendLayout();
            this.pnlTradables.SuspendLayout();
            this.pnlBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable6)).BeginInit();
            this.pnlBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable5)).BeginInit();
            this.pnlBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable3)).BeginInit();
            this.pnlBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable4)).BeginInit();
            this.pnlBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable2)).BeginInit();
            this.pnlBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable1)).BeginInit();
            this.pnlBlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlogImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Controls.Add(this.picOpenID);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblLink1);
            this.pnlHeader.Controls.Add(this.lblLink3);
            this.pnlHeader.Controls.Add(this.lblLink2);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 57);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Hypatia Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(88)))), ((int)(((byte)(70)))));
            this.lblClose.Location = new System.Drawing.Point(924, 1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 21);
            this.lblClose.TabIndex = 8;
            this.lblClose.Text = "✖";
            this.lblClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblClose_MouseClick);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // picOpenID
            // 
            this.picOpenID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOpenID.Image = global::gnomehenge_launcher.Properties.Resources.imgSignInThroughSteam;
            this.picOpenID.Location = new System.Drawing.Point(763, 17);
            this.picOpenID.Name = "picOpenID";
            this.picOpenID.Size = new System.Drawing.Size(154, 23);
            this.picOpenID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOpenID.TabIndex = 2;
            this.picOpenID.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::gnomehenge_launcher.Properties.Resources.alpha;
            this.picLogo.Location = new System.Drawing.Point(19, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(221, 52);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picLogo_MouseMove);
            // 
            // lblLink1
            // 
            this.lblLink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
            this.lblLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLink1.Font = new System.Drawing.Font("Hypatia Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink1.ForeColor = System.Drawing.Color.White;
            this.lblLink1.Location = new System.Drawing.Point(392, 0);
            this.lblLink1.Name = "lblLink1";
            this.lblLink1.Size = new System.Drawing.Size(88, 57);
            this.lblLink1.TabIndex = 4;
            this.lblLink1.Text = "TWITTER";
            this.lblLink1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLink1.MouseEnter += new System.EventHandler(this.lblLink1_MouseEnter);
            this.lblLink1.MouseLeave += new System.EventHandler(this.lblLink1_MouseLeave);
            // 
            // lblLink3
            // 
            this.lblLink3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
            this.lblLink3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLink3.Font = new System.Drawing.Font("Hypatia Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink3.ForeColor = System.Drawing.Color.White;
            this.lblLink3.Location = new System.Drawing.Point(640, 0);
            this.lblLink3.Name = "lblLink3";
            this.lblLink3.Size = new System.Drawing.Size(103, 57);
            this.lblLink3.TabIndex = 6;
            this.lblLink3.Text = "SUBREDDIT";
            this.lblLink3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLink3.MouseEnter += new System.EventHandler(this.lblLink3_MouseEnter);
            this.lblLink3.MouseLeave += new System.EventHandler(this.lblLink3_MouseLeave);
            // 
            // lblLink2
            // 
            this.lblLink2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
            this.lblLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLink2.Font = new System.Drawing.Font("Hypatia Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink2.ForeColor = System.Drawing.Color.White;
            this.lblLink2.Location = new System.Drawing.Point(494, 0);
            this.lblLink2.Name = "lblLink2";
            this.lblLink2.Size = new System.Drawing.Size(134, 57);
            this.lblLink2.TabIndex = 5;
            this.lblLink2.Text = "STEAM GROUP";
            this.lblLink2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLink2.MouseEnter += new System.EventHandler(this.lblLink2_MouseEnter);
            this.lblLink2.MouseLeave += new System.EventHandler(this.lblLink2_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(97)))), ((int)(((byte)(59)))));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Hypatia Sans Pro", 17.25F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(822, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(122, 64);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAnnounceFront
            // 
            this.pnlAnnounceFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(174)))), ((int)(((byte)(37)))));
            this.pnlAnnounceFront.Controls.Add(this.lblAnnouncement);
            this.pnlAnnounceFront.Controls.Add(this.picAnnouncer);
            this.pnlAnnounceFront.Location = new System.Drawing.Point(28, 72);
            this.pnlAnnounceFront.Name = "pnlAnnounceFront";
            this.pnlAnnounceFront.Size = new System.Drawing.Size(896, 66);
            this.pnlAnnounceFront.TabIndex = 2;
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.Font = new System.Drawing.Font("Hypatia Sans Pro", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAnnouncement.ForeColor = System.Drawing.Color.White;
            this.lblAnnouncement.Location = new System.Drawing.Point(80, 8);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(737, 47);
            this.lblAnnouncement.TabIndex = 4;
            this.lblAnnouncement.Text = "GnomeHenge will be down for scheduled maintenance on Tuesday, Gnovember 2nd.";
            this.lblAnnouncement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picAnnouncer
            // 
            this.picAnnouncer.Image = global::gnomehenge_launcher.Properties.Resources.imgGnomeWinter;
            this.picAnnouncer.Location = new System.Drawing.Point(18, 3);
            this.picAnnouncer.Name = "picAnnouncer";
            this.picAnnouncer.Size = new System.Drawing.Size(51, 60);
            this.picAnnouncer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnnouncer.TabIndex = 3;
            this.picAnnouncer.TabStop = false;
            // 
            // pnlPatcher
            // 
            this.pnlPatcher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(23)))));
            this.pnlPatcher.Controls.Add(this.lblStatusMessage);
            this.pnlPatcher.Controls.Add(this.lblTimeRemaining);
            this.pnlPatcher.Controls.Add(this.btnPlay);
            this.pnlPatcher.Controls.Add(this.prgDownload);
            this.pnlPatcher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPatcher.Location = new System.Drawing.Point(0, 457);
            this.pnlPatcher.Name = "pnlPatcher";
            this.pnlPatcher.Size = new System.Drawing.Size(950, 74);
            this.pnlPatcher.TabIndex = 4;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Font = new System.Drawing.Font("Hypatia Sans Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusMessage.ForeColor = System.Drawing.Color.White;
            this.lblStatusMessage.Location = new System.Drawing.Point(42, 44);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(283, 21);
            this.lblStatusMessage.TabIndex = 9;
            this.lblStatusMessage.Text = "Downloading from remote server...";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.Font = new System.Drawing.Font("Hypatia Sans Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimeRemaining.ForeColor = System.Drawing.Color.White;
            this.lblTimeRemaining.Location = new System.Drawing.Point(471, 44);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(76, 21);
            this.lblTimeRemaining.TabIndex = 8;
            this.lblTimeRemaining.Text = "00:00:00";
            this.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prgDownload
            // 
            this.prgDownload.Location = new System.Drawing.Point(45, 18);
            this.prgDownload.MarqueeAnimationSpeed = 0;
            this.prgDownload.Maximum = 1000;
            this.prgDownload.Name = "prgDownload";
            this.prgDownload.Size = new System.Drawing.Size(497, 23);
            this.prgDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgDownload.TabIndex = 7;
            this.prgDownload.Value = 1;
            // 
            // pnlTradables
            // 
            this.pnlTradables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.pnlTradables.Controls.Add(this.lblFeaturedTradables);
            this.pnlTradables.Controls.Add(this.pnlBox6);
            this.pnlTradables.Controls.Add(this.pnlBox5);
            this.pnlTradables.Controls.Add(this.pnlBox3);
            this.pnlTradables.Controls.Add(this.pnlBox4);
            this.pnlTradables.Controls.Add(this.pnlBox2);
            this.pnlTradables.Controls.Add(this.pnlBox1);
            this.pnlTradables.Location = new System.Drawing.Point(547, 153);
            this.pnlTradables.Name = "pnlTradables";
            this.pnlTradables.Size = new System.Drawing.Size(377, 284);
            this.pnlTradables.TabIndex = 6;
            // 
            // lblFeaturedTradables
            // 
            this.lblFeaturedTradables.AutoSize = true;
            this.lblFeaturedTradables.Font = new System.Drawing.Font("HelveticaNeueLT Std Cn", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeaturedTradables.ForeColor = System.Drawing.Color.White;
            this.lblFeaturedTradables.Location = new System.Drawing.Point(7, 6);
            this.lblFeaturedTradables.Name = "lblFeaturedTradables";
            this.lblFeaturedTradables.Size = new System.Drawing.Size(259, 38);
            this.lblFeaturedTradables.TabIndex = 6;
            this.lblFeaturedTradables.Text = "Featured Tradables";
            // 
            // pnlBox6
            // 
            this.pnlBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(48)))), ((int)(((byte)(38)))));
            this.pnlBox6.Controls.Add(this.lblItem6);
            this.pnlBox6.Controls.Add(this.picTradable6);
            this.pnlBox6.Location = new System.Drawing.Point(251, 162);
            this.pnlBox6.Name = "pnlBox6";
            this.pnlBox6.Size = new System.Drawing.Size(114, 110);
            this.pnlBox6.TabIndex = 5;
            // 
            // lblItem6
            // 
            this.lblItem6.AutoSize = true;
            this.lblItem6.Font = new System.Drawing.Font("HelveticaNeueLT Std Lt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem6.ForeColor = System.Drawing.Color.White;
            this.lblItem6.Location = new System.Drawing.Point(28, 80);
            this.lblItem6.Name = "lblItem6";
            this.lblItem6.Size = new System.Drawing.Size(59, 22);
            this.lblItem6.TabIndex = 1;
            this.lblItem6.Text = "$0.99";
            // 
            // picTradable6
            // 
            this.picTradable6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.picTradable6.Image = global::gnomehenge_launcher.Properties.Resources.gnomegreyhat;
            this.picTradable6.Location = new System.Drawing.Point(3, 3);
            this.picTradable6.Name = "picTradable6";
            this.picTradable6.Size = new System.Drawing.Size(108, 71);
            this.picTradable6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTradable6.TabIndex = 0;
            this.picTradable6.TabStop = false;
            // 
            // pnlBox5
            // 
            this.pnlBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(48)))), ((int)(((byte)(38)))));
            this.pnlBox5.Controls.Add(this.lblItem5);
            this.pnlBox5.Controls.Add(this.picTradable5);
            this.pnlBox5.Location = new System.Drawing.Point(131, 162);
            this.pnlBox5.Name = "pnlBox5";
            this.pnlBox5.Size = new System.Drawing.Size(114, 110);
            this.pnlBox5.TabIndex = 4;
            // 
            // lblItem5
            // 
            this.lblItem5.AutoSize = true;
            this.lblItem5.Font = new System.Drawing.Font("HelveticaNeueLT Std Lt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem5.ForeColor = System.Drawing.Color.White;
            this.lblItem5.Location = new System.Drawing.Point(28, 80);
            this.lblItem5.Name = "lblItem5";
            this.lblItem5.Size = new System.Drawing.Size(59, 22);
            this.lblItem5.TabIndex = 1;
            this.lblItem5.Text = "$0.99";
            // 
            // picTradable5
            // 
            this.picTradable5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.picTradable5.Image = global::gnomehenge_launcher.Properties.Resources.gnomeorangehat;
            this.picTradable5.Location = new System.Drawing.Point(3, 3);
            this.picTradable5.Name = "picTradable5";
            this.picTradable5.Size = new System.Drawing.Size(108, 71);
            this.picTradable5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTradable5.TabIndex = 0;
            this.picTradable5.TabStop = false;
            // 
            // pnlBox3
            // 
            this.pnlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(48)))), ((int)(((byte)(38)))));
            this.pnlBox3.Controls.Add(this.lblItem3);
            this.pnlBox3.Controls.Add(this.picTradable3);
            this.pnlBox3.Location = new System.Drawing.Point(251, 46);
            this.pnlBox3.Name = "pnlBox3";
            this.pnlBox3.Size = new System.Drawing.Size(114, 110);
            this.pnlBox3.TabIndex = 3;
            // 
            // lblItem3
            // 
            this.lblItem3.AutoSize = true;
            this.lblItem3.Font = new System.Drawing.Font("HelveticaNeueLT Std Lt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem3.ForeColor = System.Drawing.Color.White;
            this.lblItem3.Location = new System.Drawing.Point(28, 80);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Size = new System.Drawing.Size(59, 22);
            this.lblItem3.TabIndex = 1;
            this.lblItem3.Text = "$0.99";
            // 
            // picTradable3
            // 
            this.picTradable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.picTradable3.Image = global::gnomehenge_launcher.Properties.Resources.gnomebluehat;
            this.picTradable3.Location = new System.Drawing.Point(3, 3);
            this.picTradable3.Name = "picTradable3";
            this.picTradable3.Size = new System.Drawing.Size(108, 71);
            this.picTradable3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTradable3.TabIndex = 0;
            this.picTradable3.TabStop = false;
            // 
            // pnlBox4
            // 
            this.pnlBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(48)))), ((int)(((byte)(38)))));
            this.pnlBox4.Controls.Add(this.lblItem4);
            this.pnlBox4.Controls.Add(this.picTradable4);
            this.pnlBox4.Location = new System.Drawing.Point(11, 162);
            this.pnlBox4.Name = "pnlBox4";
            this.pnlBox4.Size = new System.Drawing.Size(114, 110);
            this.pnlBox4.TabIndex = 3;
            // 
            // lblItem4
            // 
            this.lblItem4.AutoSize = true;
            this.lblItem4.Font = new System.Drawing.Font("HelveticaNeueLT Std Lt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem4.ForeColor = System.Drawing.Color.White;
            this.lblItem4.Location = new System.Drawing.Point(28, 80);
            this.lblItem4.Name = "lblItem4";
            this.lblItem4.Size = new System.Drawing.Size(59, 22);
            this.lblItem4.TabIndex = 1;
            this.lblItem4.Text = "$0.99";
            // 
            // picTradable4
            // 
            this.picTradable4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.picTradable4.Image = global::gnomehenge_launcher.Properties.Resources.gnomemagentahat;
            this.picTradable4.Location = new System.Drawing.Point(3, 3);
            this.picTradable4.Name = "picTradable4";
            this.picTradable4.Size = new System.Drawing.Size(108, 71);
            this.picTradable4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTradable4.TabIndex = 0;
            this.picTradable4.TabStop = false;
            // 
            // pnlBox2
            // 
            this.pnlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(48)))), ((int)(((byte)(38)))));
            this.pnlBox2.Controls.Add(this.lblItem2);
            this.pnlBox2.Controls.Add(this.picTradable2);
            this.pnlBox2.Location = new System.Drawing.Point(131, 46);
            this.pnlBox2.Name = "pnlBox2";
            this.pnlBox2.Size = new System.Drawing.Size(114, 110);
            this.pnlBox2.TabIndex = 2;
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Font = new System.Drawing.Font("HelveticaNeueLT Std Lt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem2.ForeColor = System.Drawing.Color.White;
            this.lblItem2.Location = new System.Drawing.Point(28, 80);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(59, 22);
            this.lblItem2.TabIndex = 1;
            this.lblItem2.Text = "$0.99";
            // 
            // picTradable2
            // 
            this.picTradable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.picTradable2.Image = global::gnomehenge_launcher.Properties.Resources.gnomeredhat;
            this.picTradable2.Location = new System.Drawing.Point(3, 3);
            this.picTradable2.Name = "picTradable2";
            this.picTradable2.Size = new System.Drawing.Size(108, 71);
            this.picTradable2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTradable2.TabIndex = 0;
            this.picTradable2.TabStop = false;
            // 
            // pnlBox1
            // 
            this.pnlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(48)))), ((int)(((byte)(38)))));
            this.pnlBox1.Controls.Add(this.lblItem1);
            this.pnlBox1.Controls.Add(this.picTradable1);
            this.pnlBox1.Location = new System.Drawing.Point(11, 46);
            this.pnlBox1.Name = "pnlBox1";
            this.pnlBox1.Size = new System.Drawing.Size(114, 110);
            this.pnlBox1.TabIndex = 0;
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Font = new System.Drawing.Font("Hypatia Sans Pro Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem1.ForeColor = System.Drawing.Color.White;
            this.lblItem1.Location = new System.Drawing.Point(29, 81);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(56, 20);
            this.lblItem1.TabIndex = 2;
            this.lblItem1.Text = "Owned";
            // 
            // picTradable1
            // 
            this.picTradable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(34)))), ((int)(((byte)(27)))));
            this.picTradable1.Image = global::gnomehenge_launcher.Properties.Resources.gnomegreenhat;
            this.picTradable1.Location = new System.Drawing.Point(3, 3);
            this.picTradable1.Name = "picTradable1";
            this.picTradable1.Size = new System.Drawing.Size(108, 71);
            this.picTradable1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTradable1.TabIndex = 0;
            this.picTradable1.TabStop = false;
            // 
            // tmrDownload
            // 
            this.tmrDownload.Interval = 10;
            this.tmrDownload.Tick += new System.EventHandler(this.tmrSkinTimer_Tick);
            // 
            // pnlBlog
            // 
            this.pnlBlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.pnlBlog.Controls.Add(this.picBlogImage);
            this.pnlBlog.Controls.Add(this.lblBlogHeader);
            this.pnlBlog.Location = new System.Drawing.Point(28, 153);
            this.pnlBlog.Name = "pnlBlog";
            this.pnlBlog.Size = new System.Drawing.Size(501, 284);
            this.pnlBlog.TabIndex = 7;
            // 
            // picBlogImage
            // 
            this.picBlogImage.Image = global::gnomehenge_launcher.Properties.Resources.gnomestainedglass;
            this.picBlogImage.Location = new System.Drawing.Point(73, 48);
            this.picBlogImage.Name = "picBlogImage";
            this.picBlogImage.Size = new System.Drawing.Size(354, 223);
            this.picBlogImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBlogImage.TabIndex = 8;
            this.picBlogImage.TabStop = false;
            // 
            // lblBlogHeader
            // 
            this.lblBlogHeader.AutoSize = true;
            this.lblBlogHeader.Font = new System.Drawing.Font("Hypatia Sans Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlogHeader.ForeColor = System.Drawing.Color.White;
            this.lblBlogHeader.Location = new System.Drawing.Point(10, 8);
            this.lblBlogHeader.Name = "lblBlogHeader";
            this.lblBlogHeader.Size = new System.Drawing.Size(481, 38);
            this.lblBlogHeader.TabIndex = 7;
            this.lblBlogHeader.Text = "Thank you for playing GnomeHenge!";
            // 
            // frmGnomeHenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(19)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(950, 531);
            this.Controls.Add(this.pnlAnnounceFront);
            this.Controls.Add(this.pnlBlog);
            this.Controls.Add(this.pnlTradables);
            this.Controls.Add(this.pnlPatcher);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmGnomeHenge";
            this.Text = "GnomeHenge";
            this.Load += new System.EventHandler(this.frmSkinhaven_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlAnnounceFront.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnnouncer)).EndInit();
            this.pnlPatcher.ResumeLayout(false);
            this.pnlTradables.ResumeLayout(false);
            this.pnlTradables.PerformLayout();
            this.pnlBox6.ResumeLayout(false);
            this.pnlBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable6)).EndInit();
            this.pnlBox5.ResumeLayout(false);
            this.pnlBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable5)).EndInit();
            this.pnlBox3.ResumeLayout(false);
            this.pnlBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable3)).EndInit();
            this.pnlBox4.ResumeLayout(false);
            this.pnlBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable4)).EndInit();
            this.pnlBox2.ResumeLayout(false);
            this.pnlBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable2)).EndInit();
            this.pnlBox1.ResumeLayout(false);
            this.pnlBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTradable1)).EndInit();
            this.pnlBlog.ResumeLayout(false);
            this.pnlBlog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlogImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label btnPlay;
        private System.Windows.Forms.PictureBox picOpenID;
        private System.Windows.Forms.Panel pnlAnnounceFront;
        private System.Windows.Forms.PictureBox picAnnouncer;
        private System.Windows.Forms.Label lblAnnouncement;
        private System.Windows.Forms.Panel pnlPatcher;
        private System.Windows.Forms.Label lblLink3;
        private System.Windows.Forms.Label lblLink2;
        private System.Windows.Forms.Panel pnlTradables;
        private System.Windows.Forms.Panel pnlBox1;
        private System.Windows.Forms.PictureBox picTradable1;
        private System.Windows.Forms.Panel pnlBox2;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.PictureBox picTradable2;
        private System.Windows.Forms.Panel pnlBox4;
        private System.Windows.Forms.Label lblItem4;
        private System.Windows.Forms.PictureBox picTradable4;
        private System.Windows.Forms.Panel pnlBox3;
        private System.Windows.Forms.PictureBox picTradable3;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.Panel pnlBox6;
        private System.Windows.Forms.Label lblItem6;
        private System.Windows.Forms.PictureBox picTradable6;
        private System.Windows.Forms.Panel pnlBox5;
        private System.Windows.Forms.Label lblItem5;
        private System.Windows.Forms.PictureBox picTradable5;
        private System.Windows.Forms.ProgressBar prgDownload;
        private System.Windows.Forms.Timer tmrDownload;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLink1;
        private System.Windows.Forms.Label lblFeaturedTradables;
        private System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Panel pnlBlog;
        private System.Windows.Forms.PictureBox picBlogImage;
        private System.Windows.Forms.Label lblBlogHeader;
        private System.Windows.Forms.Label lblClose;
    }
}

