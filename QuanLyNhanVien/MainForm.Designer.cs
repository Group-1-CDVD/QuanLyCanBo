﻿/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 28/11/2019
 * Time: 16:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuanLyNhanVien
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMacanbo = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cbChuyenmon = new System.Windows.Forms.ComboBox();
            this.txtNamsinh = new System.Windows.Forms.TextBox();
            this.txtHesoluong = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtAntrua = new System.Windows.Forms.TextBox();
            this.cbtrinhdo = new System.Windows.Forms.ComboBox();
            this.cbXeploai = new System.Windows.Forms.ComboBox();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Location = new System.Drawing.Point(12, 212);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.Size = new System.Drawing.Size(831, 150);
            this.dgvnhanvien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Cán Bộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chuyên Môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trình Độ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hệ Số Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Năm Tân Lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ăn Trưa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Xếp Loại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Giới Tính";
            // 
            // txtMacanbo
            // 
            this.txtMacanbo.Location = new System.Drawing.Point(79, 10);
            this.txtMacanbo.Name = "txtMacanbo";
            this.txtMacanbo.Size = new System.Drawing.Size(140, 20);
            this.txtMacanbo.TabIndex = 11;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(79, 50);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(140, 20);
            this.txtHoten.TabIndex = 12;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // cbChuyenmon
            // 
            this.cbChuyenmon.FormattingEnabled = true;
            this.cbChuyenmon.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Điều Dưỡng",
            "Đồ Họa ",
            "Cơ Khí",
            "Tiến Anh"});
            this.cbChuyenmon.Location = new System.Drawing.Point(83, 131);
            this.cbChuyenmon.Name = "cbChuyenmon";
            this.cbChuyenmon.Size = new System.Drawing.Size(136, 21);
            this.cbChuyenmon.TabIndex = 13;
            // 
            // txtNamsinh
            // 
            this.txtNamsinh.Location = new System.Drawing.Point(83, 96);
            this.txtNamsinh.Name = "txtNamsinh";
            this.txtNamsinh.Size = new System.Drawing.Size(136, 20);
            this.txtNamsinh.TabIndex = 14;
            // 
            // txtHesoluong
            // 
            this.txtHesoluong.Location = new System.Drawing.Point(331, 50);
            this.txtHesoluong.Name = "txtHesoluong";
            this.txtHesoluong.Size = new System.Drawing.Size(140, 20);
            this.txtHesoluong.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(331, 133);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 20);
            this.textBox6.TabIndex = 17;
            // 
            // txtAntrua
            // 
            this.txtAntrua.Location = new System.Drawing.Point(331, 93);
            this.txtAntrua.Name = "txtAntrua";
            this.txtAntrua.Size = new System.Drawing.Size(140, 20);
            this.txtAntrua.TabIndex = 18;
            // 
            // cbtrinhdo
            // 
            this.cbtrinhdo.FormattingEnabled = true;
            this.cbtrinhdo.Items.AddRange(new object[] {
            "Đại Học",
            "Cao Đẵng",
            "Thạc Sĩ ",
            "Tiến Sĩ ",
            "Giáo Sư "});
            this.cbtrinhdo.Location = new System.Drawing.Point(331, 6);
            this.cbtrinhdo.Name = "cbtrinhdo";
            this.cbtrinhdo.Size = new System.Drawing.Size(140, 21);
            this.cbtrinhdo.TabIndex = 21;
            // 
            // cbXeploai
            // 
            this.cbXeploai.FormattingEnabled = true;
            this.cbXeploai.Items.AddRange(new object[] {
            "Giỏi",
            "Khá ",
            "Trung Bình"});
            this.cbXeploai.Location = new System.Drawing.Point(601, 5);
            this.cbXeploai.Name = "cbXeploai";
            this.cbXeploai.Size = new System.Drawing.Size(136, 21);
            this.cbXeploai.TabIndex = 22;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(601, 49);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(136, 21);
            this.cbGioitinh.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(515, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 33);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(627, 127);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 33);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(719, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 33);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 365);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbGioitinh);
            this.Controls.Add(this.cbXeploai);
            this.Controls.Add(this.cbtrinhdo);
            this.Controls.Add(this.txtAntrua);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtHesoluong);
            this.Controls.Add(this.txtNamsinh);
            this.Controls.Add(this.cbChuyenmon);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMacanbo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvnhanvien);
            this.Name = "MainForm";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMacanbo;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cbChuyenmon;
        private System.Windows.Forms.TextBox txtNamsinh;
        private System.Windows.Forms.TextBox txtHesoluong;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtAntrua;
        private System.Windows.Forms.ComboBox cbtrinhdo;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbXeploai;
	}
}
