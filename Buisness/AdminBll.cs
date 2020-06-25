using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props;
using DataLayer;
using System.Data;

namespace Buisness
{
    public class AdminBll
    {
        AdminDll dll_object;
        public bool Insert(AdminProps Obj)
        {
            dll_object = new AdminDll();
           bool status= dll_object.Insert(Obj);
            return status;
        }
        public int GetLastId()
        {
            dll_object = new AdminDll();
            int id=  dll_object.GetLastId();
            return id;
        }
        public DataTable SelectAll()
        {
            dll_object = new AdminDll();
            DataTable dt = new DataTable();
            dt = dll_object.SelectAll();
            return dt;
        }
    }
}
