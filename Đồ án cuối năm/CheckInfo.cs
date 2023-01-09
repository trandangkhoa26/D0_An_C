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
using System.Reflection;

namespace Đồ_án_cuối_năm
{
    public partial class CheckInfo : Form
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
        ACCOUNT_DTO thisInfo;
        public CheckInfo()
        {
            InitializeComponent();
        }
        public CheckInfo(int ID)
        {
            thisInfo = ACCOUNT_DAO.Instance.GetCustomerInfoID(ID);
            InitializeComponent();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckInfo_Load(object sender, EventArgs e)
        {
            lb_Name.Text = thisInfo.tennguoidung;
            lb_Year.Text = thisInfo.namsinh.ToString();
            lb_Gender.Text = thisInfo.gioitinh;
            lb_Height.Text = thisInfo.chieucao.ToString();
            lb_Weight.Text = thisInfo.cannang.ToString();
            lb_School.Text = thisInfo.truong;
            lb_SchoolYear.Text = thisInfo.namhoc.ToString();
            lb_Bio.Text = thisInfo.bio;
            if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg"))
            {
                Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                pb_Avatar.BackgroundImage = image;
            }
            else
            {
                Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg");
                pb_Avatar.BackgroundImage = image;
            }
            List<YEUTHICH_DTO> check_list = YEUTHICH_DAO.Instance.KiemTraYeuThich(Global.current_ID, thisInfo.id);
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

        private void btn_NotLike_Click(object sender, EventArgs e)
        {
            YEUTHICH_DAO.Instance.AddYeuThich(Global.current_ID, thisInfo.id);
            btn_Like.Visible = true;
            btn_NotLike.Visible = false;
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            YEUTHICH_DAO.Instance.RemoveYeuThich(Global.current_ID, thisInfo.id);
            btn_Like.Visible = false;
            btn_NotLike.Visible = true;
        }
    }
}
