namespace SystemManagerApp
{
    partial class DriveSerialForm
    {
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 15);
            this.lblTitle.Text = "Número de Serie del Disco:";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(12, 30);
            this.txtSerial.Multiline = true;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(360, 60);
            // 
            // DriveSerialForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.lblTitle);
            this.Name = "DriveSerialForm";
            this.Text = "Número de Serie del Disco";
            this.Load += new System.EventHandler(this.DriveSerialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}