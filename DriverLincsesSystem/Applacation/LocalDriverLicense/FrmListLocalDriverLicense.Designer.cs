namespace DriverLincsesSystem.Applacation.LocalDriverLicense
{
    partial class FrmListLocalDriverLicense
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
            this.components = new System.ComponentModel.Container();
            this.LabTitleMode = new System.Windows.Forms.Label();
            this.LabTotalRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBFilterOption = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVLocalDrivingLicenseAppList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.TBInputFilter = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClosePageLocalDrivingApp = new System.Windows.Forms.Button();
            this.PbAddNewLocalDrivingLicenseApp = new System.Windows.Forms.PictureBox();
            this.ShowApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppliactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceledApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWriteTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicesnseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistoryLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocalDrivingLicenseAppList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewLocalDrivingLicenseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabTitleMode
            // 
            this.LabTitleMode.AutoSize = true;
            this.LabTitleMode.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitleMode.ForeColor = System.Drawing.Color.Red;
            this.LabTitleMode.Location = new System.Drawing.Point(273, 135);
            this.LabTitleMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabTitleMode.Name = "LabTitleMode";
            this.LabTitleMode.Size = new System.Drawing.Size(608, 54);
            this.LabTitleMode.TabIndex = 15;
            this.LabTitleMode.Text = "Local Driving License Applcation";
            // 
            // LabTotalRecord
            // 
            this.LabTotalRecord.AutoSize = true;
            this.LabTotalRecord.Location = new System.Drawing.Point(100, 692);
            this.LabTotalRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabTotalRecord.Name = "LabTotalRecord";
            this.LabTotalRecord.Size = new System.Drawing.Size(14, 15);
            this.LabTotalRecord.TabIndex = 23;
            this.LabTotalRecord.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(73, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filter By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-49, 545);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "#Record";
            // 
            // CBFilterOption
            // 
            this.CBFilterOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilterOption.FormattingEnabled = true;
            this.CBFilterOption.Location = new System.Drawing.Point(161, 234);
            this.CBFilterOption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBFilterOption.Name = "CBFilterOption";
            this.CBFilterOption.Size = new System.Drawing.Size(148, 23);
            this.CBFilterOption.TabIndex = 18;
            this.CBFilterOption.SelectedIndexChanged += new System.EventHandler(this.CBFilterOption_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGVLocalDrivingLicenseAppList);
            this.panel1.Location = new System.Drawing.Point(10, 284);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 382);
            this.panel1.TabIndex = 19;
            // 
            // DGVLocalDrivingLicenseAppList
            // 
            this.DGVLocalDrivingLicenseAppList.AllowUserToAddRows = false;
            this.DGVLocalDrivingLicenseAppList.AllowUserToDeleteRows = false;
            this.DGVLocalDrivingLicenseAppList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVLocalDrivingLicenseAppList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVLocalDrivingLicenseAppList.BackgroundColor = System.Drawing.Color.White;
            this.DGVLocalDrivingLicenseAppList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DGVLocalDrivingLicenseAppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLocalDrivingLicenseAppList.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVLocalDrivingLicenseAppList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVLocalDrivingLicenseAppList.Location = new System.Drawing.Point(4, 3);
            this.DGVLocalDrivingLicenseAppList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVLocalDrivingLicenseAppList.Name = "DGVLocalDrivingLicenseAppList";
            this.DGVLocalDrivingLicenseAppList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVLocalDrivingLicenseAppList.RowTemplate.ReadOnly = true;
            this.DGVLocalDrivingLicenseAppList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVLocalDrivingLicenseAppList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLocalDrivingLicenseAppList.Size = new System.Drawing.Size(1101, 374);
            this.DGVLocalDrivingLicenseAppList.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowApplication,
            this.item2ToolStripMenuItem,
            this.editAppliactionToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.canceledApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.scheduleTestToolStripMenuItem,
            this.toolStripMenuItem3,
            this.issueDrivingLicesnseFirstTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem4,
            this.showHistoryLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(380, 322);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(376, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(376, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(376, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(376, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(376, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 689);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "#Record";
            // 
            // TBInputFilter
            // 
            this.TBInputFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBInputFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBInputFilter.Location = new System.Drawing.Point(316, 232);
            this.TBInputFilter.Name = "TBInputFilter";
            this.TBInputFilter.Size = new System.Drawing.Size(275, 27);
            this.TBInputFilter.TabIndex = 26;
            this.TBInputFilter.TextChanged += new System.EventHandler(this.TBInputFilter_TextChanged);
            this.TBInputFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBInputFilter_KeyPress);
            this.TBInputFilter.Validating += new System.ComponentModel.CancelEventHandler(this.TBInputFilter_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClosePageLocalDrivingApp
            // 
            this.btnClosePageLocalDrivingApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClosePageLocalDrivingApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePageLocalDrivingApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePageLocalDrivingApp.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnClosePageLocalDrivingApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePageLocalDrivingApp.Location = new System.Drawing.Point(973, 683);
            this.btnClosePageLocalDrivingApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosePageLocalDrivingApp.Name = "btnClosePageLocalDrivingApp";
            this.btnClosePageLocalDrivingApp.Size = new System.Drawing.Size(142, 33);
            this.btnClosePageLocalDrivingApp.TabIndex = 24;
            this.btnClosePageLocalDrivingApp.Text = "close";
            this.btnClosePageLocalDrivingApp.UseVisualStyleBackColor = true;
            this.btnClosePageLocalDrivingApp.Click += new System.EventHandler(this.btnClosePageLocalDrivingApp_Click);
            // 
            // PbAddNewLocalDrivingLicenseApp
            // 
            this.PbAddNewLocalDrivingLicenseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbAddNewLocalDrivingLicenseApp.Image = global::DriverLincsesSystem.Properties.Resources.New_Application_64;
            this.PbAddNewLocalDrivingLicenseApp.Location = new System.Drawing.Point(1034, 211);
            this.PbAddNewLocalDrivingLicenseApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PbAddNewLocalDrivingLicenseApp.Name = "PbAddNewLocalDrivingLicenseApp";
            this.PbAddNewLocalDrivingLicenseApp.Size = new System.Drawing.Size(59, 58);
            this.PbAddNewLocalDrivingLicenseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAddNewLocalDrivingLicenseApp.TabIndex = 22;
            this.PbAddNewLocalDrivingLicenseApp.TabStop = false;
            this.PbAddNewLocalDrivingLicenseApp.Click += new System.EventHandler(this.PbAddNewLocalDrivingLicenseApp_Click);
            // 
            // ShowApplication
            // 
            this.ShowApplication.Image = global::DriverLincsesSystem.Properties.Resources.PersonDetails_321;
            this.ShowApplication.Name = "ShowApplication";
            this.ShowApplication.Size = new System.Drawing.Size(379, 36);
            this.ShowApplication.Text = "Show Application Details";
            this.ShowApplication.Click += new System.EventHandler(this.item1ToolStripMenuItem_Click);
            // 
            // editAppliactionToolStripMenuItem
            // 
            this.editAppliactionToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.edit_321;
            this.editAppliactionToolStripMenuItem.Name = "editAppliactionToolStripMenuItem";
            this.editAppliactionToolStripMenuItem.Size = new System.Drawing.Size(379, 36);
            this.editAppliactionToolStripMenuItem.Text = "Edit Appliaction";
            this.editAppliactionToolStripMenuItem.Click += new System.EventHandler(this.editAppliactionToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(379, 36);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // canceledApplicationToolStripMenuItem
            // 
            this.canceledApplicationToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Delete_32;
            this.canceledApplicationToolStripMenuItem.Name = "canceledApplicationToolStripMenuItem";
            this.canceledApplicationToolStripMenuItem.Size = new System.Drawing.Size(379, 36);
            this.canceledApplicationToolStripMenuItem.Text = "Canceled Application";
            this.canceledApplicationToolStripMenuItem.Click += new System.EventHandler(this.canceledApplicationToolStripMenuItem_Click_1);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWriteTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Test_Type_641;
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(379, 36);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Vision_512;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule  Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click_1);
            // 
            // scheduleWriteTestToolStripMenuItem
            // 
            this.scheduleWriteTestToolStripMenuItem.Enabled = false;
            this.scheduleWriteTestToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Written_Test_32;
            this.scheduleWriteTestToolStripMenuItem.Name = "scheduleWriteTestToolStripMenuItem";
            this.scheduleWriteTestToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.scheduleWriteTestToolStripMenuItem.Text = "Schedule  Write Test";
            this.scheduleWriteTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWriteTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Enabled = false;
            this.scheduleStreetTestToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule  Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // issueDrivingLicesnseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicesnseFirstTimeToolStripMenuItem.Enabled = false;
            this.issueDrivingLicesnseFirstTimeToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrivingLicesnseFirstTimeToolStripMenuItem.Name = "issueDrivingLicesnseFirstTimeToolStripMenuItem";
            this.issueDrivingLicesnseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(379, 36);
            this.issueDrivingLicesnseFirstTimeToolStripMenuItem.Text = "Issue Driving Licesnse (First Time)";
            this.issueDrivingLicesnseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicesnseFirstTimeToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.LicenseView_400;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(379, 36);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showHistoryLicenseToolStripMenuItem
            // 
            this.showHistoryLicenseToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.PersonLicenseHistory_512;
            this.showHistoryLicenseToolStripMenuItem.Name = "showHistoryLicenseToolStripMenuItem";
            this.showHistoryLicenseToolStripMenuItem.Size = new System.Drawing.Size(379, 36);
            this.showHistoryLicenseToolStripMenuItem.Text = "Show History License";
            this.showHistoryLicenseToolStripMenuItem.Click += new System.EventHandler(this.showHistoryLicenseToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DriverLincsesSystem.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(631, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.Applications2;
            this.pictureBox1.Location = new System.Drawing.Point(447, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListLocalDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 753);
            this.Controls.Add(this.TBInputFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClosePageLocalDrivingApp);
            this.Controls.Add(this.PbAddNewLocalDrivingLicenseApp);
            this.Controls.Add(this.LabTotalRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBFilterOption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabTitleMode);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmListLocalDriverLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Local Driving Lincese Application";
            this.Load += new System.EventHandler(this.FrmListLocalDriverLicense_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocalDrivingLicenseAppList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAddNewLocalDrivingLicenseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabTitleMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClosePageLocalDrivingApp;
        private System.Windows.Forms.PictureBox PbAddNewLocalDrivingLicenseApp;
        private System.Windows.Forms.Label LabTotalRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBFilterOption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVLocalDrivingLicenseAppList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInputFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowApplication;
        private System.Windows.Forms.ToolStripSeparator item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppliactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem canceledApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWriteTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicesnseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem showHistoryLicenseToolStripMenuItem;
    }
}