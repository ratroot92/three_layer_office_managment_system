using System.Data;
using Props;
namespace DataLayer
{
    public  class ProductDll
    {
       DbConn conn;

        public bool Insert(ProductsProps P)
        {
            string qry = @"insert into products (name,price,image,description,status) values ('" + P.name + "'," +
                "" + P.price + "," +
                "'" + P.image + "'," +
                "'" + P.description + "'," +
                "'" + P.status + "')";
            conn = new DbConn();
            bool status = conn.UDI(qry);

            return status;
        }


        public DataTable SelectAll()
        {
            string qry = "select * from products";
            conn = new DbConn();
            DataTable dt = new DataTable();
            dt = (DataTable)conn.SelectAll(qry);
            return dt;
        }
    }
}
