using CommonCater;
using Lufei_CaterBLL;
using Lufei_CaterModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lufei_CaterUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //点击退出的时候 关闭窗体
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //登入成功的时候 才会执行 this.DialogResult= DialogResult.OK;
            //1.先判断2个文本框是否输入了数据
            if (Check())
            {
                //输入了输入
                string name=txtName.Text.Trim();
                string pwd=txtPwd.Text.Trim();
                //对密码进行md5加密
                pwd= MD5Helper.GetMD5(pwd);

                //2.调用业务逻辑层代码堆用户名和密码进行判断
                UserInfoBLL userInfoBLL = new UserInfoBLL();
                UserInfo user = new UserInfo();//构建user对象
                user.LoginUserName = name;
                user.Pwd = pwd;
                string msg = "";
                bool isLogin=  userInfoBLL.GetUserInfoByLoginUserName(user,out msg);
                //3.判断登入结果
                if (isLogin)
                {
                    // MessageBox.Show(msg);
                    msgDiv1.MsgDivShow(msg,1, ChangeDialog);
                    //更改当前的模态窗体状态
                   
                }
                else
                {
                    // MessageBox.Show(msg);
                    msgDiv1.MsgDivShow(msg, 1);
                }
            }

        }


        private void ChangeDialog()
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 判断是否输入了文本
        /// </summary>
        private bool Check()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                //  MessageBox.Show("用户名不能为空");
                msgDiv1.MsgDivShow("用户名不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                //   MessageBox.Show("密码不能为空");
                msgDiv1.MsgDivShow("密码不能为空", 1);
                return false;
            }
            return true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
    
        }
    }
}
