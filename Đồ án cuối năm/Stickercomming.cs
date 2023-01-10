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
    public partial class Stickercomming : UserControl
    {
        public Stickercomming()
        {
            InitializeComponent();
        }

        public Image Stick
        {
            get { return pictureBox1.BackgroundImage; }
            set { pictureBox1.BackgroundImage = value; }
        }

        public Image Avatar
        {
            get { return bunifuPictureBox1.Image; }
            set { bunifuPictureBox1.Image = value; }
        }
    }
}
