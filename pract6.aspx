<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pract6.aspx.cs" Inherits="unit2.pract6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select any file:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
        </div>
        <br />
        <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert Picture" />
        <br />
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="5">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Name","~/image_folder/{0}") %>' />
            </ItemTemplate>
        </asp:DataList>
    </form>
</body>
</html>
