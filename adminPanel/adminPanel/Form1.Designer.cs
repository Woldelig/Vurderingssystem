namespace adminPanel
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.brukernavnText = new System.Windows.Forms.TextBox();
            this.passordText = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.feilmelding = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brukernavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passord";
            // 
            // brukernavnText
            // 
            this.brukernavnText.Location = new System.Drawing.Point(302, 191);
            this.brukernavnText.Name = "brukernavnText";
            this.brukernavnText.Size = new System.Drawing.Size(100, 20);
            this.brukernavnText.TabIndex = 2;
            // 
            // passordText
            // 
            this.passordText.Location = new System.Drawing.Point(302, 252);
            this.passordText.Name = "passordText";
            this.passordText.PasswordChar = '*';
            this.passordText.Size = new System.Drawing.Size(100, 20);
            this.passordText.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(302, 286);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 28);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Logg inn";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // feilmelding
            // 
            this.feilmelding.AutoSize = true;
            this.feilmelding.Location = new System.Drawing.Point(302, 317);
            this.feilmelding.Name = "feilmelding";
            this.feilmelding.Size = new System.Drawing.Size(0, 13);
            this.feilmelding.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Innlogging for VMS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feilmelding);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passordText);
            this.Controls.Add(this.brukernavnText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Innlogging for VMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brukernavnText;
        private System.Windows.Forms.TextBox passordText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label feilmelding;
        private System.Windows.Forms.Label label3;
    }
}

