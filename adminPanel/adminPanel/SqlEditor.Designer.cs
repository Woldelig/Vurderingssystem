namespace adminPanel
{
    partial class SqlEditor
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
            this.sqlTxt = new System.Windows.Forms.TextBox();
            this.sqlBtn = new System.Windows.Forms.Button();
            this.sqlDatagrid = new System.Windows.Forms.DataGridView();
            this.feilmeldingTxt = new System.Windows.Forms.Label();
            this.LagreXmlBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlTxt
            // 
            this.sqlTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlTxt.Location = new System.Drawing.Point(108, 466);
            this.sqlTxt.Multiline = true;
            this.sqlTxt.Name = "sqlTxt";
            this.sqlTxt.Size = new System.Drawing.Size(535, 89);
            this.sqlTxt.TabIndex = 0;
            // 
            // sqlBtn
            // 
            this.sqlBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sqlBtn.FlatAppearance.BorderSize = 0;
            this.sqlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlBtn.Location = new System.Drawing.Point(649, 466);
            this.sqlBtn.Name = "sqlBtn";
            this.sqlBtn.Size = new System.Drawing.Size(176, 90);
            this.sqlBtn.TabIndex = 1;
            this.sqlBtn.Text = "Kjør SQL";
            this.sqlBtn.UseVisualStyleBackColor = false;
            this.sqlBtn.Click += new System.EventHandler(this.sqlBtn_Click);
            // 
            // sqlDatagrid
            // 
            this.sqlDatagrid.AllowUserToAddRows = false;
            this.sqlDatagrid.AllowUserToDeleteRows = false;
            this.sqlDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlDatagrid.Location = new System.Drawing.Point(108, 63);
            this.sqlDatagrid.Name = "sqlDatagrid";
            this.sqlDatagrid.ReadOnly = true;
            this.sqlDatagrid.Size = new System.Drawing.Size(717, 372);
            this.sqlDatagrid.TabIndex = 2;
            // 
            // feilmeldingTxt
            // 
            this.feilmeldingTxt.AutoSize = true;
            this.feilmeldingTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feilmeldingTxt.Location = new System.Drawing.Point(245, 575);
            this.feilmeldingTxt.Name = "feilmeldingTxt";
            this.feilmeldingTxt.Size = new System.Drawing.Size(0, 25);
            this.feilmeldingTxt.TabIndex = 3;
            // 
            // LagreXmlBtn
            // 
            this.LagreXmlBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LagreXmlBtn.FlatAppearance.BorderSize = 0;
            this.LagreXmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LagreXmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LagreXmlBtn.Location = new System.Drawing.Point(108, 575);
            this.LagreXmlBtn.Name = "LagreXmlBtn";
            this.LagreXmlBtn.Size = new System.Drawing.Size(119, 34);
            this.LagreXmlBtn.TabIndex = 5;
            this.LagreXmlBtn.Text = "Lagre til xml";
            this.LagreXmlBtn.UseVisualStyleBackColor = false;
            this.LagreXmlBtn.Click += new System.EventHandler(this.LagreXmlBtn_Click);
            // 
            // SqlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LagreXmlBtn);
            this.Controls.Add(this.feilmeldingTxt);
            this.Controls.Add(this.sqlDatagrid);
            this.Controls.Add(this.sqlBtn);
            this.Controls.Add(this.sqlTxt);
            this.Name = "SqlEditor";
            this.Size = new System.Drawing.Size(1008, 627);
            ((System.ComponentModel.ISupportInitialize)(this.sqlDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqlTxt;
        private System.Windows.Forms.Button sqlBtn;
        private System.Windows.Forms.DataGridView sqlDatagrid;
        private System.Windows.Forms.Label feilmeldingTxt;
        private System.Windows.Forms.Button LagreXmlBtn;
    }
}
