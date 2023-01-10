using Bunifu.UI.WinForms;
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
    public partial class Outgoing : UserControl
    {
        public Outgoing()
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


        private void Outgoing_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void bunifuUserControl1_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
