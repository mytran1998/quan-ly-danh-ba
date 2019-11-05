using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Danh_Ba.DAL.Entity
{
    public class Nhom
    {
        private string maNhom;
        private string tenNhom;

        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }

        // Lấy nhóm từ file data
        public static List<Nhom> getNhomFromFile(string path)
        {
            List<Nhom> lstNhom = new List<Nhom>();

            string[] data = File.ReadAllLines(path);
            foreach (string line in data)
            {
                var lstValue = line.Split('|');
                Nhom nhom = new Nhom
                {
                    MaNhom = lstValue[0],
                    TenNhom = lstValue[1],
                };
                lstNhom.Add(nhom);
            }
            return lstNhom;
        }

        // Thêm nhóm
        public static void themNhom(string path, string tenNhom)
        {
            int maNhom = getMaNhomCuoiCung(path) + 1;
            using (StreamWriter writer = new StreamWriter(path, true))
            {
               
                writer.WriteLine(maNhom + "|" + tenNhom);
                writer.Flush();
                writer.Close();
            }
        }

        // Xóa nhóm
        public static void xoaNhom(string path, string maNhom)
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
                    string ma = lsValue[0];
                    if (!ma.Contains(maNhom))
                    {
                        writer.WriteLine(line);
                    }
                }
                writer.Flush();
                writer.Close();
            }
        }

        // Lấy mã từ tên nhóm
        public static string getMaTuTenNhom(string tenNhom, string path)
        {
            List<Nhom> lstNhom = getNhomFromFile(path);

            foreach(Nhom nhom in lstNhom)
            {
                if(nhom.tenNhom == tenNhom)
                {
                    return nhom.maNhom;
                }
            }
            return null;
        }

        // Lấy mã nhóm cuối cùng
        public static int getMaNhomCuoiCung(string path)
        {
            List<Nhom> list = Nhom.getNhomFromFile(path);
            return Int32.Parse(list[list.Count - 1].maNhom);
        }

    }

   
}
