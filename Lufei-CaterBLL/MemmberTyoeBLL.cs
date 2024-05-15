using Lufei_CaterDAL;
using Lufei_CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterBLL
{
    public class MemmberTyoeBLL
    {
        //创建DAL层对象
        MemmbereTypeDAL dal = new MemmbereTypeDAL();
        
        public List<MemmberType> GetMemmberType()
        {
          return   dal.GetMemmberType();
        }

    }
}
