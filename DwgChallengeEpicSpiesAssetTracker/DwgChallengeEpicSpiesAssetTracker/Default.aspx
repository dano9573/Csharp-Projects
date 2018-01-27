<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DwgChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/epic-spies-logo.jpg" />
    
    </div>
        <h1 class="auto-style1">Asset Performance Tracker</h1>
        <p>
            Asset Name:&nbsp;
            <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:&nbsp;
            <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="assetButton" runat="server" OnClick="assetButton_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
