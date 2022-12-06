<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogPage.aspx.cs" Inherits="RegLogWebApp.LogPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="logstyle.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
        <h3>Login Here</h3>
        <label for="username">Username</label>
        <asp:TextBox ID="txtUsername" class="input" runat="server" placeholder="Username"/>
        <label for="password">Password</label>
        <asp:TextBox ID="txtPassword" class="input" runat="server" placeholder="Password" type="password"/>
        <asp:Button Text="Login" class="button" runat="server" OnClick="btnLogin_click"/>
        <asp:LinkButton Text="Don't you have an account? >>> Register" CssClass ="linkregister"  runat="server" link href="RegPage.aspx" />
        <asp:Label  ID= "lblShow" runat="server" Text=""></asp:Label>
    </form> 
</body>
</html>
