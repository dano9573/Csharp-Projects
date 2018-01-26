<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
    
    </div>
        <h1>Spy New Assignment Form</h1>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:<asp:Calendar ID="previousCalendar" runat="server"></asp:Calendar>
        &nbsp;</p>
        <p>
            Start Date of New Assignment:<asp:Calendar ID="startdatenewCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:<asp:Calendar ID="endCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
