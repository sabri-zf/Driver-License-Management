namespace DriverLincsesSystem.People.UControl
{
    partial class CtrCardPersonWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSerch = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.PictureBox();
            this.TBFilterInput = new System.Windows.Forms.TextBox();
            this.CBFilterPerson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrCardPerson1 = new DriverLincsesSystem.People.UControl.CtrCardPerson();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnSerch);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.TBFilterInput);
            this.panel1.Controls.Add(this.CBFilterPerson);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(111, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnSerch
            // 
            this.btnSerch.BackgroundImage = global::DriverLincsesSystem.Properties.Resources.SearchPerson1;
            this.btnSerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerch.Location = new System.Drawing.Point(511, 13);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(39, 32);
            this.btnSerch.TabIndex = 6;
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::DriverLincsesSystem.Properties.Resources.Add_Person_72;
            this.btnAddNew.Location = new System.Drawing.Point(573, 14);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(39, 28);
            this.btnAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // TBFilterInput
            // 
            this.TBFilterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFilterInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFilterInput.Location = new System.Drawing.Point(290, 14);
            this.TBFilterInput.Name = "TBFilterInput";
            this.TBFilterInput.Size = new System.Drawing.Size(199, 27);
            this.TBFilterInput.TabIndex = 3;
            this.TBFilterInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFilterInput_KeyPress);
            // 
            // CBFilterPerson
            // 
            this.CBFilterPerson.BackColor = System.Drawing.Color.White;
            this.CBFilterPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilterPerson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBFilterPerson.FormattingEnabled = true;
            this.CBFilterPerson.ItemHeight = 20;
            this.CBFilterPerson.Items.AddRange(new object[] {
            "Person ID",
            "National"});
            this.CBFilterPerson.Location = new System.Drawing.Point(127, 13);
            this.CBFilterPerson.Name = "CBFilterPerson";
            this.CBFilterPerson.Size = new System.Drawing.Size(148, 28);
            this.CBFilterPerson.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by :";
            // 
            // ctrCardPerson1
            // 
            this.ctrCardPerson1.BackColor = System.Drawing.Color.White;
            this.ctrCardPerson1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrCardPerson1.Location = new System.Drawing.Point(0, 64);
            this.ctrCardPerson1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrCardPerson1.Name = "ctrCardPerson1";
            this.ctrCardPerson1.Size = new System.Drawing.Size(947, 348);
            this.ctrCardPerson1.TabIndex = 1;
            // 
            // CtrCardPersonWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrCardPerson1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CtrCardPersonWithFilter";
            this.Size = new System.Drawing.Size(942, 414);
            this.Load += new System.EventHandler(this.CtrCardPersonWithFilter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBFilterPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnAddNew;
        private System.Windows.Forms.TextBox TBFilterInput;
        private CtrCardPerson ctrCardPerson1;
        private System.Windows.Forms.Button btnSerch;
    }
}
