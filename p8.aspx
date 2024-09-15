<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="p8.aspx.cs" Inherits="unit2.p8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/Image-Folder/Img.png">
            <asp:RectangleHotSpot Bottom="30" NavigateUrl="~/p6.aspx" Right="97" />
            <asp:RectangleHotSpot Bottom="30" Left="100" NavigateUrl="~/p7.aspx" Right="197" />
            <asp:RectangleHotSpot Bottom="30" Left="200" NavigateUrl="~/p5.aspx" Right="297" />
        </asp:ImageMap>
    </form>
</body>
</html>
