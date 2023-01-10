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
    public partial class Filecomming : UserControl
    {
        public Filecomming()
        {
            InitializeComponent();
        }

        public string Address = "";
        public string FileName
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

        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {
            var sourceFile = String.Format(Address);
            var saveFileDialog = new SaveFileDialog();
            //You can offer a default name
            saveFileDialog.FileName = string.Format(FileName);
            saveFileDialog.Filter = "All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy(sourceFile, saveFileDialog.FileName, true);
                DialogResult dlr = MessageBox.Show("Your file has been downloaded successfully.", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Cancel download.", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
