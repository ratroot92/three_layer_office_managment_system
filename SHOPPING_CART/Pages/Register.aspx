<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SHOPPING_CART.Pages.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
		.panel{
			margin-top:100px;
		}
    </style> 

<div class="container-fluid bg-info">
        <div class="row centered-form">
        <div class="col-xs-12 col-sm-8 col-md-4 col-sm-offset-2 col-md-offset-4">
        	<div class="panel panel-default mt-5">
        		<div class="panel-heading">
			    		<h3 class="panel-title">E-Commerce sign up   <small>It's free!</small></h3>
			 			</div>
			 			<div class="panel-body">
			    	
			    			<div class="row">
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
											<label class="text-primary">First Name</label>
										<asp:TextBox runat="server" ID="fname_txt" CssClass="form-control input-sm" ></asp:TextBox>
			    					</div>
			    				</div>
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
			    						<label class="text-primary">Last  Name</label>
										<asp:TextBox runat="server" ID="lname_txt" CssClass="form-control input-sm" ></asp:TextBox>
			    					</div>
			    				</div>
			    			</div>

			    			<div class="form-group">
								<label class="text-primary">Email</label>
			    				<asp:TextBox runat="server" ID="email_txt" CssClass="form-control input-sm" ></asp:TextBox>
			    			</div>

			    			<div class="row">
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
										<label class="text-primary">Password</label>
			    						<asp:TextBox runat="server" ID="password_txt" CssClass="form-control input-sm" ></asp:TextBox>
			    					</div>
			    				</div>
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
										<label class="text-primary">Confirm Password </label>
			    					<asp:TextBox runat="server" ID="cpassword_txt" CssClass="form-control input-sm" ></asp:TextBox>
			    					</div>
			    				</div>
			    			</div>
			    			
			    		
							 <asp:Button ID="btn_submit" runat="server"  CssClass="btn btn-info btn-block" />
			    		
			    		
			    	</div>
	    		</div>
    		</div>
    	</div>
    </div>
</asp:Content>
