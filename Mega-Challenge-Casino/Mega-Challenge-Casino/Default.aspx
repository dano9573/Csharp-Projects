<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mega_Challenge_Casino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="180px" Width="180px" />
        <asp:Image ID="Image2" runat="server" Height="180px" Width="180px" />
        <asp:Image ID="Image3" runat="server" Height="180px" Width="180px" />
        <br />
&nbsp;<br />
        Your Bet:&nbsp;
        <asp:TextBox ID="betTextBox" runat="server" Font-Bold="True" ForeColor="Red"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="moneyLabel" runat="server" BackColor="#CCFF99" Font-Bold="True" Font-Size="Larger" ForeColor="Lime"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="leverButton" runat="server" BackColor="Blue" ForeColor="Yellow" OnClick="leverButton_Click" Text="Pull The Lever!" Width="200px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <p>
            1 Cherry&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; = x2 Your Bet<br />
            2 Cherries&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; = x3 Your Bet<br />
            3 Cherries&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; = x4 Your Bet<br />
            3
            <asp:Image ID="Image4" runat="server" Height="20px" ImageUrl="Images/Seven.png" Width="20px" />
            <asp:Image ID="Image5" runat="server" Height="20px" ImageUrl="Images/Seven.png" Width="20px" />
&nbsp;<asp:Image ID="Image6" runat="server" Height="20px" ImageUrl="Images/Seven.png" Width="20px" />
&nbsp;&nbsp;&nbsp; = Jackpot - x100 Your Bet<br />
            ANY
            <asp:Image ID="Image7" runat="server" Height="30px" ImageUrl="Images/Bar.png" Width="40px" />
&nbsp;&nbsp; = You win nothing</p>
    
    </div>
    </form>
</body>
</html>
