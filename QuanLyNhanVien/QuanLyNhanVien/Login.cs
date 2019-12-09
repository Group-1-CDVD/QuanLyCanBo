/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 09/12/2019
 * Time: 10:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		ClsBiLL clbill;
        public Login()
        {
            InitializeComponent();
            clbill = new ClsBiLL();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Register  register = new Register();
            register.Show();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Xin vui lòng chưa nhập vào Username:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Xin vui lòng chưa nhập vào Username:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return false;
            }
            return true;
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                ClsUser us = new ClsUser();
                us.Username = txtusername.Text;
                us.password = txtpassword.Text;
                if(clbill.LoginUser(us))
                {
                    MessageBox.Show("Đăng Nhập Thành Công:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
	}
}
