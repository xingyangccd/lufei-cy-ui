using Lufei_CaterDAL;
using Lufei_CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterBLL
{
    public class MemmverInfoBLL
    {
        //创建Dal层对象
        MemmberInfoDAL dal = new MemmberInfoDAL();

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <returns></returns>
        public List<MemmberInfo> GetMemmverInfo()
        {
            return dal.GetMemmberInfo();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteMemmberById(int id)
        {
           return dal.DeleteMemmberById(id)>0;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool InsertMemmber(MemmberInfo mi)
        {
          return  dal.InsertMemmber(mi)>0;
        }

    }
}
