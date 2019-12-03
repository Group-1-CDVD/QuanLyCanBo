using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyNhanVien
{
    class ClsDAL
    {
        ClsConnectDB cndb;
        SqlDataAdapter da;
        SqlCommand cmd;

        public ClsDAL()
        {
            cndb = new ClsConnectDB();
        }

        // phuong thuc login user
        public bool RegisterUser(ClsUser us)
        {
            string sql = "usp_RegisterUser";
            SqlConnection con = cndb.getConnect();
            try
            {
                con.Open();
                var cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = us.Username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = us.password;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = us.Phone;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = us.Address;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
            
        }

        public bool LoginUser(ClsUser us)
        {
            string sql = "usp_LoginUser";
            SqlConnection con = cndb.getConnect();
           
            
                con.Open();
                var cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = us.Username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = us.password;
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    return true;
                }    
               return false;
        }
    }
}
