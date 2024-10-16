namespace DriverLincsesSystem.People
{
    partial class FrmPeopleCardWithFilter
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
            this.ctrCardPersonWithFilter1 = new DriverLincsesSystem.People.UControl.CtrCardPersonWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClosePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrCardPersonWithFilter1
            // 
            this.ctrCardPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrCardPersonWithFilter1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrCardPersonWithFilter1.Location = new System.Drawing.Point(-1, 86);
            this.ctrCardPersonWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrCardPersonWithFilter1.Name = "ctrCardPersonWithFilter1";
            this.ctrCardPersonWithFilter1.Size = new System.Drawing.Size(944, 430);
            this.ctrCardPersonWithFilter1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(323, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter Person";
            // 
            // btnClosePage
            // 
            this.btnClosePage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClosePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePage.Image = global::DriverLincsesSystem.Properties.Resources.Close_321;
            this.btnClosePage.Location = new System.Drawing.Point(756, 518);
            this.btnClosePage.Name = "btnClosePage";
            this.btnClosePage.Size = new System.Drawing.Size(142, 44);
            this.btnClosePage.TabIndex = 3;
            this.btnClosePage.Text = "Close";
            this.btnClosePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClosePage.UseVisualStyleBackColor = true;
            this.btnClosePage.Click += new System.EventHandler(this.btnClosePage_Click);
            // 
            // FrmPeopleCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 574);
            this.Controls.Add(this.btnClosePage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrCardPersonWithFilter1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPeopleCardWithFilter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter Person card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UControl.CtrCardPersonWithFilter ctrCardPersonWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClosePage;
    }
}