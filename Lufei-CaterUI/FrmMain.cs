using ItcastCater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lufei_CaterUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMemmber_Click(object sender, EventArgs e)
        {
            //创建会员管理页面
            FrmMemmberInfo frmMemmber = new FrmMemmberInfo();
            frmMemmber.Show();//使用show FrmMemmberInfo_Load

        }
    }
}
