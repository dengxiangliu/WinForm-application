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
    public partial class MainForm : Form
    {
        public MainForm(string name, string password)
        {
            InitializeComponent();
            label2.Text = "用户名：" + name;
            label3.Text = "密  码：" + password;
        }
    }
}
