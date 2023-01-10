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

            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg"))
            //if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg"))
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\other.png");
                pb_AvaReciver.BackgroundImage = image;
            }
            else
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg");
                pb_AvaReciver.BackgroundImage = image;
            }

            List<TINNHAN_DTO> list = new List<TINNHAN_DTO>();
            list = TINNHAN_DAO.Instance.LoadMessage(Global.current_ID, thisInfo.id);
            foreach(TINNHAN_DTO message in list)
            {
                if(message.nguoigoi == Global.current_ID)
                {
                    if (message.noidung != "")
                        AddOutgoing(message.noidung);
                }

                else
                {
                    if (message.noidung != "")
                        AddIncomming(message.noidung);
                }
            }
        }

        int curTop = 10;

        void AddIncomming(string message)
        {
            var bubble = new Incomming();
            pn_Chat.Controls.Add(bubble);
            bubble.Top = curTop;
            bubble.Width = pn_Chat.Width - 10;
            bubble.Message = message;

            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg"))
            //if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg"))
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\other.png");

                bubble.Avatar = image;
            }
            else
            {
                // Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg");
                bubble.Avatar = image;
            }

            curTop += bubble.Height;
        }        

        void AddOutgoing(string message)
        {
            var bubble = new Outgoing();
            pn_Chat.Controls.Add(bubble);
            bubble.Top = curTop;
            bubble.Width = 625;
            bubble.Message = message;

            curTop += bubble.Height;
        }

        void AddStickercoming(int sticker)
        {
            var stick = new Stickercomming();
            stick.Top = curTop;
            stick.Width = 625;
            //Add stick imgae zô
        }

        void Send()
        {
            if (textBox1.Text.Trim().Length == 0) return;

            AddOutgoing(textBox1.Text);
            TINNHAN_DAO.Instance.AddTinNhanText(Global.current_ID, textBox1.Text, thisInfo.id);
            textBox1.Text = string.Empty;

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
