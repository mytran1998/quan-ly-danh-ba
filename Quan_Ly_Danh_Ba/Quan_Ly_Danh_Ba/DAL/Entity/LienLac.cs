using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Danh_Ba.DAL.Entity
{
    public class LienLac
    {
        private string maLienLac;
        private string maNhom;
        private string tenGoi;
        private string email;
        private string soDienThoai;
        private string diaChi;

        public string MaLienLac { get => maLienLac; set => maLienLac = value; }
        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenGoi { get => tenGoi; set => tenGoi = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        // Lấy dữ liệu liên lạc từ file data
        public static List<LienLac> getLienLacFromFile(string path)
        {
            List<LienLac> lstLienLac = new List<LienLac>();

            string[] data = File.ReadAllLines(path);
            foreach (string line in data)
            {
                var lstValue = line.Split('|');
                LienLac lienLac = new LienLac
                {
                    MaLienLac = lstValue[0],
                    MaNhom = lstValue[1],
                    TenGoi = lstValue[2],
                    Email = lstValue[3],
                    SoDienThoai = lstValue[4],
                    DiaChi = lstValue[5],
                };
                lstLienLac.Add(lienLac);
            }
            return lstLienLac;
        }

        // Lấy tất cả liên lạc của một nhóm 
        public static List<LienLac> getLienLacTuMaNhom(string maNhom, string path)
        {
            List<LienLac> lstLienLac = getLienLacFromFile(path);
            List<LienLac> lstLienLacNhom = new List<LienLac>();

            foreach(LienLac lienLac in lstLienLac)
            {
                if(lienLac.maNhom.Equals(maNhom))
                {
                    lstLienLacNhom.Add(lienLac);
                }
            }

            return lstLienLacNhom;
        }

        // Xóa liên lạc
        public static void xoaLienLac(string path, string tenLienLac)
        {
            string[] lines = File.ReadAllLines(path);

            // Xóa hết
            File.WriteAllText(path, "");

            // Ghi lại nếu không trùng mã 
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    var lsValue = line.Split('|');
                    // Lấy mã 
                    string ten = lsValue[2];
                    if (!ten.Contains(tenLienLac))
                    {
                        writer.WriteLine(line);
                    }
                }
                writer.Flush();
                writer.Close();
            }
        }

        // Thêm liên lạc
        public static void themLienLac(string path, string maNhom, string tenGoi, string email, string soDT, string diaChi)
        {
            int maLienLac = maLienLacCuoi(path) + 1;
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(maLienLac + "|" + maNhom + "|" + tenGoi + "|"  + email + "|" + soDT + "|" + diaChi);
                writer.Flush();
                writer.Close();
            }
        }

        // Lấy mã liên lạc cuối cùng của danh sách
        public static int maLienLacCuoi(string path)
        {
            List<LienLac> lstLienLac = LienLac.getLienLacFromFile(path);
            return Int32.Parse(lstLienLac[lstLienLac.Count - 1].maLienLac);
        }

        // Tìm kiếm liên lạc theo tên
        public static List<LienLac> timLienLac(string path, string tenLienLac)
        {
            List<LienLac> lstLienLac = getLienLacFromFile(path);
            List<LienLac> lstNew = new List<LienLac>();
            foreach (LienLac lienLac in lstLienLac)
            {
                if (string.Compare(lienLac.tenGoi, tenLienLac, true) == 0)
                {
                    lstNew.Add(lienLac);
                }
            }
            return lstNew;
        }
    }
}
