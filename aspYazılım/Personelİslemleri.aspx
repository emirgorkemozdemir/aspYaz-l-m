<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personelİslemleri.aspx.cs" Inherits="aspYazılım.Personelİslemleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">



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
          
    </HeaderTemplate>
    
    <ItemTemplate>
      
            <td><%# Eval("ad") %></td>
            <td><%# Eval("soyad") %></td>
            <td><%# Eval("telefon") %></td>
            <td><%# Eval("email") %></td>
            <td><%# Eval("pozisyon") %></td>
            <td><%# Eval("maas") %></td>
            <td><%# Eval("ise_giris_tarihi") %></td>
            <td><a href="PersoneliSil.aspx?id=<%# Eval("id") %>" class="btn btn-danger"></a></td>
      
    </ItemTemplate>

</asp:DataList>






    </form>
</body>
</html>
