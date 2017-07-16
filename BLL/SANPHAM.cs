using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
namespace BLL
{
    public class SANPHAM
    {
        public static void themSanPham(string MaSP, string TenSP, string MaNCC, string SoLuong, string DonViTinh, string GiaSP)
        {
            string cmd = "INSERT INTO SANPHAM VALUES('" + MaSP + "',N'" + TenSP + "',N'" + MaNCC + "',N'" + SoLuong + "',N'" + DonViTinh + "',N'" + GiaSP + "')";
            SqlConnection dbConn = new SqlConnection(ConnectDAL.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
        }
        public static void suaSanPham(string MaSP, string TenSP, string MaNCC, string SoLuong, string DonViTinh, string GiaSP)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = ("Update SANPHAM set TenSP=N'" + TenSP + "',MaNCC='" + MaNCC + "',SoLuong='" + SoLuong + "',DonViTinh='" + DonViTinh + "',GiaSP='" + GiaSP + "' where MaSP='" + MaSP + "'");
            SqlCommand sqlcmd = new SqlCommand(cmd, conndb);
            sqlcmd.ExecuteNonQuery();
            conndb.Close();
        }
        public static void xoaSanPham(string MaSP)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = "DELETE FROM SANPHAM WHERE MaSP='" + MaSP + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, conndb);
            sqlCmd.ExecuteNonQuery();
            conndb.Close();
        }
    }
}
