<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartEmpty.aspx.cs" Inherits="eKart.CartEmpty" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>eKart</title>
    <link rel="stylesheet" type="text/css" href="styles/style.css" />
</head>
<body>
    <div class="top-nav">
        <div class="home">eKart</div>
        <img src="images/shopping-cart.png">
        <a href="ShowCart.aspx">Cart</a>
        <a href="ShowProductListCustomer.aspx">Products</a>
    </div>
    <div class="page-title">Cart</div>
    <p class="message">
        No items in cart. Use 'Add to Cart' option in
        <a href="ShowProductListCustomer.aspx">Product List</a>
    </p>
    <div class="footer">Copyright 2019</div>
</body>
</html>

