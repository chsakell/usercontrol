<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%--<%@ Register Src="~/Controls/ContactUserControl.ascx" TagPrefix="UserControl" TagName="ContactUserControl" %>--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <UserControl:ContactUserControl runat="server" ID="ContactForm" />
    </div>
    </form>
</body>
</html>
