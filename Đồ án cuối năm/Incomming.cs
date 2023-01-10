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
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return label1.Text; }
            set { label1.Text = value; AdjustHeight(); }
        }

        void AdjustHeight()
        {
            this.Height = Global.GetTextHeight(label1) + 20;
            this.Width = 625;
        }

        public Image Avatar 
        {
            get { return bunifuPictureBox1.Image; } 
            set { bunifuPictureBox1.Image = value; } 
        }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
