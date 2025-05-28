namespace SystemManagerApp
{
    partial class MainMenuForm
    {
        private Button btnSerial, btnDisks, btnInventory, btnMac, btnRegistry, btnProcesses;

        private void InitializeComponent()
        {
            btnSerial = new Button();
            btnDisks = new Button();
            btnInventory = new Button();
            btnMac = new Button();
            btnRegistry = new Button();
            btnProcesses = new Button();
            SuspendLayout();
            // 
            // btnSerial
            // 
            btnSerial.Location = new Point(76, 186);
            btnSerial.Name = "btnSerial";
            btnSerial.Size = new Size(75, 23);
            btnSerial.TabIndex = 0;
            btnSerial.Text = "Serial";
            btnSerial.Click += btnSerial_Click;
            // 
            // btnDisks
            // 
            btnDisks.Location = new Point(76, 157);
            btnDisks.Name = "btnDisks";
            btnDisks.Size = new Size(75, 23);
            btnDisks.TabIndex = 1;
            btnDisks.Text = "Discos";
            btnDisks.Click += btnDisks_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(76, 128);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(75, 23);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventario";
            btnInventory.Click += btnInventory_Click;
            // 
            // btnMac
            // 
            btnMac.Location = new Point(76, 99);
            btnMac.Name = "btnMac";
            btnMac.Size = new Size(75, 23);
            btnMac.TabIndex = 3;
            btnMac.Text = "Mac";
            btnMac.Click += btnMac_Click;
            // 
            // btnRegistry
            // 
            btnRegistry.Location = new Point(76, 70);
            btnRegistry.Name = "btnRegistry";
            btnRegistry.Size = new Size(75, 23);
            btnRegistry.TabIndex = 4;
            btnRegistry.Text = "Registro";
            btnRegistry.Click += btnRegistry_Click;
            // 
            // btnProcesses
            // 
            btnProcesses.Location = new Point(76, 41);
            btnProcesses.Name = "btnProcesses";
            btnProcesses.Size = new Size(75, 23);
            btnProcesses.TabIndex = 5;
            btnProcesses.Text = "Procesos";
            btnProcesses.Click += btnProcesses_Click;
            // 
            // MainMenuForm
            // 
            ClientSize = new Size(233, 288);
            Controls.Add(btnSerial);
            Controls.Add(btnDisks);
            Controls.Add(btnInventory);
            Controls.Add(btnMac);
            Controls.Add(btnRegistry);
            Controls.Add(btnProcesses);
            Name = "MainMenuForm";
            Text = "Menú Principal";
            ResumeLayout(false);
        }
    }
}

