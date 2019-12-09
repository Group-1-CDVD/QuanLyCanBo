/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 09/12/2019
 * Time: 10:15 AM
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
	/// Description of ClsBiLL.
	/// </summary>
	class ClsBiLL
    {
        ClsDAL clsdal;
        public ClsBiLL()
        {
            clsdal = new ClsDAL();
        }
        public bool RegisterUser(ClsUser us)
        {
            return clsdal.RegisterUser(us);
        }
        public bool LoginUser(ClsUser us)
        {
            return clsdal.LoginUser(us);
        }
        public DataTable getAllNhanVien()
        {
            return clsdal.getAllNhanVien();
        }
        public bool AddNhanVien(ClsNhanVien nv)
        {
            return clsdal.AddNhanVien(nv);
        }
        public bool UpdateNhanCanBo(ClsNhanVien nv)
        {
            return clsdal.UpdateNhanCanBo(nv);
        }
        public bool DeleteCanBo(ClsNhanVien nv)
        {
            return clsdal.DeleteCanBo(nv);
        }
    }
}
