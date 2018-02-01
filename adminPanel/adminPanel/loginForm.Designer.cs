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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoggInBtn = new System.Windows.Forms.Button();
            this.ShutdownBtn = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.HelpText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 42);
            this.panel1.TabIndex = 0;
            // 
            // LoggInBtn
            // 
            this.LoggInBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LoggInBtn.FlatAppearance.BorderSize = 0;
            this.LoggInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoggInBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggInBtn.Location = new System.Drawing.Point(77, 358);
            this.LoggInBtn.Name = "LoggInBtn";
            this.LoggInBtn.Size = new System.Drawing.Size(202, 36);
            this.LoggInBtn.TabIndex = 1;
            this.LoggInBtn.Text = "Logg in";
            this.LoggInBtn.UseVisualStyleBackColor = false;
            // 
            // ShutdownBtn
            // 
            this.ShutdownBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ShutdownBtn.FlatAppearance.BorderSize = 0;
            this.ShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutdownBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutdownBtn.Location = new System.Drawing.Point(77, 400);
            this.ShutdownBtn.Name = "ShutdownBtn";
            this.ShutdownBtn.Size = new System.Drawing.Size(202, 36);
            this.ShutdownBtn.TabIndex = 2;
            this.ShutdownBtn.Text = "Avslutt";
            this.ShutdownBtn.UseVisualStyleBackColor = false;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(77, 171);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(202, 26);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.Window;
            this.Password.Location = new System.Drawing.Point(77, 232);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(202, 26);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // HelpText
            // 
            this.HelpText.AutoSize = true;
            this.HelpText.ForeColor = System.Drawing.SystemColors.Info;
            this.HelpText.Location = new System.Drawing.Point(152, 300);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(50, 13);
            this.HelpText.TabIndex = 5;
            this.HelpText.Text = "HelpText";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(359, 478);
            this.Controls.Add(this.HelpText);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ShutdownBtn);
            this.Controls.Add(this.LoggInBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innlogging for VMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoggInBtn;
        private System.Windows.Forms.Button ShutdownBtn;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label HelpText;
    }
}

