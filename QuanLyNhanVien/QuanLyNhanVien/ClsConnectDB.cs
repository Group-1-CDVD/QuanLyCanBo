/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 09/12/2019
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyNhanVien
{
	/// <summary>
	/// Description of ClsConnectDB.
	/// </summary>
	class ClsConnectDB
    {
        string conStr;
        public ClsConnectDB()
        {
            conStr = @"Data Source=BLPCQPIBHEDH2LH;Initial Catalog=QuanLyCanBo;Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
