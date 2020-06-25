<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Add_Product.aspx.cs" Inherits="SHOPPING_CART.Pages.ProductPages.Add_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-md-12">
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
    <li class="breadcrumb-item " ><asp:HyperLink  ID="href_allproduct" NavigateUrl="~/Pages/ProductPages/All_Product.aspx" runat="server" >All Products</asp:HyperLink></li>
  
    <li class="breadcrumb-item active" aria-current="page"><asp:HyperLink ID="href_addproduct" NavigateUrl="~/Pages/ProductPages/Add_Product.aspx" runat="server"  >Add Product</asp:HyperLink></li>
  </ol>
</nav>
              <div class="row panel">
                  <div class="panel-title">Add Product</div>
                  <div class="col-md-12  panel-body">
                      <!-- Form Start -->

                                          
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="txt_name" class="text-primary">Name</label>
     
   
        <asp:TextBox ID="txt_name" runat="server" CssClass="form-control" ></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
          <asp:RequiredFieldValidator ID="id_vald" CssClass="text-danger validator text-wrap" ControlToValidate="txt_name" runat="server" Text="Name is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>




                                                             
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="txt_price" class="text-primary">Price</label>
     
   
        <asp:TextBox ID="txt_price" runat="server" CssClass="form-control" TextMode="Number" ></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-danger validator text-wrap" ControlToValidate="txt_price" runat="server" Text="Price is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>



                      

                                                             
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="txt_image" class="text-primary">Image</label>
     
   
        <asp:TextBox ID="txt_image" runat="server" CssClass="form-control" ></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="text-danger validator text-wrap" ControlToValidate="txt_image" runat="server" Text="Image is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>



                                                                                 
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="txt_description" class="text-primary">Description</label>
     
   
        <asp:TextBox ID="txt_description" runat="server" CssClass="form-control" Rows="5" TextMode="MultiLine" ></asp:TextBox>
         <!-- validator -->
        <small class="text-wrap ">
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="text-danger validator text-wrap" ControlToValidate="txt_description" runat="server" Text="Description is required"></asp:RequiredFieldValidator>
        </small>
<!-- validator -->
    </div>
  </div>








                                                                                   
  <div class="form-row">
    <div class="form-group col-md-12 form-inline">
      <label for="text_status" class="text-primary">Status </label>

        <asp:DropDownList ID="txt_status" runat="server" CssClass="form-control">
            <asp:ListItem>Select Status</asp:ListItem>
            <asp:ListItem Value="1">Active</asp:ListItem>
            <asp:ListItem Value="0">In active</asp:ListItem>
        </asp:DropDownList>
        <!-- validator -->
        <small class="text-wrap ">
        <asp:RequiredFieldValidator ID="status_vald" CssClass="text-danger validator text-wrap" ControlToValidate="txt_status" runat="server" Text="Status is required"></asp:RequiredFieldValidator>
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
        
                      <asp:Button ID="btn_submit" runat="server" Text="Add " CssClass="btn btn-primary" OnClick="btn_submit_Click"  />

                      <!-- Form End  -->
                  </div>
              </div>
          </div>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JsBlock" runat="server">
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