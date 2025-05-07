using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemToolsLib;

namespace SystemManagerApp
{
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SystemTools.CreateRegistryKey(txtPath.Text, txtKey.Text, txtValue.Text);
            MessageBox.Show("Clave creada/modificada.");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtValue.Text = SystemTools.ReadRegistryKey(txtPath.Text, txtKey.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SystemTools.DeleteRegistryKey(txtPath.Text, txtKey.Text);
            MessageBox.Show("Clave eliminada.");
        }
    }
}
