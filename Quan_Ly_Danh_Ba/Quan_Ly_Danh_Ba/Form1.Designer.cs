namespace Quan_Ly_Danh_Ba
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXoaLienLac = new System.Windows.Forms.Button();
            this.btnThemLienLac = new System.Windows.Forms.Button();
            this.btnXoaNhom = new System.Windows.Forms.Button();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvNhom = new System.Windows.Forms.DataGridView();
            this.tenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvLienLac = new System.Windows.Forms.DataGridView();
            this.tenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhom)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLienLac)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnXoaLienLac);
            this.panel1.Controls.Add(this.btnThemLienLac);
            this.panel1.Controls.Add(this.btnXoaNhom);
            this.panel1.Controls.Add(this.btnThemNhom);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập từ cần tìm: ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(611, 3);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(162, 26);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
             // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Image = global::Quan_Ly_Danh_Ba.Properties.Resources.icon_delete;
            this.btnXoaLienLac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLienLac.Location = new System.Drawing.Point(343, 0);
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(112, 35);
            this.btnXoaLienLac.TabIndex = 3;
            this.btnXoaLienLac.Text = "Xóa liên lạc";
            this.btnXoaLienLac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLienLac.UseVisualStyleBackColor = true;
            this.btnXoaLienLac.Click += new System.EventHandler(this.btnXoaLienLac_Click);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = global::Quan_Ly_Danh_Ba.Properties.Resources.icon_add;
            this.btnThemLienLac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLienLac.Location = new System.Drawing.Point(228, 0);
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(112, 35);
            this.btnThemLienLac.TabIndex = 2;
            this.btnThemLienLac.Text = "Thêm liên lạc";
            this.btnThemLienLac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLienLac.UseVisualStyleBackColor = true;
            this.btnThemLienLac.Click += new System.EventHandler(this.btnThemLienLac_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = global::Quan_Ly_Danh_Ba.Properties.Resources.icon_delete;
            this.btnXoaNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNhom.Location = new System.Drawing.Point(114, 0);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(112, 35);
            this.btnXoaNhom.TabIndex = 1;
            this.btnXoaNhom.Text = "Xóa Nhóm";
            this.btnXoaNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNhom.UseVisualStyleBackColor = true;
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = global::Quan_Ly_Danh_Ba.Properties.Resources.icon_add;
            this.btnThemNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhom.Location = new System.Drawing.Point(0, 0);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemNhom.Size = new System.Drawing.Size(112, 35);
            this.btnThemNhom.TabIndex = 0;
            this.btnThemNhom.Text = "Thêm Nhóm";
            this.btnThemNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNhom.UseVisualStyleBackColor = true;
            this.btnThemNhom.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvNhom);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 385);
            this.panel2.TabIndex = 3;
            // 
            // dtgvNhom
            // 
            this.dtgvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhom});
            this.dtgvNhom.Location = new System.Drawing.Point(3, 3);
            this.dtgvNhom.Name = "dtgvNhom";
            this.dtgvNhom.Size = new System.Drawing.Size(258, 378);
            this.dtgvNhom.TabIndex = 0;
            this.dtgvNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhom_CellClick);
            // 
            // tenNhom
            // 
            this.tenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhom.DataPropertyName = "TenNhom";
            this.tenNhom.HeaderText = "Tên Nhóm";
            this.tenNhom.Name = "tenNhom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvLienLac);
            this.panel3.Location = new System.Drawing.Point(279, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 275);
            this.panel3.TabIndex = 4;
            // 
            // dtgvLienLac
            // 
            this.dtgvLienLac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLienLac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenGoi,
            this.email,
            this.soDienThoai});
            this.dtgvLienLac.Location = new System.Drawing.Point(3, 3);
            this.dtgvLienLac.Name = "dtgvLienLac";
            this.dtgvLienLac.Size = new System.Drawing.Size(506, 269);
            this.dtgvLienLac.TabIndex = 0;
            this.dtgvLienLac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLienLac_CellClick);
            // 
            // tenGoi
            // 
            this.tenGoi.DataPropertyName = "TenGoi";
            this.tenGoi.HeaderText = "Tên gọi";
            this.tenGoi.Name = "tenGoi";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // soDienThoai
            // 
            this.soDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soDienThoai.DataPropertyName = "SoDienThoai";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.Name = "soDienThoai";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSoDienThoai);
            this.panel4.Controls.Add(this.lblEmail);
            this.panel4.Controls.Add(this.lblDiaChi);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblTenGoi);
            this.panel4.Location = new System.Drawing.Point(279, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 100);
            this.panel4.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(103, 78);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(0, 13);
            this.lblSoDienThoai.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(103, 54);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(103, 32);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(0, 13);
            this.lblDiaChi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ:";
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGoi.Location = new System.Drawing.Point(16, 4);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(0, 24);
            this.lblTenGoi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - Trần Nam Mỹ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhom)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLienLac)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaLienLac;
        private System.Windows.Forms.Button btnThemLienLac;
        private System.Windows.Forms.Button btnXoaNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvNhom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvLienLac;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhom;
    }
}

