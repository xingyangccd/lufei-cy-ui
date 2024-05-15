using lufe_cy_BLL;
using lufei_cy_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lufei_cy_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //获取从BLL层传递过来的数据
        ManagerInfoBLL managerInfoBLL = new ManagerInfoBLL();
        private void Form1_Load(object sender, EventArgs e)
        {
            //把自动生成列设置为false
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            InitialData();


        }

        public void InitialData()
        {
            List<ManagerInfo> managerInfos = managerInfoBLL.GetManagers();
            dataGridView1.DataSource = managerInfos;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //添加数据
            //获取数据
            string name = textBox2.Text.Trim();
            string pwd = textBox3.Text.Trim();
            int type= radioButton1.Checked ? 1 : 0;
            //构建对象
            ManagerInfo addManagerInfo = new ManagerInfo() {
                MName = name,
                MPwd = pwd,
                MType = type
            };
            bool b=  managerInfoBLL.Insert(addManagerInfo);
            if (b)
            {
                MessageBox.Show("添加成功");
                InitialData();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取要修改数据的id
           int mid= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            //拿到要修改的数据
            string name = textBox2.Text.Trim();
            string pwd = textBox3.Text.Trim();
            int type = radioButton1.Checked ? 1 : 0;
            //构建成对象
            ManagerInfo mi = new ManagerInfo() { 
            MId= mid,
            MName= name,
            MPwd= pwd,
            MType= type
            };
            //对象传递成BLL层
            bool b = managerInfoBLL.UpdateManagerInfo(mi);
            if (b)
            {
                MessageBox.Show("修改成功");
                InitialData();
            }
            else
            {
                MessageBox.Show("修改失败");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //获取要修改数据的id
            int mid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
          bool b=  managerInfoBLL.DeleteManagerInfo(mid);
            if (b)
            {
                MessageBox.Show("删除成功");
                InitialData();
            }
            else
            {
                MessageBox.Show("删除失败");
            }

        }
    }
}
