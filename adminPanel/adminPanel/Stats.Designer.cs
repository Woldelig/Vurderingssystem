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
            this.fagkodeListeboks = new System.Windows.Forms.ListBox();
            this.spmListeboks = new System.Windows.Forms.ListBox();
            this.diagramListeboks = new System.Windows.Forms.ListBox();
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
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.diagramListeboks);
            this.Controls.Add(this.spmListeboks);
            this.Controls.Add(this.fagkodeListeboks);
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(1008, 627);
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fagkodeListeboks;
        private System.Windows.Forms.ListBox spmListeboks;
        private System.Windows.Forms.ListBox diagramListeboks;
    }
}
