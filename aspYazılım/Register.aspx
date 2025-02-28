<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="aspYazılım.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tboxUsername" runat="server"></asp:TextBox>
            <asp:TextBox ID="tboxPassword" runat="server"></asp:TextBox>
            <asp:Button ID="btnRegister" CssClass="btn btn-danger" runat="server" Text="Kayıt Ol" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
