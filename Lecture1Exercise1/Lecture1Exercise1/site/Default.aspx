<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lecture1Exercise1.site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 1</title>
    <link href="../style/MyStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
    <h1>Hello!</h1>
        <asp:Label ID="Label1" runat="server" Text="Enter your name: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="btn_Send" runat="server" OnClick="btn_Send_Click" Text="Send" />
        <br />
        <asp:Label ID="OutputLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
