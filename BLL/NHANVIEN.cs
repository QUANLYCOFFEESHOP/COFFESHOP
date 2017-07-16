using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
namespace BLL
{
    public class NHANVIEN
    {
        public static void themNhanVien(string MaNV, string HoNV, string TenNV, bool GioiTinh, string SoCMND, string DiaChi, string DienThoai, string ChucVu, string LuongCoBan)
        {
            string cmd = "INSERT INTO NHANVIEN VALUES('" + MaNV + "',N'" + HoNV + "',N'" + TenNV + "',N'" + GioiTinh + "',N'" + SoCMND + "',N'" + DiaChi + "',N'" + DienThoai + "',N'" + ChucVu + "',N'" + LuongCoBan + "')";
            SqlConnection dbConn = new SqlConnection(ConnectDAL.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
        }
        public static void suaNhanVien(string MaNV, string HoNV, string TenNV, bool GioiTinh, string SoCMND, string DiaChi, string DienThoai, string ChucVu, string LuongCoBan)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = ("Update NHANVIEN set HoNV=N'" + HoNV + "',TenNV='" + TenNV + "',GioiTinh='" + GioiTinh + "',SoCMND='" + SoCMND + "',DiaChi='" + DiaChi + "',DienThoai='" + DienThoai + "',ChucVu='" + ChucVu + "',Luong='" + LuongCoBan + "' where MaNV='" + MaNV + "'");
            SqlCommand sqlcmd = new SqlCommand(cmd, conndb);
            sqlcmd.ExecuteNonQuery();
            conndb.Close();
        }
        public static void xoaNhanVien(string MaNV)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = "DELETE FROM NHANVIEN WHERE MaNV='" + MaNV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, conndb);
            sqlCmd.ExecuteNonQuery();
            conndb.Close();
        }
    }
}
