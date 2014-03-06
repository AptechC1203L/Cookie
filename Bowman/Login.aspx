<%@ Page Title="" Language="C#" MasterPageFile="~/Bowman.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bowman.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <fieldset>
        <legend>Login details</legend>
        <ol>
            <li>
                <label for="usernameTextBox">Username</label>
                <asp:TextBox runat="server" ID="usernameTextBox" />
            </li>

            <li>
                <label for="passwordTextBox">Password</label>
                <asp:TextBox TextMode="Password" runat="server" ID="passwordTextBox" />
            </li>
            
            <asp:CheckBox Text="Remember me." runat="server" ID="rememberCheckBox"/>
        </ol>
    </fieldset>
    <asp:Button ID="submitButton" Text="Submit" runat="server" OnClick="submitButton_Click"/>
</asp:Content>
