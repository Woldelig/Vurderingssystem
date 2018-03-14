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
            this.SuspendLayout();
            // 
            // Brukernavn
            // 
            this.Brukernavn.Location = new System.Drawing.Point(110, 75);
            this.Brukernavn.Name = "Brukernavn";
            this.Brukernavn.Size = new System.Drawing.Size(224, 20);
            this.Brukernavn.TabIndex = 0;
            // 
            // Passord
            // 
            this.Passord.Location = new System.Drawing.Point(110, 141);
            this.Passord.Name = "Passord";
            this.Passord.Size = new System.Drawing.Size(224, 20);
            this.Passord.TabIndex = 1;
            // 
            // Passord2
            // 
            this.Passord2.Location = new System.Drawing.Point(110, 192);
            this.Passord2.Name = "Passord2";
            this.Passord2.Size = new System.Drawing.Size(224, 20);
            this.Passord2.TabIndex = 2;
            // 
            // LagBrukerBtn
            // 
            this.LagBrukerBtn.Location = new System.Drawing.Point(110, 236);
            this.LagBrukerBtn.Name = "LagBrukerBtn";
            this.LagBrukerBtn.Size = new System.Drawing.Size(75, 23);
            this.LagBrukerBtn.TabIndex = 3;
            this.LagBrukerBtn.Text = "Lag Bruker";
            this.LagBrukerBtn.UseVisualStyleBackColor = true;
            this.LagBrukerBtn.Click += new System.EventHandler(this.LagBrukerBtn_Click);
            // 
            // AvsluttBtn
            // 
            this.AvsluttBtn.Location = new System.Drawing.Point(259, 236);
            this.AvsluttBtn.Name = "AvsluttBtn";
            this.AvsluttBtn.Size = new System.Drawing.Size(75, 23);
            this.AvsluttBtn.TabIndex = 4;
            this.AvsluttBtn.Text = "Avslutt";
            this.AvsluttBtn.UseVisualStyleBackColor = true;
            this.AvsluttBtn.Click += new System.EventHandler(this.AvsluttBtn_Click);
            // 
            // nyBrukerLbl
            // 
            this.nyBrukerLbl.AutoSize = true;
            this.nyBrukerLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyBrukerLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nyBrukerLbl.Location = new System.Drawing.Point(142, 21);
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
            this.BrukernavnLbl.Location = new System.Drawing.Point(0, 76);
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
            this.nyttPassordLbl.Location = new System.Drawing.Point(22, 141);
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
            this.nyttPassordLbl2.Location = new System.Drawing.Point(22, 195);
            this.nyttPassordLbl2.Name = "nyttPassordLbl2";
            this.nyttPassordLbl2.Size = new System.Drawing.Size(87, 17);
            this.nyttPassordLbl2.TabIndex = 8;
            this.nyttPassordLbl2.Text = "Nytt Passord";
            // 
            // NyBrukerFeilmelding
            // 
            this.NyBrukerFeilmelding.AutoSize = true;
            this.NyBrukerFeilmelding.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyBrukerFeilmelding.ForeColor = System.Drawing.Color.Red;
            this.NyBrukerFeilmelding.Location = new System.Drawing.Point(146, 98);
            this.NyBrukerFeilmelding.Name = "NyBrukerFeilmelding";
            this.NyBrukerFeilmelding.Size = new System.Drawing.Size(139, 17);
            this.NyBrukerFeilmelding.TabIndex = 9;
            this.NyBrukerFeilmelding.Text = "Brukernavnet er tatt!";
            // 
            // nyBrukerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(448, 304);
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
    }
}