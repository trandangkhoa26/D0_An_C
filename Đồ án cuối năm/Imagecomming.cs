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
    public partial class Imagecomming : UserControl
    {
        public Imagecomming()
        {
            InitializeComponent();
        }

        public Image Img
        {
            get { return pictureBox1.BackgroundImage; }
            set { pictureBox1.BackgroundImage = value; }
        }

        public Image Avatar
        {
            get { return bunifuPictureBox1.Image; }
            set { bunifuPictureBox1.Image = value; }
        }

        public string Address = "";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var sourceFile = String.Format(Address);
            var saveFileDialog = new SaveFileDialog();
            //You can offer a default name
            saveFileDialog.FileName = string.Format(Address);
            saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy(sourceFile, saveFileDialog.FileName);
                DialogResult dlr = MessageBox.Show("Your file has been downloaded successfully.", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Cancel download.", "Notification", MessageBoxButtons.OK);
            }
        }
    }

}
