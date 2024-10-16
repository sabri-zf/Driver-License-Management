namespace DriverLincsesSystem.Applacation.ShowApplicatrionDetails
{
    partial class FrmShowHistoryLicense
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabHistory = new System.Windows.Forms.TabControl();
            this.PageLocal = new System.Windows.Forms.TabPage();
            this.labTotalLocalLicense = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvLocalHistory = new System.Windows.Forms.DataGridView();
            this.PageInternational = new System.Windows.Forms.TabPage();
            this.LabTotalInternationalLicense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvInternationalHistory = new System.Windows.Forms.DataGridView();
            this.btnClosePageLocalDrivingApp = new System.Windows.Forms.Button();
            this.ctrCardPerson1 = new DriverLincsesSystem.People.UControl.CtrCardPerson();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabHistory.SuspendLayout();
            this.PageLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalHistory)).BeginInit();
            this.PageInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInternationalHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.PersonLicenseHistory_5121;
            this.pictureBox1.Location = new System.Drawing.Point(7, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TabHistory
            // 
            this.TabHistory.Controls.Add(this.PageLocal);
            this.TabHistory.Controls.Add(this.PageInternational);
            this.TabHistory.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabHistory.Location = new System.Drawing.Point(7, 458);
            this.TabHistory.Name = "TabHistory";
            this.TabHistory.SelectedIndex = 0;
            this.TabHistory.Size = new System.Drawing.Size(1059, 328);
            this.TabHistory.TabIndex = 2;
            this.TabHistory.SelectedIndexChanged += new System.EventHandler(this.TabHistory_SelectedIndexChanged);
            // 
            // PageLocal
            // 
            this.PageLocal.BackColor = System.Drawing.Color.White;
            this.PageLocal.Controls.Add(this.labTotalLocalLicense);
            this.PageLocal.Controls.Add(this.label5);
            this.PageLocal.Controls.Add(this.label1);
            this.PageLocal.Controls.Add(this.DgvLocalHistory);
            this.PageLocal.Location = new System.Drawing.Point(4, 32);
            this.PageLocal.Name = "PageLocal";
            this.PageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.PageLocal.Size = new System.Drawing.Size(1051, 292);
            this.PageLocal.TabIndex = 0;
            this.PageLocal.Text = "Local License";
            // 
            // labTotalLocalLicense
            // 
            this.labTotalLocalLicense.AutoSize = true;
            this.labTotalLocalLicense.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalLocalLicense.Location = new System.Drawing.Point(114, 256);
            this.labTotalLocalLicense.Name = "labTotalLocalLicense";
            this.labTotalLocalLicense.Size = new System.Drawing.Size(28, 25);
            this.labTotalLocalLicense.TabIndex = 13;
            this.labTotalLocalLicense.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "#Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Local license History :";
            // 
            // DgvLocalHistory
            // 
            this.DgvLocalHistory.AllowUserToAddRows = false;
            this.DgvLocalHistory.AllowUserToDeleteRows = false;
            this.DgvLocalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLocalHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvLocalHistory.BackgroundColor = System.Drawing.Color.White;
            this.DgvLocalHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DgvLocalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocalHistory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvLocalHistory.Location = new System.Drawing.Point(8, 69);
            this.DgvLocalHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvLocalHistory.Name = "DgvLocalHistory";
            this.DgvLocalHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvLocalHistory.RowTemplate.ReadOnly = true;
            this.DgvLocalHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLocalHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLocalHistory.Size = new System.Drawing.Size(1036, 184);
            this.DgvLocalHistory.TabIndex = 7;
            // 
            // PageInternational
            // 
            this.PageInternational.BackColor = System.Drawing.Color.White;
            this.PageInternational.Controls.Add(this.LabTotalInternationalLicense);
            this.PageInternational.Controls.Add(this.label3);
            this.PageInternational.Controls.Add(this.label2);
            this.PageInternational.Controls.Add(this.DgvInternationalHistory);
            this.PageInternational.Location = new System.Drawing.Point(4, 32);
            this.PageInternational.Name = "PageInternational";
            this.PageInternational.Padding = new System.Windows.Forms.Padding(3);
            this.PageInternational.Size = new System.Drawing.Size(1051, 292);
            this.PageInternational.TabIndex = 1;
            this.PageInternational.Text = "International License";
            // 
            // LabTotalInternationalLicense
            // 
            this.LabTotalInternationalLicense.AutoSize = true;
            this.LabTotalInternationalLicense.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalInternationalLicense.Location = new System.Drawing.Point(95, 249);
            this.LabTotalInternationalLicense.Name = "LabTotalInternationalLicense";
            this.LabTotalInternationalLicense.Size = new System.Drawing.Size(28, 25);
            this.LabTotalInternationalLicense.TabIndex = 11;
            this.LabTotalInternationalLicense.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "#Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "International License History :";
            // 
            // DgvInternationalHistory
            // 
            this.DgvInternationalHistory.AllowUserToAddRows = false;
            this.DgvInternationalHistory.AllowUserToDeleteRows = false;
            this.DgvInternationalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInternationalHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvInternationalHistory.BackgroundColor = System.Drawing.Color.White;
            this.DgvInternationalHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DgvInternationalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInternationalHistory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvInternationalHistory.Location = new System.Drawing.Point(7, 62);
            this.DgvInternationalHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvInternationalHistory.Name = "DgvInternationalHistory";
            this.DgvInternationalHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvInternationalHistory.RowTemplate.ReadOnly = true;
            this.DgvInternationalHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInternationalHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInternationalHistory.Size = new System.Drawing.Size(1036, 184);
            this.DgvInternationalHistory.TabIndex = 6;
            // 
            // btnClosePageLocalDrivingApp
            // 
            this.btnClosePageLocalDrivingApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClosePageLocalDrivingApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePageLocalDrivingApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePageLocalDrivingApp.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePageLocalDrivingApp.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnClosePageLocalDrivingApp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClosePageLocalDrivingApp.Location = new System.Drawing.Point(898, 792);
            this.btnClosePageLocalDrivingApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosePageLocalDrivingApp.Name = "btnClosePageLocalDrivingApp";
            this.btnClosePageLocalDrivingApp.Size = new System.Drawing.Size(156, 43);
            this.btnClosePageLocalDrivingApp.TabIndex = 25;
            this.btnClosePageLocalDrivingApp.Text = "close";
            this.btnClosePageLocalDrivingApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClosePageLocalDrivingApp.UseVisualStyleBackColor = true;
            this.btnClosePageLocalDrivingApp.Click += new System.EventHandler(this.btnClosePageLocalDrivingApp_Click);
            // 
            // ctrCardPerson1
            // 
            this.ctrCardPerson1.BackColor = System.Drawing.Color.White;
            this.ctrCardPerson1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrCardPerson1.Location = new System.Drawing.Point(138, 25);
            this.ctrCardPerson1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrCardPerson1.Name = "ctrCardPerson1";
            this.ctrCardPerson1.Size = new System.Drawing.Size(928, 343);
            this.ctrCardPerson1.TabIndex = 0;
            // 
            // FrmShowHistoryLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 844);
            this.Controls.Add(this.btnClosePageLocalDrivingApp);
            this.Controls.Add(this.TabHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrCardPerson1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmShowHistoryLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.Load += new System.EventHandler(this.FrmShowHistoryLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabHistory.ResumeLayout(false);
            this.PageLocal.ResumeLayout(false);
            this.PageLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalHistory)).EndInit();
            this.PageInternational.ResumeLayout(false);
            this.PageInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInternationalHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private People.UControl.CtrCardPerson ctrCardPerson1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl TabHistory;
        private System.Windows.Forms.TabPage PageLocal;
        private System.Windows.Forms.TabPage PageInternational;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvLocalHistory;
        private System.Windows.Forms.DataGridView DgvInternationalHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTotalLocalLicense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabTotalInternationalLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClosePageLocalDrivingApp;
    }
}