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
            Main main = new Main(this);
            this.Hide();
            main.ShowDialog();
            
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
            // Thêm phần add tài khoản
            DialogResult dlr = MessageBox.Show("You have been successfully registered!", "REGISTER", MessageBoxButtons.OK);
            if (dlr == DialogResult.OK)
            {
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
