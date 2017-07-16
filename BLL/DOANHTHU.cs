using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class DOANHTHU
    {
        public static void themDoanhThu(string SoHD, string MaSP, string GiaSP, string SoLuong, string ChietKhau, string ThanhTien)
        {
                
                string cmd = "INSERT INTO DOANHTHU VALUES('" + SoHD + "',N'" + MaSP + "',N'" + GiaSP + "',N'" + SoLuong + "',N'" + ChietKhau + "',N'" + ThanhTien + "')";
                            SqlConnection dbConn = new SqlConnection(ConnectDAL.strConn);
                            dbConn.Open();
                            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
                            dbCmd.ExecuteNonQuery();
                            dbConn.Close();
            
            
        }
        public static void suaDoanhThu(string SoHD, string MaSP, string GiaSP, string SoLuong, string ChietKhau, string ThanhTien)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = ("Update DOANHTHU set GiaBan=N'" + GiaSP + "',SoLuong='" + SoLuong + "',ChietKhau='" + ChietKhau + "',ThanhTien='" + ThanhTien + "' where SoHD='" + SoHD + "' and MaSP='" + MaSP + "'");
            SqlCommand sqlcmd = new SqlCommand(cmd, conndb);
            sqlcmd.ExecuteNonQuery();
            conndb.Close();
        }
        public static void xoaDoanhThu(string SoHD, string MaSP)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = "DELETE FROM DOANHTHU WHERE SoHD='" + SoHD + "' and MaSP='" + MaSP + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, conndb);
            sqlCmd.ExecuteNonQuery();
            conndb.Close();
        }
    }
}
