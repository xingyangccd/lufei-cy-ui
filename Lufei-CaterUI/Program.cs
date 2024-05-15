using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lufei_CaterUI
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //在创建主窗体之前，先把登入窗体创建出来
            //FrmLogin fromLogin = new FrmLogin();

            ////fromLogin.Show();
            ////目标创建登入窗体时候阻断主窗体运行
            //fromLogin.ShowDialog(); //ShowDialog出来的窗体 我们称为模态窗体
            ////ShowDialog()会阻断后面的代码 知道你的对话框操作完成 才会接着向下执行
            ////当你的对话框的操作完成的时候 一定要改变对话框DialogResult的状态
            ////对fromLoginde1DialogResult属性进行判断
            //if (fromLogin.DialogResult==DialogResult.OK)
            //{
            //    Application.Run(new FrmMain());//设置main为主窗体
            //}
            Application.Run(new FrmMain());//设置main为主窗体
        }
    }
}
