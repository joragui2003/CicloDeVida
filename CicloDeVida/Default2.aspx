<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <br />Cantidad de Texbox a Generar <asp:TextBox ID="txtCant" runat="server" /> <br /><br />
    <asp:LinkButton ID="lnkGene" runat="server" Text="Generar" OnClick="lnkGene_Click"></asp:LinkButton><br />
    <asp:PlaceHolder ID="phTxt" runat="server"></asp:PlaceHolder>
    <asp:Panel ID="pnlSuma" runat="server"></asp:Panel>
</asp:Content>