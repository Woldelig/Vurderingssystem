namespace adminPanel
{
    partial class SammenlignFlereFagkoder
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
            this.FagkodeListbox = new System.Windows.Forms.ListBox();
            this.FagkodeSammenlignesListebox = new System.Windows.Forms.ListBox();
            this.Fra1Til2Btn = new System.Windows.Forms.Button();
            this.Fra2Til1Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FagkodeListbox
            // 
            this.FagkodeListbox.FormattingEnabled = true;
            this.FagkodeListbox.Location = new System.Drawing.Point(134, 94);
            this.FagkodeListbox.Name = "FagkodeListbox";
            this.FagkodeListbox.Size = new System.Drawing.Size(120, 95);
            this.FagkodeListbox.TabIndex = 0;
            // 
            // FagkodeSammenlignesListebox
            // 
            this.FagkodeSammenlignesListebox.FormattingEnabled = true;
            this.FagkodeSammenlignesListebox.Location = new System.Drawing.Point(411, 94);
            this.FagkodeSammenlignesListebox.Name = "FagkodeSammenlignesListebox";
            this.FagkodeSammenlignesListebox.Size = new System.Drawing.Size(120, 95);
            this.FagkodeSammenlignesListebox.TabIndex = 1;
            // 
            // Fra1Til2Btn
            // 
            this.Fra1Til2Btn.Location = new System.Drawing.Point(295, 94);
            this.Fra1Til2Btn.Name = "Fra1Til2Btn";
            this.Fra1Til2Btn.Size = new System.Drawing.Size(75, 23);
            this.Fra1Til2Btn.TabIndex = 2;
            this.Fra1Til2Btn.Text = ">>";
            this.Fra1Til2Btn.UseVisualStyleBackColor = true;
            this.Fra1Til2Btn.Click += new System.EventHandler(this.Fra1Til2Btn_Click);
            // 
            // Fra2Til1Btn
            // 
            this.Fra2Til1Btn.Location = new System.Drawing.Point(295, 166);
            this.Fra2Til1Btn.Name = "Fra2Til1Btn";
            this.Fra2Til1Btn.Size = new System.Drawing.Size(75, 23);
            this.Fra2Til1Btn.TabIndex = 3;
            this.Fra2Til1Btn.Text = "<<";
            this.Fra2Til1Btn.UseVisualStyleBackColor = true;
            this.Fra2Til1Btn.Click += new System.EventHandler(this.Fra2Til1Btn_Click);
            // 
            // SammenlignFlereFagkoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Fra2Til1Btn);
            this.Controls.Add(this.Fra1Til2Btn);
            this.Controls.Add(this.FagkodeSammenlignesListebox);
            this.Controls.Add(this.FagkodeListbox);
            this.Name = "SammenlignFlereFagkoder";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.SammenlignFlereFagkoder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FagkodeListbox;
        private System.Windows.Forms.ListBox FagkodeSammenlignesListebox;
        private System.Windows.Forms.Button Fra1Til2Btn;
        private System.Windows.Forms.Button Fra2Til1Btn;
    }
}
