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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        //“确定”按钮的点击事件，用于判断注册信息并跳转到新窗口显示注册信息
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;//用户名信息
            string password = textBox2.Text;//密码
            string repassword = textBox3.Text;//密码确认
            //判断用户名不能为空
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("用户名不能为空!");
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            else if (!password.Equals(repassword))
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }

            //将用户名和密码传入主窗口中
            MainForm mainForm = new MainForm(name, password);
            mainForm.Show();
        }

        //"取消"按钮的事件用于关闭窗口
        private void button2_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }
    }
}
