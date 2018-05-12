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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MyCoursesPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.SammenlignFeilmldLbl = new System.Windows.Forms.Label();
            this.SammenlignFagBtn = new System.Windows.Forms.Button();
            this.SammenlignLbl = new System.Windows.Forms.Label();
            this.Fagkode1lbl = new System.Windows.Forms.Label();
            this.FagkodeNr2Lbl = new System.Windows.Forms.Label();
            this.FagkodeNr2 = new System.Windows.Forms.TextBox();
            this.FagkodeNr1 = new System.Windows.Forms.TextBox();
            this.DiagramFeilmldLbl = new System.Windows.Forms.Label();
            this.FagkodeDiagram1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SkrivUtDiagram1Btn = new System.Windows.Forms.Button();
            this.LagreDiagram1Btn = new System.Windows.Forms.Button();
            this.FagkodeDiagram2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LagreDiagram2Btn = new System.Windows.Forms.Button();
            this.SkrivUtDiagram2Btn = new System.Windows.Forms.Button();
            this.DiagramFeilmld2Lbl = new System.Windows.Forms.Label();
            this.MyCoursesHeader = new System.Windows.Forms.Label();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FagkodeDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FagkodeDiagram2)).BeginInit();
            this.SuspendLayout();
            // 
            // MyCoursesPanel
            // 
            this.MyCoursesPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MyCoursesPanel.Location = new System.Drawing.Point(63, 51);
            this.MyCoursesPanel.Name = "MyCoursesPanel";
            this.MyCoursesPanel.Size = new System.Drawing.Size(435, 144);
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
            this.InfoPanel.Location = new System.Drawing.Point(513, 51);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(435, 144);
            this.InfoPanel.TabIndex = 2;
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
            // FagkodeNr2
            // 
            this.FagkodeNr2.Location = new System.Drawing.Point(241, 78);
            this.FagkodeNr2.Name = "FagkodeNr2";
            this.FagkodeNr2.ReadOnly = true;
            this.FagkodeNr2.Size = new System.Drawing.Size(100, 20);
            this.FagkodeNr2.TabIndex = 1;
            // 
            // FagkodeNr1
            // 
            this.FagkodeNr1.Location = new System.Drawing.Point(72, 78);
            this.FagkodeNr1.Name = "FagkodeNr1";
            this.FagkodeNr1.ReadOnly = true;
            this.FagkodeNr1.Size = new System.Drawing.Size(100, 20);
            this.FagkodeNr1.TabIndex = 0;
            // 
            // ChartFeilmldLbl
            // 
            this.DiagramFeilmldLbl.AutoSize = true;
            this.DiagramFeilmldLbl.Location = new System.Drawing.Point(212, 252);
            this.DiagramFeilmldLbl.Name = "ChartFeilmldLbl";
            this.DiagramFeilmldLbl.Size = new System.Drawing.Size(83, 13);
            this.DiagramFeilmldLbl.TabIndex = 3;
            this.DiagramFeilmldLbl.Text = "chart feilmelding";
            // 
            // FagkodeDiagram1
            // 
            chartArea1.Name = "ChartArea1";
            this.FagkodeDiagram1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.FagkodeDiagram1.Legends.Add(legend1);
            this.FagkodeDiagram1.Location = new System.Drawing.Point(0, 271);
            this.FagkodeDiagram1.Name = "FagkodeDiagram1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.FagkodeDiagram1.Series.Add(series1);
            this.FagkodeDiagram1.Size = new System.Drawing.Size(498, 356);
            this.FagkodeDiagram1.TabIndex = 7;
            this.FagkodeDiagram1.Text = "chart1";
            // 
            // SkrivUtDiagram1Btn
            // 
            this.SkrivUtDiagram1Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SkrivUtDiagram1Btn.Location = new System.Drawing.Point(110, 211);
            this.SkrivUtDiagram1Btn.Name = "SkrivUtDiagram1Btn";
            this.SkrivUtDiagram1Btn.Size = new System.Drawing.Size(96, 54);
            this.SkrivUtDiagram1Btn.TabIndex = 9;
            this.SkrivUtDiagram1Btn.Text = "Skriv ut diagram";
            this.SkrivUtDiagram1Btn.UseVisualStyleBackColor = false;
            this.SkrivUtDiagram1Btn.Click += new System.EventHandler(this.SkrivUtDiagram1Btn_Click);
            // 
            // LagreDiagram1Btn
            // 
            this.LagreDiagram1Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LagreDiagram1Btn.Location = new System.Drawing.Point(8, 211);
            this.LagreDiagram1Btn.Name = "LagreDiagram1Btn";
            this.LagreDiagram1Btn.Size = new System.Drawing.Size(96, 54);
            this.LagreDiagram1Btn.TabIndex = 10;
            this.LagreDiagram1Btn.Text = "Lagre diagram";
            this.LagreDiagram1Btn.UseVisualStyleBackColor = false;
            this.LagreDiagram1Btn.Click += new System.EventHandler(this.LagreDiagram1Btn_Click);
            // 
            // FagkodeDiagram2
            // 
            chartArea2.Name = "ChartArea1";
            this.FagkodeDiagram2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.FagkodeDiagram2.Legends.Add(legend2);
            this.FagkodeDiagram2.Location = new System.Drawing.Point(513, 271);
            this.FagkodeDiagram2.Name = "FagkodeDiagram2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.FagkodeDiagram2.Series.Add(series2);
            this.FagkodeDiagram2.Size = new System.Drawing.Size(495, 356);
            this.FagkodeDiagram2.TabIndex = 11;
            this.FagkodeDiagram2.Text = "chart2";
            // 
            // LagreDiagram2Btn
            // 
            this.LagreDiagram2Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LagreDiagram2Btn.Location = new System.Drawing.Point(806, 214);
            this.LagreDiagram2Btn.Name = "LagreDiagram2Btn";
            this.LagreDiagram2Btn.Size = new System.Drawing.Size(96, 54);
            this.LagreDiagram2Btn.TabIndex = 12;
            this.LagreDiagram2Btn.Text = "Lagre diagram";
            this.LagreDiagram2Btn.UseVisualStyleBackColor = false;
            this.LagreDiagram2Btn.Click += new System.EventHandler(this.LagreDiagram2Btn_Click);
            // 
            // SkrivUtDiagram2Btn
            // 
            this.SkrivUtDiagram2Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SkrivUtDiagram2Btn.Location = new System.Drawing.Point(909, 214);
            this.SkrivUtDiagram2Btn.Name = "SkrivUtDiagram2Btn";
            this.SkrivUtDiagram2Btn.Size = new System.Drawing.Size(96, 54);
            this.SkrivUtDiagram2Btn.TabIndex = 13;
            this.SkrivUtDiagram2Btn.Text = "Skriv ut diagram";
            this.SkrivUtDiagram2Btn.UseVisualStyleBackColor = false;
            this.SkrivUtDiagram2Btn.Click += new System.EventHandler(this.SkrivUtDiagram2Btn_Click);
            // 
            // ChartFeilmld2Lbl
            // 
            this.DiagramFeilmld2Lbl.AutoSize = true;
            this.DiagramFeilmld2Lbl.Location = new System.Drawing.Point(567, 255);
            this.DiagramFeilmld2Lbl.Name = "ChartFeilmld2Lbl";
            this.DiagramFeilmld2Lbl.Size = new System.Drawing.Size(83, 13);
            this.DiagramFeilmld2Lbl.TabIndex = 14;
            this.DiagramFeilmld2Lbl.Text = "chart feilmelding";
            // 
            // MyCoursesHeader
            // 
            this.MyCoursesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyCoursesHeader.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.MyCoursesHeader.Location = new System.Drawing.Point(0, 0);
            this.MyCoursesHeader.Name = "MyCoursesHeader";
            this.MyCoursesHeader.Size = new System.Drawing.Size(1008, 48);
            this.MyCoursesHeader.TabIndex = 0;
            this.MyCoursesHeader.Text = "Sammenlign to fag";
            this.MyCoursesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiagramFeilmld2Lbl);
            this.Controls.Add(this.SkrivUtDiagram2Btn);
            this.Controls.Add(this.LagreDiagram2Btn);
            this.Controls.Add(this.FagkodeDiagram2);
            this.Controls.Add(this.LagreDiagram1Btn);
            this.Controls.Add(this.SkrivUtDiagram1Btn);
            this.Controls.Add(this.FagkodeDiagram1);
            this.Controls.Add(this.DiagramFeilmldLbl);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MyCoursesPanel);
            this.Controls.Add(this.MyCoursesHeader);
            this.Name = "MyCourses";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.MyCourses_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FagkodeDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FagkodeDiagram2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MyCoursesPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label DiagramFeilmldLbl;
        private System.Windows.Forms.Label SammenlignLbl;
        private System.Windows.Forms.Label Fagkode1lbl;
        private System.Windows.Forms.Label FagkodeNr2Lbl;
        private System.Windows.Forms.TextBox FagkodeNr2;
        private System.Windows.Forms.TextBox FagkodeNr1;
        private System.Windows.Forms.Button SammenlignFagBtn;
        private System.Windows.Forms.Label SammenlignFeilmldLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart FagkodeDiagram1;
        private System.Windows.Forms.Button SkrivUtDiagram1Btn;
        private System.Windows.Forms.Button LagreDiagram1Btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart FagkodeDiagram2;
        private System.Windows.Forms.Button LagreDiagram2Btn;
        private System.Windows.Forms.Button SkrivUtDiagram2Btn;
        private System.Windows.Forms.Label DiagramFeilmld2Lbl;
        private System.Windows.Forms.Label MyCoursesHeader;
    }
}
