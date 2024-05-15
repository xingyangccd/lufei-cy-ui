using Lufei_CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterDAL
{
    public class MemmbereTypeDAL
    {
        public List<MemmberType> GetMemmberType()
        {
            List<MemmberType> list = new List<MemmberType>();
            string sql = "SELECT * FROM MemmberType WHERE DelFlag =0";
            DataTable dt=   SqlHelper.ExecuteDataTable(sql);
            //关系转对象

            if (dt.Rows.Count>0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    list.Add(RowsToMemberType(item));
                }
            }
            return list;
        }

        public MemmberType RowsToMemberType(DataRow row)
        {
            MemmberType mem = new MemmberType();
            mem.MemType = Convert.ToInt32(row["MemType"]);
            mem.MemTpName = row["MemTpName"].ToString();
            return mem;
        }

    }
}
