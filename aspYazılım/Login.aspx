﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="aspYazılım.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tboxUsername" runat="server"></asp:TextBox>
            <asp:TextBox ID="tboxPassword" runat="server"></asp:TextBox>
            <asp:Button ID="btnLogin" CssClass="btn btn-danger" runat="server" Text="Giriş Yap" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
