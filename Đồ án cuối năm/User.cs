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
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;


namespace Đồ_án_cuối_năm
{
    public partial class User : Form
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
        ACCOUNT_DTO thisAccount;
        public User()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            thisAccount = ACCOUNT_DAO.Instance.GetCustomerInfo(Global.current_user, Global.current_pass);
            LoadInfo();
            LoadAva();
        }
        private void LoadInfo()
        {
            lb_Name.Text = thisAccount.tennguoidung;
            lb_Year.Text = thisAccount.namsinh.ToString();
            lb_Gender.Text = thisAccount.gioitinh;
            lb_Height.Text = thisAccount.chieucao.ToString();
            lb_Weight.Text = thisAccount.cannang.ToString();
            lb_School.Text = thisAccount.truong;
            lb_SchoolYear.Text = thisAccount.namhoc.ToString();
            lb_Bio.Text = thisAccount.bio;
        }
        private void LoadAva()
        {
            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisAccount.id.ToString() + ".jpg"))
            //if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisAccount.id.ToString() + ".jpg"))
            {
                // Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\other.png");
                pb_Avatar.BackgroundImage = image;
            }
            else
            {

                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisAccount.id.ToString() + ".jpg");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisAccount.id.ToString() + ".jpg");
                pb_Avatar.BackgroundImage = image;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_Menu_MouseLeave(object sender, EventArgs e)
        {
            if (!(Cursor.Position.X > 1107 && Cursor.Position.X < 1226) || !(Cursor.Position.Y > 60 && Cursor.Position.Y < 199))
            {
                 pn_Menu.Visible = false; 
            }
            //Console.WriteLine(Cursor.Position.X);
            //Console.WriteLine(Cursor.Position.Y);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            pn_Menu.Visible = true;
        }

        private void btn_ChangeAva_Click(object sender, EventArgs e)
        {
            pn_ChangeAva.Visible = true;
            pn_ChangeInfo.Visible = false;
            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisAccount.id.ToString() + ".jpg"))
            //if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisAccount.id.ToString() + ".jpg"))
            {
                // Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\other.png");
                pb_ChangeAva.BackgroundImage = image;
            }
            else
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisAccount.id.ToString() + ".jpg");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisAccount.id.ToString() + ".jpg");
                pb_ChangeAva.BackgroundImage = image;
            }

        }

        private void btn_ChangeInfo_Click(object sender, EventArgs e)
        {
            pn_ChangeAva.Visible = false;
            pn_ChangeInfo.Visible = true;
            pn_ChangePass.Visible = false;
            txb_ChangeName.Text = thisAccount.tennguoidung;
            txb_ChangeYear.Text = thisAccount.namsinh.ToString();
            cb_ChangeGender.Text = thisAccount.gioitinh;
            nm_ChangeHeight.Value = thisAccount.chieucao;
            nm_ChangeWeight.Value = thisAccount.cannang;
            txb_ChangeSchool.Text = thisAccount.truong;
            txb_ChangeSchoolYear.Text = thisAccount.namhoc.ToString();
            txb_ChangeBio.Text = thisAccount.bio;
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            pn_ChangeAva.Visible = false;
            pn_ChangeInfo.Visible = false;
            pn_ChangePass.Visible = true;
        }

        private void btn_NoInfo_Click(object sender, EventArgs e)
        {
            pn_ChangeInfo.Visible= false;
        }
        private void btn_NoAva_Click(object sender, EventArgs e)
        {
            pn_ChangeAva.Visible = false;
        }
        private void btn_NoPass_Click(object sender, EventArgs e)
        {
            pn_ChangePass.Visible = false;
            txb_NewPass.Text = "";
            txb_OldPass.Text = "";
        }

        private void btn_YesInfo_Click(object sender, EventArgs e)
        {
            string name = txb_ChangeName.Text;
            int namsinh = Convert.ToInt32(txb_ChangeYear.Text);
            string truong = txb_ChangeSchool.Text;
            string gioitinh = cb_ChangeGender.Text;
            int namhoc = Convert.ToInt32(txb_ChangeSchoolYear.Text);
            int chieucao = Convert.ToInt32(nm_ChangeHeight.Value);
            int cannang = Convert.ToInt32(nm_ChangeWeight.Value);
            string bio = txb_ChangeBio.Text;
            ACCOUNT_DAO.Instance.UpdateNGUOIDUNG(thisAccount.id,name,namsinh,truong,gioitinh,namhoc,chieucao,cannang,bio);
            MessageBox.Show("Bạn đã thay đổi thông tin thành công!", "THAY ĐỔI", MessageBoxButtons.OK);
            lb_Name.Text = name;
            lb_Year.Text = namsinh.ToString();
            lb_Gender.Text = gioitinh;
            lb_Height.Text = chieucao.ToString();
            lb_Weight.Text = cannang.ToString();
            lb_School.Text = truong;
            lb_SchoolYear.Text = namhoc.ToString();
            lb_Bio.Text = bio;
            pn_ChangeInfo.Visible = false;
        }

        private void btn_YesPass_Click(object sender, EventArgs e)
        {
            if (txb_OldPass.Text == txb_NewPass.Text)
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khảu cũ!", "CẢNH BÁO", MessageBoxButtons.OK);
            }
            else {
                if (txb_OldPass.Text == thisAccount.matkhau)
                {
                    ACCOUNT_DAO.Instance.UpdatePass(thisAccount.id, thisAccount.matkhau);
                    MessageBox.Show("Bạn đã thay đổi mật khẩu thành công!", "THAY ĐỔI", MessageBoxButtons.OK);
                    pn_ChangePass.Visible = false ;
                    txb_NewPass.Text = "";
                    txb_OldPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu cũ!", "CẢNH BÁO", MessageBoxButtons.OK);
                } 
            }
        }
        string file;
        private void btn_YesAva_Click(object sender, EventArgs e)
        {
            string des = @"C:\Users\netpr\source\repos\Đồ án cuối năm\img\"+ thisAccount.id.ToString()+ ".jpg";
            if(!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisAccount.id.ToString() + ".jpg"))
            {
                File.Copy(file, des);
            }
            LoadAva();
            MessageBox.Show("Bạn đã thay đổi ảnh đại diện thành công!", "THAY ĐỔI", MessageBoxButtons.OK);
            pn_ChangeAva.Visible = false;
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ava = new OpenFileDialog()
            {
                FileName = "Avatar",
                Filter = "JPG file (*.jpg)|*.jpg",
                Title = "Chọn ảnh đại diện",
                Multiselect = false
            };
            if (ava.ShowDialog() == DialogResult.OK)
            {
                file = ava.FileName;
                Console.WriteLine(file);
                pb_ChangeAva.BackgroundImage = Image.FromFile(file);

            }
            
        }
    }
}
