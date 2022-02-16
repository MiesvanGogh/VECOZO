namespace Vecozo_sprint_1
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
            this.BtnMed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMed
            // 
            this.BtnMed.Location = new System.Drawing.Point(27, 117);
            this.BtnMed.Name = "BtnMed";
            this.BtnMed.Size = new System.Drawing.Size(83, 25);
            this.BtnMed.TabIndex = 1;
            this.BtnMed.Text = "Medewerker";
            this.BtnMed.UseVisualStyleBackColor = true;
            this.BtnMed.Click += new System.EventHandler(this.BtnMed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kies uw functie:";
            // 
            // BtnMan
            // 
            this.BtnMan.Location = new System.Drawing.Point(28, 69);
            this.BtnMan.Name = "BtnMan";
            this.BtnMan.Size = new System.Drawing.Size(83, 25);
            this.BtnMan.TabIndex = 3;
            this.BtnMan.Text = "Manager";
            this.BtnMan.UseVisualStyleBackColor = true;
            this.BtnMan.Click += new System.EventHandler(this.BtnMan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 162);
            this.Controls.Add(this.BtnMan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMan;
    }
}

