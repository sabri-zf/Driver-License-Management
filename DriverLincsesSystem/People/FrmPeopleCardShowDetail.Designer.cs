namespace DriverLincsesSystem.People
{
    partial class FrmPeopleCardShowDetail
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
            this.btnBackPage = new System.Windows.Forms.Button();
            this.ctrCardPerson1 = new DriverLincsesSystem.People.UControl.CtrCardPerson();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Detail";
            // 
            // btnBackPage
            // 
            this.btnBackPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPage.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnBackPage.Location = new System.Drawing.Point(811, 437);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(119, 40);
            this.btnBackPage.TabIndex = 2;
            this.btnBackPage.Text = "Back";
            this.btnBackPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackPage.UseVisualStyleBackColor = true;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // ctrCardPerson1
            // 
            this.ctrCardPerson1.BackColor = System.Drawing.Color.White;
            this.ctrCardPerson1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrCardPerson1.Location = new System.Drawing.Point(0, 74);
            this.ctrCardPerson1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ctrCardPerson1.Name = "ctrCardPerson1";
            this.ctrCardPerson1.Size = new System.Drawing.Size(943, 354);
            this.ctrCardPerson1.TabIndex = 0;
            // 
            // FrmPeopleCardShowDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 486);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrCardPerson1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPeopleCardShowDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person Card";
            this.Load += new System.EventHandler(this.FrmPeopleCardShowDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UControl.CtrCardPerson ctrCardPerson1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackPage;
    }
}