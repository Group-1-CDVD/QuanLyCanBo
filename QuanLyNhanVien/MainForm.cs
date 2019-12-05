/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 28/11/2019
 * Time: 16:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace QuanLyNhanVien
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        ClsBiLL clsbill;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            clsbill = new ClsBiLL();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        public void ShowAllNhanVien()
        {
            DataTable tb = clsbill.getAllNhanVien();
            dgvnhanvien.DataSource = tb;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowAllNhanVien();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClsNhanVien nv = new ClsNhanVien();
            nv.MaCanBo = txtMacanbo.Text;
            nv.HoTen = txtHoten.Text;
           // nv.ChuyenMon = cbChuyenmon.Text;
            if(clsbill.AddNhanVien(nv))
            {
                MessageBox.Show("Them Cán Bộ thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ShowAllNhanVien();
            }
            else
            {
                MessageBox.Show("Them Cán Bộ không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
	}
}
