<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DwgChallengeDaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        How many days have elapsed?<p>
            Choose one date:<asp:Calendar ID="firstCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" BackColor="#CCCCCC" Font-Bold="True" Font-Size="Larger" Font-Underline="True" ForeColor="Red"></asp:Label>
        </p>
        <p>
            Choose a second date:<asp:Calendar ID="secondCalendar" runat="server"></asp:Calendar>
        </p>
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
    </form>
</body>
</html>
