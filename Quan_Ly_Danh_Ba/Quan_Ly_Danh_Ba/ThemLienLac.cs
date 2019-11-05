using Quan_Ly_Danh_Ba.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Danh_Ba
{
    public partial class ThemLienLac : Form
    {
        string maNhom;
        static string pathLienLac = @"E:\Net Framework\Learn\Quan_Ly_Danh_Ba\Quan_Ly_Danh_Ba\DATA\lienlac.txt";
        private Form1 form;
        public ThemLienLac(Form1 form, string maNhom)
        {
            InitializeComponent();
            this.maNhom = maNhom;
            this.form = form;
            txtMaNhom.Text = maNhom;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLienLac = txtTen.Text;
            string email = txtEmail.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string diaChi = txtDiaChi.Text;
            if (tenLienLac != null)
            {
                LienLac.themLienLac(pathLienLac, maNhom, tenLienLac, email, soDienThoai, diaChi);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void ThemLienLac_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.refreshDtgvLienLac();
        }
    }
}
