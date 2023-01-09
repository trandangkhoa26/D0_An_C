﻿using Đồ_án_cuối_năm.DAO;
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
    public partial class Messenger : Form
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
        public Messenger(int ID)
        {
            thisInfo = ACCOUNT_DAO.Instance.GetCustomerInfoID(ID);
            InitializeComponent();
        }
        public Messenger()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Messenger_Load(object sender, EventArgs e)
        {
            lb_Name.Text = thisInfo.tennguoidung;
            if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg"))
            {
                Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                pb_AvaReciver.BackgroundImage = image;
            }
            else
            {
                Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg");
                pb_AvaReciver.BackgroundImage = image;
            }
        }
    }
}
