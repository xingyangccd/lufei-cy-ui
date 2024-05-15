using Lufei_CaterDAL;
using Lufei_CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterBLL
{
    public class UserInfoBLL
    {
        UserInfoDAL userInfoDAL = new UserInfoDAL();

        public bool GetUserInfoByLoginUserName(UserInfo userino,out string msg)
        {
            UserInfo user=   userInfoDAL.GetUserInfoByLoginUserName(userino.LoginUserName);
            if (user!=null)
            {
                //查询到了用户  但是 密码不一样
                if (userino.Pwd==user.Pwd)
                {
                    msg = "登入成功";
                    return true;
                }
                else
                {
                    msg = "密码不正常";
                    return false;
                }

            }
            else
            {
                msg = "用户名不存在";
                return false;
            }

        }


    }
}
