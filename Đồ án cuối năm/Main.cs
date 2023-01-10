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


namespace Đồ_án_cuối_năm
{
    public partial class Main : Form
    {
        Đồ_án_cuối_năm.Login cur_login;
        List<ACCOUNT_DTO> list = new List<ACCOUNT_DTO>();
        int index = 0;

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
        public Main(Đồ_án_cuối_năm.Login login)
        {
            cur_login = login;
            InitializeComponent();
        }
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void LayThongTinCacUser()
        {
          
            lb_Name.Text = list[index].tennguoidung;
            lb_Year.Text = list[index].namsinh.ToString();
            lb_Gender.Text = list[index].gioitinh;
            lb_Height.Text = list[index].chieucao.ToString();
            lb_Weight.Text = list[index].cannang.ToString();
            lb_School.Text = list[index].truong;
            lb_SchoolYear.Text = list[index].namhoc.ToString();
            lb_Bio.Text = list[index].bio;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            ACCOUNT_DTO thisAccount = ACCOUNT_DAO.Instance.GetCustomerInfo(Global.current_user,Global.current_pass);
            list = ACCOUNT_DAO.Instance.GetNguoiDung(Global.current_ID);
            lb_Name.Text = list[index].tennguoidung;
            lb_Year.Text = list[index].namsinh.ToString();
            lb_Gender.Text = list[index].gioitinh;
            lb_Height.Text = list[index].chieucao.ToString();
            lb_Weight.Text = list[index].cannang.ToString();
            lb_School.Text = list[index].truong;
            lb_SchoolYear.Text = list[index].namhoc.ToString();
            lb_Bio.Text = list[index].bio;
            KiemTraYeuThich();
            LoadAva();
        }
        private void pn_Menu_MouseLeave(object sender, EventArgs e)
        {
            if (!(Cursor.Position.X > 1109 && Cursor.Position.X < 1228) || !(Cursor.Position.Y > 59 && Cursor.Position.Y < 199))
            {
                pn_Menu.Visible=false; 
            }
            //Console.WriteLine(Cursor.Position.X);
            //Console.WriteLine(Cursor.Position.Y);
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.ShowDialog();
            this.Show();    
        }

        private void btn_Menu_MouseClick(object sender, MouseEventArgs e)
        {
            pn_Menu.Visible = true;
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (pn_filter.Visible == false) 
            {
                pn_filter.Visible = true;
            }
            else
            {
                pn_filter.Visible = false;
                txb_Find.Text = "";

            }
        }
        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (cb_FindWhat.Text == "Trường")
            {
                index = 0;
                list.Clear();
                list = ACCOUNT_DAO.Instance.SearchTruong(txb_Find.Text,Global.current_ID);
                KiemTraYeuThich();
                LoadAva();
                LayThongTinCacUser();
            }
            else if (cb_FindWhat.Text == "Năm sinh")
            {
                index = 0;
                list.Clear();
                list = ACCOUNT_DAO.Instance.SearchYear(Convert.ToInt32(txb_Find.Text), Global.current_ID);
                KiemTraYeuThich();
                LoadAva();
                LayThongTinCacUser();
            }
            else
            {
                index = 0;
                list.Clear();
                list = ACCOUNT_DAO.Instance.SearchYearSchool(Convert.ToInt32(txb_Find.Text), Global.current_ID);
                KiemTraYeuThich();
                LoadAva();
                LayThongTinCacUser();
            }
            pn_filter.Visible = false;
            txb_Find.Text = "";
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            KiemTraYeuThich();
            pn_LikeList.Visible = false;
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            History newHistory = new History();
            this.Hide();
            newHistory.ShowDialog();
            this.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            cur_login.Show();
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            index++;
            int length = list.Count;
            if (index < length)
            {
                LayThongTinCacUser();
                KiemTraYeuThich();
                LoadAva();
            }
            else
            {
                index = 0;
                LayThongTinCacUser();
                KiemTraYeuThich();
                LoadAva();
            }
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            index--;
            int length = list.Count;
            if (index < 0)
            {
                index = length - 1;
                LayThongTinCacUser();
                KiemTraYeuThich();
                LoadAva();
            }
            else
            {
                LayThongTinCacUser();
                KiemTraYeuThich();
                LoadAva();
            }
        }

        private void btn_Male_Click(object sender, EventArgs e)
        {
            index = 0;
            list.Clear();
            list = ACCOUNT_DAO.Instance.GetNguoiDungMF("Nam");
            KiemTraYeuThich();
            LoadAva();
            LayThongTinCacUser();
        }

