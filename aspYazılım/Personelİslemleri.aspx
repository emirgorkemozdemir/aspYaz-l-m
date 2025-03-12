<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personelİslemleri.aspx.cs" Inherits="aspYazılım.Personelİslemleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <asp:Button ID="GoToAdd" runat="server" CssClass="btn btn-info" Text="Personel Ekle" OnClick="GoToAdd_Click" />

        <asp:TextBox ID="tboxFilter" runat="server" OnTextChanged="tboxFilter_TextChanged"  AutoPostBack="True"></asp:TextBox>
        <asp:Button ID="btnFilter" runat="server" Text="Filtrele" OnClick="btnFilter_Click" />

 <asp:DataList ID="DataList1" runat="server" CssClass="table table-hover" cellspacing="0" style="border-collapse:collapse;">
    
   
    <HeaderTemplate>
      
                <th>Personel Ad</th>
                <th>Personel Soyad</th>
                <th>Personel Telefon</th>
                <th>Personel Mail</th>
                <th>Personel Pozisyon</th>
                <th>Personel Maaş</th>
                <th>Personel İşe Giriş</th>
                <th>Personeli Sil</th>
                <th>Personeli Güncelle</th>
          
    </HeaderTemplate>
    
    <ItemTemplate>
            <td><%# Eval("ad") %></td>
            <td><%# Eval("soyad") %></td>
            <td><%# Eval("telefon") %></td>
            <td><%# Eval("email") %></td>
            <td><%# Eval("pozisyon") %></td>
            <td><%# Eval("maas") %></td>
            <td><%# Eval("ise_giris_tarihi") %></td>
            <td><a href="PersoneliSil.aspx?id=<%# Eval("id") %>" class="btn btn-danger">Sil</a></td>
            <td><a href="PersoneliGuncelle.aspx?id=<%# Eval("id") %>" class="btn btn-warning">Güncelle</a></td>
    </ItemTemplate>

</asp:DataList>






    </form>
</body>
</html>
