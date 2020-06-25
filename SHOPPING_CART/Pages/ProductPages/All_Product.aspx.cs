using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Buisness;
using Props;
using System.Data;
using System.Data.SqlClient;
namespace SHOPPING_CART.Pages.ProductPages
{
    public partial class All_Product : System.Web.UI.Page
    {

        public void SelectAll()
        {
            ProductBll bll = new ProductBll();
            DataTable dt = new DataTable();
             dt= bll.SelectAll();
            ProductTable.DataSource = dt;
            ProductTable.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SelectAll();
        }
    }
}