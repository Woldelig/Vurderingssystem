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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FagkodeListbox = new System.Windows.Forms.ListBox();
            this.FagkodeSammenlignesListebox = new System.Windows.Forms.ListBox();
            this.Fra1Til2Btn = new System.Windows.Forms.Button();
            this.Fra2Til1Btn = new System.Windows.Forms.Button();
            this.SpmListeboks = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lagreChartBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.ClearDiagramBtn = new System.Windows.Forms.Button();
            this.UpdateDiagramBtn = new System.Windows.Forms.Button();
            this.ResetListboxBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // FagkodeListbox
            // 
            this.FagkodeListbox.FormattingEnabled = true;
            this.FagkodeListbox.Location = new System.Drawing.Point(61, 43);
            this.FagkodeListbox.Name = "FagkodeListbox";
            this.FagkodeListbox.Size = new System.Drawing.Size(120, 108);
            this.FagkodeListbox.TabIndex = 0;
            // 
            // FagkodeSammenlignesListebox
            // 
            this.FagkodeSammenlignesListebox.FormattingEnabled = true;
            this.FagkodeSammenlignesListebox.Location = new System.Drawing.Point(311, 43);
            this.FagkodeSammenlignesListebox.Name = "FagkodeSammenlignesListebox";
            this.FagkodeSammenlignesListebox.Size = new System.Drawing.Size(120, 108);
            this.FagkodeSammenlignesListebox.TabIndex = 1;
            // 
            // Fra1Til2Btn
            // 
            this.Fra1Til2Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Fra1Til2Btn.Location = new System.Drawing.Point(206, 43);
            this.Fra1Til2Btn.Name = "Fra1Til2Btn";
            this.Fra1Til2Btn.Size = new System.Drawing.Size(75, 23);
            this.Fra1Til2Btn.TabIndex = 2;
            this.Fra1Til2Btn.Text = ">>";
            this.Fra1Til2Btn.UseVisualStyleBackColor = false;
            this.Fra1Til2Btn.Click += new System.EventHandler(this.Fra1Til2Btn_Click);
            // 
            // Fra2Til1Btn
            // 
            this.Fra2Til1Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Fra2Til1Btn.Location = new System.Drawing.Point(206, 128);
            this.Fra2Til1Btn.Name = "Fra2Til1Btn";
            this.Fra2Til1Btn.Size = new System.Drawing.Size(75, 23);
            this.Fra2Til1Btn.TabIndex = 3;
            this.Fra2Til1Btn.Text = "<<";
            this.Fra2Til1Btn.UseVisualStyleBackColor = false;
            this.Fra2Til1Btn.Click += new System.EventHandler(this.Fra2Til1Btn_Click);
            // 
            // SpmListeboks
            // 
            this.SpmListeboks.FormattingEnabled = true;
            this.SpmListeboks.Location = new System.Drawing.Point(577, 43);
            this.SpmListeboks.Name = "SpmListeboks";
            this.SpmListeboks.Size = new System.Drawing.Size(120, 95);
            this.SpmListeboks.TabIndex = 4;
            this.SpmListeboks.SelectedIndexChanged += new System.EventHandler(this.SpmListeboks_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(61, 197);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(718, 413);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // lagreChartBtn
            // 
            this.lagreChartBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lagreChartBtn.Location = new System.Drawing.Point(851, 257);
            this.lagreChartBtn.Name = "lagreChartBtn";
            this.lagreChartBtn.Size = new System.Drawing.Size(105, 54);
            this.lagreChartBtn.TabIndex = 11;
            this.lagreChartBtn.Text = "Lagre diagram";
            this.lagreChartBtn.UseVisualStyleBackColor = false;
            this.lagreChartBtn.Click += new System.EventHandler(this.lagreChartBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printBtn.Location = new System.Drawing.Point(851, 317);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(105, 54);
            this.printBtn.TabIndex = 12;
            this.printBtn.Text = "Skriv ut diagram";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // ClearDiagramBtn
            // 
            this.ClearDiagramBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearDiagramBtn.Location = new System.Drawing.Point(851, 377);
            this.ClearDiagramBtn.Name = "ClearDiagramBtn";
            this.ClearDiagramBtn.Size = new System.Drawing.Size(105, 54);
            this.ClearDiagramBtn.TabIndex = 13;
            this.ClearDiagramBtn.Text = "Tøm diagram";
            this.ClearDiagramBtn.UseVisualStyleBackColor = false;
            this.ClearDiagramBtn.Click += new System.EventHandler(this.ClearDiagramBtn_Click);
            // 
            // UpdateDiagramBtn
            // 
            this.UpdateDiagramBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateDiagramBtn.Location = new System.Drawing.Point(851, 197);
            this.UpdateDiagramBtn.Name = "UpdateDiagramBtn";
            this.UpdateDiagramBtn.Size = new System.Drawing.Size(105, 54);
            this.UpdateDiagramBtn.TabIndex = 14;
            this.UpdateDiagramBtn.Text = "Oppdater diagram";
            this.UpdateDiagramBtn.UseVisualStyleBackColor = false;
            this.UpdateDiagramBtn.Click += new System.EventHandler(this.UpdateDiagramBtn_Click);
            // 
            // ResetListboxBtn
            // 
            this.ResetListboxBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResetListboxBtn.Location = new System.Drawing.Point(206, 87);
            this.ResetListboxBtn.Name = "ResetListboxBtn";
            this.ResetListboxBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetListboxBtn.TabIndex = 15;
            this.ResetListboxBtn.Text = "Reset";
            this.ResetListboxBtn.UseVisualStyleBackColor = false;
            this.ResetListboxBtn.Click += new System.EventHandler(this.ResetListboxBtn_Click);
            // 
            // SammenlignFlereFagkoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResetListboxBtn);
            this.Controls.Add(this.UpdateDiagramBtn);
            this.Controls.Add(this.ClearDiagramBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.lagreChartBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.SpmListeboks);
            this.Controls.Add(this.Fra2Til1Btn);
            this.Controls.Add(this.Fra1Til2Btn);
            this.Controls.Add(this.FagkodeSammenlignesListebox);
            this.Controls.Add(this.FagkodeListbox);
            this.Name = "SammenlignFlereFagkoder";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.SammenlignFlereFagkoder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FagkodeListbox;
        private System.Windows.Forms.ListBox FagkodeSammenlignesListebox;
        private System.Windows.Forms.Button Fra1Til2Btn;
        private System.Windows.Forms.Button Fra2Til1Btn;
        private System.Windows.Forms.ListBox SpmListeboks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button lagreChartBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button ClearDiagramBtn;
        private System.Windows.Forms.Button UpdateDiagramBtn;
        private System.Windows.Forms.Button ResetListboxBtn;
    }
}
