using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Props;
using Buisness;
namespace SHOPPING_CART.Pages.Admin.Admin_Pages
{
    public partial class Add_Admin : System.Web.UI.Page
    {
        AdminProps admin_object;
        AdminBll adminbll_object;
        //Generic Functions 
        public void GetlastId()
        {
            adminbll_object = new AdminBll();
            int id = adminbll_object.GetLastId();
            id = id + 1;
            txt_id.Text = id.ToString();
            System.Diagnostics.Debug.WriteLine("## Admin Last Id ##" + id);
        }
        //End Generic Fucntions
        protected void Page_Load(object sender, EventArgs e)
        {


            //if (Session["username"] != null)
            // {
           
            //  }
            //  else
            //   {
            //    Response.Redirect("../../LoginPages/LoginPage.aspx");
            //  }


        }


        public void ClearAll()
        {
            fname_txt.Text = "";
            lname_txt.Text = "";
            email_txt.Text = "";
            password_txt.Text = "";
            mobile_txt.Text = "";
            

        }
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id.Text);
            string fname = fname_txt.Text;
            string lname = lname_txt.Text;
            string email = email_txt.Text;
            string mobile = mobile_txt.Text;
            string password = password_txt.Text;
            string name = fname_txt.Text;
            int status = Int32.Parse(status_txt.Text);
            //Encapsulate data
            admin_object =new AdminProps();
            admin_object.id = id;
            admin_object.fname = fname;
            admin_object.lname = lname;
            admin_object.email = email;
            admin_object.mobile = mobile;
            admin_object.password = password;
            admin_object.status =status;
            //Call to Buiness Layer
            adminbll_object = new AdminBll();
            bool db_status =adminbll_object.Insert(admin_object);
            if (db_status)
            {
                Response.Write("<script>alert('Admin inserted successfully ')</script>");
                ClearAll();
                GetlastId();
            }
            else
            {
                Response.Write("<script>alert('Operation failed ')</script>");
            }



        }
    }
}