<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="eKart.AddToCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>eKart</title>
    <link rel="stylesheet" type="text/css" href="styles/style.css" />
</head>
<body>
    <form id="addToCartForm" runat="server">
        <div class="top-nav">
            <div class="home">eKart</div>
            <img src="images/shopping-cart.png" />
            <a href="ShowCart.aspx">Cart</a>
            <a href="ShowProductListCustomer.aspx">Products</a>
        </div>
        <div class="page-title">Home</div>
        <div class="success-message">Item added to Cart Successfully.</div>
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
