using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
namespace P2PServer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);
            AddSecurityControll2File(Application.StartupPath + "\\TCPSocket.mdf");
            AddSecurityControll2File(Application.StartupPath + "\\TCPSocket_log.ldf");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StatusForm());
        }
        static void AddSecurityControll2File(string filePath)
        {

            //获取文件信息
            FileInfo fileInfo = new FileInfo(filePath);
            //获得该文件的访问权限
            System.Security.AccessControl.FileSecurity fileSecurity = fileInfo.GetAccessControl();
            //添加ereryone用户组的访问权限规则 完全控制权限
            fileSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
            //添加Users用户组的访问权限规则 完全控制权限
            fileSecurity.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
            //设置访问权限
            fileInfo.SetAccessControl(fileSecurity);
        }
    }
}
