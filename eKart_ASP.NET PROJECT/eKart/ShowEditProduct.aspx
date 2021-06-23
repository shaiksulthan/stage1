<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEditProduct.aspx.cs" Inherits="eKart.ShowEditProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>eKart</title>
    <link rel="stylesheet" type="text/css" href="styles/style.css" />
</head>
<body>
    <div class="top-nav">
        <div class="home">eKart</div>
        <img src="images/shopping-cart.png" />
        <a href="ShowProductListAdmin.aspx">Products</a>
    </div>
    <div class="page-title">Edit Product</div>
    <div class="body-content-colour">
        <form name="editProductForm" runat="server">
            <div>
                <label for="txtTitle">Title</label>
                <asp:TextBox ID="txtTitle" runat="server" CssClass="text-box text-box-title"/>
            </div>
            <div class="form-field-spacing">
                <div><label for="txtPrice">Price (₹)</label></div>
                <asp:TextBox ID="txtPrice" runat="server" CssClass="text-box"/>
            </div>

            <div class="form-field-spacing">
                <div><label for="inStock">In Stock</label></div>
                <asp:RadioButton ID="radInStockYes" GroupName="inStock" runat="server" Text="Yes" />
                <asp:RadioButton ID="radInStockNo" GroupName="inStock" runat="server" Text="No" />
            </div>

            <div class="form-field-spacing">
                <div><label for="txtDateOfExpiry">Date of Expiry</label></div>
                <asp:TextBox ID="txtDateOfExpiry" runat="server" TextMode="Date" />
            </div>

            <div class="form-field-spacing">
                <div><label for="ddlCategory">Category</label></div>
                <select id="ddlCategory" name="category" class="dropdown" runat="server">
                    <option value="1">Snack Foods</option>
                    <option value="2">Electronics</option>
                    <option value="3">Mobile</option>
                    <option value="4">Movies & Music</option>
                    <option value="5">Sports</option>
                    <option value="6">Books</option>
                </select>
            </div>
            <div class="form-field-spacing">
               <input type="checkbox" id="chkFreeDelivery" name="freeDelivery" runat="server"/>
               <label for="chkFreeDelivery">Free Delivery</label >
            </div>
            <asp:Button runat="server" ID="btnSave" Text="Save" CssClass="button success-button" OnClientClick="return validateForm()" OnClick="btnSave_Click" />
        </form>
    </div>
    <div class="footer">Copyright 2019</div>
</body>
</html>
