namespace Labirent
{
    partial class AnaSayfa
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
            this.btnTekBasinaOyna = new System.Windows.Forms.Button();
            this.btnBilgisayarOyna = new System.Windows.Forms.Button();
            this.btnIkiKisiOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTekBasinaOyna
            // 
            this.btnTekBasinaOyna.Location = new System.Drawing.Point(230, 75);
            this.btnTekBasinaOyna.Name = "btnTekBasinaOyna";
            this.btnTekBasinaOyna.Size = new System.Drawing.Size(431, 129);
            this.btnTekBasinaOyna.TabIndex = 0;
            this.btnTekBasinaOyna.Text = "Tek Baışna Oyna";
            this.btnTekBasinaOyna.UseVisualStyleBackColor = true;
            this.btnTekBasinaOyna.Click += new System.EventHandler(this.btnTekBasinaOyna_Click);
            // 
            // btnBilgisayarOyna
            // 
            this.btnBilgisayarOyna.Location = new System.Drawing.Point(230, 350);
            this.btnBilgisayarOyna.Name = "btnBilgisayarOyna";
            this.btnBilgisayarOyna.Size = new System.Drawing.Size(431, 139);
            this.btnBilgisayarOyna.TabIndex = 1;
            this.btnBilgisayarOyna.Text = "Bilgisayar Oynasın";
            this.btnBilgisayarOyna.UseVisualStyleBackColor = true;
            this.btnBilgisayarOyna.Click += new System.EventHandler(this.btnBilgisayarOyna_Click);
            // 
            // btnIkiKisiOyna
            // 
            this.btnIkiKisiOyna.Location = new System.Drawing.Point(230, 210);
            this.btnIkiKisiOyna.Name = "btnIkiKisiOyna";
            this.btnIkiKisiOyna.Size = new System.Drawing.Size(431, 134);
            this.btnIkiKisiOyna.TabIndex = 2;
            this.btnIkiKisiOyna.Text = "İki Kişi Oyna";
            this.btnIkiKisiOyna.UseVisualStyleBackColor = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 577);
            this.Controls.Add(this.btnIkiKisiOyna);
            this.Controls.Add(this.btnBilgisayarOyna);
            this.Controls.Add(this.btnTekBasinaOyna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTekBasinaOyna;
        private System.Windows.Forms.Button btnBilgisayarOyna;
        private System.Windows.Forms.Button btnIkiKisiOyna;
    }
}