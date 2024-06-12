<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_43938442_Exam_WebApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Brighton Medical - Home</title>
    <link rel="shortcut icon" href="download.jpeg" type="image/jpg" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>

    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-family:'Arial Nova';
        }
        body {
            background-color: #04FBC3;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
            text-align: center;
            margin-left: 40px;
        }
        .auto-style4 {
            text-decoration: underline;
        }
        .auto-style5 {
            text-align: center;
            font-family: 'Arial Nova';
        }
        .auto-style6 {
            text-align: center;
        }
        h2 {
            text-align: center;
        }
        .auto-style7 {
            text-align: center;
            align-content:center;
            font-family: 'Arial Nova';
        }
        .auto-style8 {
            text-align: center;
            height: 26px;
            font-family: 'Arial Nova';
        }
        .custom-carousel {
            max-width: 600px; 
            max-height: 400px; 
            margin: 0 auto; 
        }

        .custom-carousel img {
            width: 100%; 
            height: 300px; 
            object-fit: cover;
        }
        .carousel-caption {
            color: black;
            border-color: black;
            background-color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">Brighton Medical</h1>
            <h2 class="auto-style1">Caring for brighter days ahead</h2>
        </div>
        <div class="auto-style2">
            <h2 class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style4" Font-Names="Arial Nova" Font-Size="Large" NavigateUrl="~/about.aspx">About</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink2" runat="server" CssClass="auto-style4" Font-Names="Arial Nova" Font-Size="Large" NavigateUrl="~/contact.aspx">Contact Us</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink3" runat="server" CssClass="auto-style4" Font-Names="Arial Nova" Font-Size="Large" NavigateUrl="~/reviews.aspx">Reviews</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink4" runat="server" CssClass="auto-style4" Font-Names="Arial Nova" Font-Size="Large" NavigateUrl="~/book_appt.aspx">Book an Appointment</asp:HyperLink>
            </h2>
        </div>
        <div class="row justify-content-center mt-10">
            <div class="col-md-8">
                <h2 class="text-center">
                    <asp:Login ID="Login1" runat="server" BackColor="#04B7FB" BorderColor="#04FB48" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" Height="104px" Width="939px" CssClass="auto-style7">
                        <LayoutTemplate>
                            <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                                <tr>
                                    <td>
                                        <table cellpadding="0" style="height:104px;width:939px;" class="auto-                   style5">
                                            <tr>
                                                <td align="center" colspan="2" style="color:White;background-                           color:#04FB48;font-weight:bold;">Log In</td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="EmailLabel" runat="server"               AssociatedControlID="UserName">Email:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="UserName" runat="server"   OnTextChanged="UserName_TextChanged"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="PasswordLabel" runat="server"    AssociatedControlID="Password">Password:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2" style="color:Red;">
                                                    <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" colspan="2">
                                                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" OnClick="LoginButton_Click" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
                    </asp:Login>
                </h2>
                </div>
            </div>

        <h3 class="auto-style8">
            <asp:Label ID="Label3" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h3>
        <h3 class="text-center">
            <asp:Label ID="lblServices" runat="server" Font-Names="Arial Nova">Services we offer:</asp:Label>
        </h3>

        <div id="Carousel" class="carousel slide custom-carousel" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="surgical.jpeg" class="d-block w-100" alt="Surgical Appointment"/><br />
&nbsp;<div class="carousel-caption d-none d-md-block">
                        <h4>Surgical Appointment</h4>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="results.jpg" class="d-block w-100" alt="Laboratory Analysis"/>
                    <div class="carousel-caption d-none d-md-block">
                        <h4>Medical Results Analysis</h4>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="routine-appt.jpeg" class="d-block w-100" alt="Routine Check-up"/>
                    <div class="carousel-caption d-none d-md-block">
                        <h4>Routine Check-up</h4>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="urgent.jpeg" class="d-block w-100" alt="Urgent Medical Check-up"/>
                    <div class="carousel-caption d-none d-md-block">
                        <h4>Urgent Medical Check-up</h4>
                    </div>
                </div>
            </div>
            <a class="carousel-control-prev" href="#Carousel" role="button" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#Carousel" role="button" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>

        <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js" integrity="sha384-0pUGZvbkm6XF6gxjEnlmuGrJXVbNuzT9qBBavbLwCsOGabYfZo0T0to5eqruptLy" crossorigin="anonymous"></script>
        <script>
            $(document).ready(function () {
                $('#Carousel').carousel();
            });
        </script>

        <h3 class="auto-style5">
            <asp:Label ID="Label1" runat="server" Text="Dr A.H. van Zyl (MBChB, Pretoria) &amp; Dr C. Hendricks (MBChB, Stellenbosch)"></asp:Label>
        </h3>
        <h4 class="auto-style6">
            <asp:Label ID="Label2" runat="server" Text="&copy; 2024"></asp:Label>
        </h4>
    </form>
</body>
</html>
