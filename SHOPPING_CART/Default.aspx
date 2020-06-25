<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SHOPPING_CART._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        img{
            height:;
            width:100%;
        }
    </style>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="jumbotron">
                    <h1>E-Commerce Website</h1>
                </div>
            </div>
        </div>
        <div class="row">
         <asp:Button ID="submit_btn" runat="server"  CssClass="btn btn-block btn-warning" Text="Add to cart" />
            <asp:DataList ID="DataList1" RepeatLayout="Flow" RepeatDirection="Horizontal" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" >
           <ItemTemplate>
               <div class="  col-md-3 col-xs-6 card border border-dark">
                    <img class="card-img-top" class="img-fluid img-responsive img-thumnail" src="./Images/<%# Eval("Image") %>">"
                 
                    <div class="card-body">
                    <div class="card-title text-center font-weighht-bold text-uppercase"> <%# Eval("Name") %> </div>
                     <div class="card-text p-2"><%# Eval("Description") %></div>
                      </div>
                    <div class="card-footer"> 
                    </div>
               </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
