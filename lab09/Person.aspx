 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="lab09.Person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-8 mr-auto ml-auto">
            <asp:Label ID="Label1" runat="server" Text="Saludar"></asp:Label> 
            <asp:TextBox ID="txtNombre" runat="server" Height="16px" CssClass="form-control"></asp:TextBox>
            <asp:Button ID="btnSaludar" runat="server" OnClick="Button1_Click" Text="Button" CssClass="btn btn-primary" />
            </div>
        </div>
    </form>
</body>
</html>
