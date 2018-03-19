namespace adminPanel
{
    partial class MyCourses
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
            this.MyCoursesHeader = new System.Windows.Forms.Label();
            this.MyCoursesPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FagkodeNr1 = new System.Windows.Forms.TextBox();
            this.FagkodeNr2 = new System.Windows.Forms.TextBox();
            this.Fagkode1lbl = new System.Windows.Forms.Label();
            this.FagkodeNr2Lbl = new System.Windows.Forms.Label();
            this.SammenlignLbl = new System.Windows.Forms.Label();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyCoursesHeader
            // 
            this.MyCoursesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyCoursesHeader.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.MyCoursesHeader.Location = new System.Drawing.Point(0, 0);
            this.MyCoursesHeader.Name = "MyCoursesHeader";
            this.MyCoursesHeader.Size = new System.Drawing.Size(1008, 82);
            this.MyCoursesHeader.TabIndex = 0;
            this.MyCoursesHeader.Text = "Mine Fag";
            this.MyCoursesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyCoursesPanel
            // 
            this.MyCoursesPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MyCoursesPanel.Location = new System.Drawing.Point(61, 85);
            this.MyCoursesPanel.Name = "MyCoursesPanel";
            this.MyCoursesPanel.Size = new System.Drawing.Size(435, 500);
            this.MyCoursesPanel.TabIndex = 1;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InfoPanel.Controls.Add(this.SammenlignLbl);
            this.InfoPanel.Controls.Add(this.Fagkode1lbl);
            this.InfoPanel.Controls.Add(this.FagkodeNr2Lbl);
            this.InfoPanel.Controls.Add(this.FagkodeNr2);
            this.InfoPanel.Controls.Add(this.FagkodeNr1);
            this.InfoPanel.Location = new System.Drawing.Point(518, 85);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(435, 116);
            this.InfoPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FagkodeNr1
            // 
            this.FagkodeNr1.Location = new System.Drawing.Point(72, 78);
            this.FagkodeNr1.Name = "FagkodeNr1";
            this.FagkodeNr1.Size = new System.Drawing.Size(100, 20);
            this.FagkodeNr1.TabIndex = 0;
            // 
            // FagkodeNr2
            // 
            this.FagkodeNr2.Location = new System.Drawing.Point(241, 78);
            this.FagkodeNr2.Name = "FagkodeNr2";
            this.FagkodeNr2.Size = new System.Drawing.Size(100, 20);
            this.FagkodeNr2.TabIndex = 1;
            // 
            // Fagkode1lbl
            // 
            this.Fagkode1lbl.AutoSize = true;
            this.Fagkode1lbl.Location = new System.Drawing.Point(69, 62);
            this.Fagkode1lbl.Name = "Fagkode1lbl";
            this.Fagkode1lbl.Size = new System.Drawing.Size(49, 13);
            this.Fagkode1lbl.TabIndex = 4;
            this.Fagkode1lbl.Text = "Fagkode";
            // 
            // FagkodeNr2Lbl
            // 
            this.FagkodeNr2Lbl.AutoSize = true;
            this.FagkodeNr2Lbl.Location = new System.Drawing.Point(238, 62);
            this.FagkodeNr2Lbl.Name = "FagkodeNr2Lbl";
            this.FagkodeNr2Lbl.Size = new System.Drawing.Size(49, 13);
            this.FagkodeNr2Lbl.TabIndex = 5;
            this.FagkodeNr2Lbl.Text = "Fagkode";
            // 
            // SammenlignLbl
            // 
            this.SammenlignLbl.AutoSize = true;
            this.SammenlignLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SammenlignLbl.Location = new System.Drawing.Point(17, 13);
            this.SammenlignLbl.Name = "SammenlignLbl";
            this.SammenlignLbl.Size = new System.Drawing.Size(392, 20);
            this.SammenlignLbl.TabIndex = 4;
            this.SammenlignLbl.Text = "Trykk eller dra over fagkodene som skal sammenlignes";
            // 
            // MyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MyCoursesPanel);
            this.Controls.Add(this.MyCoursesHeader);
            this.Name = "MyCourses";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.MyCourses_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyCoursesHeader;
        private System.Windows.Forms.Panel MyCoursesPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SammenlignLbl;
        private System.Windows.Forms.Label Fagkode1lbl;
        private System.Windows.Forms.Label FagkodeNr2Lbl;
        private System.Windows.Forms.TextBox FagkodeNr2;
        private System.Windows.Forms.TextBox FagkodeNr1;
    }
}
