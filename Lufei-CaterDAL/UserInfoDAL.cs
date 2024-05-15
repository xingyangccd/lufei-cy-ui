using Lufei_CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterDAL
{
    public class UserInfoDAL
    {
        //调用sqlhelper   拼sql语句   关系转对象
        //通过用户名和是否删除来查询数据
        public UserInfo GetUserInfoByLoginUserName(string loginName)//GUIBUN
        {
            //提供对象
            UserInfo userInfo = null;

            string sql = "SELECT * FROM UserInfo WHERE DelFlag = 0 AND LoginUserName = @name";

        DataTable dt=    SqlHelper.ExecuteDataTable(sql,new System.Data.SQLite.SQLiteParameter("@name",loginName));

            //判断是否查询到数据
            if (dt.Rows.Count>0)
            {
                //关系转对象
                foreach (DataRow item in dt.Rows)
                {
                    userInfo= RowsToUserInfo(item);
                }
            }
            return userInfo;
        }


        /// <summary>
        /// 关系转对象
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public UserInfo RowsToUserInfo(DataRow dr)
        {
            UserInfo user = new UserInfo();
            user.LoginUserName = dr["LoginUserName"].ToString();
            user.Pwd = dr["Pwd"].ToString();
            return user;
        }

    }
}
