using lufei_cy_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lufei_cy_DLL
{
    public class ManagerInfoDAL
    {
        //1.需要一个方法 调用sqlHelper获取 DataTable  2. 将TataTable中的数据转换成对象

        public List<ManagerInfo> GetManager()
        {
            string sql = "select * from ManagerInfo";

            //2.创建一个空对象集合
            List<ManagerInfo> list=new List<ManagerInfo>();
            //3.调用sqlhelper获取DataTable
           DataTable dt=  SqlHelper.ExecuteDataTable(sql);
            //4.把DataTable转换成模型实体 ---->表----》对象
            foreach (DataRow dr in dt.Rows)
            {

                list.Add(
               new ManagerInfo()
               {
                   MId = Convert.ToInt32(dr["MId"]),
                   MName = dr["MName"].ToString(),
                   MPwd = dr["MPwd"].ToString(),
                   MType = Convert.ToInt32(dr["MType"])
               }) ;
            }

            return list;

        }

        public int Insert(ManagerInfo managerInfo)
        {
            string sql = "insert into ManagerInfo(MName,MPwd,MType) values(@name,@pwd,@type)";
            //构建参数
            SQLiteParameter[] sqlParameters = new SQLiteParameter[] {
            new SQLiteParameter("@name",managerInfo.MName),
            new SQLiteParameter("@pwd",managerInfo.MPwd),
            new SQLiteParameter("@type",managerInfo.MType)
            };

            int r = -1;
            r=  SqlHelper.ExecuteNonQuery(sql, sqlParameters);
            return r;

        }

        public int UpdateManagerInfo(ManagerInfo mi)
        {
            int r = -1;
            //1.准备sql
            string sql = "update managerinfo set MName=@name,MPwd=@pwd,MType=@type where Mid=@id";
            //2.准备参数
            SQLiteParameter[] param = new SQLiteParameter[] {
                new SQLiteParameter("@name",mi.MName),
                new SQLiteParameter("@pwd",mi.MPwd),
                new SQLiteParameter("@type",mi.MType),
                new SQLiteParameter("@id",mi.MId)
            };
            //3.执行sqlhelper
            r= SqlHelper.ExecuteNonQuery(sql,param);
            //4.返回结果
            return r;
        }


        public int DeleteManagerInfo(int id)
        {
            string sql = "delete from managerinfo where  mid=" + id;
            return SqlHelper.ExecuteNonQuery(sql);
        }

    }
}
