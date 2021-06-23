<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowProductListCustomer.aspx.cs" Inherits="eKart.ShowProductListCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>eKart</title>
    <link rel="stylesheet" type="text/css" href="styles/style.css" />
</head>
<body>
    <form id="showProductListCustomerForm" runat="server">
        <div class="top-nav">
            <div class="home">eKart</div>
            <img src="images/shopping-cart.png" />
            <a href="ShowCart.aspx">Cart</a>
            <a href="#">Products</a>
        </div>
        <div class="page-title">Products</div>
        <asp:GridView id="grdProducts" runat="server" AutoGenerateColumns="false" OnRowCommand="grdProducts_RowCommand">
            <Columns>
                <asp:BoundField ItemStyle-CssClass="gridview-hidden-column" HeaderStyle-CssClass="gridview-hidden-column" DataField="Id" HeaderText="ProductId" />
                <asp:BoundField HeaderText="Product" DataField="Title" />
                <asp:BoundField HeaderText="Free Delivery" DataField="FreeDelivery" />
                <asp:BoundField HeaderText="Price" DataField="Price" />
                <asp:BoundField HeaderText="Category" DataField="Category" />
                <asp:ButtonField ButtonType="Link" HeaderText="Action" Text="Add" CommandName="Add" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
