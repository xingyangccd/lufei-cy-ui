using Lufei_CaterBLL;
using Lufei_CaterModel;
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
    public partial class FrmAdd : Form
    {
        private DateTimePicker dtEndServerTime;
        private Label labId;
        private ComboBox cmbMemType;
        private RadioButton rdoWomen;
        private RadioButton rdoMan;
        private Button btnOk;
        private TextBox txtMemDiscount;
        private Label label9;
        private TextBox txtMemPhone;
        private Label label8;
        private TextBox txtBirs;
        private Label label7;
        private TextBox txtMemIntegral;
        private Label label6;
        private TextBox txtmemMoney;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtMemName;
        private Label label2;
        private TextBox txtMemNum;
        private Label label1;

        public FrmAdd()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dtEndServerTime = new System.Windows.Forms.DateTimePicker();
            this.labId = new System.Windows.Forms.Label();
            this.cmbMemType = new System.Windows.Forms.ComboBox();
            this.rdoWomen = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtMemDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMemPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBirs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMemIntegral = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmemMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtEndServerTime
            // 
            this.dtEndServerTime.Location = new System.Drawing.Point(341, 153);
            this.dtEndServerTime.Name = "dtEndServerTime";
            this.dtEndServerTime.Size = new System.Drawing.Size(158, 21);
            this.dtEndServerTime.TabIndex = 163;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(424, 189);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 12);
            this.labId.TabIndex = 162;
            this.labId.Visible = false;
            // 
            // cmbMemType
            // 
            this.cmbMemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemType.FormattingEnabled = true;
            this.cmbMemType.Location = new System.Drawing.Point(86, 134);
            this.cmbMemType.Name = "cmbMemType";
            this.cmbMemType.Size = new System.Drawing.Size(152, 20);
            this.cmbMemType.TabIndex = 161;
            // 
            // rdoWomen
            // 
            this.rdoWomen.AutoSize = true;
            this.rdoWomen.Location = new System.Drawing.Point(148, 87);
            this.rdoWomen.Name = "rdoWomen";
            this.rdoWomen.Size = new System.Drawing.Size(35, 16);
            this.rdoWomen.TabIndex = 160;
            this.rdoWomen.TabStop = true;
            this.rdoWomen.Text = "女";
            this.rdoWomen.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Location = new System.Drawing.Point(86, 87);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 159;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(362, 180);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 158;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMemDiscount
            // 
            this.txtMemDiscount.Location = new System.Drawing.Point(341, 125);
            this.txtMemDiscount.Name = "txtMemDiscount";
            this.txtMemDiscount.Size = new System.Drawing.Size(152, 21);
            this.txtMemDiscount.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 156;
            this.label9.Text = "折扣:";
            // 
            // txtMemPhone
            // 
            this.txtMemPhone.Location = new System.Drawing.Point(341, 89);
            this.txtMemPhone.Name = "txtMemPhone";
            this.txtMemPhone.Size = new System.Drawing.Size(152, 21);
            this.txtMemPhone.TabIndex = 155;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 149;
            this.label8.Text = "会员电话:";
            // 
            // txtBirs
            // 
            this.txtBirs.Location = new System.Drawing.Point(341, 47);
            this.txtBirs.Name = "txtBirs";
            this.txtBirs.Size = new System.Drawing.Size(152, 21);
            this.txtBirs.TabIndex = 151;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 150;
            this.label7.Text = "生日:";
            // 
            // txtMemIntegral
            // 
            this.txtMemIntegral.Location = new System.Drawing.Point(341, 9);
            this.txtMemIntegral.Name = "txtMemIntegral";
            this.txtMemIntegral.ReadOnly = true;
            this.txtMemIntegral.Size = new System.Drawing.Size(152, 21);
            this.txtMemIntegral.TabIndex = 152;
            this.txtMemIntegral.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 148;
            this.label6.Text = "积分:";
            // 
            // txtmemMoney
            // 
            this.txtmemMoney.Location = new System.Drawing.Point(86, 168);
            this.txtmemMoney.Name = "txtmemMoney";
            this.txtmemMoney.Size = new System.Drawing.Size(152, 21);
            this.txtmemMoney.TabIndex = 153;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 147;
            this.label5.Text = "卡余额:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 146;
            this.label4.Text = "会员等级:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 145;
            this.label3.Text = "会员性别:";
            // 
            // txtMemName
            // 
            this.txtMemName.Location = new System.Drawing.Point(86, 44);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(152, 21);
            this.txtMemName.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 144;
            this.label2.Text = "会员姓名:";
            // 
            // txtMemNum
            // 
            this.txtMemNum.Location = new System.Drawing.Point(86, 6);
            this.txtMemNum.Name = "txtMemNum";
            this.txtMemNum.Size = new System.Drawing.Size(152, 21);
            this.txtMemNum.TabIndex = 143;
            this.txtMemNum.Text = "编号自动生成";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 142;
            this.label1.Text = "会员编号:";
            // 
            // FrmAdd
            // 
            this.ClientSize = new System.Drawing.Size(519, 224);
            this.Controls.Add(this.dtEndServerTime);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.cmbMemType);
            this.Controls.Add(this.rdoWomen);
            this.Controls.Add(this.rdoMan);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMemDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMemPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBirs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMemIntegral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmemMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemNum);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdd";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        MemmberTyoeBLL bll = new MemmberTyoeBLL(); 
        private void FrmAdd_Load(object sender, EventArgs e)
        {
            //给下拉框绑定数据
            List<MemmberType> list = bll.GetMemmberType();
            //需要设置属性  （2个）
            cmbMemType.DisplayMember = "MemTpName"; //显示的字段 text
            cmbMemType.ValueMember = "MemType";//不显示的  selectedValue
                                               //向下拉框插入请选择
            list.Insert(0, new MemmberType() { MemTpName = "请选择", MemType = -1 });
            cmbMemType.DataSource = list;
   
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //1.构建对象
            //2.调用业务逻辑层  InsertMammber方法
            MemmberInfo mi = new MemmberInfo();

            //会员编号 Guid：太长   把当前时间当作参数
           // mi.MemNum = txtMemNum.Text.Trim();
            mi.MemNum = DateTime.Now.ToString();
            mi.MemName=txtMemName.Text.Trim();
            mi.MemGender = rdoMan.Checked ? "男" : "女";
            mi.MemType=Convert.ToInt32(cmbMemType.SelectedValue);
            mi.MemMoney = Convert.ToDecimal(txtmemMoney.Text.Trim());
            mi.MemIntegral = Convert.ToInt32(txtMemIntegral.Text.Trim());//积分
            mi.MemBirthdaty = Convert.ToDateTime(txtBirs.Text.Trim());
            mi.MemMobilePhone = txtMemPhone.Text.Trim();
            mi.MemDiscount = Convert.ToDecimal(txtMemDiscount.Text.Trim());
            mi.MemEndServerTime = Convert.ToDateTime(dtEndServerTime.Text.Trim());
            MemmverInfoBLL min = new MemmverInfoBLL();
            bool isSuccess= min.InsertMemmber(mi);
            if (isSuccess)
            {
                MessageBox.Show("插入成功");
                //刷新
                this.Close();
            }
            else
            {
                MessageBox.Show("插入失败");
            }
        }
    }
}
