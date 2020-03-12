using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 企业管理
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //设置窗体的背景颜色为黑色
            // this.BackColor = Color.Black;
        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //设置窗体的背景颜色为蓝色
            //  this.BackColor = Color.Blue;
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            //设置窗体的背景颜色为红色
            //this.BackColor = Color.Red;
        }
    }
}
