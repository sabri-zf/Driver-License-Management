namespace DriverLincsesSystem.Applacation.Compoment_Tests.Schedule_tests.WriteTest
{
    partial class FrmScheduleStreetTest
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
            this.ctrScheduleTestInfo1 = new DriverLincsesSystem.Applacation.Compoment_Tests.UC.ctrScheduleTestInfo();
            this.btnClosePageLocalDrivingApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ctrScheduleTestInfo1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(478, 680);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Street Test";
            // 
            // ctrScheduleTestInfo1
            // 
            this.ctrScheduleTestInfo1.BackColor = System.Drawing.Color.White;
            this.ctrScheduleTestInfo1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ctrScheduleTestInfo1.Location = new System.Drawing.Point(24, 92);
            this.ctrScheduleTestInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrScheduleTestInfo1.Name = "ctrScheduleTestInfo1";
            this.ctrScheduleTestInfo1.Size = new System.Drawing.Size(435, 580);
            this.ctrScheduleTestInfo1.TabIndex = 0;
            // 
            // btnClosePageLocalDrivingApp
            // 
            this.btnClosePageLocalDrivingApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClosePageLocalDrivingApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePageLocalDrivingApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePageLocalDrivingApp.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnClosePageLocalDrivingApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePageLocalDrivingApp.Location = new System.Drawing.Point(353, 705);
            this.btnClosePageLocalDrivingApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosePageLocalDrivingApp.Name = "btnClosePageLocalDrivingApp";
            this.btnClosePageLocalDrivingApp.Size = new System.Drawing.Size(128, 32);
            this.btnClosePageLocalDrivingApp.TabIndex = 29;
            this.btnClosePageLocalDrivingApp.Text = "close";
            this.btnClosePageLocalDrivingApp.UseVisualStyleBackColor = true;
            this.btnClosePageLocalDrivingApp.Click += new System.EventHandler(this.btnClosePageLocalDrivingApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.driving_test_5121;
            this.pictureBox1.Location = new System.Drawing.Point(159, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmScheduleStreetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 749);
            this.Controls.Add(this.btnClosePageLocalDrivingApp);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmScheduleStreetTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Street Test";
            this.Load += new System.EventHandler(this.FrmScheduleStreetTest_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClosePageLocalDrivingApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UC.ctrScheduleTestInfo ctrScheduleTestInfo1;
    }
}