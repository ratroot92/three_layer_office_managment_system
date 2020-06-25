using PrjProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrjProps;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class ItemDLL
    {
        DbConn conn;
        public bool InsertDLL(ItemProps OBJ)
        {
            conn = new DbConn();
            conn.OpenConection();
            string qry = "INSERT INTO items(id,name,barcode,purchase_price,sale_price,status,manufacturer,supplier)" +
                            "VALUES( " + OBJ.Id + ",  '" + OBJ.Name + "',  '" + OBJ.Barcode + "',  " + OBJ.Purchase_price + ", " + OBJ.Sale_price + "" +
                            ", " + OBJ.Status + ", '" + OBJ.Manufacturer + "', '" + OBJ.Supplier + "')";
            conn.UDI(qry);
            conn.CloseConnection();
            return false;
        }



        public int GET_LAST_ID_DLL()
        {
            conn = new DbConn();
            conn.OpenConection();
            string qry = "SELECT TOP 1 * FROM items ORDER BY ID DESC";
            int last_id= conn.GET_LAST_ID(qry);
            conn.CloseConnection();
            return last_id;
        }

        public DataTable ALL_ITEMS_DLL()
        {
            conn = new DbConn();
            conn.OpenConection();
            string qry = "SELECT * FROM items";
            DataTable ds = new DataTable();
            ds =(DataTable)conn.ShowDataInGridView(qry);
            conn.CloseConnection();
            return ds;
        }

    }
}
