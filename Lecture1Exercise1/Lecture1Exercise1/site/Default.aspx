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
        <div class="main">
            <h2>What do you like the most?
                
            </h2>
            <br />
            <asp:Label runat="server" Text="Music"></asp:Label><asp:RadioButton ID="btn_music" runat="server" AutoPostBack="True" OnCheckedChanged="btn_music_CheckedChanged" />
            <asp:Label runat="server" Text="News in swedish."></asp:Label><asp:RadioButton ID="btn_news" runat="server" AutoPostBack="True" OnCheckedChanged="btn_news_CheckedChanged" />
            <asp:Panel ID="panel_music" runat="server" Height="30px" Visible="False">
                <a href="http://www.spotify.com">Spotify</a>
            </asp:Panel>
            <asp:Panel ID="panel_news" runat="server" Visible="False">
                <a href="http://www.Omni.se">Omni</a>
                </asp:Panel>
            
        </div>
    </form>
</body>
</html>
