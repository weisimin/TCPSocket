namespace P2PSocket
{
    partial class TalkForm
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
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_usr = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.gv_Friend = new System.Windows.Forms.DataGridView();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_online = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_Friend = new System.Windows.Forms.BindingSource(this.components);
            this.gv_talkhistory = new System.Windows.Forms.DataGridView();
            this.bs_TalkkingMessage = new System.Windows.Forms.BindingSource(this.components);
            this.gb_talking = new System.Windows.Forms.GroupBox();
            this.Btn_UDPSend = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.l_MessageTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_RawJson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_ServerSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Friend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Friend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_talkhistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TalkkingMessage)).BeginInit();
            this.gb_talking.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ServerSet
            // 
            this.gb_ServerSet.Controls.Add(this.tb_password);
            this.gb_ServerSet.Controls.Add(this.tb_username);
            this.gb_ServerSet.Controls.Add(this.lbl_pwd);
            this.gb_ServerSet.Controls.Add(this.lbl_usr);
            this.gb_ServerSet.Controls.Add(this.Btn_Start);
            this.gb_ServerSet.Controls.Add(this.tb_port);
            this.gb_ServerSet.Controls.Add(this.tb_ip);
            this.gb_ServerSet.Controls.Add(this.lbl_port);
            this.gb_ServerSet.Controls.Add(this.lbl_ip);
            this.gb_ServerSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_ServerSet.Location = new System.Drawing.Point(12, 4);
            this.gb_ServerSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_ServerSet.Name = "gb_ServerSet";
            this.gb_ServerSet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_ServerSet.Size = new System.Drawing.Size(615, 84);
            this.gb_ServerSet.TabIndex = 1;
            this.gb_ServerSet.TabStop = false;
            this.gb_ServerSet.Text = "服务器设置";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(222, 46);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 23);
            this.tb_password.TabIndex = 8;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(66, 49);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 23);
            this.tb_username.TabIndex = 7;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pwd.Location = new System.Drawing.Point(181, 49);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(35, 17);
            this.lbl_pwd.TabIndex = 6;
            this.lbl_pwd.Text = "密码:";
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_usr.Location = new System.Drawing.Point(7, 49);
            this.lbl_usr.Name = "lbl_usr";
            this.lbl_usr.Size = new System.Drawing.Size(47, 17);
            this.lbl_usr.TabIndex = 5;
            this.lbl_usr.Text = "用户名:";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(526, 32);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "登录";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(222, 18);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 23);
            this.tb_port.TabIndex = 3;
            this.tb_port.Text = "9230";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(66, 21);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 23);
            this.tb_ip.TabIndex = 2;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_port.Location = new System.Drawing.Point(181, 21);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(35, 17);
            this.lbl_port.TabIndex = 1;
            this.lbl_port.Text = "端口:";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ip.Location = new System.Drawing.Point(7, 21);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(22, 17);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "IP:";
            // 
            // gv_Friend
            // 
            this.gv_Friend.AllowUserToAddRows = false;
            this.gv_Friend.AllowUserToDeleteRows = false;
            this.gv_Friend.AutoGenerateColumns = false;
            this.gv_Friend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Friend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f_name,
            this.f_ip,
            this.f_online});
            this.gv_Friend.DataSource = this.bs_Friend;
            this.gv_Friend.Location = new System.Drawing.Point(12, 95);
            this.gv_Friend.MultiSelect = false;
            this.gv_Friend.Name = "gv_Friend";
            this.gv_Friend.ReadOnly = true;
            this.gv_Friend.RowHeadersWidth = 10;
            this.gv_Friend.RowTemplate.Height = 23;
            this.gv_Friend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Friend.Size = new System.Drawing.Size(197, 421);
            this.gv_Friend.TabIndex = 2;
            this.gv_Friend.SelectionChanged += new System.EventHandler(this.gv_Friend_SelectionChanged);
            // 
            // f_name
            // 
            this.f_name.DataPropertyName = "UserName";
            this.f_name.HeaderText = "好友";
            this.f_name.Name = "f_name";
            this.f_name.ReadOnly = true;
            this.f_name.Width = 80;
            // 
            // f_ip
            // 
            this.f_ip.DataPropertyName = "IP";
            this.f_ip.HeaderText = "IP";
            this.f_ip.Name = "f_ip";
            this.f_ip.ReadOnly = true;
            this.f_ip.Width = 80;
            // 
            // f_online
            // 
            this.f_online.DataPropertyName = "OnLine";
            this.f_online.HeaderText = "在线";
            this.f_online.Name = "f_online";
            this.f_online.ReadOnly = true;
            // 
            // gv_talkhistory
            // 
            this.gv_talkhistory.AllowUserToAddRows = false;
            this.gv_talkhistory.AllowUserToDeleteRows = false;
            this.gv_talkhistory.AutoGenerateColumns = false;
            this.gv_talkhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_talkhistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.l_MessageTime,
            this.l_Content,
            this.l_RawJson});
            this.gv_talkhistory.DataSource = this.bs_TalkkingMessage;
            this.gv_talkhistory.Location = new System.Drawing.Point(6, 20);
            this.gv_talkhistory.Name = "gv_talkhistory";
            this.gv_talkhistory.ReadOnly = true;
            this.gv_talkhistory.RowHeadersWidth = 12;
            this.gv_talkhistory.RowTemplate.Height = 23;
            this.gv_talkhistory.Size = new System.Drawing.Size(409, 272);
            this.gv_talkhistory.TabIndex = 3;
            // 
            // gb_talking
            // 
            this.gb_talking.Controls.Add(this.Btn_UDPSend);
            this.gb_talking.Controls.Add(this.btn_send);
            this.gb_talking.Controls.Add(this.tb_content);
            this.gb_talking.Controls.Add(this.gv_talkhistory);
            this.gb_talking.Location = new System.Drawing.Point(215, 95);
            this.gb_talking.Name = "gb_talking";
            this.gb_talking.Size = new System.Drawing.Size(421, 421);
            this.gb_talking.TabIndex = 4;
            this.gb_talking.TabStop = false;
            this.gb_talking.Text = "聊天：";
            // 
            // Btn_UDPSend
            // 
            this.Btn_UDPSend.Location = new System.Drawing.Point(342, 359);
            this.Btn_UDPSend.Name = "Btn_UDPSend";
            this.Btn_UDPSend.Size = new System.Drawing.Size(72, 56);
            this.Btn_UDPSend.TabIndex = 6;
            this.Btn_UDPSend.Text = "P2P发送";
            this.Btn_UDPSend.UseVisualStyleBackColor = true;
            this.Btn_UDPSend.Click += new System.EventHandler(this.Btn_UDPSend_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(343, 299);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(72, 56);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "服务器发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(6, 298);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(330, 107);
            this.tb_content.TabIndex = 4;
            // 
            // l_MessageTime
            // 
            this.l_MessageTime.DataPropertyName = "MessageTime";
            this.l_MessageTime.HeaderText = "时间";
            this.l_MessageTime.Name = "l_MessageTime";
            this.l_MessageTime.ReadOnly = true;
            // 
            // l_Content
            // 
            this.l_Content.DataPropertyName = "Content";
            this.l_Content.HeaderText = "内容";
            this.l_Content.Name = "l_Content";
            this.l_Content.ReadOnly = true;
            this.l_Content.Width = 250;
            // 
            // l_RawJson
            // 
            this.l_RawJson.DataPropertyName = "RawJson";
            this.l_RawJson.HeaderText = "包文";
            this.l_RawJson.Name = "l_RawJson";
            this.l_RawJson.ReadOnly = true;
            // 
            // TalkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 528);
            this.Controls.Add(this.gb_talking);
            this.Controls.Add(this.gv_Friend);
            this.Controls.Add(this.gb_ServerSet);
            this.Name = "TalkForm";
            this.Text = "通讯窗口";
            this.gb_ServerSet.ResumeLayout(false);
            this.gb_ServerSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Friend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Friend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_talkhistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TalkkingMessage)).EndInit();
            this.gb_talking.ResumeLayout(false);
            this.gb_talking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ServerSet;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.DataGridView gv_Friend;
        private System.Windows.Forms.DataGridView gv_talkhistory;
        private System.Windows.Forms.BindingSource bs_Friend;
        private System.Windows.Forms.BindingSource bs_TalkkingMessage;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_usr;
        private System.Windows.Forms.GroupBox gb_talking;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Button Btn_UDPSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_online;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_MessageTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_RawJson;
    }
}

