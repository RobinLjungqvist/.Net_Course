<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fancycalc.aspx.cs" Inherits="Lecture1Exercise1.site.fancycalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fancy Calc</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="352px" Height="37px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="1" Width="90px" />
        <asp:Button ID="Button2" runat="server" Text="2" Width="90px" />
        <asp:Button ID="Button3" runat="server" Text="3" Width="90px" />
        <asp:Button ID="ButtonAdd" runat="server" Text="+" Width="90px" />

        <br />                                                  
        <asp:Button ID="Button4" runat="server" Text="4" Width="90px" />
        <asp:Button ID="Button5" runat="server" Text="5" Width="90px" />
        <asp:Button ID="Button6" runat="server" Text="6" Width="90px" />
        <asp:Button ID="ButtonSub" runat="server" Text="-" Width="90px" />

        <br />                                                  
        <asp:Button ID="Button7" runat="server" Text="7" Width="90px" />
        <asp:Button ID="Button8" runat="server" Text="8" Width="90px" />
        <asp:Button ID="Button9" runat="server" Text="9" Width="90px" />
        <asp:Button ID="ButtonMulti" runat="server" Text="*" Width="90px" />

        <br />
        <asp:Button ID="Button_C" runat="server" Text="C" Width="90px" />
        <asp:Button ID="Button0" runat="server" Text="0" Width="90px" />
        <asp:Button ID="ButtonEqual" runat="server" Text="=" Width="90px" />
        <asp:Button ID="ButtonDiv" runat="server" Text="/" Width="90px" />




    
    </div>
    </form>
</body>
</html>
