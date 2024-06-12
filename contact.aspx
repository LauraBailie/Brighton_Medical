<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="_43938442_Exam_WebApp.contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Us</title>
    <link rel="shortcut icon" href="download.jpeg" type="image/jpg" />
    <style>
        body {
            background-color: #B7FB04;
            justify-content:center;
        }
        .auto-style1 {
            text-align: center;
            justify-content:center;
        }
        h2.auto-style1 {
            justify-content:center;
        }
        .auto-style2 {
            justify-content: center;
            text-align:center;
        }
        div {
            justify-content: center;
            text-align:center;
        }
        h2 {
            text-align:center;
            font-family:'Arial Nova';
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="auto-style1">
                <asp:Label ID="lblContact" runat="server" Font-Names="Arial Nova" Font-Underline="True">Contact Us</asp:Label>
            </h1>
        <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#669900" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <Items>
                <asp:MenuItem NavigateUrl="~/default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/about.aspx" Text="About" Value="About"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/book_appt.aspx" Text="Book Appointment" Value="Book Appointment"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/reviews.aspx" Text="Reviews" Value="Reviews"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/user.aspx" Text="Dashboard" Value="Dashboard"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
        </asp:Menu>
        <div class="row justify-content-center mt-14">
            <div class="col-md-10">
                <h2 class="text-center">
                    <asp:Table ID="Table1" runat="server" CssClass="auto-style2">
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">Contact Details</asp:TableCell>        
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">Tel:</asp:TableCell>
        <asp:TableCell runat="server">021 919 1234 (reception)</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">""</asp:TableCell>
        <asp:TableCell runat="server">079 919 2315 (accounts)</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">Email:</asp:TableCell>
        <asp:TableCell runat="server">admin@brightonmedical.com</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">""</asp:TableCell>
        <asp:TableCell runat="server">accounts@brightonmedical.com</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">""</asp:TableCell>
        <asp:TableCell runat="server">vanzyla@brightonmedical.com</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">""</asp:TableCell>
        <asp:TableCell runat="server">hendricksc@brightonmedical.com</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">For emergencies only:</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">Cell:</asp:TableCell>
        <asp:TableCell runat="server">082 343 7129 (Dr van Zyl)</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">""</asp:TableCell>
        <asp:TableCell runat="server">073 581 4914 (Dr Hendricks)</asp:TableCell>
    </asp:TableRow>
</asp:Table>
                    </h2>
                </div>
            </div>
           <h3 class="auto-style3">&copy; 2024</h3>     
    </form>
</body>
</html>
