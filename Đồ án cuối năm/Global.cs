using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Đồ_án_cuối_năm
{
    internal class Global
    {
        public static int current_ID = 0;
        public static string current_user = "";
        public static string current_pass = "";

        public static int GetTextHeight(Label label)
        {
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, 345);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
