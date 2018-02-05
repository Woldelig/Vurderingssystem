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
            this.fagkodeLbl = new System.Windows.Forms.Label();
            this.spmLbl = new System.Windows.Forms.Label();
            this.diagramLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // fagkodeListeboks
            // 
            this.fagkodeListeboks.FormattingEnabled = true;
            this.fagkodeListeboks.ItemHeight = 16;
            this.fagkodeListeboks.Location = new System.Drawing.Point(89, 68);
            this.fagkodeListeboks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fagkodeListeboks.Name = "fagkodeListeboks";
            this.fagkodeListeboks.Size = new System.Drawing.Size(159, 132);
            this.fagkodeListeboks.TabIndex = 0;
            this.fagkodeListeboks.SelectedIndexChanged += new System.EventHandler(this.fagkodeListeboks_SelectedIndexChanged);
            // 
            // spmListeboks
            // 
            this.spmListeboks.FormattingEnabled = true;
            this.spmListeboks.ItemHeight = 16;
            this.spmListeboks.Location = new System.Drawing.Point(329, 68);
            this.spmListeboks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spmListeboks.Name = "spmListeboks";
            this.spmListeboks.Size = new System.Drawing.Size(159, 132);
            this.spmListeboks.TabIndex = 1;
            this.spmListeboks.SelectedIndexChanged += new System.EventHandler(this.spmListeboks_SelectedIndexChanged);
            // 
            // diagramListeboks
            // 
            this.diagramListeboks.FormattingEnabled = true;
            this.diagramListeboks.ItemHeight = 16;
            this.diagramListeboks.Location = new System.Drawing.Point(569, 68);
            this.diagramListeboks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diagramListeboks.Name = "diagramListeboks";
            this.diagramListeboks.Size = new System.Drawing.Size(159, 132);
            this.diagramListeboks.TabIndex = 2;
            this.diagramListeboks.SelectedIndexChanged += new System.EventHandler(this.diagramListeboks_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(89, 236);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1136, 465);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // fagkodeLbl
            // 
            this.fagkodeLbl.AutoSize = true;
            this.fagkodeLbl.Location = new System.Drawing.Point(85, 48);
            this.fagkodeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fagkodeLbl.Name = "fagkodeLbl";
            this.fagkodeLbl.Size = new System.Drawing.Size(95, 17);
            this.fagkodeLbl.TabIndex = 4;
            this.fagkodeLbl.Text = "Velg fagkode:";
            // 
            // spmLbl
            // 
            this.spmLbl.AutoSize = true;
            this.spmLbl.Location = new System.Drawing.Point(325, 48);
            this.spmLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spmLbl.Name = "spmLbl";
            this.spmLbl.Size = new System.Drawing.Size(101, 17);
            this.spmLbl.TabIndex = 5;
            this.spmLbl.Text = "Velg spørsmål:";
            // 
            // diagramLbl
            // 
            this.diagramLbl.AutoSize = true;
            this.diagramLbl.Location = new System.Drawing.Point(565, 48);
            this.diagramLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diagramLbl.Name = "diagramLbl";
            this.diagramLbl.Size = new System.Drawing.Size(122, 17);
            this.diagramLbl.TabIndex = 6;
            this.diagramLbl.Text = "Velg diagramtype:";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.diagramLbl);
            this.Controls.Add(this.spmLbl);
            this.Controls.Add(this.fagkodeLbl);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.diagramListeboks);
            this.Controls.Add(this.spmListeboks);
            this.Controls.Add(this.fagkodeListeboks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(1344, 772);
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
        private System.Windows.Forms.Label fagkodeLbl;
        private System.Windows.Forms.Label spmLbl;
        private System.Windows.Forms.Label diagramLbl;
    }
}
