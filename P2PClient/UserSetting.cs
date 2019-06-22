using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web.Security;
using System.Data.Linq;

namespace P2PServer
{
    public partial class UserSetting : Form
    {
        public UserSetting()
        {
            InitializeComponent();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ServerData.dbDataContext db = new ServerData.dbDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            db.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED");

            ep_wf.Clear();


            switch (_Mode)
            {
                case "New":
                    try
                    {

                        MembershipUser usr = System.Web.Security.Membership.CreateUser(fd_username.Text, fd_password.Text);
                        MessageBox.Show("保存成功");
                    }
                    catch (Exception anyerror)
                    {

                        ep_wf.SetError(btn_Save, anyerror.Message + Environment.NewLine + anyerror.StackTrace);
                        fd_password.Enabled = true;
                    }

                    break;
                case "Modify":
                    try
                    {

                        MembershipUser user = System.Web.Security.Membership.GetUser(fd_username.Text);
                        if (fd_password.Text != "")
                        {
                            string NewPassword = user.ResetPassword();
                            user.ChangePassword(NewPassword, fd_password.Text);

                        }
                        if (fd_IsLock.Checked == false)
                        {
                            user.UnlockUser();

                        }
                        System.Web.Security.Membership.UpdateUser(user);
                        if (fd_IsLock.Checked == true)
                        {
                            ServerData.aspnet_Users aspnet_Users = db.aspnet_Users.SingleOrDefault(t => t.UserId == new Guid(user.ProviderUserKey.ToString()));
                            aspnet_Users.aspnet_Membership.IsLockedOut = true;
                            db.SubmitChanges();

                        }





                        MessageBox.Show("保存成功");


                    }
                    catch (Exception anyerror)
                    {

                        ep_wf.SetError(btn_Save, anyerror.Message + Environment.NewLine + anyerror.StackTrace);
                    }
                    break;
                case "MyData":
                    MembershipUser usermydata = System.Web.Security.Membership.GetUser(fd_username.Text);
                    if (fd_password.Text != "")
                    {
                        string NewPassword = usermydata.ResetPassword();
                        usermydata.ChangePassword(NewPassword, fd_password.Text);

                    }
                    System.Web.Security.Membership.UpdateUser(usermydata);



                    break;
                default:
                    break;
            }//按模式操作
            fd_password.Text = "";
            fd_password.Enabled = false;
            fd_IsLock.Checked = false;
            fd_IsLock.Enabled = false;
            db.SubmitChanges();

        }//函数结束

        private string _Mode = "";
        public void SetMode(string Mode)
        {
            _Mode = Mode;
            switch (Mode)
            {
                case "New":
                    Btn_Load.Visible = false;

                    break;
                case "Modify":
                    fd_password.Enabled = false;
                    fd_IsLock.Enabled = false;
                    btn_Save.Enabled = false;

                    break;
                case "MyData":
                    fd_username.Enabled = false;
                    TC_Main.Controls.Remove(TP_UserList);
                    fd_IsLock.Visible = false;
                    lbl_Islock.Visible = false;

                    fd_password.Enabled = false;
                    fd_IsLock.Enabled = false;
                    btn_Save.Enabled = false;









                    break;
                default:
                    break;
            }
        }



        private void Btn_Load_Click(object sender, EventArgs e)
        {


        }

        private void gv_UserList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (gv_UserList.SelectedRows.Count != 0)
            {
                fd_username.Text = gv_UserList.SelectedRows[0].Cells["UserName"].Value.ToString();
                TC_Main.SelectedTab = TP_Data;
                TP_Data.Show();
                Btn_Load_Click(null, null);

            }

        }

        private class UserInfoQ
        {
            public string UserId { get; set; }
            public string UserName { get; set; }
            public string IsLockedOut { get; set; }
        }

        private void UserSetting_Load(object sender, EventArgs e)
        {
            ServerData.dbDataContext db = new ServerData.dbDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);

            gv_UserList.DataSource = from usr in db.aspnet_Users
                                     join ship in db.aspnet_Membership on usr.UserId equals ship.UserId
                                     select new { usr.UserId, usr.UserName, ship.IsLockedOut }

                                                                              ;


        }



        private string Object2Str(object param, string NullValue = "")
        {

            return param == null ? NullValue : param.ToString();
        }




    }
}
