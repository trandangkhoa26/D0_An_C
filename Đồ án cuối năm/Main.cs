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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pn_Menu_MouseLeave(object sender, EventArgs e)
        {
            if (!(Cursor.Position.X > 1109 && Cursor.Position.X < 1228) || !(Cursor.Position.Y > 92 && Cursor.Position.Y < 185))
            {
                //pn_Menu.Visible=false;  Sửa lại vị trí sau
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
            pn_filter.Visible = true;
        }
    }
}
