﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCFWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
        <asp:Button ID="Button1" runat="server" Text="Sum" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sub" />
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br/>
    </div>
    </form>
</body>
</html>
