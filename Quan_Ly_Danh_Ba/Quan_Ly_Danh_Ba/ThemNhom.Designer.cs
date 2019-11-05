namespace Quan_Ly_Danh_Ba
{
    partial class ThemNhom
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm:";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(104, 35);
            this.txtTenNhom.Multiline = true;
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(231, 29);
            this.txtTenNhom.TabIndex = 1;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(260, 96);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 16;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(168, 96);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThemNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 138);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.label1);
            this.Name = "ThemNhom";
            this.Text = "Thêm nhóm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThemNhom_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnThem;
    }
}