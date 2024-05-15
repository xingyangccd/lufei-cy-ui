using Lufei_CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterDAL
{
    public class MemmberInfoDAL
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public List<MemmberInfo> GetMemmberInfo()
        {
            List<MemmberInfo> list=new List<MemmberInfo>();
            //拼接sql
            string sql = "SELECT * from MemmberInfo WHERE DelFlag = 0";

           DataTable dt=  SqlHelper.ExecuteDataTable(sql);
            if (dt.Rows.Count>0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    //关系转模型
                    list.Add(RowsToMemmberInfo(item));

                }
            }

            return list;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteMemmberById(int id)
        {
            string sql = "UPDATE MemmberInfo SET DelFlag = 1 WHERE MemmberId ="+ id;
           return SqlHelper.ExecuteNonQuery(sql);

        }



        /// <summary>
        /// 关系转模型
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public MemmberInfo RowsToMemmberInfo(DataRow dr)
        {
            MemmberInfo info = new MemmberInfo();
            info.MemNum = dr["MemNum"].ToString();
            info.MemName = dr["MemName"].ToString();
            info.MemGender =dr["MemGender"].ToString();
            info.MemType = Convert.ToInt32(dr["MemType"]);
            info.MemDiscount = Convert.ToDecimal(dr["MemDiscount"]);
            info.MemMoney = Convert.ToDecimal(dr["MemMoney"]);
            info.MemIntegral = Convert.ToInt32(dr["MemIntegral"]);
            info.MemBirthdaty = Convert.ToDateTime(dr["MemBirthdaty"]);
            info.MemMobilePhone =dr["MemMobilePhone"].ToString();
            info.MemPhone = dr["MemPhone"].ToString();
            info.MemEndServerTime = Convert.ToDateTime(dr["MemEndServerTime"]);
            info.SubTime =Convert.ToDateTime(dr["SubTime"]==DBNull.Value?DateTime.Now.ToString(): dr["SubTime"]);
            info.MemAddress = dr["MemAddress"].ToString();
            info.MemmberId = Convert.ToInt32(dr["MemmberId"]);
            info.DelFlag= Convert.ToInt32(dr["DelFlag"]);
            return info;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int InsertMemmber(MemmberInfo mi)
        {
            //1.拼接sql语句
            string sql = "insert into MemmberInfo (MemName,MemMobilePhone,MemType,MemNum,MemGender,MemDiscount,MemMoney,MemIntegral,MemEndServerTime,MemBirthdaty) values(@MemName,@MemMobilePhone,@MemType,@MemNum,@MemGender,@MemDiscount,@MemMoney,@MemIntegral,@MemEndServerTime,@MemBirthdaty)";

            //添加参数
            SQLiteParameter[] sQLiteParameters = new SQLiteParameter[]
            {
                new SQLiteParameter("MemName",mi.MemName),
                new SQLiteParameter("MemMobilePhone",mi.MemMobilePhone),
             new SQLiteParameter("MemNum",mi.MemNum),
                new SQLiteParameter("MemType",mi.MemType),
                new SQLiteParameter("MemGender",mi.MemGender),
                new SQLiteParameter("MemDiscount",mi.MemDiscount),
                new SQLiteParameter("MemMoney",mi.MemMoney),
               //new SQLiteParameter("DelFlag",mi.DelFlag),
               //new SQLiteParameter("SubTime",mi.SubTime),
               new SQLiteParameter("MemIntegral",mi.MemIntegral),
               new SQLiteParameter("MemEndServerTime",mi.MemEndServerTime),
               new SQLiteParameter("MemBirthdaty",mi.MemBirthdaty),
            };
            return   SqlHelper.ExecuteNonQuery(sql,sQLiteParameters);
        }


    }
}
