using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Props;
using Buisness;

namespace SHOPPING_CART.Pages.LoginPages
{
    public partial class LoginPage : System.Web.UI.Page
    {
        LoginProps login_object;
        LoginBll bll_object;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            //on submit 
            string password = txt_password.Text;
            string username = txt_name.Text;
            //encapuslation
            login_object = new LoginProps();
            login_object.name = username;
            login_object.password = password;
            //
            bll_object = new LoginBll();
            UserProps fecthed_object = bll_object.Valdiate(login_object);
            System.Diagnostics.Debug.WriteLine("UserProps fecthed_object = bll_object.Valdiate(login_object)");
            if (fecthed_object.id > 0)
            {
                System.Diagnostics.Debug.WriteLine("(fecthed_object.id > 0)");
                if (fecthed_object.role == 1 && fecthed_object.status == 1)
                {
                  
                   
                    //role is admin redirect to admin page
                    System.Diagnostics.Debug.WriteLine("user is admin");
                    Session["username"] = fecthed_object.name;
                    Session["password"] = fecthed_object.password;
                    Response.Redirect("../Admin/Admin_Pages/All_Admin.aspx");
                }
                else
                
                {
                    System.Diagnostics.Debug.WriteLine("user not found");
                    Session["username"] = fecthed_object.name;
                    Session["password"] = fecthed_object.password;
                    Response.Redirect("../../Index.aspx");
                    //role is user redirect to admin page
                   
                }

            }
            else
            {
                // Response.Redirect('');
                //user not found redirect to login page 
                System.Diagnostics.Debug.WriteLine("user not found");
            }
        }
    }
}