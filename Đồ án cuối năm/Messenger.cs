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
using Đồ_án_cuối_năm.Properties;
using System.Net;

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
        int curTop = 10;
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
            curTop = 10;
            pn_Chat.Controls.Clear();
            lb_Name.Text = thisInfo.tennguoidung;

            for (int i = 1; i < 25; i++)
            {
                var listViewItem = lv_Sticker.Items.Add(i.ToString());
                listViewItem.ImageKey = Convert.ToString(i + ".png");
            }

            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg"))
           // if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg"))
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
                    else
                        if (message.nhandann != -1)
                        AddStickergoing(Convert.ToString(message.nhandann));
                        else
                            if (message.diachianh != "")
                                AddImagegoing(@message.diachianh);
                            else
                                AddFilegoing(message.diachifile);

                }

                else
                {
                    if (message.noidung != "")
                        AddIncomming(message.noidung);
                    else
                        if (message.nhandann != -1)
                        AddStickercoming(Convert.ToString(message.nhandann));
                        else
                            if (message.diachianh != "")
                                AddImagecomming(@message.diachianh);
                            else
                                AddFilecomming(message.diachifile);
                }
            }

            pn_Chat.VerticalScroll.Value = pn_Chat.VerticalScroll.Maximum;
            pn_Chat.VerticalScroll.Visible = false;
        }

   

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
               // Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\other.png");

                bubble.Avatar = image;
            }
            else
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg");
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

        void AddStickercoming(string sticker)
        {
            var stick = new Stickercomming();
            pn_Chat.Controls.Add(stick);
            stick.Top = curTop;
            stick.Width = 625;


            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg"))
            //if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg"))
            {
                // Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\other.png");

                stick.Avatar = image;
            }
            else
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg");
                stick.Avatar = image;
            }

            Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(string.Format(sticker));
            stick.Stick = bmp;

            curTop += stick.Height;
        }

        void AddStickergoing(string sticker)
        {
            var stick = new Stickergoing();
            pn_Chat.Controls.Add(stick);
            stick.Top = curTop;
            stick.Width = 625;
            Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(string.Format(sticker));
            stick.Stick = bmp;

            curTop += stick.Height;
        }

        void Send(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0) return;

            TINNHAN_DAO.Instance.AddTinNhanText(Global.current_ID, textBox1.Text, thisInfo.id);
            textBox1.Text = string.Empty;
            Messenger_Load(sender, e);

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send(sender, e);
        }

        private void btn_Sticker_Click(object sender, EventArgs e)
        {
            if (pn_Sticker.Visible == false)
                pn_Sticker.Visible = true;
            else pn_Sticker.Visible = false;

        }

        private void lv_Sticker_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lv_Sticker.SelectedItems[0];
            string theItem = item.Text.ToString();


            TINNHAN_DAO.Instance.AddNhanDan(Global.current_ID, theItem, thisInfo.id);
            btn_Sticker_Click(sender, e);
            Messenger_Load(sender, e);
        }

        private void btn_Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic = new OpenFileDialog()
            {
                FileName = "...",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;",
                Title = "Chọn ảnh",
                Multiselect = false
            };
            if (pic.ShowDialog() == DialogResult.OK)
            {
                TINNHAN_DAO.Instance.AddAnh(Global.current_ID, pic.FileName, thisInfo.id);
                Messenger_Load(sender, e);
            }
        }
      
        void AddImagecomming(string address)
        {
            var img = new Imagecomming();
            pn_Chat.Controls.Add(img);
            img.Top = curTop;
            img.Width = 625;
            img.Address = address;

            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg"))
            //if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg"))
            {
                // Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\other.png");
                img.Avatar = image;
            }
            else
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg");
                img.Avatar = image;
            }

            img.Img = Image.FromFile(address);
       

            curTop += img.Height;
        }

        void AddImagegoing(string address)
        {
            var img = new Imagegoing();
            pn_Chat.Controls.Add(img);
            img.Top = curTop;
            img.Width = 625;
            img.Address = address;

            img.Img = Image.FromFile(address);

            curTop += img.Height;
        }


        void AddFilecomming(string address)
        {
            var file = new Filecomming();
            pn_Chat.Controls.Add(file);
            file.Top = curTop;
            file.Width = 625;
            file.Address = address;


            if (!File.Exists(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg"))
            //if (!File.Exists(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg"))
            {
                // Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\other.png");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\other.png");
                file.Avatar = image;
            }
            else
            {
                //Image image = Image.FromFile(@"C:\Users\netpr\source\repos\Đồ án cuối năm\img\" + thisInfo.id.ToString() + ".jpg");
                Image image = Image.FromFile(@"C:\Users\phung\source\repos\D0_An_C\img\" + thisInfo.id.ToString() + ".jpg");
                file.Avatar = image;
            }

            file.FileName = Path.GetFileName(address);
            curTop += file.Height;
        }

        void AddFilegoing(string address)
        {
            var file = new Filegoing();
            pn_Chat.Controls.Add(file);
            file.Top = curTop;
            file.Width = 625;
            file.Address = address;


            file.FileName = Path.GetFileName(address);
            curTop += file.Height;
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog pic = new OpenFileDialog()
            {
                FileName = "...",
                Filter = "All files (*.*)|*.*",
                Title = "Chọn file",
                Multiselect = false
            };

            if (pic.ShowDialog() == DialogResult.OK)
            {
                TINNHAN_DAO.Instance.AddFile(Global.current_ID, pic.FileName, thisInfo.id);
                Messenger_Load(sender, e);
            }
        }
    }
}
