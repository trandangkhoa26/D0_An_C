using Đồ_án_cuối_năm.DAO;
using Đồ_án_cuối_năm.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_cuối_năm
{
    public partial class Login : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txb_LoginName.Text;
            string password = txb_Password.Text;
            if (ACCOUNT_DAO.Instance.DangNhap(username, password))
            {
                Global.current_ID = ACCOUNT_DAO.Instance.GetCustomerID(username, password);
                Global.current_user = username;
                Global.current_pass = password;
                Main main = new Main(this);
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!","THÔNG BÁO");
            }
            
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            pn_Register.Visible = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txb_AddName.Text = "";
            txb_AddUser.Text = "";
            txb_AddPass.Text = "";
            txb_AddYear.Text = "";
            txb_AddSchool.Text = "";
            pn_Register.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            DialogResult dlr = MessageBox.Show("Bạn đã đăng kí thành công!", "ĐĂNG KÍ", MessageBoxButtons.OK);
            if (dlr == DialogResult.OK)
            {
                string user = txb_AddUser.Text;
                string pass = txb_AddPass.Text;
                string name = txb_AddName.Text;
                string gioitinh=cb_AddGender.Text;
                int namsinh = Convert.ToInt32(txb_AddYear.Text);
                int chieucao = Convert.ToInt32(nm_AddHeight.Value);
                int cannang = Convert.ToInt32(nm_AddWeight.Value);
                string truong = txb_AddSchool.Text; 
                int namhoc = Convert.ToInt32(txb_AddSchoolYear.Text);
                ACCOUNT_DAO.Instance.AddNewCustomer(user,pass,name,namsinh,truong,gioitinh,namhoc,chieucao,cannang);
                txb_AddName.Text = "";
                txb_AddUser.Text = "";
                txb_AddPass.Text = "";
                txb_AddYear.Text = "";
                txb_AddSchool.Text = "";
                pn_Register.Visible = false;
            }
        }
    }
}
