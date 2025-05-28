namespace SystemManagerApp
{
    partial class RegistryForm
    {
        private System.Windows.Forms.TextBox txtPath, txtKey, txtValue;
        private System.Windows.Forms.Button btnCreate, btnRead, btnDelete;

        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.PlaceholderText = "Ruta";
            this.txtPath.Size = new System.Drawing.Size(360, 23);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 41);
            this.txtKey.Name = "txtKey";
            this.txtKey.PlaceholderText = "Nombre Clave";
            this.txtKey.Size = new System.Drawing.Size(360, 23);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(12, 70);
            this.txtValue.Name = "txtValue";
            this.txtValue.PlaceholderText = "Valor";
            this.txtValue.Size = new System.Drawing.Size(360, 23);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.Text = "Crear";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(93, 100);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.Text = "Leer";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Text = "Borrar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RegistryForm
            // 
            this.ClientSize = new System.Drawing.Size(390, 140);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDelete);
            this.Name = "RegistryForm";
            this.Text = "Registro de Windows";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}