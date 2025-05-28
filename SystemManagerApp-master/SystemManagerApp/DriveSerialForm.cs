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
    public partial class DriveSerialForm : Form
    {
        public DriveSerialForm()
        {
            InitializeComponent();
        }
        private void DriveSerialForm_Load(object sender, EventArgs e)
        {
            txtSerial.Text = SystemTools.GetDriveSerialNumber();
        }
    }
}
