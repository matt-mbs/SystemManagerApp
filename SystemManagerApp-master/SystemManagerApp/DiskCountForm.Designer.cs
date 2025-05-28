namespace SystemManagerApp
{
    partial class DiskCountForm
    {
        private System.Windows.Forms.Label lblCount;

        private void InitializeComponent()
        {
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(30, 30);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 15);
            // 
            // DiskCountForm
            // 
            this.ClientSize = new System.Drawing.Size(250, 90);
            this.Controls.Add(this.lblCount);
            this.Name = "DiskCountForm";
            this.Text = "Cantidad de Discos";
            this.Load += new System.EventHandler(this.DiskCountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}