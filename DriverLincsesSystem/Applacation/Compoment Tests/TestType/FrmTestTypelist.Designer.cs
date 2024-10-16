namespace DriverLincsesSystem.Applacation.TestType
{
    partial class FrmTestTypelist
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
            this.LabTotalTestType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTestTypeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseFrmTestType = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabTotalTestType
            // 
            this.LabTotalTestType.AutoSize = true;
            this.LabTotalTestType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalTestType.ForeColor = System.Drawing.Color.Black;
            this.LabTotalTestType.Location = new System.Drawing.Point(117, 534);
            this.LabTotalTestType.Name = "LabTotalTestType";
            this.LabTotalTestType.Size = new System.Drawing.Size(24, 21);
            this.LabTotalTestType.TabIndex = 15;
            this.LabTotalTestType.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "#Record";
            // 
            // dgvTestTypeList
            // 
            this.dgvTestTypeList.AllowUserToAddRows = false;
            this.dgvTestTypeList.AllowUserToDeleteRows = false;
            this.dgvTestTypeList.AllowUserToResizeColumns = false;
            this.dgvTestTypeList.AllowUserToResizeRows = false;
            this.dgvTestTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestTypeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTestTypeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypeList.Location = new System.Drawing.Point(24, 217);
            this.dgvTestTypeList.Name = "dgvTestTypeList";
            this.dgvTestTypeList.RowTemplate.ReadOnly = true;
            this.dgvTestTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestTypeList.ShowCellErrors = false;
            this.dgvTestTypeList.ShowCellToolTips = false;
            this.dgvTestTypeList.ShowEditingIcon = false;
            this.dgvTestTypeList.ShowRowErrors = false;
            this.dgvTestTypeList.Size = new System.Drawing.Size(781, 311);
            this.dgvTestTypeList.TabIndex = 13;
            this.dgvTestTypeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestTypeList_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(220, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mangement Test Types";
            // 
            // btnCloseFrmTestType
            // 
            this.btnCloseFrmTestType.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnCloseFrmTestType.Location = new System.Drawing.Point(696, 535);
            this.btnCloseFrmTestType.Name = "btnCloseFrmTestType";
            this.btnCloseFrmTestType.Size = new System.Drawing.Size(119, 39);
            this.btnCloseFrmTestType.TabIndex = 16;
            this.btnCloseFrmTestType.Text = "Close";
            this.btnCloseFrmTestType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFrmTestType.UseVisualStyleBackColor = true;
            this.btnCloseFrmTestType.Click += new System.EventHandler(this.btnCloseFrmAppType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(344, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTestTypelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 586);
            this.Controls.Add(this.btnCloseFrmTestType);
            this.Controls.Add(this.LabTotalTestType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTestTypeList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTestTypelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Type Screen";
            this.Load += new System.EventHandler(this.FrmTestTypelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseFrmTestType;
        private System.Windows.Forms.Label LabTotalTestType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTestTypeList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}