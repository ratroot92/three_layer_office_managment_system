using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Props;
using Buisness;
namespace SHOPPING_CART.Pages.ProductPages
{
    public partial class Add_Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            ProductsProps P = new ProductsProps();
            P.name = txt_name.Text;
            P.description = txt_description.Text;
            P.image = txt_image.Text;
            P.price = float.Parse(txt_price.Text);
            P.status = Int32.Parse(txt_status.Text);
            ProductBll bll = new ProductBll();
           bool db_status= bll.Insert(P);
            if (db_status)
            {
                System.Diagnostics.Debug.WriteLine("Product inserted");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Operation failed");
            }

        }
    }
}