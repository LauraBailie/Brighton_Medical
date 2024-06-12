<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="_43938442_Exam_WebApp.about" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About</title>
    <link rel="shortcut icon" href="download.jpeg" type="image/jpg" />
    <style>
        body {
            background-color: #04FB48;
        }
        .auto-style1 {
            text-align: left;


        }
        h2 {
            color: black;
            font-family: 'Arial Nova';
            font-size: 20px;
            justify-content: center;
        }
        .auto-style2 {
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style2">
                <asp:Label ID="lblAbout" runat="server" Font-Names="Arial Nova" Font-Underline="True">About Brighton Medical</asp:Label>
            </h1>
        </div>
        <div class="auto-style1">
            <asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#E3EAEB" />
                <DynamicSelectedStyle BackColor="#1C5E55" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/user.aspx" Text="Dashboard" Value="Dashboard"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/contact.aspx" Text="Contact Us" Value="Contact Us"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/reviews.aspx" Text="Reviews" Value="Reviews"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/book_appt.aspx" Text="Book Appointment" Value="Book Appointment"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#666666" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#1C5E55" />
            </asp:Menu>
            <div class="auto-style2">
        <asp:Label ID="lblStart1" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Names="Arial Nova" Font-Size="15pt">Inception: </asp:Label>
            </div>
        </div>
        <h2 class="auto-style2">
            <asp:Label ID="lblStart" runat="server" Font-Size="15pt">Brighton Medical was established in January 2024 and is located in the heart of a bustling, friendly neighbourhood in Cape Town.</asp:Label>
        </h2>
        <div class="auto-style2">
        <asp:Label ID="lblDoctors" runat="server" Font-Bold="True" Font-Names="Arial Nova" Font-Size="15pt">Doctors:</asp:Label>
        </div>
        <p class="auto-style2">
            <asp:Label ID="lblDoctors1" runat="server" Font-Bold="True" Font-Names="Arial Nova" Font-Size="15pt">Dr van Zyl obtained his medical degree in 2005 from the University of Pretoria with a specialty in General Surgery. Dr Hendricks obtained her medical degree from the University of Stellenbosch in 2014 with a specialty in Emergency Medicine. Both driven and inspired by humble communities, their aim and mission statement is to encourage positive change in the lives of their patients by providing top quality medical assistance that is also affordable.</asp:Label>
        </p>
        <p class="auto-style2">
        <asp:Label ID="lblCopyright" runat="server" Font-Bold="True" Font-Names="Arial Nova" Font-Size="12pt">&copy; 2024</asp:Label>
        </p>
    </form>
</body>
</html>
