<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowCart.aspx.cs" Inherits="eKart.ShowCart" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>eKart</title>
    <link rel="stylesheet" type="text/css" href="styles/style.css" />
    <script type="text/javascript" src="scripts/script.js"></script>
</head>
<body>
    <form id="showCartForm" runat="server">
        <div class="top-nav">
            <div class="home">eKart</div>
            <img src="images/shopping-cart.png">
            <a href="#">Cart</a>
            <a href="ShowProductListCustomer.aspx">Products</a>
        </div>
        <div class="page-title">Cart</div>
        <asp:GridView ID="grdProducts" runat="server" AutoGenerateColumns="false" OnRowCommand="grdProducts_RowCommand" OnRowDeleting="grdProducts_RowDeleting">
            <Columns>
                <asp:BoundField ItemStyle-CssClass="gridview-hidden-column" HeaderStyle-CssClass="gridview-hidden-column" DataField="Id" HeaderText="ProductId" />
                <asp:BoundField HeaderText="Product" DataField="Title" />
                <asp:BoundField HeaderText="Free Delivery" DataField="FreeDelivery" />
                <asp:BoundField HeaderText="Price" DataField="Price" />
                <asp:ButtonField ButtonType="Link" HeaderText="" Text="Delete" CommandName="Delete" />
            </Columns>
        </asp:GridView>
        <div class="footer">Copyright 2019</div>
    </form>
</body>
</html>

