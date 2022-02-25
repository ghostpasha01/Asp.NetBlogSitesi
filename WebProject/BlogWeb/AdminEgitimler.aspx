<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimler.aspx.cs" Inherits="BlogWeb.AdminEgitimler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
    <table class="table table-bordered">
         

        <tr>
            <th>ID</th>
            <th>BAŞLIK</th>
            <th>ALT BAŞLIK</th>
            <th>AÇIKLAMA</th>
            <th>GENEL NOT ORT</th>
            <th>TARİH</th>
            <th>İŞLEMLER</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <td><%# Eval("ID") %> </td>
                         <td><%# Eval("BASLIK") %> </td>
                         <td><%# Eval("ALTBASLIK") %> </td>
                         <td><%#("ACIKLAMA") %> </td>
                         <td><%#("GNOT") %> </td>
                         <td><%#Eval("TARIH") %> </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#String.Format("~/AdminEgitimSil.aspx?ID={0}",Eval("ID")) %>' ID="HyperLink1" runat="server"
                                 CssClass="btn btn-danger">SİL</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#String.Format("~/AdminEgitimGuncelle.aspx?ID={0}",Eval("ID")) %>' ID="HyperLink2" runat="server"
                                 CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
         
    </table>
    <asp:HyperLink NavigateUrl='AdminEgitimEkle.aspx' ID="HyperLink3" runat="server"
             CssClass="btn btn-info">Egitim Ekle</asp:HyperLink>

        </form>

</asp:Content>
