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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(747, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}
