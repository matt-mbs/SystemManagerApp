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
    public partial class MacAddressForm : Form
    {
        public MacAddressForm()
        {
            InitializeComponent();
        }
        private void MacAddressForm_Load(object sender, EventArgs e)
        {
            lstMAC.Items.AddRange(SystemTools.GetMACAddresses().ToArray());
        }
    }
}
