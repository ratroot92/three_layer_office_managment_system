<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="All_Admin.aspx.cs" Inherits="SHOPPING_CART.Pages.Admin.Admin_Pages.All_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
        <div class="container">


<nav aria-label="breadcrumb">
  <ol class="breadcrumb">
     <li class="breadcrumb-item"><asp:HyperLink ID="href_home" NavigateUrl="~/Pages/Admin/Admin_Pages/All_Admin.aspx" runat="server" >Home</asp:HyperLink></li>
    <li class="breadcrumb-item active" aria-current="page" ><asp:HyperLink  ID="href_alladmin" NavigateUrl="~/Pages/Admin/Admin_Pages/All_Admin.aspx" runat="server" >All Admins</asp:HyperLink></li>
  
    <li class="breadcrumb-item "><asp:HyperLink ID="href_addproduct" NavigateUrl="~/Pages/Admin/Admin_Pages/Add_Admin.aspx" runat="server"  >Add Admin</asp:HyperLink></li>
  </ol>
</nav>
            </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="All_Admins_Table" runat="server" CssClass="table table-hover table-striped" GridLines="None" 
    AutoGenerateColumns="False" Font-Size="12px">
                     <Columns>
        <asp:BoundField DataField="id" HeaderText="ID" Visible="true" />
        <asp:BoundField DataField="fname" HeaderText="F Name" />
        <asp:BoundField DataField="lname" HeaderText="L Name" />
        <asp:BoundField DataField="email" HeaderText="Email" />
        <asp:BoundField DataField="mobile" HeaderText="Mobile" />
        <asp:BoundField DataField="password" HeaderText="Password" />
        <asp:BoundField DataField="status" HeaderText="Status" />
        <asp:BoundField DataField="created_at" HeaderText="Created At " />
        <asp:BoundField DataField="updated_at" HeaderText="Updated  At " />

    </Columns>
    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>

               
               
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="JsBlock" runat="server">
       <script>
              $(document).ready(function () {
                  console.log("Ready");
                  var url_last_segment = window.location.pathname.split("/").pop();
                  console.log(url_last_segment);
 
                      var submenu_name = url_last_segment.split("_").pop();
                      console.log("Page Name = " + url_last_segment);
                      console.log("PSubMenu Name = " + submenu_name);
                      $('#submenu-' + submenu_name).addClass("collapsed");
                      $('#submenu-' + submenu_name).addClass("collapse in");
                      $('#' + url_last_segment).addClass("bg-primary text-dark");
                  

              })
          </script>
    </asp:Content>