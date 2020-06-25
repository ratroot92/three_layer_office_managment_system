using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Props;
using DataLayer;
namespace Buisness
{

   public  class ProductBll
    {
        ProductDll dll = new ProductDll();

        public bool Insert(ProductsProps P)
        {
          bool status=  dll.Insert(P);
            return status;
        }

        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            dt = dll.SelectAll();
            return dt;
        }
    }
}
