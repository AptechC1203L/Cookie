<%@ Page Title="" Language="C#" MasterPageFile="~/Bowman.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Bowman.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="welcomeText" Text="" runat="server" /><br />
    <asp:Button ID="loginButton" Text="Login" runat="server" OnClick="loginButton_Click"/>
    <asp:Button ID="logoutButton" Text="Logout" runat="server" OnClick="logoutButton_Click" />
</asp:Content>
