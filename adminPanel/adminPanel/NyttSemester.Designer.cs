namespace adminPanel
{
    partial class NyttSemester
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
            this.TabellNavnTextbox = new System.Windows.Forms.TextBox();
            this.GodkjennNyttSemesterLbl = new System.Windows.Forms.Label();
            this.ValideringsTextBox = new System.Windows.Forms.TextBox();
            this.ValideringsInfoLbl = new System.Windows.Forms.Label();
            this.HjelpBtn = new System.Windows.Forms.Button();
            this.IkkeGodkjennNyttSemesterLbl = new System.Windows.Forms.Label();
            this.TabellNavnLbl = new System.Windows.Forms.Label();
            this.StartNyttSemesterBtn = new System.Windows.Forms.Button();
            this.FeilmeldingLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelValideringsLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabellNavnTextbox
            // 
            this.TabellNavnTextbox.Location = new System.Drawing.Point(129, 241);
            this.TabellNavnTextbox.Name = "TabellNavnTextbox";
            this.TabellNavnTextbox.Size = new System.Drawing.Size(100, 20);
            this.TabellNavnTextbox.TabIndex = 1;
            // 
            // GodkjennNyttSemesterLbl
            // 
            this.GodkjennNyttSemesterLbl.AutoSize = true;
            this.GodkjennNyttSemesterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GodkjennNyttSemesterLbl.Location = new System.Drawing.Point(24, 17);
            this.GodkjennNyttSemesterLbl.Name = "GodkjennNyttSemesterLbl";
            this.GodkjennNyttSemesterLbl.Size = new System.Drawing.Size(78, 20);
            this.GodkjennNyttSemesterLbl.TabIndex = 2;
            this.GodkjennNyttSemesterLbl.Text = "Godkjenn";
            // 
            // ValideringsTextBox
            // 
            this.ValideringsTextBox.Location = new System.Drawing.Point(202, 33);
            this.ValideringsTextBox.Name = "ValideringsTextBox";
            this.ValideringsTextBox.ReadOnly = true;
            this.ValideringsTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValideringsTextBox.TabIndex = 3;
            // 
            // ValideringsInfoLbl
            // 
            this.ValideringsInfoLbl.AutoSize = true;
            this.ValideringsInfoLbl.Location = new System.Drawing.Point(199, 17);
            this.ValideringsInfoLbl.Name = "ValideringsInfoLbl";
            this.ValideringsInfoLbl.Size = new System.Drawing.Size(84, 13);
            this.ValideringsInfoLbl.TabIndex = 4;
            this.ValideringsInfoLbl.Text = "Valideringsboks:";
            // 
            // HjelpBtn
            // 
            this.HjelpBtn.Location = new System.Drawing.Point(129, 48);
            this.HjelpBtn.Name = "HjelpBtn";
            this.HjelpBtn.Size = new System.Drawing.Size(114, 38);
            this.HjelpBtn.TabIndex = 6;
            this.HjelpBtn.Text = "Hjelp";
            this.HjelpBtn.UseVisualStyleBackColor = true;
            this.HjelpBtn.Click += new System.EventHandler(this.HjelpBtn_Click);
            // 
            // IkkeGodkjennNyttSemesterLbl
            // 
            this.IkkeGodkjennNyttSemesterLbl.AutoSize = true;
            this.IkkeGodkjennNyttSemesterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IkkeGodkjennNyttSemesterLbl.Location = new System.Drawing.Point(24, 37);
            this.IkkeGodkjennNyttSemesterLbl.Name = "IkkeGodkjennNyttSemesterLbl";
            this.IkkeGodkjennNyttSemesterLbl.Size = new System.Drawing.Size(108, 20);
            this.IkkeGodkjennNyttSemesterLbl.TabIndex = 7;
            this.IkkeGodkjennNyttSemesterLbl.Text = "Ikke godkjenn";
            // 
            // TabellNavnLbl
            // 
            this.TabellNavnLbl.AutoSize = true;
            this.TabellNavnLbl.Location = new System.Drawing.Point(129, 222);
            this.TabellNavnLbl.Name = "TabellNavnLbl";
            this.TabellNavnLbl.Size = new System.Drawing.Size(63, 13);
            this.TabellNavnLbl.TabIndex = 8;
            this.TabellNavnLbl.Text = "Tabellnavn:";
            // 
            // StartNyttSemesterBtn
            // 
            this.StartNyttSemesterBtn.Location = new System.Drawing.Point(235, 241);
            this.StartNyttSemesterBtn.Name = "StartNyttSemesterBtn";
            this.StartNyttSemesterBtn.Size = new System.Drawing.Size(75, 23);
            this.StartNyttSemesterBtn.TabIndex = 9;
            this.StartNyttSemesterBtn.Text = "Start";
            this.StartNyttSemesterBtn.UseVisualStyleBackColor = true;
            this.StartNyttSemesterBtn.Click += new System.EventHandler(this.StartNyttSemesterBtn_Click);
            // 
            // FeilmeldingLbl
            // 
            this.FeilmeldingLbl.AutoSize = true;
            this.FeilmeldingLbl.Location = new System.Drawing.Point(316, 241);
            this.FeilmeldingLbl.Name = "FeilmeldingLbl";
            this.FeilmeldingLbl.Size = new System.Drawing.Size(35, 13);
            this.FeilmeldingLbl.TabIndex = 10;
            this.FeilmeldingLbl.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.GodkjennNyttSemesterLbl);
            this.panel1.Controls.Add(this.ValideringsTextBox);
            this.panel1.Controls.Add(this.ValideringsInfoLbl);
            this.panel1.Controls.Add(this.IkkeGodkjennNyttSemesterLbl);
            this.panel1.Location = new System.Drawing.Point(626, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 154);
            this.panel1.TabIndex = 11;
            // 
            // PanelValideringsLbl
            // 
            this.PanelValideringsLbl.AutoSize = true;
            this.PanelValideringsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelValideringsLbl.Location = new System.Drawing.Point(621, 180);
            this.PanelValideringsLbl.Name = "PanelValideringsLbl";
            this.PanelValideringsLbl.Size = new System.Drawing.Size(114, 25);
            this.PanelValideringsLbl.TabIndex = 12;
            this.PanelValideringsLbl.Text = "Validering:";
            // 
            // NyttSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelValideringsLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FeilmeldingLbl);
            this.Controls.Add(this.StartNyttSemesterBtn);
            this.Controls.Add(this.TabellNavnLbl);
            this.Controls.Add(this.HjelpBtn);
            this.Controls.Add(this.TabellNavnTextbox);
            this.Name = "NyttSemester";
            this.Size = new System.Drawing.Size(1008, 627);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TabellNavnTextbox;
        private System.Windows.Forms.Label GodkjennNyttSemesterLbl;
        private System.Windows.Forms.TextBox ValideringsTextBox;
        private System.Windows.Forms.Label ValideringsInfoLbl;
        private System.Windows.Forms.Button HjelpBtn;
        private System.Windows.Forms.Label IkkeGodkjennNyttSemesterLbl;
        private System.Windows.Forms.Label TabellNavnLbl;
        private System.Windows.Forms.Button StartNyttSemesterBtn;
        private System.Windows.Forms.Label FeilmeldingLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PanelValideringsLbl;
    }
}
