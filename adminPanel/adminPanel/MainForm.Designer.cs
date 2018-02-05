namespace adminPanel
{
    partial class MainForm
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
            this.ControllPanel = new System.Windows.Forms.Panel();
            this.ShutdownBtn = new System.Windows.Forms.Button();
            this.SqlBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.StatsBtn = new System.Windows.Forms.Button();
            this.SchemaBtn = new System.Windows.Forms.Button();
            this.CoursesBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogoLbl = new System.Windows.Forms.Label();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.ControllPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControllPanel
            // 
            this.ControllPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.ControllPanel.Controls.Add(this.ShutdownBtn);
            this.ControllPanel.Controls.Add(this.SqlBtn);
            this.ControllPanel.Controls.Add(this.LogOutBtn);
            this.ControllPanel.Controls.Add(this.StatsBtn);
            this.ControllPanel.Controls.Add(this.SchemaBtn);
            this.ControllPanel.Controls.Add(this.CoursesBtn);
            this.ControllPanel.Controls.Add(this.HomeBtn);
            this.ControllPanel.Location = new System.Drawing.Point(0, 48);
            this.ControllPanel.Name = "ControllPanel";
            this.ControllPanel.Size = new System.Drawing.Size(191, 627);
            this.ControllPanel.TabIndex = 0;
            // 
            // ShutdownBtn
            // 
            this.ShutdownBtn.FlatAppearance.BorderSize = 0;
            this.ShutdownBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.ShutdownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.ShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutdownBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.ShutdownBtn.Location = new System.Drawing.Point(0, 575);
            this.ShutdownBtn.Name = "ShutdownBtn";
            this.ShutdownBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.ShutdownBtn.Size = new System.Drawing.Size(191, 52);
            this.ShutdownBtn.TabIndex = 1;
            this.ShutdownBtn.Text = "Avslutt";
            this.ShutdownBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutdownBtn.UseVisualStyleBackColor = true;
            this.ShutdownBtn.Click += new System.EventHandler(this.ShutdownBtn_Click);
            this.ShutdownBtn.MouseEnter += new System.EventHandler(this.ShutdownBtn_MouseEnter);
            this.ShutdownBtn.MouseLeave += new System.EventHandler(this.ShutdownBtn_MouseLeave);
            // 
            // SqlBtn
            // 
            this.SqlBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.SqlBtn.FlatAppearance.BorderSize = 0;
            this.SqlBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.SqlBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.SqlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqlBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.SqlBtn.Location = new System.Drawing.Point(0, 208);
            this.SqlBtn.Name = "SqlBtn";
            this.SqlBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.SqlBtn.Size = new System.Drawing.Size(191, 52);
            this.SqlBtn.TabIndex = 3;
            this.SqlBtn.Text = "SQL-Editor";
            this.SqlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SqlBtn.UseVisualStyleBackColor = false;
            this.SqlBtn.Click += new System.EventHandler(this.SqlBtn_Click);
            this.SqlBtn.MouseEnter += new System.EventHandler(this.SqlBtn_MouseEnter);
            this.SqlBtn.MouseLeave += new System.EventHandler(this.SqlBtn_MouseLeave);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.LogOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.LogOutBtn.Location = new System.Drawing.Point(0, 525);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.LogOutBtn.Size = new System.Drawing.Size(191, 52);
            this.LogOutBtn.TabIndex = 0;
            this.LogOutBtn.Text = "Logg Ut";
            this.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            this.LogOutBtn.MouseEnter += new System.EventHandler(this.LogOutBtn_MouseEnter);
            this.LogOutBtn.MouseLeave += new System.EventHandler(this.LogOutBtn_MouseLeave);
            // 
            // StatsBtn
            // 
            this.StatsBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.StatsBtn.FlatAppearance.BorderSize = 0;
            this.StatsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.StatsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.StatsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.StatsBtn.Location = new System.Drawing.Point(0, 104);
            this.StatsBtn.Name = "StatsBtn";
            this.StatsBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.StatsBtn.Size = new System.Drawing.Size(191, 52);
            this.StatsBtn.TabIndex = 2;
            this.StatsBtn.Text = "Se Statistikk";
            this.StatsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatsBtn.UseVisualStyleBackColor = false;
            this.StatsBtn.Click += new System.EventHandler(this.StatsBtn_Click);
            this.StatsBtn.MouseEnter += new System.EventHandler(this.StatsBtn_MouseEnter);
            this.StatsBtn.MouseLeave += new System.EventHandler(this.StatsBtn_MouseLeave);
            // 
            // SchemaBtn
            // 
            this.SchemaBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.SchemaBtn.FlatAppearance.BorderSize = 0;
            this.SchemaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.SchemaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.SchemaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SchemaBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.SchemaBtn.Location = new System.Drawing.Point(0, 156);
            this.SchemaBtn.Name = "SchemaBtn";
            this.SchemaBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.SchemaBtn.Size = new System.Drawing.Size(191, 52);
            this.SchemaBtn.TabIndex = 2;
            this.SchemaBtn.Text = "Spørreskjema";
            this.SchemaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SchemaBtn.UseVisualStyleBackColor = false;
            this.SchemaBtn.Click += new System.EventHandler(this.SchemaBtn_Click);
            this.SchemaBtn.MouseEnter += new System.EventHandler(this.SchemaBtn_MouseEnter);
            this.SchemaBtn.MouseLeave += new System.EventHandler(this.SchemaBtn_MouseLeave);
            // 
            // CoursesBtn
            // 
            this.CoursesBtn.FlatAppearance.BorderSize = 0;
            this.CoursesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.CoursesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.CoursesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoursesBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.CoursesBtn.Location = new System.Drawing.Point(0, 52);
            this.CoursesBtn.Name = "CoursesBtn";
            this.CoursesBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.CoursesBtn.Size = new System.Drawing.Size(191, 52);
            this.CoursesBtn.TabIndex = 2;
            this.CoursesBtn.Text = "Mine Fag";
            this.CoursesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CoursesBtn.UseVisualStyleBackColor = true;
            this.CoursesBtn.Click += new System.EventHandler(this.CoursesBtn_Click);
            this.CoursesBtn.MouseEnter += new System.EventHandler(this.CoursesBtn_MouseEnter);
            this.CoursesBtn.MouseLeave += new System.EventHandler(this.CoursesBtn_MouseLeave);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(99)))), ((int)(((byte)(112)))));
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(191, 52);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Hjem";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            this.HomeBtn.MouseEnter += new System.EventHandler(this.HomeBtn_MouseEnter);
            this.HomeBtn.MouseLeave += new System.EventHandler(this.HomeBtn_MouseLeave);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.LogoPanel.Controls.Add(this.MinimizeBtn);
            this.LogoPanel.Controls.Add(this.ExitBtn);
            this.LogoPanel.Controls.Add(this.LogoLbl);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(1199, 48);
            this.LogoPanel.TabIndex = 1;
            this.LogoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseDown);
            this.LogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseMove);
            this.LogoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseUp);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.Location = new System.Drawing.Point(1097, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MinimizeBtn.Size = new System.Drawing.Size(51, 48);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.Text = "_";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(1148, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(51, 48);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogoLbl
            // 
            this.LogoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoLbl.AutoSize = true;
            this.LogoLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLbl.Location = new System.Drawing.Point(7, 11);
            this.LogoLbl.Name = "LogoLbl";
            this.LogoLbl.Size = new System.Drawing.Size(182, 25);
            this.LogoLbl.TabIndex = 2;
            this.LogoLbl.Text = "Vurderingssytem";
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.LightGray;
            this.ContainerPanel.Location = new System.Drawing.Point(191, 48);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1008, 627);
            this.ContainerPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 675);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.ControllPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ControllPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControllPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoLbl;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CoursesBtn;
        private System.Windows.Forms.Button StatsBtn;
        private System.Windows.Forms.Button SqlBtn;
        private System.Windows.Forms.Button SchemaBtn;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Button ShutdownBtn;
        private System.Windows.Forms.Button LogOutBtn;
    }
}