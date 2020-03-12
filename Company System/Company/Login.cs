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
    public partial class Login : Form
    {
        //新建一个窗体
        Main main = new Main();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏当前的窗体
            //显示下一个窗体
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //弹出消息框，并获取消息框的返回值
            DialogResult dr = MessageBox.Show("确定要取消吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //如果消息框返回值是Yes，显示新窗体
            if (dr == DialogResult.Yes)
            {
                //跳转到注册页面
                Register register = new Register();
                register.Show();
                //同时此登录页面隐藏
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
