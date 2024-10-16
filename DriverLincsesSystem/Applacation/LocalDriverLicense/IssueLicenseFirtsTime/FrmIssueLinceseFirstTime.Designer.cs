namespace DriverLincsesSystem.Applacation.LocalDriverLicense.IssueLicenseFirtsTime
{
    partial class FrmIssueLinceseFirstTime
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
            this.TBTakeNotes = new System.Windows.Forms.TextBox();
            this.BtnSaveIssueLicense = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.ctrLocalDrivingLinceseApplactionInfo1 = new DriverLincsesSystem.Applacation.Compoment_Tests.UC.CtrLocalDrivingLinceseApplactionInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes";
            // 
            // TBTakeNotes
            // 
            this.TBTakeNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTakeNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTakeNotes.Location = new System.Drawing.Point(156, 547);
            this.TBTakeNotes.Multiline = true;
            this.TBTakeNotes.Name = "TBTakeNotes";
            this.TBTakeNotes.Size = new System.Drawing.Size(636, 130);
            this.TBTakeNotes.TabIndex = 2;
            // 
            // BtnSaveIssueLicense
            // 
            this.BtnSaveIssueLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSaveIssueLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveIssueLicense.Image = global::DriverLincsesSystem.Properties.Resources.Save_32;
            this.BtnSaveIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveIssueLicense.Location = new System.Drawing.Point(555, 705);
            this.BtnSaveIssueLicense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSaveIssueLicense.Name = "BtnSaveIssueLicense";
            this.BtnSaveIssueLicense.Size = new System.Drawing.Size(142, 33);
            this.BtnSaveIssueLicense.TabIndex = 25;
            this.BtnSaveIssueLicense.Text = "Save";
            this.BtnSaveIssueLicense.UseVisualStyleBackColor = true;
            this.BtnSaveIssueLicense.Click += new System.EventHandler(this.BtnSaveIssueLicense_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(705, 705);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(142, 33);
            this.BtnClose.TabIndex = 26;
            this.BtnClose.Text = "close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ctrLocalDrivingLinceseApplactionInfo1
            // 
            this.ctrLocalDrivingLinceseApplactionInfo1.BackColor = System.Drawing.Color.White;
            this.ctrLocalDrivingLinceseApplactionInfo1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrLocalDrivingLinceseApplactionInfo1.Location = new System.Drawing.Point(54, 12);
            this.ctrLocalDrivingLinceseApplactionInfo1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ctrLocalDrivingLinceseApplactionInfo1.Name = "ctrLocalDrivingLinceseApplactionInfo1";
            this.ctrLocalDrivingLinceseApplactionInfo1.Size = new System.Drawing.Size(757, 508);
            this.ctrLocalDrivingLinceseApplactionInfo1.TabIndex = 0;
            // 
            // FrmIssueLinceseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 750);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSaveIssueLicense);
            this.Controls.Add(this.TBTakeNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrLocalDrivingLinceseApplactionInfo1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIssueLinceseFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue License";
            this.Load += new System.EventHandler(this.FrmIssueLinceseFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Compoment_Tests.UC.CtrLocalDrivingLinceseApplactionInfo ctrLocalDrivingLinceseApplactionInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBTakeNotes;
        private System.Windows.Forms.Button BtnSaveIssueLicense;
        private System.Windows.Forms.Button BtnClose;
    }
}