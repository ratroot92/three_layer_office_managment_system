using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Props;
using Buisness;
namespace SHOPPING_CART.Pages.UserPages
{
    public partial class Add_User : System.Web.UI.Page
    {
        //class user props global object
        UserProps user_object;
        //bll class object
        UserBll bll_object;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //on button clikc 
            string name = name_txt.Text;
            string email = email_txt.Text;
            string password = password_txt.Text;
            int status = Int32.Parse(status_ddn.Text);
            int role = Int32.Parse(role_ddn.Text);
            string mobile = mobile_txt.Text;
            //initialize
            //encapsulation
            user_object = new UserProps();
            user_object.name = name;
            user_object.email = email;
            user_object.password = password;
            user_object.mobile = mobile;
            user_object.status = status;
            user_object.role = role;
            //
            bll_object = new UserBll();
            bool db_status = bll_object.Insert(user_object);
            if (db_status)
            {
                System.Diagnostics.Debug.WriteLine("success");
                Response.Write("<script>alert('User Inserted to Database ')<script>");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("failure");
                Response.Write("<script>alert('Failed ')<script>");
            }
        }
    }
    
}