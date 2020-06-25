<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Add_User.aspx.cs" Inherits="SHOPPING_CART.Pages.UserPages.Add_User" %>
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
<!-- FORM FIELD START -->
       <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Name</label>
     
       
        <asp:TextBox ID="name_txt" runat="server" MaxLength="25" TextMode="SingleLine"  CssClass="form-control"></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-danger validator text-wrap" ControlToValidate="name_txt" runat="server" Text="Name is required"></asp:RequiredFieldValidator> 

        </small>
<!-- validator -->
    </div>
  </div>
<!-- FORM FIELD START -->



        <!-- FORM FIELD START -->
       <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Email</label>
     
       
        <asp:TextBox ID="email_txt" runat="server" MaxLength="25" TextMode="Email" CssClass="form-control"></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-danger validator text-wrap" ControlToValidate="email_txt" runat="server" Text="Email is required"></asp:RequiredFieldValidator> 

        </small>
<!-- validator -->
    </div>
  </div>
<!-- FORM FIELD START -->

        
        <!-- FORM FIELD START -->
       <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Mobile</label>
     
       
        <asp:TextBox ID="mobile_txt" runat="server"  CssClass="form-control" MaxLength="11" TextMode="SingleLine"></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="text-danger validator text-wrap" ControlToValidate="mobile_txt"  runat="server" Text="Mobile is required"></asp:RequiredFieldValidator> 

        </small>
<!-- validator -->
    </div>
  </div>
<!-- FORM FIELD START -->


        
        <!-- FORM FIELD START -->
       <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Password</label>
     
       
        <asp:TextBox ID="password_txt" runat="server" MaxLength="14" MinLength="8"  TextMode="Password" CssClass="form-control"></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="text-danger validator text-wrap" ControlToValidate="password_txt" runat="server" Text="Password is required"></asp:RequiredFieldValidator> 

        </small>
<!-- validator -->
    </div>
  </div>
<!-- FORM FIELD START -->




        
        <!-- FORM FIELD START -->
       <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Role</label>
     
        <asp:DropDownList ID="role_ddn" runat="server" CssClass="form-control">
            <asp:ListItem>Select Role</asp:ListItem>
            <asp:ListItem Value="1">Admin</asp:ListItem>
            <asp:ListItem Value="0">User</asp:ListItem>
        </asp:DropDownList>
       
         <!-- validator -->
        <small class="text-wrap ">
        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="text-danger validator text-wrap" ControlToValidate="role_ddn" runat="server" Text="Role  is required"></asp:RequiredFieldValidator> 

        </small>
<!-- validator -->
    </div>
  </div>
<!-- FORM FIELD START -->




         
        <!-- FORM FIELD START -->
       <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="inputEmail4" class="text-primary">Status</label>
     
        <asp:DropDownList ID="status_ddn" runat="server" CssClass="form-control">
            <asp:ListItem>Select Role</asp:ListItem>
            <asp:ListItem Value="1">Active</asp:ListItem>
            <asp:ListItem Value="0">Inactive</asp:ListItem>
        </asp:DropDownList>
       
         <!-- validator -->
        <small class="text-wrap ">
        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="text-danger validator text-wrap" ControlToValidate="status_ddn" runat="server" Text="Role  is required"></asp:RequiredFieldValidator> 

        </small>
<!-- validator -->
    </div>
  </div>
<!-- FORM FIELD START -->

        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add User" />

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
                      console.log("SubMenu Name = " + submenu_name);
                      $('#submenu-' + submenu_name).addClass("collapsed");
                      $('#submenu-' + submenu_name).addClass("collapse in");
                      $('#' + url_last_segment).addClass("bg-primary text-dark");
                  

              })
          </script>
   </asp:Content>
