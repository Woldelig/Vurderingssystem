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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fagkodeListeboks = new System.Windows.Forms.ListBox();
            this.spmListeboks = new System.Windows.Forms.ListBox();
            this.diagramListeboks = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fagkodeLbl = new System.Windows.Forms.Label();
            this.spmLbl = new System.Windows.Forms.Label();
            this.diagramLbl = new System.Windows.Forms.Label();
            this.clearListeboxBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.lagreChartBtn = new System.Windows.Forms.Button();
            this.FeilmeldingsLbl = new System.Windows.Forms.Label();
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
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(67, 192);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(852, 378);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // fagkodeLbl
            // 
            this.fagkodeLbl.AutoSize = true;
            this.fagkodeLbl.Location = new System.Drawing.Point(64, 39);
            this.fagkodeLbl.Name = "fagkodeLbl";
            this.fagkodeLbl.Size = new System.Drawing.Size(73, 13);
            this.fagkodeLbl.TabIndex = 4;
            this.fagkodeLbl.Text = "Velg fagkode:";
            // 
            // spmLbl
            // 
            this.spmLbl.AutoSize = true;
            this.spmLbl.Location = new System.Drawing.Point(244, 39);
            this.spmLbl.Name = "spmLbl";
            this.spmLbl.Size = new System.Drawing.Size(75, 13);
            this.spmLbl.TabIndex = 5;
            this.spmLbl.Text = "Velg spørsmål:";
            // 
            // diagramLbl
            // 
            this.diagramLbl.AutoSize = true;
            this.diagramLbl.Location = new System.Drawing.Point(424, 39);
            this.diagramLbl.Name = "diagramLbl";
            this.diagramLbl.Size = new System.Drawing.Size(91, 13);
            this.diagramLbl.TabIndex = 6;
            this.diagramLbl.Text = "Velg diagramtype:";
            // 
            // clearListeboxBtn
            // 
            this.clearListeboxBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearListeboxBtn.Location = new System.Drawing.Point(553, 55);
            this.clearListeboxBtn.Name = "clearListeboxBtn";
            this.clearListeboxBtn.Size = new System.Drawing.Size(96, 54);
            this.clearListeboxBtn.TabIndex = 7;
            this.clearListeboxBtn.Text = "Tøm filtere";
            this.clearListeboxBtn.UseVisualStyleBackColor = false;
            this.clearListeboxBtn.Click += new System.EventHandler(this.clearListeboxBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printBtn.Location = new System.Drawing.Point(654, 55);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(96, 54);
            this.printBtn.TabIndex = 8;
            this.printBtn.Text = "Skriv ut diagram";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // lagreChartBtn
            // 
            this.lagreChartBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lagreChartBtn.Location = new System.Drawing.Point(553, 115);
            this.lagreChartBtn.Name = "lagreChartBtn";
            this.lagreChartBtn.Size = new System.Drawing.Size(96, 54);
            this.lagreChartBtn.TabIndex = 9;
            this.lagreChartBtn.Text = "Lagre diagram";
            this.lagreChartBtn.UseVisualStyleBackColor = false;
            this.lagreChartBtn.Click += new System.EventHandler(this.lagreChartBtn_Click);
            // 
            // FeilmeldingsLbl
            // 
            this.FeilmeldingsLbl.AutoSize = true;
            this.FeilmeldingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeilmeldingsLbl.Location = new System.Drawing.Point(77, 591);
            this.FeilmeldingsLbl.Name = "FeilmeldingsLbl";
            this.FeilmeldingsLbl.Size = new System.Drawing.Size(0, 25);
            this.FeilmeldingsLbl.TabIndex = 10;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FeilmeldingsLbl);
            this.Controls.Add(this.lagreChartBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.clearListeboxBtn);
            this.Controls.Add(this.diagramLbl);
            this.Controls.Add(this.spmLbl);
            this.Controls.Add(this.fagkodeLbl);
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
        private System.Windows.Forms.Label fagkodeLbl;
        private System.Windows.Forms.Label spmLbl;
        private System.Windows.Forms.Label diagramLbl;
        private System.Windows.Forms.Button clearListeboxBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button lagreChartBtn;
        private System.Windows.Forms.Label FeilmeldingsLbl;
    }
}
