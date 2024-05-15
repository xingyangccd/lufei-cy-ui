using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterModel
{
    public class UserInfo
    {

        //        CREATE TABLE UserInfo(
        //    UserId INTEGER       NOT NULL
        //                                PRIMARY KEY AUTOINCREMENT,
        //    UserName NVARCHAR (32),
        //    LoginUserName NVARCHAR(32) NOT NULL,
        //    Pwd           NVARCHAR(32) NOT NULL,
        //    LastLoginTime DATE,
        //    LastLoginIP NVARCHAR(32),
        //    DelFlag SMALLINT,
        //    SubTime       DATE
        //);

        public string LoginUserName { get; set; }

        public string Pwd { get; set; }

        public int DelFlag { get; set; }
    }


}
