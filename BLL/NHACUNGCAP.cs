using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class NHACUNGCAP
    {
        public static void themNhaCungCap(string MaNCC, string TenNCC, string DiaChi, string DienThoai)
        {
            string cmd = "INSERT INTO NHACUNGCAP VALUES('" + MaNCC + "',N'" + TenNCC + "',N'" + DiaChi + "',N'" + DienThoai + "')";
            SqlConnection dbConn = new SqlConnection(ConnectDAL.strConn);
            dbConn.Open();
            SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
            dbCmd.ExecuteNonQuery();
            dbConn.Close();
        }
        public static void suaNhaCungCap(string MaNCC, string TenNCC, string DiaChi, string DienThoai)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = ("Update NHACUNGCAP set TenNCC=N'" + TenNCC + "',DiaChi='" + DiaChi + "',DienThoai='" + DienThoai + "' where MaNCC='" + MaNCC + "'");
            SqlCommand sqlcmd = new SqlCommand(cmd, conndb);
            sqlcmd.ExecuteNonQuery();
            conndb.Close();
        }
        public static void xoaNhaCungCap(string MaNCC)
        {
            SqlConnection conndb = new SqlConnection(ConnectDAL.strConn);
            conndb.Open();
            string cmd = "DELETE FROM NHACUNGCAP WHERE MaNCC='" + MaNCC + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, conndb);
            sqlCmd.ExecuteNonQuery();
            conndb.Close();
        }
    }
}
