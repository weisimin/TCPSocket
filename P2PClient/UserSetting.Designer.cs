namespace P2PServer
{
    partial class UserSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ep_wf = new System.Windows.Forms.ErrorProvider(this.components);
            this.TC_Main = new System.Windows.Forms.TabControl();
            this.TP_Data = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.fd_username = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_Islock = new System.Windows.Forms.Label();
            this.fd_password = new System.Windows.Forms.TextBox();
            this.fd_IsLock = new System.Windows.Forms.CheckBox();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.TP_UserList = new System.Windows.Forms.TabPage();
            this.gv_UserList = new System.Windows.Forms.DataGridView();
            this.BS_UserList = new System.Windows.Forms.BindingSource(this.components);
            this.c_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IsLockOut = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ep_wf)).BeginInit();
            this.TC_Main.SuspendLayout();
            this.TP_Data.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TP_UserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // ep_wf
            // 
            this.ep_wf.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_wf.ContainerControl = this;
            // 
            // TC_Main
            // 
            this.TC_Main.Controls.Add(this.TP_Data);
            this.TC_Main.Controls.Add(this.TP_UserList);
            this.TC_Main.Location = new System.Drawing.Point(3, 12);
            this.TC_Main.Name = "TC_Main";
            this.TC_Main.SelectedIndex = 0;
            this.TC_Main.Size = new System.Drawing.Size(775, 538);
            this.TC_Main.TabIndex = 1;
            // 
            // TP_Data
            // 
            this.TP_Data.Controls.Add(this.tableLayoutPanel1);
            this.TP_Data.Location = new System.Drawing.Point(4, 22);
            this.TP_Data.Name = "TP_Data";
            this.TP_Data.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Data.Size = new System.Drawing.Size(767, 512);
            this.TP_Data.TabIndex = 0;
            this.TP_Data.Text = "资料";
            this.TP_Data.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_UserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fd_username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pwd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Islock, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fd_password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fd_IsLock, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Load, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 3, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(3, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(47, 12);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "会员号:";
            // 
            // fd_username
            // 
            this.fd_username.Location = new System.Drawing.Point(103, 3);
            this.fd_username.Name = "fd_username";
            this.fd_username.Size = new System.Drawing.Size(174, 21);
            this.fd_username.TabIndex = 1;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(3, 30);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(35, 12);
            this.lbl_pwd.TabIndex = 2;
            this.lbl_pwd.Text = "密码:";
            // 
            // lbl_Islock
            // 
            this.lbl_Islock.AutoSize = true;
            this.lbl_Islock.Location = new System.Drawing.Point(3, 60);
            this.lbl_Islock.Name = "lbl_Islock";
            this.lbl_Islock.Size = new System.Drawing.Size(35, 12);
            this.lbl_Islock.TabIndex = 3;
            this.lbl_Islock.Text = "锁定:";
            // 
            // fd_password
            // 
            this.fd_password.Location = new System.Drawing.Point(103, 33);
            this.fd_password.Name = "fd_password";
            this.fd_password.Size = new System.Drawing.Size(174, 21);
            this.fd_password.TabIndex = 5;
            // 
            // fd_IsLock
            // 
            this.fd_IsLock.AutoSize = true;
            this.fd_IsLock.Location = new System.Drawing.Point(103, 63);
            this.fd_IsLock.Name = "fd_IsLock";
            this.fd_IsLock.Size = new System.Drawing.Size(15, 14);
            this.fd_IsLock.TabIndex = 6;
            this.fd_IsLock.UseVisualStyleBackColor = true;
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(283, 3);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(75, 23);
            this.Btn_Load.TabIndex = 9;
            this.Btn_Load.Text = "加载";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(383, 333);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // TP_UserList
            // 
            this.TP_UserList.Controls.Add(this.gv_UserList);
            this.TP_UserList.Location = new System.Drawing.Point(4, 22);
            this.TP_UserList.Name = "TP_UserList";
            this.TP_UserList.Padding = new System.Windows.Forms.Padding(3);
            this.TP_UserList.Size = new System.Drawing.Size(767, 512);
            this.TP_UserList.TabIndex = 1;
            this.TP_UserList.Text = "列表";
            this.TP_UserList.UseVisualStyleBackColor = true;
            // 
            // gv_UserList
            // 
            this.gv_UserList.AllowUserToAddRows = false;
            this.gv_UserList.AllowUserToDeleteRows = false;
            this.gv_UserList.AllowUserToOrderColumns = true;
            this.gv_UserList.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_UserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_UserID,
            this.C_UserName,
            this.C_IsLockOut});
            this.gv_UserList.DataSource = this.BS_UserList;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_UserList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_UserList.Location = new System.Drawing.Point(7, 7);
            this.gv_UserList.MultiSelect = false;
            this.gv_UserList.Name = "gv_UserList";
            this.gv_UserList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_UserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_UserList.RowHeadersVisible = false;
            this.gv_UserList.RowTemplate.Height = 23;
            this.gv_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_UserList.Size = new System.Drawing.Size(754, 499);
            this.gv_UserList.TabIndex = 0;
            this.gv_UserList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_UserList_CellContentDoubleClick);
            // 
            // c_UserID
            // 
            this.c_UserID.DataPropertyName = "UserId";
            this.c_UserID.HeaderText = "用户ID";
            this.c_UserID.Name = "c_UserID";
            this.c_UserID.ReadOnly = true;
            // 
            // C_UserName
            // 
            this.C_UserName.DataPropertyName = "UserName";
            this.C_UserName.HeaderText = "用户名";
            this.C_UserName.Name = "C_UserName";
            this.C_UserName.ReadOnly = true;
            // 
            // C_IsLockOut
            // 
            this.C_IsLockOut.DataPropertyName = "IsLockedOut";
            this.C_IsLockOut.HeaderText = "锁定";
            this.C_IsLockOut.Name = "C_IsLockOut";
            this.C_IsLockOut.ReadOnly = true;
            this.C_IsLockOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_IsLockOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.TC_Main);
            this.Name = "UserSetting";
            this.Text = "用户设置";
            this.Load += new System.EventHandler(this.UserSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_wf)).EndInit();
            this.TC_Main.ResumeLayout(false);
            this.TP_Data.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TP_UserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ep_wf;
        private System.Windows.Forms.TabControl TC_Main;
        private System.Windows.Forms.TabPage TP_Data;
        private System.Windows.Forms.TabPage TP_UserList;
        private System.Windows.Forms.DataGridView gv_UserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLockedOut;
        private System.Windows.Forms.BindingSource BS_UserList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_UserName;
        public System.Windows.Forms.TextBox fd_username;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_Islock;
        private System.Windows.Forms.TextBox fd_password;
        private System.Windows.Forms.CheckBox fd_IsLock;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C_IsLockOut;


    }
}