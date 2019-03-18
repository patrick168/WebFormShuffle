<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebDealPlaycard.aspx.cs" Inherits="TungSampleCode.WebDealPlaycard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="dealbtn" runat="server" Text="Deal" OnClick="dealbtn_Click" />
        &nbsp;
            <asp:Button ID="ShuffleBtn" runat="server" OnClick="ShuffleBtn_Click" Text="Shuffle" />
        </div>
    </form>
</body>
</html>
