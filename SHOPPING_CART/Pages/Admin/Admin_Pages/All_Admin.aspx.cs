using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Buisness;
using System.Data.SqlClient;
using System.Data;

namespace SHOPPING_CART.Pages.Admin.Admin_Pages
{
    public partial class All_Admin : System.Web.UI.Page
    {
        AdminBll bll_object;
        public void Show_All_Admins()
        {
            bll_object = new AdminBll();
            DataTable dt = new DataTable();
            dt = bll_object.SelectAll();
            All_Admins_Table.DataSource = dt;
            All_Admins_Table.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           

            //if (Session["username"] != null)
           // {
                Show_All_Admins();
          //  }
          //  else
         //   {
            //    Response.Redirect("../../LoginPages/LoginPage.aspx");
          //  }


        }
    }
}