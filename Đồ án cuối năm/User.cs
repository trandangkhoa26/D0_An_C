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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pn_Menu_MouseLeave(object sender, EventArgs e)
        {
            if (!(Cursor.Position.X > 1107 && Cursor.Position.X < 1226) || !(Cursor.Position.Y > 92 && Cursor.Position.Y < 231))
            {
                // pn_Menu.Visible = false; Sửa lại vị trí sau
            }
            //Console.WriteLine(Cursor.Position.X);
            //Console.WriteLine(Cursor.Position.Y);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            pn_Menu.Visible = true;
        }
    }
}
