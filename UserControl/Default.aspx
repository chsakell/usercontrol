<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserControl.Default" %>

<%@ Reference Control="~/controls/ActiveActor.ascx" %>
<%@ Reference Control="~/controls/NextActor.ascx" %>
<%@ Reference Control="~/controls/PageTemplate.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="content/css/default.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div id="myCarousel" class="carousel slide" data-ride="carousel">

                <div class="carousel-inner">               
                    <asp:PlaceHolder ID="PlaceHolderActors" runat="server"></asp:PlaceHolder>
                </div>

                <ul class="nav nav-pills nav-justified">
                    <asp:PlaceHolder ID="PlaceHolderPages" runat="server"></asp:PlaceHolder>
                </ul>


            </div>
            <!-- End Carousel -->
        </div>
    </form>
     <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js" type="text/javascript"></script>
    <script src="content/js/bootstrap.min.js"></script>
    <script src="content/js/default.js"></script>
</body>
</html>
