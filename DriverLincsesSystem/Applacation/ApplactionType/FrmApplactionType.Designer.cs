namespace DriverLincsesSystem.Applacation.ApplactionType
{
    partial class FrmApplactionType
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvApplacitonType = new System.Windows.Forms.DataGridView();
            this.LabTotalAppType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseFrmAppType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplacitonType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(115, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mangement Applacation Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(290, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvApplacitonType
            // 
            this.dgvApplacitonType.AllowUserToAddRows = false;
            this.dgvApplacitonType.AllowUserToDeleteRows = false;
            this.dgvApplacitonType.AllowUserToResizeColumns = false;
            this.dgvApplacitonType.AllowUserToResizeRows = false;
            this.dgvApplacitonType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplacitonType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApplacitonType.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplacitonType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplacitonType.Location = new System.Drawing.Point(12, 209);
            this.dgvApplacitonType.Name = "dgvApplacitonType";
            this.dgvApplacitonType.RowTemplate.ReadOnly = true;
            this.dgvApplacitonType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplacitonType.ShowCellErrors = false;
            this.dgvApplacitonType.ShowCellToolTips = false;
            this.dgvApplacitonType.ShowEditingIcon = false;
            this.dgvApplacitonType.ShowRowErrors = false;
            this.dgvApplacitonType.Size = new System.Drawing.Size(749, 311);
            this.dgvApplacitonType.TabIndex = 4;
            this.dgvApplacitonType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplacitonType_CellDoubleClick);
            // 
            // LabTotalAppType
            // 
            this.LabTotalAppType.AutoSize = true;
            this.LabTotalAppType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalAppType.ForeColor = System.Drawing.Color.Black;
            this.LabTotalAppType.Location = new System.Drawing.Point(90, 532);
            this.LabTotalAppType.Name = "LabTotalAppType";
            this.LabTotalAppType.Size = new System.Drawing.Size(24, 21);
            this.LabTotalAppType.TabIndex = 9;
            this.LabTotalAppType.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "#Record";
            // 
            // btnCloseFrmAppType
            // 
            this.btnCloseFrmAppType.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnCloseFrmAppType.Location = new System.Drawing.Point(635, 532);
            this.btnCloseFrmAppType.Name = "btnCloseFrmAppType";
            this.btnCloseFrmAppType.Size = new System.Drawing.Size(126, 39);
            this.btnCloseFrmAppType.TabIndex = 10;
            this.btnCloseFrmAppType.Text = "Close";
            this.btnCloseFrmAppType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFrmAppType.UseVisualStyleBackColor = true;
            this.btnCloseFrmAppType.Click += new System.EventHandler(this.btnCloseFrmAppType_Click);
            // 
            // FrmApplactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 588);
            this.Controls.Add(this.btnCloseFrmAppType);
            this.Controls.Add(this.LabTotalAppType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvApplacitonType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmApplactionType";
            this.Text = "FrmApplactionType";
            this.Load += new System.EventHandler(this.FrmApplactionType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplacitonType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvApplacitonType;
        private System.Windows.Forms.Label LabTotalAppType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseFrmAppType;
    }
}