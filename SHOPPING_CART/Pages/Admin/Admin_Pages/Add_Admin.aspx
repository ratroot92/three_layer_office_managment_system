<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Add_Admin.aspx.cs" Inherits="SHOPPING_CART.Pages.Admin.Admin_Pages.Add_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        label{
            width:150px;
            height:auto;
            border:1px solid #ffd800;
            padding:5px;
        }
        .form-control{
              border:1px solid #ffd800!important;
              border-radius:0px!important;
              width:300px!important;
        }
        small{
            width:200px;


        }
    </style>
      <div class="col-md-12">
          <div class="container">

<nav aria-label="breadcrumb">
  <ol class="breadcrumb">
     <li class="breadcrumb-item"><asp:HyperLink ID="href_home" NavigateUrl="~/Pages/Admin/Admin_Pages/All_Admin.aspx" runat="server" >Home</asp:HyperLink></li>
    <li class="breadcrumb-item " ><asp:HyperLink  ID="href_alladmin" NavigateUrl="~/Pages/Admin/Admin_Pages/All_Admin.aspx" runat="server" >All Admins</asp:HyperLink></li>
  
    <li class="breadcrumb-item active" aria-current="page"><asp:HyperLink ID="href_addproduct" NavigateUrl="~/Pages/Admin/Admin_Pages/Add_Admin.aspx" runat="server"  >Add Admin</asp:HyperLink></li>
  </ol>
</nav>
              <div class="row panel">
                  <div class="panel-title">Add Admin</div>
                  <div class="col-md-12  panel-body">
                      <!-- Form Start -->

                                          
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">ID</label>
     
        <asp:TextBox ID="txt_id" runat="server" CssClass="form-control"></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
          <asp:RequiredFieldValidator ID="id_vald" CssClass="text-danger validator text-wrap" ControlToValidate="txt_id" runat="server" Text="ID is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>


                     
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">First Name</label>
     
        <asp:TextBox ID="fname_txt" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="25"></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
          <asp:RequiredFieldValidator ID="fname_vald" CssClass="text-danger validator text-wrap" ControlToValidate="fname_txt" runat="server" Text="First name is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>

                                           
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">last Name</label>
      <asp:TextBox ID="lname_txt" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="25"></asp:TextBox>
        <!-- validator -->
        <small class="text-wrap ">
          <asp:RequiredFieldValidator ID="lname_vald" CssClass="text-danger validator text-wrap" ControlToValidate="lname_txt" runat="server" Text="Last name is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>


                                                               
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Email</label>
   <asp:TextBox ID="email_txt" runat="server" CssClass="form-control" TextMode="Email" MaxLength="25"></asp:TextBox>
        <!-- validator -->
        <small class="text-wrap ">
                <asp:RequiredFieldValidator ID="email_vald" CssClass="text-danger validator text-wrap" ControlToValidate="email_txt" runat="server" Text="Email is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>

                                                               
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Mobile #</label>
      <asp:TextBox ID="mobile_txt" runat="server" CssClass="form-control" TextMode="Number" MaxLength="11"></asp:TextBox>
        <!-- validator -->
        <small class="text-wrap ">
    <asp:RequiredFieldValidator ID="mobile_vald" CssClass="text-danger validator text-wrap" ControlToValidate="mobile_txt" runat="server" Text="Mobile #  is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>


                                                               
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Password </label>
   <asp:TextBox ID="password_txt" runat="server" CssClass="form-control" TextMode="Password" MinLength="8" MaxLength="14"></asp:TextBox>
        <!-- validator -->
        <small class="text-wrap ">
        <asp:RequiredFieldValidator ID="passowrd_vald" CssClass="text-danger validator text-wrap" ControlToValidate="password_txt" runat="server" Text="Password is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->

    </div>
  </div>

                                                               
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Confirm Password </label>
      <asp:TextBox ID="cpassword_txt" runat="server" CssClass="form-control" TextMode="Password" MaxLength="25"></asp:TextBox>
        <!-- validator -->
        <small class="text-wrap ">
            <asp:CompareValidator ID="CompareValidator1" CssClass="text-danger validator text-wrap"  runat="server" ErrorMessage="Password Mismatch" ControlToCompare="password_txt" ControlToValidate="cpassword_txt"></asp:CompareValidator>
        </small>
<!-- validator -->
    </div>
  </div>


                                                                                   
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Status </label>

        <asp:DropDownList ID="status_txt" runat="server" CssClass="form-control">
            <asp:ListItem>Select Status</asp:ListItem>
            <asp:ListItem Value="1">Active</asp:ListItem>
            <asp:ListItem Value="0">In active</asp:ListItem>
        </asp:DropDownList>
        <!-- validator -->
        <small class="text-wrap ">
        <asp:RequiredFieldValidator ID="status_vald" CssClass="text-danger validator text-wrap" ControlToValidate="status_txt" runat="server" Text="Status is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->

    </div>
  </div>





  <div class="form-group">
    <div class="form-check">
      <input class="form-check-input" type="checkbox" id="gridCheck">
      <small class="form-check-label text-primary" for="gridCheck">
       I agree with terms and conditions 
      </small>
    </div>
  </div>
 <asp:Button ID="btn_submit" runat="server" Text="Add " CssClass="btn btn-primary" OnClick="btn_submit_Click" />        


                      <!-- Form End  -->
                  </div>
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
                  if (url_last_segment == 'Add_Admin') {
                      var submenu_name = url_last_segment.split("_").pop();
                      console.log("Page Name = " + url_last_segment);
                      console.log("PSubMenu Name = " + submenu_name);
                      $('#submenu-' + submenu_name).addClass("collapsed");
                      $('#submenu-' + submenu_name).addClass("collapse in");
                      $('#' + url_last_segment).addClass("bg-primary text-dark");
                  }

              })
          </script>
    </asp:Content>