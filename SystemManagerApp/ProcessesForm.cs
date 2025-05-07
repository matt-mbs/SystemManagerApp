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
    public partial class ProcessesForm : Form
    {
        public ProcessesForm()
        {
            InitializeComponent();
        }

        private void ProcessesForm_Load(object sender, EventArgs e)
        {
            lstProcesses.Items.AddRange(SystemTools.GetRunningProcesses().ToArray());
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPID.Text, out int pid))
            {
                try
                {
                    SystemTools.KillProcessById(pid);
                    MessageBox.Show("Proceso terminado.");
                    lstProcesses.Items.Clear();
                    lstProcesses.Items.AddRange(SystemTools.GetRunningProcesses().ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
