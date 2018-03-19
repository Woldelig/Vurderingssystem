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
            this.NyBrukerFeilmelding = new System.Windows.Forms.Label();
            this.fornavn = new System.Windows.Forms.TextBox();
            this.etternavn = new System.Windows.Forms.TextBox();
            this.fornavnLbl = new System.Windows.Forms.Label();
            this.etternavnLbl = new System.Windows.Forms.Label();
            this.opprettetLbl = new System.Windows.Forms.Label();
            this.nyBrukerLogginn = new System.Windows.Forms.Button();
            this.FeltFeilmeldingLbl = new System.Windows.Forms.Label();
            this.passordFeilmeldingLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Brukernavn
            // 
            this.Brukernavn.Location = new System.Drawing.Point(62, 78);
            this.Brukernavn.Name = "Brukernavn";
            this.Brukernavn.Size = new System.Drawing.Size(224, 20);
            this.Brukernavn.TabIndex = 0;
            // 
            // Passord
            // 
            this.Passord.Location = new System.Drawing.Point(62, 274);
            this.Passord.Name = "Passord";
            this.Passord.Size = new System.Drawing.Size(224, 20);
            this.Passord.TabIndex = 1;
            // 
            // Passord2
            // 
            this.Passord2.Location = new System.Drawing.Point(62, 348);
            this.Passord2.Name = "Passord2";
            this.Passord2.Size = new System.Drawing.Size(224, 20);
            this.Passord2.TabIndex = 2;
            // 
            // LagBrukerBtn
            // 
            this.LagBrukerBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LagBrukerBtn.FlatAppearance.BorderSize = 0;
            this.LagBrukerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LagBrukerBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LagBrukerBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LagBrukerBtn.Location = new System.Drawing.Point(34, 405);
            this.LagBrukerBtn.Name = "LagBrukerBtn";
            this.LagBrukerBtn.Size = new System.Drawing.Size(75, 23);
            this.LagBrukerBtn.TabIndex = 3;
            this.LagBrukerBtn.Text = "Lag Bruker";
            this.LagBrukerBtn.UseVisualStyleBackColor = false;
            this.LagBrukerBtn.Click += new System.EventHandler(this.LagBrukerBtn_Click);
            // 
            // AvsluttBtn
            // 
            this.AvsluttBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AvsluttBtn.FlatAppearance.BorderSize = 0;
            this.AvsluttBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvsluttBtn.Location = new System.Drawing.Point(244, 405);
            this.AvsluttBtn.Name = "AvsluttBtn";
            this.AvsluttBtn.Size = new System.Drawing.Size(75, 23);
            this.AvsluttBtn.TabIndex = 4;
            this.AvsluttBtn.Text = "Avslutt";
            this.AvsluttBtn.UseVisualStyleBackColor = false;
            this.AvsluttBtn.Click += new System.EventHandler(this.AvsluttBtn_Click);
            // 
            // nyBrukerLbl
            // 
            this.nyBrukerLbl.AutoSize = true;
            this.nyBrukerLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyBrukerLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nyBrukerLbl.Location = new System.Drawing.Point(103, 9);
            this.nyBrukerLbl.Name = "nyBrukerLbl";
            this.nyBrukerLbl.Size = new System.Drawing.Size(161, 39);
            this.nyBrukerLbl.TabIndex = 5;
            this.nyBrukerLbl.Text = "Ny Bruker";
            // 
            // BrukernavnLbl
            // 
            this.BrukernavnLbl.AutoSize = true;
            this.BrukernavnLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrukernavnLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.BrukernavnLbl.Location = new System.Drawing.Point(59, 58);
            this.BrukernavnLbl.Name = "BrukernavnLbl";
            this.BrukernavnLbl.Size = new System.Drawing.Size(109, 17);
            this.BrukernavnLbl.TabIndex = 6;
            this.BrukernavnLbl.Text = "Nytt Brukernavn";
            // 
            // nyttPassordLbl
            // 
            this.nyttPassordLbl.AutoSize = true;
            this.nyttPassordLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyttPassordLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nyttPassordLbl.Location = new System.Drawing.Point(59, 254);
            this.nyttPassordLbl.Name = "nyttPassordLbl";
            this.nyttPassordLbl.Size = new System.Drawing.Size(87, 17);
            this.nyttPassordLbl.TabIndex = 7;
            this.nyttPassordLbl.Text = "Nytt Passord";
            // 
            // nyttPassordLbl2
            // 
            this.nyttPassordLbl2.AutoSize = true;
            this.nyttPassordLbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyttPassordLbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.nyttPassordLbl2.Location = new System.Drawing.Point(59, 328);
            this.nyttPassordLbl2.Name = "nyttPassordLbl2";
            this.nyttPassordLbl2.Size = new System.Drawing.Size(161, 17);
            this.nyttPassordLbl2.TabIndex = 8;
            this.nyttPassordLbl2.Text = "Skriv inn passordet igjen";
            // 
            // NyBrukerFeilmelding
            // 
            this.NyBrukerFeilmelding.AutoSize = true;
            this.NyBrukerFeilmelding.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyBrukerFeilmelding.ForeColor = System.Drawing.Color.Red;
            this.NyBrukerFeilmelding.Location = new System.Drawing.Point(59, 101);
            this.NyBrukerFeilmelding.Name = "NyBrukerFeilmelding";
            this.NyBrukerFeilmelding.Size = new System.Drawing.Size(139, 17);
            this.NyBrukerFeilmelding.TabIndex = 9;
            this.NyBrukerFeilmelding.Text = "Brukernavnet er tatt!";
            // 
            // fornavn
            // 
            this.fornavn.Location = new System.Drawing.Point(62, 147);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(224, 20);
            this.fornavn.TabIndex = 10;
            // 
            // etternavn
            // 
            this.etternavn.Location = new System.Drawing.Point(62, 206);
            this.etternavn.Name = "etternavn";
            this.etternavn.Size = new System.Drawing.Size(224, 20);
            this.etternavn.TabIndex = 11;
            // 
            // fornavnLbl
            // 
            this.fornavnLbl.AutoSize = true;
            this.fornavnLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornavnLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.fornavnLbl.Location = new System.Drawing.Point(59, 127);
            this.fornavnLbl.Name = "fornavnLbl";
            this.fornavnLbl.Size = new System.Drawing.Size(60, 17);
            this.fornavnLbl.TabIndex = 12;
            this.fornavnLbl.Text = "Fornavn";
            // 
            // etternavnLbl
            // 
            this.etternavnLbl.AutoSize = true;
            this.etternavnLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etternavnLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.etternavnLbl.Location = new System.Drawing.Point(59, 186);
            this.etternavnLbl.Name = "etternavnLbl";
            this.etternavnLbl.Size = new System.Drawing.Size(70, 17);
            this.etternavnLbl.TabIndex = 13;
            this.etternavnLbl.Text = "Etternavn";
            // 
            // opprettetLbl
            // 
            this.opprettetLbl.AutoSize = true;
            this.opprettetLbl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opprettetLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.opprettetLbl.Location = new System.Drawing.Point(56, 101);
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
            this.nyBrukerLogginn.Location = new System.Drawing.Point(88, 204);
            this.nyBrukerLogginn.Name = "nyBrukerLogginn";
            this.nyBrukerLogginn.Size = new System.Drawing.Size(176, 64);
            this.nyBrukerLogginn.TabIndex = 15;
            this.nyBrukerLogginn.Text = "Logg Inn";
            this.nyBrukerLogginn.UseVisualStyleBackColor = false;
            this.nyBrukerLogginn.Click += new System.EventHandler(this.nyBrukerLogginn_Click);
            // 
            // FeltFeilmeldingLbl
            // 
            this.FeltFeilmeldingLbl.AutoSize = true;
            this.FeltFeilmeldingLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FeltFeilmeldingLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeltFeilmeldingLbl.ForeColor = System.Drawing.Color.Red;
            this.FeltFeilmeldingLbl.Location = new System.Drawing.Point(78, 374);
            this.FeltFeilmeldingLbl.Name = "FeltFeilmeldingLbl";
            this.FeltFeilmeldingLbl.Size = new System.Drawing.Size(192, 21);
            this.FeltFeilmeldingLbl.TabIndex = 16;
            this.FeltFeilmeldingLbl.Text = "Alle feltene må fylles ut!";
            // 
            // passordFeilmeldingLbl
            // 
            this.passordFeilmeldingLbl.AutoSize = true;
            this.passordFeilmeldingLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passordFeilmeldingLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passordFeilmeldingLbl.ForeColor = System.Drawing.Color.Red;
            this.passordFeilmeldingLbl.Location = new System.Drawing.Point(78, 297);
            this.passordFeilmeldingLbl.Name = "passordFeilmeldingLbl";
            this.passordFeilmeldingLbl.Size = new System.Drawing.Size(178, 20);
            this.passordFeilmeldingLbl.TabIndex = 17;
            this.passordFeilmeldingLbl.Text = "Passordene er ikke like!";
            // 
            // nyBrukerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(359, 478);
            this.Controls.Add(this.passordFeilmeldingLbl);
            this.Controls.Add(this.FeltFeilmeldingLbl);
            this.Controls.Add(this.nyBrukerLogginn);
            this.Controls.Add(this.opprettetLbl);
            this.Controls.Add(this.etternavnLbl);
            this.Controls.Add(this.fornavnLbl);
            this.Controls.Add(this.etternavn);
            this.Controls.Add(this.fornavn);
            this.Controls.Add(this.NyBrukerFeilmelding);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label NyBrukerFeilmelding;
        private System.Windows.Forms.TextBox fornavn;
        private System.Windows.Forms.TextBox etternavn;
        private System.Windows.Forms.Label fornavnLbl;
        private System.Windows.Forms.Label etternavnLbl;
        private System.Windows.Forms.Label opprettetLbl;
        private System.Windows.Forms.Button nyBrukerLogginn;
        private System.Windows.Forms.Label FeltFeilmeldingLbl;
        private System.Windows.Forms.Label passordFeilmeldingLbl;
    }
}