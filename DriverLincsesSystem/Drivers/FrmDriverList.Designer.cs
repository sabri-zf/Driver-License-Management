namespace DriverLincsesSystem.Drivers
{
    partial class FrmDriverList
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
        private void InitializeComponent()
        {
            this.dgvListDrivers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabTotalDriver = new System.Windows.Forms.Label();
            this.btnCloseFrmDriver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListDrivers
            // 
            this.dgvListDrivers.AllowUserToAddRows = false;
            this.dgvListDrivers.AllowUserToDeleteRows = false;
            this.dgvListDrivers.AllowUserToResizeColumns = false;
            this.dgvListDrivers.AllowUserToResizeRows = false;
            this.dgvListDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDrivers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDrivers.Location = new System.Drawing.Point(22, 136);
            this.dgvListDrivers.Name = "dgvListDrivers";
            this.dgvListDrivers.RowTemplate.ReadOnly = true;
            this.dgvListDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListDrivers.ShowCellErrors = false;
            this.dgvListDrivers.ShowCellToolTips = false;
            this.dgvListDrivers.ShowEditingIcon = false;
            this.dgvListDrivers.ShowRowErrors = false;
            this.dgvListDrivers.Size = new System.Drawing.Size(771, 311);
            this.dgvListDrivers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(330, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Driver";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.Drivers_64;
            this.pictureBox1.Location = new System.Drawing.Point(267, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "#Record";
            // 
            // LabTotalDriver
            // 
            this.LabTotalDriver.AutoSize = true;
            this.LabTotalDriver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalDriver.ForeColor = System.Drawing.Color.Black;
            this.LabTotalDriver.Location = new System.Drawing.Point(105, 450);
            this.LabTotalDriver.Name = "LabTotalDriver";
            this.LabTotalDriver.Size = new System.Drawing.Size(24, 21);
            this.LabTotalDriver.TabIndex = 7;
            this.LabTotalDriver.Text = "??";
            // 
            // btnCloseFrmDriver
            // 
            this.btnCloseFrmDriver.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnCloseFrmDriver.Location = new System.Drawing.Point(667, 495);
            this.btnCloseFrmDriver.Name = "btnCloseFrmDriver";
            this.btnCloseFrmDriver.Size = new System.Drawing.Size(126, 39);
            this.btnCloseFrmDriver.TabIndex = 9;
            this.btnCloseFrmDriver.Text = "Close";
            this.btnCloseFrmDriver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFrmDriver.UseVisualStyleBackColor = true;
            this.btnCloseFrmDriver.Click += new System.EventHandler(this.btnCloseFrmDriver_Click);
            // 
            // FrmDriverList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 555);
            this.Controls.Add(this.btnCloseFrmDriver);
            this.Controls.Add(this.LabTotalDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListDrivers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDriverList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Driver List";
            this.Load += new System.EventHandler(this.FrmDriverList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListDrivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabTotalDriver;
        private System.Windows.Forms.Button btnCloseFrmDriver;
    }
}