        private void btn_Female_Click(object sender, EventArgs e)
        {
            index = 0;
            list.Clear();
            list = ACCOUNT_DAO.Instance.GetNguoiDungMF("Nữ");
            KiemTraYeuThich();
            LoadAva();
            LayThongTinCacUser();
        }

        private void btn_LikeList_Click(object sender, EventArgs e)
        {
            LoadListLike();
            LoadListLiked();
            pn_LikeList.Visible = true;
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            YEUTHICH_DAO.Instance.RemoveYeuThich(Global.current_ID, list[index].id);
            btn_Like.Visible = false;
            btn_NotLike.Visible = true;
            //load laij ds yeu thich
        }

        private void btn_NotLike_Click(object sender, EventArgs e)
        {
            YEUTHICH_DAO.Instance.AddYeuThich(Global.current_ID, list[index].id);
            btn_Like.Visible = true;
            btn_NotLike.Visible = false;
            //load laij ds yeu thich
        }
        private void KiemTraYeuThich()
        {
            List<YEUTHICH_DTO> check_list = YEUTHICH_DAO.Instance.KiemTraYeuThich(Global.current_ID, list[index].id);
            if (check_list.Count > 0)
            {
                btn_Like.Visible = true;
                btn_NotLike.Visible = false;
            }
            else
            {
                btn_Like.Visible = false;
                btn_NotLike.Visible = true;
            }
               
        }

        private void LoadListLike()
        {
            dgv_ylp.Rows.Clear();
            List<YEUTHICH_DTO> check_list = YEUTHICH_DAO.Instance.GetListLike(Global.current_ID);
            dgv_ylp.ColumnCount = 1;
            dgv_ylp.Columns[0].Name = "Tên";
            foreach (var item in check_list) 
            {
                ACCOUNT_DTO itemInfo = ACCOUNT_DAO.Instance.GetCustomerInfoID(item.nguoibanthich);
                dgv_ylp.Rows.Add(itemInfo.tennguoidung);
            }
        }

        private void LoadListLiked()
        {
            dgv_ply.Rows.Clear();
            dgv_ply.ColumnCount = 1;
            dgv_ply.Columns[0].Name = "Tên";
            List<YEUTHICH_DTO> likedList = YEUTHICH_DAO.Instance.GetListLiked(Global.current_ID);
            foreach (var person in likedList)
            {
                if (YEUTHICH_DAO.Instance.CheckMatch(Global.current_ID, person.taikhoan))
                {
                    ACCOUNT_DTO itemInfo = ACCOUNT_DAO.Instance.GetCustomerInfoID(person.taikhoan);
                    dgv_ply.Rows.Add(itemInfo.tennguoidung);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            YEUTHICH_DAO.Instance.RemoveAll(Global.current_ID);
            LoadListLiked();
            LoadListLike();
        }

       private void LoadAva()
        {
            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + list[index].id.ToString() + ".jpg"))
            //if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + list[index].id.ToString() + ".jpg"))
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + list[index].id.ToString() + ".jpg");
                pb_Avatar.BackgroundImage = image; 
            }
            else
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + list[index].id.ToString() + ".jpg");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + list[index].id.ToString() + ".jpg");
                pb_Avatar.BackgroundImage = image;
            }
        }

        private void pb_Logo_Click(object sender, EventArgs e)
        {
            index = 0;
            list.Clear();
            list = ACCOUNT_DAO.Instance.GetNguoiDung(Global.current_ID);
            KiemTraYeuThich();
            LoadAva();
            LayThongTinCacUser();
        }

        private void dgv_ylp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dgv_ylp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            int GetID = ACCOUNT_DAO.Instance.GetCustomerIDbyName(dgv_ylp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            CheckInfo newInfo = new CheckInfo(GetID);
            newInfo.ShowDialog();
            KiemTraYeuThich();
            LoadListLiked();
            LoadListLike();

        }

        private void dgv_ply_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int GetID = ACCOUNT_DAO.Instance.GetCustomerIDbyName(dgv_ply.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                CheckInfo newInfo = new CheckInfo(GetID);
                newInfo.ShowDialog();
                KiemTraYeuThich();
                LoadListLiked();
                LoadListLike();
            }
            else
            {
                int GetID = ACCOUNT_DAO.Instance.GetCustomerIDbyName(dgv_ply.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                Messenger newMess = new Messenger(GetID);
                this.Hide();
                newMess.ShowDialog();
                this.Show();
            }
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog ava = new OpenFileDialog()
            {
                FileName = "",
                Filter = "All files (*.*)|*.*",
                Title = "Kho ảnh",
                Multiselect = false
            };
           Console.WriteLine(ava);
        }
    }
}
