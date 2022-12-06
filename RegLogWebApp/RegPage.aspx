<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegPage.aspx.cs" Inherits="RegLogWebApp.RegPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="regstyle.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
    <div class="title">Registration</div>
    <div class="content">
        <form id="form1" runat="server">
        <div class="user-details">
          <div class="input-box">
            <span class="details" >Username<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
              </span>
          </div>
          <div class="input-box">
            <span class="details">Email<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
              </span>
          </div>
          <div class="input-box">
            <span class="details">Password<asp:TextBox ID="txtPassword" runat="server" type="password"></asp:TextBox>
              </span>
          </div>
        </div>
          <asp:Button Text="Register" class="button" runat="server" OnClick="btnRegister_click" />
            <div class ="linkregister">
            <asp:LinkButton Text="Login Here" CssClass ="linklogin"  runat="server" link href="LogPage.aspx" />
            </div>
            
    <asp:Label  ID= "lblShow" runat="server" Text=""></asp:Label>
        </form>
         
    </div>
  </div>
</body>
</html>
