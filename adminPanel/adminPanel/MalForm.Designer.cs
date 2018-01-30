namespace adminPanel
{
    partial class MalForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.verktøyLinje = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skrivUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avsluttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verktøyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLEditorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikkOgDiagrammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vurderingsskjemaerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verktøyLinje.SuspendLayout();
            this.SuspendLayout();
            // 
            // verktøyLinje
            // 
            this.verktøyLinje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem,
            this.verktøyToolStripMenuItem,
            this.hjelpToolStripMenuItem});
            this.verktøyLinje.Location = new System.Drawing.Point(0, 0);
            this.verktøyLinje.Name = "verktøyLinje";
            this.verktøyLinje.Size = new System.Drawing.Size(1184, 24);
            this.verktøyLinje.TabIndex = 0;
            this.verktøyLinje.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lagreToolStripMenuItem,
            this.skrivUtToolStripMenuItem,
            this.avsluttToolStripMenuItem});
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.filToolStripMenuItem.Text = "Fil";
            // 
            // skrivUtToolStripMenuItem
            // 
            this.skrivUtToolStripMenuItem.Name = "skrivUtToolStripMenuItem";
            this.skrivUtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.skrivUtToolStripMenuItem.Text = "Skriv ut";
            // 
            // avsluttToolStripMenuItem
            // 
            this.avsluttToolStripMenuItem.Name = "avsluttToolStripMenuItem";
            this.avsluttToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.avsluttToolStripMenuItem.Text = "Avslutt";
            this.avsluttToolStripMenuItem.Click += new System.EventHandler(this.avsluttToolStripMenuItem_Click);
            // 
            // lagreToolStripMenuItem
            // 
            this.lagreToolStripMenuItem.Name = "lagreToolStripMenuItem";
            this.lagreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lagreToolStripMenuItem.Text = "Lagre";
            // 
            // hjelpToolStripMenuItem
            // 
            this.hjelpToolStripMenuItem.Name = "hjelpToolStripMenuItem";
            this.hjelpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjelpToolStripMenuItem.Text = "Hjelp";
            this.hjelpToolStripMenuItem.Click += new System.EventHandler(this.hjelpToolStripMenuItem_Click);
            // 
            // verktøyToolStripMenuItem
            // 
            this.verktøyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLEditorToolStripMenuItem1,
            this.statistikkOgDiagrammerToolStripMenuItem,
            this.vurderingsskjemaerToolStripMenuItem});
            this.verktøyToolStripMenuItem.Name = "verktøyToolStripMenuItem";
            this.verktøyToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.verktøyToolStripMenuItem.Text = "Verktøy";
            // 
            // sQLEditorToolStripMenuItem1
            // 
            this.sQLEditorToolStripMenuItem1.Name = "sQLEditorToolStripMenuItem1";
            this.sQLEditorToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.sQLEditorToolStripMenuItem1.Text = "SQL Editor";
            this.sQLEditorToolStripMenuItem1.Click += new System.EventHandler(this.sQLEditorToolStripMenuItem1_Click);
            // 
            // statistikkOgDiagrammerToolStripMenuItem
            // 
            this.statistikkOgDiagrammerToolStripMenuItem.Name = "statistikkOgDiagrammerToolStripMenuItem";
            this.statistikkOgDiagrammerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.statistikkOgDiagrammerToolStripMenuItem.Text = "Statistikk og diagrammer";
            this.statistikkOgDiagrammerToolStripMenuItem.Click += new System.EventHandler(this.statistikkOgDiagrammerToolStripMenuItem_Click);
            // 
            // vurderingsskjemaerToolStripMenuItem
            // 
            this.vurderingsskjemaerToolStripMenuItem.Name = "vurderingsskjemaerToolStripMenuItem";
            this.vurderingsskjemaerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.vurderingsskjemaerToolStripMenuItem.Text = "Vurderingsskjemaer";
            this.vurderingsskjemaerToolStripMenuItem.Click += new System.EventHandler(this.vurderingsskjemaerToolStripMenuItem_Click);
            // 
            // MalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.verktøyLinje);
            this.MainMenuStrip = this.verktøyLinje;
            this.Name = "MalForm";
            this.Text = "MalForm";
            this.verktøyLinje.ResumeLayout(false);
            this.verktøyLinje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip verktøyLinje;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skrivUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avsluttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verktøyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLEditorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statistikkOgDiagrammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vurderingsskjemaerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjelpToolStripMenuItem;
    }
}