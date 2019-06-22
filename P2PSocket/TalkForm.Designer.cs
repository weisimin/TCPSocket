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
            this.Btn_Start = new System.Windows.Forms.Button();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.gv_frend = new System.Windows.Forms.DataGridView();
            this.gv_talkhistory = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_ipandport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_online = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_receivetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_Raw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_ServerSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_frend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_talkhistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ServerSet
            // 
            this.gb_ServerSet.Controls.Add(this.Btn_Start);
            this.gb_ServerSet.Controls.Add(this.tb_port);
            this.gb_ServerSet.Controls.Add(this.tb_ip);
            this.gb_ServerSet.Controls.Add(this.lbl_port);
            this.gb_ServerSet.Controls.Add(this.lbl_ip);
            this.gb_ServerSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_ServerSet.Location = new System.Drawing.Point(12, 13);
            this.gb_ServerSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_ServerSet.Name = "gb_ServerSet";
            this.gb_ServerSet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_ServerSet.Size = new System.Drawing.Size(615, 75);
            this.gb_ServerSet.TabIndex = 1;
            this.gb_ServerSet.TabStop = false;
            this.gb_ServerSet.Text = "监听设置";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(313, 29);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "监听";
            this.Btn_Start.UseVisualStyleBackColor = true;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(192, 29);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 23);
            this.tb_port.TabIndex = 3;
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(36, 32);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 23);
            this.tb_ip.TabIndex = 2;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_port.Location = new System.Drawing.Point(151, 32);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(35, 17);
            this.lbl_port.TabIndex = 1;
            this.lbl_port.Text = "端口:";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ip.Location = new System.Drawing.Point(7, 32);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(22, 17);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "IP:";
            // 
            // gv_frend
            // 
            this.gv_frend.AllowUserToAddRows = false;
            this.gv_frend.AllowUserToDeleteRows = false;
            this.gv_frend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_frend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f_name,
            this.f_ipandport,
            this.f_online});
            this.gv_frend.Location = new System.Drawing.Point(12, 95);
            this.gv_frend.Name = "gv_frend";
            this.gv_frend.ReadOnly = true;
            this.gv_frend.RowHeadersWidth = 10;
            this.gv_frend.RowTemplate.Height = 23;
            this.gv_frend.Size = new System.Drawing.Size(197, 421);
            this.gv_frend.TabIndex = 2;
            // 
            // gv_talkhistory
            // 
            this.gv_talkhistory.AllowUserToAddRows = false;
            this.gv_talkhistory.AllowUserToDeleteRows = false;
            this.gv_talkhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_talkhistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.l_receivetime,
            this.l_Raw,
            this.l_Text});
            this.gv_talkhistory.Location = new System.Drawing.Point(216, 96);
            this.gv_talkhistory.Name = "gv_talkhistory";
            this.gv_talkhistory.ReadOnly = true;
            this.gv_talkhistory.RowHeadersWidth = 12;
            this.gv_talkhistory.RowTemplate.Height = 23;
            this.gv_talkhistory.Size = new System.Drawing.Size(397, 420);
            this.gv_talkhistory.TabIndex = 3;
            // 
            // f_name
            // 
            this.f_name.HeaderText = "好友";
            this.f_name.Name = "f_name";
            this.f_name.ReadOnly = true;
            this.f_name.Width = 80;
            // 
            // f_ipandport
            // 
            this.f_ipandport.HeaderText = "IP端口";
            this.f_ipandport.Name = "f_ipandport";
            this.f_ipandport.ReadOnly = true;
            this.f_ipandport.Width = 80;
            // 
            // f_online
            // 
            this.f_online.HeaderText = "在线";
            this.f_online.Name = "f_online";
            this.f_online.ReadOnly = true;
            // 
            // l_receivetime
            // 
            this.l_receivetime.HeaderText = "时间";
            this.l_receivetime.Name = "l_receivetime";
            this.l_receivetime.ReadOnly = true;
            // 
            // l_Raw
            // 
            this.l_Raw.HeaderText = "包文";
            this.l_Raw.Name = "l_Raw";
            this.l_Raw.ReadOnly = true;
            // 
            // l_Text
            // 
            this.l_Text.HeaderText = "内容";
            this.l_Text.Name = "l_Text";
            this.l_Text.ReadOnly = true;
            this.l_Text.Width = 250;
            // 
            // TalkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 528);
            this.Controls.Add(this.gv_talkhistory);
            this.Controls.Add(this.gv_frend);
            this.Controls.Add(this.gb_ServerSet);
            this.Name = "TalkForm";
            this.Text = "通讯窗口";
            this.gb_ServerSet.ResumeLayout(false);
            this.gb_ServerSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_frend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_talkhistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ServerSet;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.DataGridView gv_frend;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_ipandport;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_online;
        private System.Windows.Forms.DataGridView gv_talkhistory;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_receivetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_Raw;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_Text;
    }
}

