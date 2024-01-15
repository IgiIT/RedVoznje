<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RedVoznje._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Prikaz sedista autobusa:</h1>
    <br />
    <asp:Table ID="tabela" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" GridLines="Both" Width="199px"></asp:Table>
    <br />
    <table style="width: 50%;">
        <tr>
            <td width="33%">Broj sedista</td>
            <td width="33%"><asp:TextBox ID="txtSediste" runat="server" Enabled="False" Width="144px"></asp:TextBox></td>
            <td width="33%">&nbsp;</td>
        </tr>
        <tr>
            <td>Ime i prezime</td>
            <td><asp:TextBox ID="txtImePrezime" runat="server" Width="144px"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server" Width="144px"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btn" runat="server" Text="Posalji" OnClick="btn_Click" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
