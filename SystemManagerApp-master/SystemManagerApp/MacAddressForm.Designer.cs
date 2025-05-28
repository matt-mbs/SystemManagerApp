namespace SystemManagerApp
{
    partial class MacAddressForm
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
        private System.Windows.Forms.ListBox lstMAC;
        private void InitializeComponent()
        {
            this.lstMAC = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstMAC
            // 
            this.lstMAC.FormattingEnabled = true;
            this.lstMAC.ItemHeight = 15;
            this.lstMAC.Location = new System.Drawing.Point(12, 12);
            this.lstMAC.Name = "lstMAC";
            this.lstMAC.Size = new System.Drawing.Size(300, 184);
            // 
            // MacAddressForm
            // 
            this.ClientSize = new System.Drawing.Size(330, 220);
            this.Controls.Add(this.lstMAC);
            this.Name = "MacAddressForm";
            this.Text = "Direcciones MAC";
            this.Load += new System.EventHandler(this.MacAddressForm_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}