using Lufei_CaterBLL;
using Lufei_CaterModel;
using Lufei_CaterUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ItcastCater
{
    public partial class FrmMemmberInfo : Form
    {
        public FrmMemmberInfo()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //创建业务逻辑层对象
        MemmverInfoBLL bll = new MemmverInfoBLL(); 
        private void FrmMemmberInfo_Load(object sender, EventArgs e)
        {
            //取消自动生成列
            dgvMemmber.AutoGenerateColumns = false;
            InitMemmberData();
           //取消第一行被选中
            dgvMemmber.SelectedRows[0].Selected = false;
        }

        private void InitMemmberData()
        {
            //进行数据加载
            List<MemmberInfo> list = bll.GetMemmverInfo();

            //将集合赋值给DataGridView
            dgvMemmber.DataSource = list;

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            //第Cells[0]绑定的第0个索引就是id
           int id= Convert.ToInt32(dgvMemmber.SelectedRows[0].Cells[0].Value);
            bool isDleted = bll.DeleteMemmberById(id);
            if (isDleted)
            {
                MessageBox.Show("删除成功");
                //todo 重写加载数据
                InitMemmberData();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btnAddMemMber_Click(object sender, EventArgs e)
        {
            FrmAdd frmadd = new FrmAdd();
            frmadd.FormClosed += Frmadd_FormClosed;//注册关闭事件
            frmadd.ShowDialog();
        }

        private void Frmadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitMemmberData();
        }
    }
}
