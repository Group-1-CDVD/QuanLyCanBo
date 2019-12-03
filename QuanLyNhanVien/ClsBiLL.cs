using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien
{
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
    }
}
