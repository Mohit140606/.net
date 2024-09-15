<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default4.aspx.cs" Inherits="unit2.Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [friendsdetails] WHERE ([friendsId] = @friendsId)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="friendsId" QueryStringField="EventID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="friendsId" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    friendsId:
                    <asp:Label ID="friendsIdLabel" runat="server" Text='<%# Eval("friendsId") %>' />
                    <br />
                    friendsname:
                    <asp:Label ID="friendsnameLabel" runat="server" Text='<%# Eval("friendsname") %>' />
                    <br />
                    dob:
                    <asp:Label ID="dobLabel" runat="server" Text='<%# Eval("dob") %>' />
                    <br />
<br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
