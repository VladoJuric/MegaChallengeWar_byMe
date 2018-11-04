<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeWar_byMe.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Algerian;
            color: #FF0000;
        }
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong><span class="auto-style2">War Card Game</span><br />
            <br />
            </strong>
            <asp:Button ID="playButton" runat="server" OnClick="playButton_Click" Text="Play !" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" style="color: #000000; font-family: Arial, Helvetica, sans-serif; font-size: small"></asp:Label>
        </div>
    </form>
</body>
</html>
