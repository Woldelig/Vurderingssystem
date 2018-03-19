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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MyCoursesHeader = new System.Windows.Forms.Label();
            this.MyCoursesPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.ChartFeilmldLbl = new System.Windows.Forms.Label();
            this.FagkodeNr1 = new System.Windows.Forms.TextBox();
            this.FagkodeNr2 = new System.Windows.Forms.TextBox();
            this.Fagkode1lbl = new System.Windows.Forms.Label();
            this.FagkodeNr2Lbl = new System.Windows.Forms.Label();
            this.SammenlignLbl = new System.Windows.Forms.Label();
            this.SammenlignFagBtn = new System.Windows.Forms.Button();
            this.SammenlignFeilmldLbl = new System.Windows.Forms.Label();
            this.spmListeboks = new System.Windows.Forms.ListBox();
            this.spmLbl = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printBtn = new System.Windows.Forms.Button();
            this.lagreChartBtn = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.InfoPanel.Controls.Add(this.SammenlignFeilmldLbl);
            this.InfoPanel.Controls.Add(this.SammenlignFagBtn);
            this.InfoPanel.Controls.Add(this.SammenlignLbl);
            this.InfoPanel.Controls.Add(this.Fagkode1lbl);
            this.InfoPanel.Controls.Add(this.FagkodeNr2Lbl);
            this.InfoPanel.Controls.Add(this.FagkodeNr2);
            this.InfoPanel.Controls.Add(this.FagkodeNr1);
            this.InfoPanel.Location = new System.Drawing.Point(518, 85);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(435, 144);
            this.InfoPanel.TabIndex = 2;
            // 
            // ChartFeilmldLbl
            // 
            this.ChartFeilmldLbl.AutoSize = true;
            this.ChartFeilmldLbl.Location = new System.Drawing.Point(708, 598);
            this.ChartFeilmldLbl.Name = "ChartFeilmldLbl";
            this.ChartFeilmldLbl.Size = new System.Drawing.Size(83, 13);
            this.ChartFeilmldLbl.TabIndex = 3;
            this.ChartFeilmldLbl.Text = "chart feilmelding";
            // 
            // FagkodeNr1
            // 
            this.FagkodeNr1.Location = new System.Drawing.Point(72, 78);
            this.FagkodeNr1.Name = "FagkodeNr1";
            this.FagkodeNr1.ReadOnly = true;
            this.FagkodeNr1.Size = new System.Drawing.Size(100, 20);
            this.FagkodeNr1.TabIndex = 0;
            // 
            // FagkodeNr2
            // 
            this.FagkodeNr2.Location = new System.Drawing.Point(241, 78);
            this.FagkodeNr2.Name = "FagkodeNr2";
            this.FagkodeNr2.ReadOnly = true;
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
            // SammenlignFagBtn
            // 
            this.SammenlignFagBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SammenlignFagBtn.Location = new System.Drawing.Point(166, 104);
            this.SammenlignFagBtn.Name = "SammenlignFagBtn";
            this.SammenlignFagBtn.Size = new System.Drawing.Size(75, 37);
            this.SammenlignFagBtn.TabIndex = 6;
            this.SammenlignFagBtn.Text = "Sammenlign";
            this.SammenlignFagBtn.UseVisualStyleBackColor = false;
            this.SammenlignFagBtn.Click += new System.EventHandler(this.SammenlignFagBtn_Click);
            // 
            // SammenlignFeilmldLbl
            // 
            this.SammenlignFeilmldLbl.AutoSize = true;
            this.SammenlignFeilmldLbl.Location = new System.Drawing.Point(247, 116);
            this.SammenlignFeilmldLbl.Name = "SammenlignFeilmldLbl";
            this.SammenlignFeilmldLbl.Size = new System.Drawing.Size(35, 13);
            this.SammenlignFeilmldLbl.TabIndex = 4;
            this.SammenlignFeilmldLbl.Text = "label2";
            // 
            // spmListeboks
            // 
            this.spmListeboks.FormattingEnabled = true;
            this.spmListeboks.Location = new System.Drawing.Point(789, 248);
            this.spmListeboks.Name = "spmListeboks";
            this.spmListeboks.Size = new System.Drawing.Size(164, 108);
            this.spmListeboks.TabIndex = 4;
            this.spmListeboks.SelectedIndexChanged += new System.EventHandler(this.spmListeboks_SelectedIndexChanged);
            // 
            // spmLbl
            // 
            this.spmLbl.AutoSize = true;
            this.spmLbl.Location = new System.Drawing.Point(786, 232);
            this.spmLbl.Name = "spmLbl";
            this.spmLbl.Size = new System.Drawing.Size(167, 13);
            this.spmLbl.TabIndex = 6;
            this.spmLbl.Text = "Velg spørsmål du vil sammenligne:";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(17, 235);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(673, 376);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printBtn.Location = new System.Drawing.Point(789, 422);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(96, 54);
            this.printBtn.TabIndex = 9;
            this.printBtn.Text = "Skriv ut diagram";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // lagreChartBtn
            // 
            this.lagreChartBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lagreChartBtn.Location = new System.Drawing.Point(789, 362);
            this.lagreChartBtn.Name = "lagreChartBtn";
            this.lagreChartBtn.Size = new System.Drawing.Size(96, 54);
            this.lagreChartBtn.TabIndex = 10;
            this.lagreChartBtn.Text = "Lagre diagram";
            this.lagreChartBtn.UseVisualStyleBackColor = false;
            this.lagreChartBtn.Click += new System.EventHandler(this.lagreChartBtn_Click);
            // 
            // MyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lagreChartBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.spmLbl);
            this.Controls.Add(this.ChartFeilmldLbl);
            this.Controls.Add(this.spmListeboks);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MyCoursesPanel);
            this.Controls.Add(this.MyCoursesHeader);
            this.Name = "MyCourses";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.MyCourses_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyCoursesHeader;
        private System.Windows.Forms.Panel MyCoursesPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label ChartFeilmldLbl;
        private System.Windows.Forms.Label SammenlignLbl;
        private System.Windows.Forms.Label Fagkode1lbl;
        private System.Windows.Forms.Label FagkodeNr2Lbl;
        private System.Windows.Forms.TextBox FagkodeNr2;
        private System.Windows.Forms.TextBox FagkodeNr1;
        private System.Windows.Forms.Button SammenlignFagBtn;
        private System.Windows.Forms.Label SammenlignFeilmldLbl;
        private System.Windows.Forms.ListBox spmListeboks;
        private System.Windows.Forms.Label spmLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button lagreChartBtn;
    }
}
