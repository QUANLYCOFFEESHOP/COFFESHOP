using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class HOADON
    {
        public static void themHoaDon(string SoHD, string MaNV, string MaKH, string NgayGiaoDich)
        {
            string cmd = "INSERT INTO HOADON VALUES('" + SoHD + "',N'" + MaNV + "',N'" + MaKH + "',N'" + NgayGiaoDich + "')";
            SqlConnection dbConn = new SqlConnection(ConnectDAL.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
        }
        public static void suaHoaDon(string SoHD, string MaNV, string MaKH, string NgayGiaoDich)
        {
            string cmd = ("Update HOADON set MaNV=N'" + MaNV + "',N'" + MaKH + "',N'" + NgayGiaoDich + "' where SoHD='" + SoHD + "'");
            SqlConnection dbConn = new SqlConnection(ConnectDAL.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
        }
        public static void xoaHoaDon(string SoHD)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = "DELETE FROM HOADON WHERE SoHD='" + SoHD + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, conndb);
            sqlCmd.ExecuteNonQuery();
            conndb.Close();
        }
    }
}
