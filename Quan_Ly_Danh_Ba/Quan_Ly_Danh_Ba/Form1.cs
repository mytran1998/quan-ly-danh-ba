using Quan_Ly_Danh_Ba.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Danh_Ba
{
    public partial class Form1 : Form
    {
        static string pathNhom = @"E:\Net Framework\Learn\Quan_Ly_Danh_Ba\Quan_Ly_Danh_Ba\DATA\nhom.txt";
        static string pathLienLac = @"E:\Net Framework\Learn\Quan_Ly_Danh_Ba\Quan_Ly_Danh_Ba\DATA\lienlac.txt";
        public Form1()
        {
            InitializeComponent();
            // Hiển thị Nhóm lần đầu
            List<Nhom> lstNhom = Nhom.getNhomFromFile(pathNhom);
            dtgvNhom.AutoGenerateColumns = false;
            dtgvNhom.DataSource = lstNhom;

            // Hiển thị liên lạc lần đầu
            List<LienLac> lstLienLac = LienLac.getLienLacFromFile(pathLienLac);
            dtgvLienLac.AutoGenerateColumns = false;
            dtgvLienLac.DataSource = lstLienLac;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var themNhom = new ThemNhom(this);
            themNhom.Show();
        }

        // Refresh dtgvNhom
        public void refreshDtgvNhom()
        {
            dtgvNhom.AutoGenerateColumns = false;
            dtgvNhom.DataSource = Nhom.getNhomFromFile(pathNhom);
            dtgvNhom.Refresh();
        }

        // Refresh dtgvLienLac
        public void refreshDtgvLienLac()
        {
            dtgvNhom.CurrentRow.Selected = true;
            string tenNhom = dtgvNhom.SelectedCells[0].Value.ToString();
            string maNhom = Nhom.getMaTuTenNhom(tenNhom, pathNhom);
            
            dtgvLienLac.AutoGenerateColumns = false;
            dtgvLienLac.DataSource = LienLac.getLienLacTuMaNhom(maNhom, pathLienLac);
            dtgvLienLac.Refresh();
        }

        private void dtgvLienLac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dtgvLienLac.Rows[index];
                lblTenGoi.Text = selectRow.Cells["TenGoi"].Value.ToString();
                lblEmail.Text = selectRow.Cells["Email"].Value.ToString();
                lblSoDienThoai.Text = selectRow.Cells["SoDienThoai"].Value.ToString();
            }
        }

        private void dtgvNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dtgvNhom.Rows[index];
                string tenNhom = selectRow.Cells["TenNhom"].Value.ToString();
                string maNhom = Nhom.getMaTuTenNhom(tenNhom, pathNhom);

                dtgvLienLac.AutoGenerateColumns = false;
                dtgvLienLac.DataSource = LienLac.getLienLacTuMaNhom(maNhom, pathLienLac);
            }
        }

        
        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            dtgvNhom.CurrentRow.Selected = true;

            string tenNhom = dtgvNhom.SelectedCells[0].Value.ToString();
            string maNhom = Nhom.getMaTuTenNhom(tenNhom, pathNhom);
            
            var themLienLac = new ThemLienLac(this, maNhom);
            themLienLac.Show();
        }

        // Xoa nhom
        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Bạn có thật sự muốn xóa không?",
               "Thông báo",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                dtgvNhom.CurrentRow.Selected = true;
                
                string tenNhom = dtgvNhom.SelectedCells[0].Value.ToString();
                string maNhom = Nhom.getMaTuTenNhom(tenNhom, pathNhom);
                Nhom.xoaNhom(pathNhom, maNhom); 
                
                MessageBox.Show("Đã xóa thành công!",
                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Refresh
            refreshDtgvNhom();
        }

        // Xóa liên lạc
        private void btnXoaLienLac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Bạn có thật sự muốn xóa không?",
               "Thông báo",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                dtgvLienLac.CurrentRow.Selected = true;
                string tenLienLac = dtgvLienLac.SelectedCells[0].Value.ToString();
                LienLac.xoaLienLac(pathLienLac, tenLienLac);

                MessageBox.Show("Đã xóa thành công!",
                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Refresh
            refreshDtgvLienLac();
        }
        /*
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tenGoi = txtTimKiem.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<LienLac> lstSearch = LienLac.timLienLac(pathLienLac, tenGoi);
                dtgvLienLac.DataSource = lstSearch;
            }
            txtTimKiem.Text = null;
        }
        */
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                string tenGoi = txtTimKiem.Text;
                List<LienLac> lstSearch = LienLac.timLienLac(pathLienLac, tenGoi);
                dtgvLienLac.DataSource = lstSearch;
                
            }
        }
    }
}
