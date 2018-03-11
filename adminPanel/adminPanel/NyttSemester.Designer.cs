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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GodkjennNyttSemesterLbl = new System.Windows.Forms.Label();
            this.ValideringsTextBox = new System.Windows.Forms.TextBox();
            this.ValideringsInfoLbl = new System.Windows.Forms.Label();
            this.HjelpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // GodkjennNyttSemesterLbl
            // 
            this.GodkjennNyttSemesterLbl.AutoSize = true;
            this.GodkjennNyttSemesterLbl.Location = new System.Drawing.Point(658, 153);
            this.GodkjennNyttSemesterLbl.Name = "GodkjennNyttSemesterLbl";
            this.GodkjennNyttSemesterLbl.Size = new System.Drawing.Size(53, 13);
            this.GodkjennNyttSemesterLbl.TabIndex = 2;
            this.GodkjennNyttSemesterLbl.Text = "Godkjenn";
            // 
            // ValideringsTextBox
            // 
            this.ValideringsTextBox.Location = new System.Drawing.Point(836, 153);
            this.ValideringsTextBox.Name = "ValideringsTextBox";
            this.ValideringsTextBox.ReadOnly = true;
            this.ValideringsTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValideringsTextBox.TabIndex = 3;
            // 
            // ValideringsInfoLbl
            // 
            this.ValideringsInfoLbl.AutoSize = true;
            this.ValideringsInfoLbl.Location = new System.Drawing.Point(833, 137);
            this.ValideringsInfoLbl.Name = "ValideringsInfoLbl";
            this.ValideringsInfoLbl.Size = new System.Drawing.Size(84, 13);
            this.ValideringsInfoLbl.TabIndex = 4;
            this.ValideringsInfoLbl.Text = "Valideringsboks:";
            // 
            // HjelpBtn
            // 
            this.HjelpBtn.Location = new System.Drawing.Point(45, 46);
            this.HjelpBtn.Name = "HjelpBtn";
            this.HjelpBtn.Size = new System.Drawing.Size(114, 38);
            this.HjelpBtn.TabIndex = 6;
            this.HjelpBtn.Text = "Hjelp";
            this.HjelpBtn.UseVisualStyleBackColor = true;
            this.HjelpBtn.Click += new System.EventHandler(this.HjelpBtn_Click);
            // 
            // NyttSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HjelpBtn);
            this.Controls.Add(this.ValideringsInfoLbl);
            this.Controls.Add(this.ValideringsTextBox);
            this.Controls.Add(this.GodkjennNyttSemesterLbl);
            this.Controls.Add(this.textBox1);
            this.Name = "NyttSemester";
            this.Size = new System.Drawing.Size(1008, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label GodkjennNyttSemesterLbl;
        private System.Windows.Forms.TextBox ValideringsTextBox;
        private System.Windows.Forms.Label ValideringsInfoLbl;
        private System.Windows.Forms.Button HjelpBtn;
    }
}
