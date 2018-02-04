namespace adminPanel
{
    partial class Stats
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
            this.fagkodeListeboks = new System.Windows.Forms.ListBox();
            this.spmListeboks = new System.Windows.Forms.ListBox();
            this.diagramListeboks = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // fagkodeListeboks
            // 
            this.fagkodeListeboks.FormattingEnabled = true;
            this.fagkodeListeboks.Location = new System.Drawing.Point(67, 55);
            this.fagkodeListeboks.Name = "fagkodeListeboks";
            this.fagkodeListeboks.Size = new System.Drawing.Size(120, 108);
            this.fagkodeListeboks.TabIndex = 0;
            this.fagkodeListeboks.SelectedIndexChanged += new System.EventHandler(this.fagkodeListeboks_SelectedIndexChanged);
            // 
            // spmListeboks
            // 
            this.spmListeboks.FormattingEnabled = true;
            this.spmListeboks.Location = new System.Drawing.Point(247, 55);
            this.spmListeboks.Name = "spmListeboks";
            this.spmListeboks.Size = new System.Drawing.Size(120, 108);
            this.spmListeboks.TabIndex = 1;
            this.spmListeboks.SelectedIndexChanged += new System.EventHandler(this.spmListeboks_SelectedIndexChanged);
            // 
            // diagramListeboks
            // 
            this.diagramListeboks.FormattingEnabled = true;
            this.diagramListeboks.Location = new System.Drawing.Point(427, 55);
            this.diagramListeboks.Name = "diagramListeboks";
            this.diagramListeboks.Size = new System.Drawing.Size(120, 108);
            this.diagramListeboks.TabIndex = 2;
            this.diagramListeboks.SelectedIndexChanged += new System.EventHandler(this.diagramListeboks_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(67, 192);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(852, 378);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Velg fagkode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Velg spørsmål:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Velg diagramtype:";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.diagramListeboks);
            this.Controls.Add(this.spmListeboks);
            this.Controls.Add(this.fagkodeListeboks);
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.Stats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fagkodeListeboks;
        private System.Windows.Forms.ListBox spmListeboks;
        private System.Windows.Forms.ListBox diagramListeboks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
