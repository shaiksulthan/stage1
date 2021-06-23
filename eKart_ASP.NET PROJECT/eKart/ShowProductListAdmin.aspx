<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowProductListAdmin.aspx.cs" Inherits="eKart.ShowProductListAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>eKart</title>
    <link rel="stylesheet" type="text/css" href="styles/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="top-nav">
            <div class="home">eKart</div>
            <img src="images/shopping-cart.png" />
        </div>
        <div class="page-title">Products</div>
        <asp:GridView id="grdProducts" runat="server" AutoGenerateColumns="false" OnRowEditing="grdProducts_RowEditing">
            <Columns>
                <asp:BoundField ItemStyle-CssClass="gridview-hidden-column" HeaderStyle-CssClass="gridview-hidden-column" DataField="Id" HeaderText="ProductId" />
                <asp:BoundField HeaderText="Product" DataField="Title" />
                <asp:BoundField HeaderText="Price" DataField="Price" />
                <asp:BoundField HeaderText="In Stock" DataField="InStock" />
                <asp:BoundField HeaderText="Date of Expiry" DataField="DateOfExpiry" DataFormatString="{0:dd/MM/yyyy}"/>
                <asp:BoundField HeaderText="Category" DataField="Category" />
                <asp:BoundField HeaderText="Free Delivery" DataField="FreeDelivery" />
                <asp:CommandField HeaderText="Action" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True"/>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
