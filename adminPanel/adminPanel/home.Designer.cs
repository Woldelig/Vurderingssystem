namespace adminPanel
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.HomeHeaderLbl = new System.Windows.Forms.Label();
            this.LastLoginPanel = new System.Windows.Forms.Panel();
            this.LastLogin = new System.Windows.Forms.Label();
            this.LastLoginHeader = new System.Windows.Forms.Label();
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.NameLbl = new System.Windows.Forms.Label();
            this.UsertypeLbl = new System.Windows.Forms.Label();
            this.AvatarPanel = new System.Windows.Forms.Panel();
            this.AvatarImage = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.VelkomstLbl = new System.Windows.Forms.Label();
            this.LastLoginPanel.SuspendLayout();
            this.UserInfoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeHeaderLbl
            // 
            this.HomeHeaderLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeHeaderLbl.AutoSize = true;
            this.HomeHeaderLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeHeaderLbl.Location = new System.Drawing.Point(210, 78);
            this.HomeHeaderLbl.Name = "HomeHeaderLbl";
            this.HomeHeaderLbl.Size = new System.Drawing.Size(618, 44);
            this.HomeHeaderLbl.TabIndex = 0;
            this.HomeHeaderLbl.Text = "Velkommen til vurderingssystemet";
            // 
            // LastLoginPanel
            // 
            this.LastLoginPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LastLoginPanel.Controls.Add(this.LastLogin);
            this.LastLoginPanel.Controls.Add(this.LastLoginHeader);
            this.LastLoginPanel.Location = new System.Drawing.Point(628, 172);
            this.LastLoginPanel.Name = "LastLoginPanel";
            this.LastLoginPanel.Size = new System.Drawing.Size(200, 84);
            this.LastLoginPanel.TabIndex = 1;
            // 
            // LastLogin
            // 
            this.LastLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.LastLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LastLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLogin.Location = new System.Drawing.Point(0, 37);
            this.LastLogin.Name = "LastLogin";
            this.LastLogin.Size = new System.Drawing.Size(200, 47);
            this.LastLogin.TabIndex = 2;
            this.LastLogin.Text = "DATO";
            this.LastLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastLoginHeader
            // 
            this.LastLoginHeader.AutoSize = true;
            this.LastLoginHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLoginHeader.Location = new System.Drawing.Point(42, 16);
            this.LastLoginHeader.Name = "LastLoginHeader";
            this.LastLoginHeader.Size = new System.Drawing.Size(115, 21);
            this.LastLoginHeader.TabIndex = 0;
            this.LastLoginHeader.Text = "Sist Innlogget";
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(173)))), ((int)(((byte)(220)))));
            this.UserInfoPanel.Controls.Add(this.NameLbl);
            this.UserInfoPanel.Controls.Add(this.UsertypeLbl);
            this.UserInfoPanel.Location = new System.Drawing.Point(274, 172);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(348, 84);
            this.UserInfoPanel.TabIndex = 2;
            // 
            // NameLbl
            // 
            this.NameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(0, 50);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameLbl.Size = new System.Drawing.Size(348, 34);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Navn";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsertypeLbl
            // 
            this.UsertypeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsertypeLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertypeLbl.Location = new System.Drawing.Point(0, 0);
            this.UsertypeLbl.Name = "UsertypeLbl";
            this.UsertypeLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UsertypeLbl.Size = new System.Drawing.Size(348, 50);
            this.UsertypeLbl.TabIndex = 4;
            this.UsertypeLbl.Text = "Brukertype";
            this.UsertypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvatarPanel
            // 
            this.AvatarPanel.BackColor = System.Drawing.Color.Transparent;
            this.AvatarPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AvatarPanel.BackgroundImage")));
            this.AvatarPanel.Location = new System.Drawing.Point(169, 172);
            this.AvatarPanel.Name = "AvatarPanel";
            this.AvatarPanel.Size = new System.Drawing.Size(106, 84);
            this.AvatarPanel.TabIndex = 3;
            // 
            // AvatarImage
            // 
            this.AvatarImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.AvatarImage.ImageSize = new System.Drawing.Size(16, 16);
            this.AvatarImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(78)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.VelkomstLbl);
            this.panel1.Location = new System.Drawing.Point(169, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 325);
            this.panel1.TabIndex = 4;
            // 
            // VelkomstLbl
            // 
            this.VelkomstLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VelkomstLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VelkomstLbl.Location = new System.Drawing.Point(0, 0);
            this.VelkomstLbl.Name = "VelkomstLbl";
            this.VelkomstLbl.Size = new System.Drawing.Size(658, 325);
            this.VelkomstLbl.TabIndex = 0;
            this.VelkomstLbl.Text = "Panel for velkomstmelding: Her vil det bli lagt til statistikk for den spesifkke " +
    "brukeren om evalueringer i brukerens fag.\r\n";
            this.VelkomstLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AvatarPanel);
            this.Controls.Add(this.UserInfoPanel);
            this.Controls.Add(this.LastLoginPanel);
            this.Controls.Add(this.HomeHeaderLbl);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.Home_Load);
            this.LastLoginPanel.ResumeLayout(false);
            this.LastLoginPanel.PerformLayout();
            this.UserInfoPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeHeaderLbl;
        private System.Windows.Forms.Panel LastLoginPanel;
        private System.Windows.Forms.Label LastLoginHeader;
        private System.Windows.Forms.Label LastLogin;
        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Panel AvatarPanel;
        private System.Windows.Forms.ImageList AvatarImage;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label UsertypeLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VelkomstLbl;
    }
}
