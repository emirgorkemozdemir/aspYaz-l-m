<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersoneliGuncelle.aspx.cs" Inherits="aspYazılım.PersoneliGuncelle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tboxAd" runat="server" placeholder="Ad"></asp:TextBox>
            <asp:TextBox ID="tboxSoyad" runat="server" placeholder="Soyad"></asp:TextBox>
            <asp:TextBox ID="tboxPozisyon" runat="server"  placeholder="Pozisyon"></asp:TextBox>
            <asp:TextBox ID="tboxMaas" runat="server"  placeholder="Maaş"></asp:TextBox>
            <asp:TextBox ID="tboxEmail" runat="server"  placeholder="Mail"></asp:TextBox>
            <asp:TextBox ID="tboxTelefon" runat="server"  placeholder="Telefon"></asp:TextBox>
            <asp:TextBox ID="tboxAktiflik" runat="server"  placeholder="Aktiflik"></asp:TextBox>
            <asp:Button ID="btnUpdate" runat="server" Text="Güncelle" OnClick="btnUpdate_Click" />
        </div>
    </form>
</body>
</html>
