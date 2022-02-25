<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HobiListesi.aspx.cs" Inherits="BlogWeb.HobiListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form id="form1" runat="server">
    <table class="table table-bordered">
         

        <tr>
            <th>ID</th>
            <th>HOBİ</th>
            <th>İŞLEMLER</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <td><%# Eval("ID") %> </td>
                         <td><%# Eval("HOBİ") %> </td>
                      
                        <td>
                            <asp:HyperLink NavigateUrl='<%#String.Format("~/HobiSil.aspx?ID={0}",Eval("ID")) %>'  ID="HyperLink1" runat="server"
                                 CssClass="btn btn-danger">SİL</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#String.Format("~/HobiGuncelle.aspx?ID={0}",Eval("ID")) %>' ID="HyperLink2" runat="server"
                                 CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
         
    </table>
    <asp:HyperLink NavigateUrl='<%#String.Format("~/HobiEkle.aspx")%>' ID="HyperLink3" runat="server"
             CssClass="btn btn-info"> YENİ HOBİ EKLE</asp:HyperLink>

        </form>
</asp:Content>
