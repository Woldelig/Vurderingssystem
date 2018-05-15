namespace adminPanel
{
    partial class LoginForm
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
            this.LoginBoarder = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ShutdownBtn = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.HelpText = new System.Windows.Forms.Label();
            this.LoginHeader = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.BoarderDivider = new System.Windows.Forms.Panel();
            this.nyBrukerBtn = new System.Windows.Forms.Label();
            this.LoginBoarder.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBoarder
            // 
            this.LoginBoarder.Controls.Add(this.MinimizeBtn);
            this.LoginBoarder.Controls.Add(this.ExitBtn);
            this.LoginBoarder.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginBoarder.Location = new System.Drawing.Point(0, 0);
            this.LoginBoarder.Name = "LoginBoarder";
            this.LoginBoarder.Size = new System.Drawing.Size(359, 42);
            this.LoginBoarder.TabIndex = 9;
            this.LoginBoarder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginBoarder_MouseDown);
            this.LoginBoarder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginBoarder_MouseMove);
            this.LoginBoarder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginBoarder_MouseUp);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.MinimizeBtn.Location = new System.Drawing.Point(277, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MinimizeBtn.Size = new System.Drawing.Size(41, 42);
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.Text = "_";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(318, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(41, 42);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(77)))));
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(77)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(77, 358);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(202, 36);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Logg inn";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            this.LoginBtn.MouseEnter += new System.EventHandler(this.LoginBtn_MouseEnter);
            this.LoginBtn.MouseLeave += new System.EventHandler(this.LoginBtn_MouseLeave);
            // 
            // ShutdownBtn
            // 
            this.ShutdownBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ShutdownBtn.FlatAppearance.BorderSize = 0;
            this.ShutdownBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(77)))));
            this.ShutdownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(77)))));
            this.ShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutdownBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutdownBtn.Location = new System.Drawing.Point(77, 400);
            this.ShutdownBtn.Name = "ShutdownBtn";
            this.ShutdownBtn.Size = new System.Drawing.Size(202, 36);
            this.ShutdownBtn.TabIndex = 3;
            this.ShutdownBtn.Text = "Avslutt";
            this.ShutdownBtn.UseVisualStyleBackColor = false;
            this.ShutdownBtn.Click += new System.EventHandler(this.ShutdownBtn_Click);
            this.ShutdownBtn.MouseEnter += new System.EventHandler(this.ShutdownBtn_MouseEnter);
            this.ShutdownBtn.MouseLeave += new System.EventHandler(this.ShutdownBtn_MouseLeave);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(77, 192);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(202, 29);
            this.Username.TabIndex = 0;
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.Window;
            this.Password.Location = new System.Drawing.Point(77, 253);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(202, 29);
            this.Password.TabIndex = 1;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // HelpText
            // 
            this.HelpText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpText.ForeColor = System.Drawing.SystemColors.Info;
            this.HelpText.Location = new System.Drawing.Point(74, 297);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(205, 44);
            this.HelpText.TabIndex = 5;
            // 
            // LoginHeader
            // 
            this.LoginHeader.AutoSize = true;
            this.LoginHeader.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginHeader.Location = new System.Drawing.Point(18, 86);
            this.LoginHeader.Name = "LoginHeader";
            this.LoginHeader.Size = new System.Drawing.Size(325, 44);
            this.LoginHeader.TabIndex = 6;
            this.LoginHeader.Text = "Vurderingssystem";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.UsernameLbl.Location = new System.Drawing.Point(72, 171);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(98, 21);
            this.UsernameLbl.TabIndex = 7;
            this.UsernameLbl.Text = "Brukernavn";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.PasswordLbl.Location = new System.Drawing.Point(72, 232);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(68, 21);
            this.PasswordLbl.TabIndex = 8;
            this.PasswordLbl.Text = "Passord";
            // 
            // BoarderDivider
            // 
            this.BoarderDivider.BackColor = System.Drawing.Color.SteelBlue;
            this.BoarderDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoarderDivider.Location = new System.Drawing.Point(0, 42);
            this.BoarderDivider.Name = "BoarderDivider";
            this.BoarderDivider.Size = new System.Drawing.Size(359, 1);
            this.BoarderDivider.TabIndex = 9;
            // 
            // nyBrukerBtn
            // 
            this.nyBrukerBtn.AutoSize = true;
            this.nyBrukerBtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyBrukerBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.nyBrukerBtn.Location = new System.Drawing.Point(130, 445);
            this.nyBrukerBtn.Name = "nyBrukerBtn";
            this.nyBrukerBtn.Size = new System.Drawing.Size(101, 24);
            this.nyBrukerBtn.TabIndex = 10;
            this.nyBrukerBtn.Text = "Ny Bruker";
            this.nyBrukerBtn.Click += new System.EventHandler(this.NyBrukerBtn_Click);
            this.nyBrukerBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NyBrukerBtn_MouseDown);
            this.nyBrukerBtn.MouseEnter += new System.EventHandler(this.NyBrukerBtn_MouseEnter);
            this.nyBrukerBtn.MouseLeave += new System.EventHandler(this.NyBrukerBtn_MouseLeave);
            this.nyBrukerBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NyBrukerBtn_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(359, 478);
            this.Controls.Add(this.nyBrukerBtn);
            this.Controls.Add(this.BoarderDivider);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.LoginHeader);
            this.Controls.Add(this.HelpText);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ShutdownBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginBoarder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innlogging for VMS";
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.LoginBoarder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginBoarder;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ShutdownBtn;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label HelpText;
        private System.Windows.Forms.Label LoginHeader;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Panel BoarderDivider;
        private System.Windows.Forms.Label nyBrukerBtn;
    }
}

