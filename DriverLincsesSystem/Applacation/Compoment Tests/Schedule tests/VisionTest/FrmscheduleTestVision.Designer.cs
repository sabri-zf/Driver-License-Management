namespace DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.VisionTest
{
    partial class FrmscheduleTestVision
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrScheduleTestInfo1 = new DriverLincsesSystem.Applacation.Compoment_Tests.UC.ctrScheduleTestInfo();
            this.btnClosePageLocalDrivingApp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ctrScheduleTestInfo1);
            this.groupBox1.Location = new System.Drawing.Point(4, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(445, 658);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vision Test";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(156, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ctrScheduleTestInfo1
            // 
            this.ctrScheduleTestInfo1.BackColor = System.Drawing.Color.White;
            this.ctrScheduleTestInfo1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ctrScheduleTestInfo1.Location = new System.Drawing.Point(0, 89);
            this.ctrScheduleTestInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrScheduleTestInfo1.Name = "ctrScheduleTestInfo1";
            this.ctrScheduleTestInfo1.Size = new System.Drawing.Size(445, 580);
            this.ctrScheduleTestInfo1.TabIndex = 0;
            // 
            // btnClosePageLocalDrivingApp
            // 
            this.btnClosePageLocalDrivingApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClosePageLocalDrivingApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePageLocalDrivingApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePageLocalDrivingApp.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnClosePageLocalDrivingApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePageLocalDrivingApp.Location = new System.Drawing.Point(331, 703);
            this.btnClosePageLocalDrivingApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosePageLocalDrivingApp.Name = "btnClosePageLocalDrivingApp";
            this.btnClosePageLocalDrivingApp.Size = new System.Drawing.Size(108, 33);
            this.btnClosePageLocalDrivingApp.TabIndex = 25;
            this.btnClosePageLocalDrivingApp.Text = "close";
            this.btnClosePageLocalDrivingApp.UseVisualStyleBackColor = true;
            this.btnClosePageLocalDrivingApp.Click += new System.EventHandler(this.btnClosePageLocalDrivingApp_Click);
            // 
            // FrmscheduleTestVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 748);
            this.Controls.Add(this.btnClosePageLocalDrivingApp);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmscheduleTestVision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vision";
            this.Load += new System.EventHandler(this.FrmscheduleTestVision_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ctrScheduleTestInfo ctrScheduleTestInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClosePageLocalDrivingApp;
    }
}