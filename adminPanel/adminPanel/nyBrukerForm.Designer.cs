namespace adminPanel
{
    partial class nyBrukerForm
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
            this.Brukernavn = new System.Windows.Forms.TextBox();
            this.Passord = new System.Windows.Forms.TextBox();
            this.Passord2 = new System.Windows.Forms.TextBox();
            this.LagBrukerBtn = new System.Windows.Forms.Button();
            this.AvsluttBtn = new System.Windows.Forms.Button();
            this.nyBrukerLbl = new System.Windows.Forms.Label();
            this.BrukernavnLbl = new System.Windows.Forms.Label();
            this.nyttPassordLbl = new System.Windows.Forms.Label();
            this.nyttPassordLbl2 = new System.Windows.Forms.Label();
            this.Feilmelding = new System.Windows.Forms.Label();
            this.fornavn = new System.Windows.Forms.TextBox();
            this.etternavn = new System.Windows.Forms.TextBox();
            this.fornavnLbl = new System.Windows.Forms.Label();
            this.etternavnLbl = new System.Windows.Forms.Label();
            this.opprettetLbl = new System.Windows.Forms.Label();
            this.nyBrukerLogginn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Brukernavn
            // 
            this.Brukernavn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brukernavn.Location = new System.Drawing.Point(96, 82);
            this.Brukernavn.Name = "Brukernavn";
            this.Brukernavn.Size = new System.Drawing.Size(167, 27);
            this.Brukernavn.TabIndex = 0;
            this.Brukernavn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Brukernavn_MouseDown);
            // 
            // Passord
            // 
            this.Passord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passord.Location = new System.Drawing.Point(96, 271);
            this.Passord.Name = "Passord";
            this.Passord.PasswordChar = '*';
            this.Passord.Size = new System.Drawing.Size(167, 27);
            this.Passord.TabIndex = 4;
            this.Passord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Passord_MouseDown);
            // 
            // Passord2
            // 
            this.Passord2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passord2.Location = new System.Drawing.Point(96, 334);
            this.Passord2.Name = "Passord2";
            this.Passord2.PasswordChar = '*';
            this.Passord2.Size = new System.Drawing.Size(167, 27);
            this.Passord2.TabIndex = 5;
            this.Passord2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Passord2_MouseDown);
            // 
            // LagBrukerBtn
            // 
            this.LagBrukerBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LagBrukerBtn.FlatAppearance.BorderSize = 0;
            this.LagBrukerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LagBrukerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LagBrukerBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LagBrukerBtn.Location = new System.Drawing.Point(12, 418);
            this.LagBrukerBtn.Name = "LagBrukerBtn";
            this.LagBrukerBtn.Size = new System.Drawing.Size(134, 48);
            this.LagBrukerBtn.TabIndex = 6;
            this.LagBrukerBtn.Text = "Lag Bruker";
            this.LagBrukerBtn.UseVisualStyleBackColor = false;
            this.LagBrukerBtn.Click += new System.EventHandler(this.LagBrukerBtn_Click);
            // 
            // AvsluttBtn
            // 
            this.AvsluttBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AvsluttBtn.FlatAppearance.BorderSize = 0;
            this.AvsluttBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvsluttBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvsluttBtn.Location = new System.Drawing.Point(213, 418);
            this.AvsluttBtn.Name = "AvsluttBtn";
            this.AvsluttBtn.Size = new System.Drawing.Size(134, 48);
            this.AvsluttBtn.TabIndex = 7;
            this.AvsluttBtn.Text = "Avslutt";
            this.AvsluttBtn.UseVisualStyleBackColor = false;
            this.AvsluttBtn.Click += new System.EventHandler(this.AvsluttBtn_Click);
            // 
            // nyBrukerLbl
            // 
            this.nyBrukerLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nyBrukerLbl.AutoSize = true;
            this.nyBrukerLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyBrukerLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nyBrukerLbl.Location = new System.Drawing.Point(99, 3);
            this.nyBrukerLbl.Name = "nyBrukerLbl";
            this.nyBrukerLbl.Size = new System.Drawing.Size(161, 39);
            this.nyBrukerLbl.TabIndex = 5;
            this.nyBrukerLbl.Text = "Ny Bruker";
            // 
            // BrukernavnLbl
            // 
            this.BrukernavnLbl.AutoSize = true;
            this.BrukernavnLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrukernavnLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.BrukernavnLbl.Location = new System.Drawing.Point(92, 58);
            this.BrukernavnLbl.Name = "BrukernavnLbl";
            this.BrukernavnLbl.Size = new System.Drawing.Size(136, 21);
            this.BrukernavnLbl.TabIndex = 6;
            this.BrukernavnLbl.Text = "Nytt Brukernavn";
            // 
            // nyttPassordLbl
            // 
            this.nyttPassordLbl.AutoSize = true;
            this.nyttPassordLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyttPassordLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nyttPassordLbl.Location = new System.Drawing.Point(92, 247);
            this.nyttPassordLbl.Name = "nyttPassordLbl";
            this.nyttPassordLbl.Size = new System.Drawing.Size(106, 21);
            this.nyttPassordLbl.TabIndex = 7;
            this.nyttPassordLbl.Text = "Nytt Passord";
            // 
            // nyttPassordLbl2
            // 
            this.nyttPassordLbl2.AutoSize = true;
            this.nyttPassordLbl2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyttPassordLbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.nyttPassordLbl2.Location = new System.Drawing.Point(92, 310);
            this.nyttPassordLbl2.Name = "nyttPassordLbl2";
            this.nyttPassordLbl2.Size = new System.Drawing.Size(127, 21);
            this.nyttPassordLbl2.TabIndex = 8;
            this.nyttPassordLbl2.Text = "Gjenta Passord";
            // 
            // Feilmelding
            // 
            this.Feilmelding.AutoSize = true;
            this.Feilmelding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feilmelding.ForeColor = System.Drawing.Color.Red;
            this.Feilmelding.Location = new System.Drawing.Point(93, 375);
            this.Feilmelding.Name = "Feilmelding";
            this.Feilmelding.Size = new System.Drawing.Size(0, 21);
            this.Feilmelding.TabIndex = 9;
            this.Feilmelding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fornavn
            // 
            this.fornavn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornavn.Location = new System.Drawing.Point(96, 145);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(167, 27);
            this.fornavn.TabIndex = 2;
            this.fornavn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fornavn_MouseDown);
            // 
            // etternavn
            // 
            this.etternavn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etternavn.Location = new System.Drawing.Point(96, 208);
            this.etternavn.Name = "etternavn";
            this.etternavn.Size = new System.Drawing.Size(167, 27);
            this.etternavn.TabIndex = 3;
            this.etternavn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.etternavn_MouseDown);
            // 
            // fornavnLbl
            // 
            this.fornavnLbl.AutoSize = true;
            this.fornavnLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornavnLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.fornavnLbl.Location = new System.Drawing.Point(92, 121);
            this.fornavnLbl.Name = "fornavnLbl";
            this.fornavnLbl.Size = new System.Drawing.Size(74, 21);
            this.fornavnLbl.TabIndex = 12;
            this.fornavnLbl.Text = "Fornavn";
            // 
            // etternavnLbl
            // 
            this.etternavnLbl.AutoSize = true;
            this.etternavnLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etternavnLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.etternavnLbl.Location = new System.Drawing.Point(92, 184);
            this.etternavnLbl.Name = "etternavnLbl";
            this.etternavnLbl.Size = new System.Drawing.Size(89, 21);
            this.etternavnLbl.TabIndex = 13;
            this.etternavnLbl.Text = "Etternavn";
            // 
            // opprettetLbl
            // 
            this.opprettetLbl.AutoSize = true;
            this.opprettetLbl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opprettetLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.opprettetLbl.Location = new System.Drawing.Point(52, 158);
            this.opprettetLbl.Name = "opprettetLbl";
            this.opprettetLbl.Size = new System.Drawing.Size(255, 36);
            this.opprettetLbl.TabIndex = 14;
            this.opprettetLbl.Text = "Bruker opprettet!";
            // 
            // nyBrukerLogginn
            // 
            this.nyBrukerLogginn.BackColor = System.Drawing.Color.SteelBlue;
            this.nyBrukerLogginn.FlatAppearance.BorderSize = 0;
            this.nyBrukerLogginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nyBrukerLogginn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyBrukerLogginn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nyBrukerLogginn.Location = new System.Drawing.Point(92, 220);
            this.nyBrukerLogginn.Name = "nyBrukerLogginn";
            this.nyBrukerLogginn.Size = new System.Drawing.Size(176, 64);
            this.nyBrukerLogginn.TabIndex = 15;
            this.nyBrukerLogginn.Text = "Logg Inn";
            this.nyBrukerLogginn.UseVisualStyleBackColor = false;
            this.nyBrukerLogginn.Click += new System.EventHandler(this.nyBrukerLogginn_Click);
            // 
            // nyBrukerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(359, 478);
            this.Controls.Add(this.nyBrukerLogginn);
            this.Controls.Add(this.opprettetLbl);
            this.Controls.Add(this.etternavnLbl);
            this.Controls.Add(this.fornavnLbl);
            this.Controls.Add(this.etternavn);
            this.Controls.Add(this.fornavn);
            this.Controls.Add(this.Feilmelding);
            this.Controls.Add(this.nyttPassordLbl2);
            this.Controls.Add(this.nyttPassordLbl);
            this.Controls.Add(this.BrukernavnLbl);
            this.Controls.Add(this.nyBrukerLbl);
            this.Controls.Add(this.AvsluttBtn);
            this.Controls.Add(this.LagBrukerBtn);
            this.Controls.Add(this.Passord2);
            this.Controls.Add(this.Passord);
            this.Controls.Add(this.Brukernavn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nyBrukerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "nyBrukerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Brukernavn;
        private System.Windows.Forms.TextBox Passord;
        private System.Windows.Forms.TextBox Passord2;
        private System.Windows.Forms.Button LagBrukerBtn;
        private System.Windows.Forms.Button AvsluttBtn;
        private System.Windows.Forms.Label nyBrukerLbl;
        private System.Windows.Forms.Label BrukernavnLbl;
        private System.Windows.Forms.Label nyttPassordLbl;
        private System.Windows.Forms.Label nyttPassordLbl2;
        private System.Windows.Forms.Label Feilmelding;
        private System.Windows.Forms.TextBox fornavn;
        private System.Windows.Forms.TextBox etternavn;
        private System.Windows.Forms.Label fornavnLbl;
        private System.Windows.Forms.Label etternavnLbl;
        private System.Windows.Forms.Label opprettetLbl;
        private System.Windows.Forms.Button nyBrukerLogginn;
    }
}