<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calc.aspx.cs" Inherits="Lecture1Exercise1.site.calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../style/MyStyle.css" rel="stylesheet" />
    <title>Calculator</title>
</head>
<body>
    <br />
    <form id="form1" runat="server">
    <div class="main">
        <h1>Calculator</h1>
    <asp:Label runat="server" Text=" Enter first number "></asp:Label><asp:Textbox ID="textbox_firstnr" runat="server"></asp:Textbox><br />
    <asp:Label runat="server" Text=" Enter second number "></asp:Label><asp:Textbox ID="textbox_secondnr" runat="server"></asp:Textbox>
        
    
        <br />
        <p>What do you want to do?</p>
        <asp:Label runat="server" Text="Add: "></asp:Label>
        <asp:Button runat="server" ID="btn_Add" OnClick="btn_Add_Click" />

        <asp:Label runat="server" Text="Subtract: ">
        </asp:Label><asp:Button runat="server" ID="btn_Sub" OnClick="btn_Sub_Click" />

        <asp:Label runat="server" Text="Multiply: "></asp:Label>
        <asp:Button runat="server" ID="btn_Multi" OnClick="btn_Multi_Click" />

        <asp:Label runat="server" Text="Divide: "></asp:Label>
        <asp:Button runat="server" ID="btn_div" OnClick="btn_div_Click" />
        <br />
        <asp:Label runat="server" ID="Result"></asp:Label>
    </div>
    </form>
</body>
</html>
