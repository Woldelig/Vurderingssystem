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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FagkodeListbox = new System.Windows.Forms.ListBox();
            this.FagkodeSammenlignesListebox = new System.Windows.Forms.ListBox();
            this.Fra1Til2Btn = new System.Windows.Forms.Button();
            this.Fra2Til1Btn = new System.Windows.Forms.Button();
            this.SpmListeboks = new System.Windows.Forms.ListBox();
            this.diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lagreDiagramBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.ClearDiagramBtn = new System.Windows.Forms.Button();
            this.UpdateDiagramBtn = new System.Windows.Forms.Button();
            this.ResetListboxBtn = new System.Windows.Forms.Button();
            this.FeilmldLbl = new System.Windows.Forms.Label();
            this.LeggTilAlleBtn = new System.Windows.Forms.Button();
            this.FagkodeListeboxLbl = new System.Windows.Forms.Label();
            this.FagkodeSammenligensLbl = new System.Windows.Forms.Label();
            this.SpmListeboxLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // FagkodeListbox
            // 
            this.FagkodeListbox.FormattingEnabled = true;
            this.FagkodeListbox.Location = new System.Drawing.Point(61, 43);
            this.FagkodeListbox.Name = "FagkodeListbox";
            this.FagkodeListbox.Size = new System.Drawing.Size(139, 108);
            this.FagkodeListbox.TabIndex = 0;
            // 
            // FagkodeSammenlignesListebox
            // 
            this.FagkodeSammenlignesListebox.FormattingEnabled = true;
            this.FagkodeSammenlignesListebox.Location = new System.Drawing.Point(311, 43);
            this.FagkodeSammenlignesListebox.Name = "FagkodeSammenlignesListebox";
            this.FagkodeSammenlignesListebox.Size = new System.Drawing.Size(139, 108);
            this.FagkodeSammenlignesListebox.TabIndex = 1;
            // 
            // Fra1Til2Btn
            // 
            this.Fra1Til2Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Fra1Til2Btn.Location = new System.Drawing.Point(218, 43);
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
            this.Fra2Til1Btn.Location = new System.Drawing.Point(218, 128);
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
            chartArea2.Name = "ChartArea1";
            this.diagram.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.diagram.Legends.Add(legend2);
            this.diagram.Location = new System.Drawing.Point(61, 197);
            this.diagram.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.diagram.Series.Add(series2);
            this.diagram.Size = new System.Drawing.Size(718, 413);
            this.diagram.TabIndex = 5;
            this.diagram.Text = "chart1";
            // 
            // lagreChartBtn
            // 
            this.lagreDiagramBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lagreDiagramBtn.Location = new System.Drawing.Point(851, 257);
            this.lagreDiagramBtn.Name = "lagreChartBtn";
            this.lagreDiagramBtn.Size = new System.Drawing.Size(105, 54);
            this.lagreDiagramBtn.TabIndex = 11;
            this.lagreDiagramBtn.Text = "Lagre diagram";
            this.lagreDiagramBtn.UseVisualStyleBackColor = false;
            this.lagreDiagramBtn.Click += new System.EventHandler(this.LagreChartBtn_Click);
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
            this.printBtn.Click += new System.EventHandler(this.PrintBtn_Click);
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
            this.ResetListboxBtn.Location = new System.Drawing.Point(218, 99);
            this.ResetListboxBtn.Name = "ResetListboxBtn";
            this.ResetListboxBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetListboxBtn.TabIndex = 15;
            this.ResetListboxBtn.Text = "Fjern alle";
            this.ResetListboxBtn.UseVisualStyleBackColor = false;
            this.ResetListboxBtn.Click += new System.EventHandler(this.ResetListboxBtn_Click);
            // 
            // FeilmldLbl
            // 
            this.FeilmldLbl.AutoSize = true;
            this.FeilmldLbl.Location = new System.Drawing.Point(809, 597);
            this.FeilmldLbl.Name = "FeilmldLbl";
            this.FeilmldLbl.Size = new System.Drawing.Size(70, 13);
            this.FeilmldLbl.TabIndex = 16;
            this.FeilmldLbl.Text = "feilmeldingLbl";
            // 
            // LeggTilAlleBtn
            // 
            this.LeggTilAlleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeggTilAlleBtn.Location = new System.Drawing.Point(218, 70);
            this.LeggTilAlleBtn.Name = "LeggTilAlleBtn";
            this.LeggTilAlleBtn.Size = new System.Drawing.Size(75, 23);
            this.LeggTilAlleBtn.TabIndex = 17;
            this.LeggTilAlleBtn.Text = "Legg til alle";
            this.LeggTilAlleBtn.UseVisualStyleBackColor = false;
            this.LeggTilAlleBtn.Click += new System.EventHandler(this.LeggTilAlleBtn_Click);
            // 
            // FagkodeListeboxLbl
            // 
            this.FagkodeListeboxLbl.AutoSize = true;
            this.FagkodeListeboxLbl.Location = new System.Drawing.Point(58, 27);
            this.FagkodeListeboxLbl.Name = "FagkodeListeboxLbl";
            this.FagkodeListeboxLbl.Size = new System.Drawing.Size(55, 13);
            this.FagkodeListeboxLbl.TabIndex = 18;
            this.FagkodeListeboxLbl.Text = "Fagkoder:";
            // 
            // FagkodeSammenligensLbl
            // 
            this.FagkodeSammenligensLbl.AutoSize = true;
            this.FagkodeSammenligensLbl.Location = new System.Drawing.Point(308, 27);
            this.FagkodeSammenligensLbl.Name = "FagkodeSammenligensLbl";
            this.FagkodeSammenligensLbl.Size = new System.Drawing.Size(146, 13);
            this.FagkodeSammenligensLbl.TabIndex = 19;
            this.FagkodeSammenligensLbl.Text = "Fagkoder som sammenlignes:";
            // 
            // SpmListeboxLbl
            // 
            this.SpmListeboxLbl.AutoSize = true;
            this.SpmListeboxLbl.Location = new System.Drawing.Point(574, 27);
            this.SpmListeboxLbl.Name = "SpmListeboxLbl";
            this.SpmListeboxLbl.Size = new System.Drawing.Size(53, 13);
            this.SpmListeboxLbl.TabIndex = 20;
            this.SpmListeboxLbl.Text = "Spørsmål:";
            // 
            // SammenlignFlereFagkoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpmListeboxLbl);
            this.Controls.Add(this.FagkodeSammenligensLbl);
            this.Controls.Add(this.FagkodeListeboxLbl);
            this.Controls.Add(this.LeggTilAlleBtn);
            this.Controls.Add(this.FeilmldLbl);
            this.Controls.Add(this.ResetListboxBtn);
            this.Controls.Add(this.UpdateDiagramBtn);
            this.Controls.Add(this.ClearDiagramBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.lagreDiagramBtn);
            this.Controls.Add(this.diagram);
            this.Controls.Add(this.SpmListeboks);
            this.Controls.Add(this.Fra2Til1Btn);
            this.Controls.Add(this.Fra1Til2Btn);
            this.Controls.Add(this.FagkodeSammenlignesListebox);
            this.Controls.Add(this.FagkodeListbox);
            this.Name = "SammenlignFlereFagkoder";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.SammenlignFlereFagkoder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FagkodeListbox;
        private System.Windows.Forms.ListBox FagkodeSammenlignesListebox;
        private System.Windows.Forms.Button Fra1Til2Btn;
        private System.Windows.Forms.Button Fra2Til1Btn;
        private System.Windows.Forms.ListBox SpmListeboks;
        private System.Windows.Forms.DataVisualization.Charting.Chart diagram;
        private System.Windows.Forms.Button lagreDiagramBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button ClearDiagramBtn;
        private System.Windows.Forms.Button UpdateDiagramBtn;
        private System.Windows.Forms.Button ResetListboxBtn;
        private System.Windows.Forms.Label FeilmldLbl;
        private System.Windows.Forms.Button LeggTilAlleBtn;
        private System.Windows.Forms.Label FagkodeListeboxLbl;
        private System.Windows.Forms.Label FagkodeSammenligensLbl;
        private System.Windows.Forms.Label SpmListeboxLbl;
    }
}
