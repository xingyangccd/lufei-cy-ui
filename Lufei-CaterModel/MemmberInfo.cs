using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lufei_CaterModel
{
    public class MemmberInfo
    {
        //实体
        public int MemmberId { get; set; }
        public string MemName { get; set; }
        public string MemPhone { get; set; }
        public string MemMobilePhone { get; set; }
        public string MemAddress { get; set; }
        public int MemType { get; set; }
        public string MemNum { get; set; }
        public string MemGender { get; set; }
        public decimal MemDiscount { get; set; }
        public decimal MemMoney { get; set; }
        public int DelFlag { get; set; }
        public DateTime SubTime { get; set; }
        public int MemIntegral { get; set; }
        public DateTime MemEndServerTime { get; set; }
        public DateTime MemBirthdaty { get; set; }
    }
}
