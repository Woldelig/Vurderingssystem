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
            this.InfoPanel.Location = new System.Drawing.Point(518, 85);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(435, 500);
            this.InfoPanel.TabIndex = 2;
            // 
            // MyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MyCoursesPanel);
            this.Controls.Add(this.MyCoursesHeader);
            this.Name = "MyCourses";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.MyCourses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MyCoursesHeader;
        private System.Windows.Forms.Panel MyCoursesPanel;
        private System.Windows.Forms.Panel InfoPanel;
    }
}
