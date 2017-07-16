using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConnectDAL
    {
       public static string strConn = @"Data Source=DESKTOP-2VKHG32\SQLEXPRESS;Initial Catalog=QLCFSHOP;Integrated Security=True";
        public static bool getConnect()
        {
            try 
	         {	        
		    
             SqlConnection conndb = new SqlConnection(strConn);
             conndb.Open();
             return true;
	             }
	        catch (Exception)
	        {
		        return false;
	        }
         
        }
        public static DataTable loadtable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql,strConn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
    }
}
