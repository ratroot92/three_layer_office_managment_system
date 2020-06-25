using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PrjProps;
using System.Data;
using DataAccessLayer;
namespace Business_Layer
{
    public class ItemBLL
    {
        ItemDLL Item_BLL_Object;

        public bool InsertBLL(ItemProps OBJECT)
        {
            Item_BLL_Object = new ItemDLL();
            bool status = Item_BLL_Object.InsertDLL(OBJECT);
            return status;
        }

        public int GET_LAST_ID_BLL()
        {
            Item_BLL_Object = new ItemDLL();
            int last_id = Item_BLL_Object.GET_LAST_ID_DLL();
            return last_id;

        }

        public DataTable ALL_ITEMS_BLL()
        {
             Item_BLL_Object = new ItemDLL();
            DataTable ds = new DataTable();
             ds =Item_BLL_Object.ALL_ITEMS_DLL();
             return ds;
        }
    }
}
