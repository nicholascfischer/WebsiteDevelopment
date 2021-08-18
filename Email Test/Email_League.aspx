<%@ Page Language="C#" AutoEventWireup="true" Codefile="Email_League.aspx.cs" Inherits="SendEmail" %>


<!DOCTYPE HTML>
<html>
<head >
</head>
<body>
<table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td>To:</td>
        <td><asp:TextBox ID="txtTo" runat="server" /></td>
    </tr>
    <tr>
        <td>Subject:</td>
        <td><asp:TextBox ID="txtSubject" runat="server" /></td>
    </tr>
    <tr>
        <td valign = "top">Body:</td>
        <td><asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Height="150" Width="200" /></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Button ID="btnSend" Text="Send" runat="server" OnClick = "SendEmail" /></td>
    </tr>
</table>
</body>
</html>