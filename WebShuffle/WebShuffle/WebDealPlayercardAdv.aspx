<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebDealPlayercardAdv.aspx.cs" Inherits="WebShuffle.WebDealPlayercardAdv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="dealbtn" runat="server" Text="Deal" OnClick="dealbtn_Click" style="height: 27px" />
        &nbsp;
            <asp:Button ID="ShuffleBtn" runat="server" OnClick="ShuffleBtn_Click" Text="Shuffle" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
