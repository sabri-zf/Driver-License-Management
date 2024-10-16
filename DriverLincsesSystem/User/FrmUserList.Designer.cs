namespace DriverLincsesSystem.User
{
    partial class FrmUserList
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
            this.label1 = new System.Windows.Forms.Label();
            this.CMListOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.CbFilrterUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labTotalUsers = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.btnCloseFrmUser = new System.Windows.Forms.Button();
            this.CMListOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(379, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mange User";
            // 
            // CMListOption
            // 
            this.CMListOption.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.CMListOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.delteUserToolStripMenuItem,
            this.sendMessageToolStripMenuItem,
            this.callUserToolStripMenuItem});
            this.CMListOption.Name = "CMListOption";
            this.CMListOption.Size = new System.Drawing.Size(183, 196);
            // 
            // showUserToolStripMenuItem
            // 
            this.showUserToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.account_settings_641;
            this.showUserToolStripMenuItem.Name = "showUserToolStripMenuItem";
            this.showUserToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.showUserToolStripMenuItem.Text = "Show User";
            this.showUserToolStripMenuItem.Click += new System.EventHandler(this.showUserToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Add_New_User_72;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Users_2_4001;
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // delteUserToolStripMenuItem
            // 
            this.delteUserToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.Delete_User_32;
            this.delteUserToolStripMenuItem.Name = "delteUserToolStripMenuItem";
            this.delteUserToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.delteUserToolStripMenuItem.Text = "Delete User";
            this.delteUserToolStripMenuItem.Click += new System.EventHandler(this.delteUserToolStripMenuItem_Click);
            // 
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.send_email_32;
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.sendMessageToolStripMenuItem.Text = "Send Message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToolStripMenuItem_Click);
            // 
            // callUserToolStripMenuItem
            // 
            this.callUserToolStripMenuItem.Image = global::DriverLincsesSystem.Properties.Resources.call_32;
            this.callUserToolStripMenuItem.Name = "callUserToolStripMenuItem";
            this.callUserToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.callUserToolStripMenuItem.Text = "Call User";
            this.callUserToolStripMenuItem.Click += new System.EventHandler(this.callUserToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter by : ";
            // 
            // CbFilrterUser
            // 
            this.CbFilrterUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilrterUser.FormattingEnabled = true;
            this.CbFilrterUser.Location = new System.Drawing.Point(235, 189);
            this.CbFilrterUser.Name = "CbFilrterUser";
            this.CbFilrterUser.Size = new System.Drawing.Size(154, 28);
            this.CbFilrterUser.TabIndex = 4;
            this.CbFilrterUser.SelectedIndexChanged += new System.EventHandler(this.CbFilrterUser_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "#Record ";
            // 
            // labTotalUsers
            // 
            this.labTotalUsers.AutoSize = true;
            this.labTotalUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalUsers.Location = new System.Drawing.Point(93, 541);
            this.labTotalUsers.Name = "labTotalUsers";
            this.labTotalUsers.Size = new System.Drawing.Size(22, 25);
            this.labTotalUsers.TabIndex = 7;
            this.labTotalUsers.Text = "0";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::DriverLincsesSystem.Properties.Resources.Add_New_User_72;
            this.btnAddUser.Location = new System.Drawing.Point(776, 186);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(68, 35);
            this.btnAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverLincsesSystem.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(304, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.AllowUserToAddRows = false;
            this.dgvListUsers.AllowUserToDeleteRows = false;
            this.dgvListUsers.AllowUserToResizeColumns = false;
            this.dgvListUsers.AllowUserToResizeRows = false;
            this.dgvListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.Location = new System.Drawing.Point(3, 227);
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.RowTemplate.ContextMenuStrip = this.CMListOption;
            this.dgvListUsers.RowTemplate.ReadOnly = true;
            this.dgvListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListUsers.ShowCellErrors = false;
            this.dgvListUsers.ShowCellToolTips = false;
            this.dgvListUsers.ShowEditingIcon = false;
            this.dgvListUsers.ShowRowErrors = false;
            this.dgvListUsers.Size = new System.Drawing.Size(939, 311);
            this.dgvListUsers.TabIndex = 2;
            // 
            // btnCloseFrmUser
            // 
            this.btnCloseFrmUser.Image = global::DriverLincsesSystem.Properties.Resources.Close_32;
            this.btnCloseFrmUser.Location = new System.Drawing.Point(804, 561);
            this.btnCloseFrmUser.Name = "btnCloseFrmUser";
            this.btnCloseFrmUser.Size = new System.Drawing.Size(126, 39);
            this.btnCloseFrmUser.TabIndex = 8;
            this.btnCloseFrmUser.Text = "Close";
            this.btnCloseFrmUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseFrmUser.UseVisualStyleBackColor = true;
            this.btnCloseFrmUser.Click += new System.EventHandler(this.btnCloseFrmUser_Click);
            // 
            // FrmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 612);
            this.Controls.Add(this.btnCloseFrmUser);
            this.Controls.Add(this.labTotalUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.CbFilrterUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User List";
            this.Load += new System.EventHandler(this.FrmUserList_Load);
            this.CMListOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbFilrterUser;
        private System.Windows.Forms.PictureBox btnAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labTotalUsers;
        private System.Windows.Forms.ContextMenuStrip CMListOption;
        private System.Windows.Forms.ToolStripMenuItem showUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callUserToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.Button btnCloseFrmUser;
    }
}