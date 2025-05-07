namespace SystemManagerApp
{
    partial class ProcessesForm
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
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Button btnKill;
        private void InitializeComponent()
        {
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProcesses
            // 
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.ItemHeight = 15;
            this.lstProcesses.Location = new System.Drawing.Point(12, 12);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(460, 184);
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(12, 210);
            this.txtPID.Name = "txtPID";
            this.txtPID.PlaceholderText = "PID del proceso";
            this.txtPID.Size = new System.Drawing.Size(200, 23);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(218, 210);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(75, 23);
            this.btnKill.Text = "Terminar";
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // ProcessesForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lstProcesses);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.btnKill);
            this.Name = "ProcessesForm";
            this.Text = "Procesos Activos";
            this.Load += new System.EventHandler(this.ProcessesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}