namespace SystemManagerApp
{
    partial class InventoryForm
    {
        private System.Windows.Forms.TextBox txtInventory;

        private void InitializeComponent()
        {
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(12, 12);
            this.txtInventory.Multiline = true;
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ReadOnly = true;
            this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInventory.Size = new System.Drawing.Size(460, 320);
            // 
            // InventoryForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.txtInventory);
            this.Name = "InventoryForm";
            this.Text = "Inventario del Sistema";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}