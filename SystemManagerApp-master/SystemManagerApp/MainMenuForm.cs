using System;
using System.Windows.Forms;

namespace SystemManagerApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnSerial_Click(object sender, EventArgs e) => new DriveSerialForm().ShowDialog();
        private void btnDisks_Click(object sender, EventArgs e) => new DiskCountForm().ShowDialog();
        private void btnInventory_Click(object sender, EventArgs e) => new InventoryForm().ShowDialog();
        private void btnMac_Click(object sender, EventArgs e) => new MacAddressForm().ShowDialog();
        private void btnRegistry_Click(object sender, EventArgs e) => new RegistryForm().ShowDialog();
        private void btnProcesses_Click(object sender, EventArgs e) => new ProcessesForm().ShowDialog();
    }
}

