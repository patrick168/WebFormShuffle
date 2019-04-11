<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebSortPlayCard.aspx.cs" Inherits="WebShuffle.WebSortPlayCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="NewPlayCard" runat="server" Text="Deal New PlayCard" OnClick="NewPlayCard_Click" />
            &nbsp;<asp:Button ID="SortNewPlayCard" runat="server" Text="Sort New PlayCard" OnClick="SortNewPlayCard_Click" />
            &nbsp;<asp:Button ID="DealOnePlayer" runat="server" Text="DealOnePlayer" OnClick="DealOnePlayer_Click" />
            &nbsp;<asp:Button ID="DealAllPlayers" runat="server" Text="Deal All Players" OnClick="DealAllPlayers_Click" />
            &nbsp;</div>
    </form>
</body>
</html>