namespace Labirent
{
    partial class Labirent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Labirent));
            this.dGVLabirent = new System.Windows.Forms.DataGridView();
            this.BilgisayarBekletme = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLabirent)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVLabirent
            // 
            this.dGVLabirent.AllowUserToAddRows = false;
            this.dGVLabirent.AllowUserToDeleteRows = false;
            this.dGVLabirent.AllowUserToResizeColumns = false;
            this.dGVLabirent.AllowUserToResizeRows = false;
            this.dGVLabirent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLabirent.ColumnHeadersVisible = false;
            resources.ApplyResources(this.dGVLabirent, "dGVLabirent");
            this.dGVLabirent.Name = "dGVLabirent";
            this.dGVLabirent.ReadOnly = true;
            this.dGVLabirent.RowHeadersVisible = false;
            this.dGVLabirent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVLabirent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HareketEt);
            // 
            // BilgisayarBekletme
            // 
            this.BilgisayarBekletme.Interval = 200;
            this.BilgisayarBekletme.Tick += new System.EventHandler(this.BilgisayarBekletme_Tick);
            // 
            // Labirent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGVLabirent);
            this.MaximizeBox = false;
            this.Name = "Labirent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Labirent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLabirent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVLabirent;
        private System.Windows.Forms.Timer BilgisayarBekletme;
    }
}