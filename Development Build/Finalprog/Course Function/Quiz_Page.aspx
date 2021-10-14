<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz_Page.aspx.cs" Inherits="Finalprog.Quiz_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <h2>
            <h2>
        <asp:Label ID="quizTitle" runat="server" Text="Label"></asp:Label>
    </h2>
        <asp:Label ID="Question_1" runat="server" Text="Question 1"></asp:Label>
        <asp:Label ID="scoreLabel" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="157px" CausesValidation="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" ViewStateMode="Enabled">
            <asp:ListItem>A)</asp:ListItem>
            <asp:ListItem>B)</asp:ListItem>
            <asp:ListItem>C)</asp:ListItem>
            <asp:ListItem>D)</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Question_2" runat="server" Text="Question 2"></asp:Label>
        <asp:Label ID="Question_2A" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" Height="157px" CausesValidation="True" ViewStateMode="Enabled">
            <asp:ListItem>A)</asp:ListItem>
            <asp:ListItem>B)</asp:ListItem>
            <asp:ListItem>C)</asp:ListItem>
            <asp:ListItem>D)</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Question_3" runat="server" Text="Question 3"></asp:Label>
        <asp:Label ID="Question_3A" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList3" runat="server" Height="157px" CausesValidation="True" ViewStateMode="Enabled">
            <asp:ListItem>A)</asp:ListItem>
            <asp:ListItem>B)</asp:ListItem>
            <asp:ListItem>C)</asp:ListItem>
            <asp:ListItem>D)</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Question_4" runat="server" Text="Question 4"></asp:Label>
        <asp:Label ID="Question_4A" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList4" runat="server" Height="157px" CausesValidation="True" ViewStateMode="Enabled">
            <asp:ListItem>A)</asp:ListItem>
            <asp:ListItem>B)</asp:ListItem>
            <asp:ListItem>C)</asp:ListItem>
            <asp:ListItem>D)</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Question_5" runat="server" Text="Question 5"></asp:Label>
        <asp:Label ID="Question_5A" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList5" runat="server" Height="157px" CausesValidation="True" ViewStateMode="Enabled">
            <asp:ListItem>A)</asp:ListItem>
            <asp:ListItem>B)</asp:ListItem>
            <asp:ListItem>C)</asp:ListItem>
            <asp:ListItem>D)</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>



