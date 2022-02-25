<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="OdulListesi.aspx.cs" Inherits="BlogWeb.OdullerLisetesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
    <table class="table table-bordered">
         

        <tr>
            <th>ID</th>
            <th>ÖDÜLLER</th>
            <th>İŞLEMLER</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <td><%# Eval("ID") %> </td>
                         <td><%# Eval("ODUL") %> </td>
                      
                        <td>
                            <asp:HyperLink NavigateUrl='<%#String.Format("~/OdulSil.aspx?ID={0}",Eval("ID")) %>' ID="HyperLink1" runat="server"
                                 CssClass="btn btn-danger">SİL</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#String.Format("~/OdulGuncelleaspx?ID={0}",Eval("ID")) %>' ID="HyperLink2" runat="server"
                                 CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
         
    </table>
    <asp:HyperLink NavigateUrl='<%#String.Format("~/OdulEkle.aspx")%>' ID="HyperLink3" runat="server"
             CssClass="btn btn-info"> YENİ ÖDÜL EKLE</asp:HyperLink>

        </form>
</asp:Content>
