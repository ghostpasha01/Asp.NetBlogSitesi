<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyimGüncelle.aspx.cs" Inherits="BlogWeb.AdminDeneyimGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form id="form1" runat="server">
        <div class="form-group">
             <div>
                <asp:Label ID="Label5" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />
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
                <asp:TextBox ID="txtAcıklama" runat="server" CssClass="form-control" Height="100px"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label ID="Label4" runat="server" Text="TARIH"></asp:Label>
                <asp:TextBox ID="txtTarıh" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <br />
           
              <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn  bg-primary" OnClick="btnGuncelle_Click"/>
        </div>
    </form>
</asp:Content>
