<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="p6.aspx.cs" Inherits="unit2.p6" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 51px;
        }
        .auto-style2 {
            height: 186px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            Select Any File:<asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style1" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert Picture" />
            <br />
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="5">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" />
                    <asp:Image ID="Image2" runat="server" />
                    <asp:Image ID="Image3" runat="server" ImageUrl='<%# Eval("Name","~/Image-Folder/{0}") %>' />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
