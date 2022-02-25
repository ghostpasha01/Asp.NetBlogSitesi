<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimEkle.aspx.cs" Inherits="BlogWeb.AdminEgitmEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label1" runat="server" Text="BASLIK"></asp:Label>
                <asp:TextBox ID="txtBaslık" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label2" runat="server" Text="ALTBASLIK"></asp:Label>
                <asp:TextBox ID="txtAltbaslık" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label ID="Label3" runat="server" Text="ACIKLAMA"></asp:Label>
                <asp:TextBox ID="txtAcıklama" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="GENEL NOT ORTALAMASI"></asp:Label>
                <asp:TextBox ID="txtGenelnotOrt" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <br />
           
            <div>
                <asp:Label ID="Label4" runat="server" Text="TARIH"></asp:Label>
                <asp:TextBox ID="txtTarıh" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <br />
           
              <asp:Button ID="Button1" runat="server" Text="KAYDET" CssClass="btn btn-info" OnClick="Button1_Click1"/>
        </div>
    </form>
</asp:Content>
