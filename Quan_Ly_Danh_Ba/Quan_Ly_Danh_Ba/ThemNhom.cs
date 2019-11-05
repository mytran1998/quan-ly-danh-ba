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
    public partial class ThemNhom : Form
    {
        static string pathNhom = @"E:\Net Framework\Learn\Quan_Ly_Danh_Ba\Quan_Ly_Danh_Ba\DATA\nhom.txt";
        private Form1 form;
        public ThemNhom(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNhom = txtTenNhom.Text;
            if(tenNhom != null)
            {
                Nhom.themNhom(pathNhom, tenNhom);
                MessageBox.Show("Thêm thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();      
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Refresh dtgvNhom
        private void ThemNhom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.refreshDtgvNhom();
        }
    }
}
