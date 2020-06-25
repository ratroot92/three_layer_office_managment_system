<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="All_Product.aspx.cs" Inherits="SHOPPING_CART.Pages.ProductPages.All_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
        
<nav aria-label="breadcrumb">
  <ol class="breadcrumb">
    <li class="breadcrumb-item"><asp:HyperLink ID="href_home" NavigateUrl="~/Pages/Admin/Admin_Pages/All_Admin.aspx" runat="server" >Home</asp:HyperLink></li>
    <li class="breadcrumb-item active" aria-current="page" ><asp:HyperLink  ID="href_allproduct" NavigateUrl="~/Pages/ProductPages/All_Product.aspx" runat="server" >All Products</asp:HyperLink></li>
  
    <li class="breadcrumb-item "><asp:HyperLink ID="href_addproduct" NavigateUrl="~/Pages/ProductPages/Add_Product.aspx" runat="server"  >Add Products</asp:HyperLink></li>
  </ol>
</nav>
    </div>
    <div class="row">
        <div class="col-md-12">
               <asp:GridView ID="ProductTable" runat="server"  CssClass="table table-hover table-striped" GridLines="None" 
    AutoGenerateColumns="False" Font-Size="12px">
                   
                     <Columns>
        <asp:BoundField DataField="id" HeaderText="ID" Visible="true" />
        <asp:BoundField DataField="name" HeaderText="Name" />
        <asp:BoundField DataField="price" HeaderText="Price" />
        <asp:BoundField DataField="description" HeaderText="Description" />
        <asp:BoundField DataField="status" HeaderText="Status" />
         <asp:BoundField DataField="image" HeaderText="Image" />
        <asp:BoundField DataField="created_at" HeaderText="Created At " />
        <asp:BoundField DataField="updated_at" HeaderText="Updated  At " />

    </Columns>
    <RowStyle CssClass="cursor-pointer" />
              
    </asp:GridView>
        </div>
    </div>
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="JsBlock" runat="server">
</asp:Content>
