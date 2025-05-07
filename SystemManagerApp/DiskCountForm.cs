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
    public partial class DiskCountForm : Form
    {
        public DiskCountForm()
        {
            InitializeComponent();
        }

        private void DiskCountForm_Load(object sender, EventArgs e)
        {
            lblCount.Text = $"Cantidad de discos: {SystemTools.GetDiskCount()}";
        }
    }
}
