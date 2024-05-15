using lufei_cy_DLL;
using lufei_cy_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lufe_cy_BLL
{
    public class ManagerInfoBLL
    {
        ManagerInfoDAL managerInfoDAL = new ManagerInfoDAL();
        public List<ManagerInfo> GetManagers()
        {
           
            return managerInfoDAL.GetManager();
        }

        public bool Insert(ManagerInfo managerInfo)
        {
            //调用DAL层对象，进行数据库插入
           return  managerInfoDAL.Insert(managerInfo)>0;
        }

        public bool UpdateManagerInfo(ManagerInfo mi)
        {
            return managerInfoDAL.UpdateManagerInfo(mi)>0;
        }

        public bool DeleteManagerInfo(int id)
        {
            return managerInfoDAL.DeleteManagerInfo(id)>0;
        }

    }
}
