namespace P2PServer
{
    partial class StatusForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_ServerSet = new System.Windows.Forms.GroupBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.ST_Stus = new System.Windows.Forms.StatusStrip();
            this.STL_Inf = new System.Windows.Forms.ToolStripStatusLabel();
            this.gb_ConnectState = new System.Windows.Forms.GroupBox();
            this.gv_statusdata = new System.Windows.Forms.DataGridView();
            this.c_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_RecTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_RecContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MI_UserManager = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_NewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Bs_StatusData = new System.Windows.Forms.BindingSource(this.components);
            this.gb_ServerSet.SuspendLayout();
            this.ST_Stus.SuspendLayout();
            this.gb_ConnectState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_statusdata)).BeginInit();
            this.CMS_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bs_StatusData)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ServerSet
            // 
            this.gb_ServerSet.Controls.Add(this.btn_check);
            this.gb_ServerSet.Controls.Add(this.Btn_Start);
            this.gb_ServerSet.Controls.Add(this.tb_port);
            this.gb_ServerSet.Controls.Add(this.tb_ip);
            this.gb_ServerSet.Controls.Add(this.lbl_port);
            this.gb_ServerSet.Controls.Add(this.lbl_ip);
            this.gb_ServerSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_ServerSet.Location = new System.Drawing.Point(12, 3);
            this.gb_ServerSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_ServerSet.Name = "gb_ServerSet";
            this.gb_ServerSet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_ServerSet.Size = new System.Drawing.Size(615, 85);
            this.gb_ServerSet.TabIndex = 0;
            this.gb_ServerSet.TabStop = false;
            this.gb_ServerSet.Text = "监听设置";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(523, 29);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "检查IP";
            this.btn_check.UseVisualStyleBackColor = true;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(386, 29);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "监听";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(242, 25);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 23);
            this.tb_port.TabIndex = 3;
            this.tb_port.Text = "9230";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(36, 25);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 23);
            this.tb_ip.TabIndex = 2;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_port.Location = new System.Drawing.Point(151, 28);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(35, 17);
            this.lbl_port.TabIndex = 1;
            this.lbl_port.Text = "端口:";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ip.Location = new System.Drawing.Point(7, 25);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(22, 17);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "IP:";
            // 
            // ST_Stus
            // 
            this.ST_Stus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STL_Inf});
            this.ST_Stus.Location = new System.Drawing.Point(0, 349);
            this.ST_Stus.Name = "ST_Stus";
            this.ST_Stus.Size = new System.Drawing.Size(678, 22);
            this.ST_Stus.TabIndex = 1;
            this.ST_Stus.Text = "statusStrip1";
            // 
            // STL_Inf
            // 
            this.STL_Inf.Name = "STL_Inf";
            this.STL_Inf.Size = new System.Drawing.Size(35, 17);
            this.STL_Inf.Text = "监听:";
            // 
            // gb_ConnectState
            // 
            this.gb_ConnectState.Controls.Add(this.gv_statusdata);
            this.gb_ConnectState.Location = new System.Drawing.Point(12, 96);
            this.gb_ConnectState.Name = "gb_ConnectState";
            this.gb_ConnectState.Size = new System.Drawing.Size(615, 250);
            this.gb_ConnectState.TabIndex = 2;
            this.gb_ConnectState.TabStop = false;
            this.gb_ConnectState.Text = "客户端：";
            // 
            // gv_statusdata
            // 
            this.gv_statusdata.AllowUserToAddRows = false;
            this.gv_statusdata.AllowUserToDeleteRows = false;
            this.gv_statusdata.AllowUserToOrderColumns = true;
            this.gv_statusdata.AutoGenerateColumns = false;
            this.gv_statusdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_statusdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_IP,
            this.C_Port,
            this.C_RecTime,
            this.C_RecContent});
            this.gv_statusdata.ContextMenuStrip = this.CMS_Main;
            this.gv_statusdata.DataSource = this.Bs_StatusData;
            this.gv_statusdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_statusdata.Location = new System.Drawing.Point(3, 19);
            this.gv_statusdata.Name = "gv_statusdata";
            this.gv_statusdata.ReadOnly = true;
            this.gv_statusdata.RowTemplate.Height = 23;
            this.gv_statusdata.Size = new System.Drawing.Size(609, 228);
            this.gv_statusdata.TabIndex = 0;
            // 
            // c_IP
            // 
            this.c_IP.HeaderText = "IP";
            this.c_IP.Name = "c_IP";
            this.c_IP.ReadOnly = true;
            // 
            // C_Port
            // 
            this.C_Port.HeaderText = "端口";
            this.C_Port.Name = "C_Port";
            this.C_Port.ReadOnly = true;
            // 
            // C_RecTime
            // 
            this.C_RecTime.HeaderText = "最后时间";
            this.C_RecTime.Name = "C_RecTime";
            this.C_RecTime.ReadOnly = true;
            // 
            // C_RecContent
            // 
            this.C_RecContent.HeaderText = "最后消息";
            this.C_RecContent.Name = "C_RecContent";
            this.C_RecContent.ReadOnly = true;
            this.C_RecContent.Width = 250;
            // 
            // CMS_Main
            // 
            this.CMS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_UserManager,
            this.MI_NewUser});
            this.CMS_Main.Name = "CMS_Main";
            this.CMS_Main.Size = new System.Drawing.Size(125, 48);
            // 
            // MI_UserManager
            // 
            this.MI_UserManager.Name = "MI_UserManager";
            this.MI_UserManager.Size = new System.Drawing.Size(124, 22);
            this.MI_UserManager.Text = "用户管理";
            this.MI_UserManager.Click += new System.EventHandler(this.MI_UserManager_Click);
            // 
            // MI_NewUser
            // 
            this.MI_NewUser.Name = "MI_NewUser";
            this.MI_NewUser.Size = new System.Drawing.Size(124, 22);
            this.MI_NewUser.Text = "新用户";
            this.MI_NewUser.Click += new System.EventHandler(this.MI_NewUser_Click);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 371);
            this.Controls.Add(this.gb_ConnectState);
            this.Controls.Add(this.ST_Stus);
            this.Controls.Add(this.gb_ServerSet);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StatusForm";
            this.Text = "连接状态";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.gb_ServerSet.ResumeLayout(false);
            this.gb_ServerSet.PerformLayout();
            this.ST_Stus.ResumeLayout(false);
            this.ST_Stus.PerformLayout();
            this.gb_ConnectState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_statusdata)).EndInit();
            this.CMS_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bs_StatusData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ServerSet;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.StatusStrip ST_Stus;
        private System.Windows.Forms.ToolStripStatusLabel STL_Inf;
        private System.Windows.Forms.GroupBox gb_ConnectState;
        private System.Windows.Forms.DataGridView gv_statusdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_RecTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_RecContent;
        private System.Windows.Forms.BindingSource Bs_StatusData;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem MI_UserManager;
        private System.Windows.Forms.ToolStripMenuItem MI_NewUser;
    }
}

