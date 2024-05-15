using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;//1.引用sqlLite
using System.Configuration;
using System.Data;

namespace lufei_cy_DLL
{
    public static class SqlHelper
    {
        //2.获取连接字符串
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="param">参数</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql,params SQLiteParameter[] param)
        {
            DataTable dt = new DataTable();

            //创建连接通道
            using (SQLiteConnection con=new SQLiteConnection(conStr))
            {
                //添加数据
                //创建adapter对象
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, con);
                adapter.SelectCommand.Parameters.AddRange(param);
                //执行
                adapter.Fill(dt);
            }

            return dt;

        }


        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string  sql,params SQLiteParameter[] param)
        {

            int r = -1;
            using (SQLiteConnection con=new SQLiteConnection(conStr))
            {
                using (SQLiteCommand cmd=new SQLiteCommand(sql,con))
                {
                    //添加参数
                    cmd.Parameters.AddRange(param);
                    //打开连接
                    con.Open();
                    //执行增删改
                    r = cmd.ExecuteNonQuery();
                }
            }
            return r;
        }

    }
}
