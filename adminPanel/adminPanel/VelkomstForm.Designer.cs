namespace adminPanel
{
    partial class VelkomstForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.mineFagBtn = new System.Windows.Forms.Button();
            this.sqlBtn = new System.Windows.Forms.Button();
            this.diagramBtn = new System.Windows.Forms.Button();
            this.vurderingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Velg en oppgave";
            // 
            // mineFagBtn
            // 
            this.mineFagBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mineFagBtn.Location = new System.Drawing.Point(65, 208);
            this.mineFagBtn.Name = "mineFagBtn";
            this.mineFagBtn.Size = new System.Drawing.Size(212, 206);
            this.mineFagBtn.TabIndex = 2;
            this.mineFagBtn.Text = "Mine fag";
            this.mineFagBtn.UseVisualStyleBackColor = true;
            this.mineFagBtn.Click += new System.EventHandler(this.mineFagBtn_Click);
            // 
            // sqlBtn
            // 
            this.sqlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlBtn.Location = new System.Drawing.Point(332, 208);
            this.sqlBtn.Name = "sqlBtn";
            this.sqlBtn.Size = new System.Drawing.Size(212, 206);
            this.sqlBtn.TabIndex = 3;
            this.sqlBtn.Text = "SQL editor";
            this.sqlBtn.UseVisualStyleBackColor = true;
            this.sqlBtn.Click += new System.EventHandler(this.sqlBtn_Click);
            // 
            // diagramBtn
            // 
            this.diagramBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagramBtn.Location = new System.Drawing.Point(597, 208);
            this.diagramBtn.Name = "diagramBtn";
            this.diagramBtn.Size = new System.Drawing.Size(212, 206);
            this.diagramBtn.TabIndex = 4;
            this.diagramBtn.Text = "Visualisering\r\n og diagramer";
            this.diagramBtn.UseVisualStyleBackColor = true;
            this.diagramBtn.Click += new System.EventHandler(this.diagramBtn_Click);
            // 
            // vurderingsBtn
            // 
            this.vurderingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vurderingsBtn.Location = new System.Drawing.Point(866, 208);
            this.vurderingsBtn.Name = "vurderingsBtn";
            this.vurderingsBtn.Size = new System.Drawing.Size(212, 206);
            this.vurderingsBtn.TabIndex = 5;
            this.vurderingsBtn.Text = "Vurderings\r\nskjemaer";
            this.vurderingsBtn.UseVisualStyleBackColor = true;
            this.vurderingsBtn.Click += new System.EventHandler(this.vurderingsBtn_Click);
            // 
            // VelkomstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.vurderingsBtn);
            this.Controls.Add(this.diagramBtn);
            this.Controls.Add(this.sqlBtn);
            this.Controls.Add(this.mineFagBtn);
            this.Controls.Add(this.label1);
            this.Name = "VelkomstForm";
            this.Text = "VMS Kontrollpanel";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.mineFagBtn, 0);
            this.Controls.SetChildIndex(this.sqlBtn, 0);
            this.Controls.SetChildIndex(this.diagramBtn, 0);
            this.Controls.SetChildIndex(this.vurderingsBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mineFagBtn;
        private System.Windows.Forms.Button sqlBtn;
        private System.Windows.Forms.Button diagramBtn;
        private System.Windows.Forms.Button vurderingsBtn;
    }
}
