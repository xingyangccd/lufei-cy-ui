using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterDAL
{
    public static class SqlHelper
    {

        //读取配置文件 获取到连接字符串
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql,params SQLiteParameter[] param)
        {
            DataTable dt=new DataTable();
            //建立连接
            using (SQLiteConnection con=new SQLiteConnection(conStr))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql,con);

                adapter.SelectCommand.Parameters.AddRange(param);

                adapter.Fill(dt);
            }
            return dt;
        } 

        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] param)
        {
            int r = -1;
            using (SQLiteConnection con=new SQLiteConnection(conStr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddRange(param);
                    con.Open();
                   r= cmd.ExecuteNonQuery();

                }
            }
            return r;
        }

    }
}
