<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book_appt.aspx.cs" Inherits="_43938442_Exam_WebApp.book_appt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Book Appointment</title>
    <link rel="shortcut icon" href="download.jpeg" type="image/jpg" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <style>
        body {
            background-color: #FB043C;
            color: #FFFFFF;
        }
        .container {
            margin-top: 50px;
            color: #000000;
        }
        .form-section {
            background-color: #FB043C;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .form-section h3, .form-section label, .form-section .form-control {
            margin-bottom: 15px;
        }
        .form-section .btn {
            margin: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-8 form-section">
                    <h1 class="text-center">
                        <asp:Label ID="lblBook" runat="server" Font-Names="Arial Nova" Font-Underline="True" CssClass="h1">Book an Appointment</asp:Label>
                    </h1>
                    <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
                        <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicMenuStyle BackColor="#FFFBD6" />
                        <DynamicSelectedStyle BackColor="#FFCC66" />
                        <Items>
                            <asp:MenuItem NavigateUrl="~/default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/about.aspx" Text="About" Value="About"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/contact.aspx" Text="Contact Us" Value="Contact Us"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/reviews.aspx" Text="Reviews" Value="Reviews"></asp:MenuItem>
                        </Items>
                        <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticSelectedStyle BackColor="#FFCC66" />
                    </asp:Menu>
                    <h3 class="text-center">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/user.aspx" CssClass="btn btn-warning">Back to Dashboard</asp:HyperLink>
                        <asp:Button ID="btnLogOut" runat="server" CssClass="btn btn-danger" OnClick="btnLogOut_Click" Text="Log out" />
                    </h3>
                    <h3>
                        <asp:Label ID="lblHelp" runat="server" CssClass="form-control-plaintext">1. To book an appointment, select a date on the calendar, a time from the drop-down list, the doctor you prefer and the required type of appointment. Leave the ID field blank, but take note of it when it appears in the ListBox control since you will need it when editing or cancelling your appointment.</asp:Label>
                    </h3>
                    <h3>
                        <asp:Label ID="lblHelp0" runat="server" CssClass="form-control-plaintext">2. To edit the date and/or time of an appointment, enter the respective ID number of your appointment in the TextBox, and select a new date and/or time. Click Edit Appointment to commit changes.</asp:Label>
                    </h3>
                    <h3>
                        <asp:Label ID="lblHelp1" runat="server" CssClass="form-control-plaintext">3. To cancel an appointment, only enter the respective ID number of your appointment you wish to cancel. Click Cancel Appointment to commit changes.</asp:Label>
                    </h3>
                    <div class="mb-3">
                        <asp:ListBox ID="ListBox2" runat="server" DataTextField="Doctor" DataValueField="Doctor" CssClass="form-control" Rows="5"></asp:ListBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblID" runat="server" Text="ID:" Font-Underline="True"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBoxID" runat="server" CssClass="form-control d-inline-block" style="width: 100px;" />
                    </div>
                    <div class="mb-3">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" ShowGridLines="True" Width="220px" Height="200px">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                    </div>
                    <div class="mb-3">
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control d-inline-block" style="width: 100px;">
                            <asp:ListItem Text="08:00" Value="1" />
                            <asp:ListItem Text="08:30" Value="2" />
                            <asp:ListItem Text="09:00" Value="3" />
                            <asp:ListItem Text="09:30" Value="4" />
                            <asp:ListItem Text="10:00" Value="5" />
                            <asp:ListItem Text="11:00" Value="6" />
                            <asp:ListItem Text="11:30" Value="7" />
                            <asp:ListItem Text="12:00" Value="8" />
                            <asp:ListItem Text="13:30" Value="9" />
                            <asp:ListItem Text="14:00" Value="10" />
                            <asp:ListItem Text="14:30" Value="11" />
                            <asp:ListItem Text="15:00" Value="12" />
                            <asp:ListItem Text="15:30" Value="13" />
                            <asp:ListItem Text="16:00" Value="14" />
                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblDoctor" runat="server" Text="Select a doctor:" Font-Underline="True"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Bold="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" CssClass="form-control">
                            <asp:ListItem Text="Dr A.H. van Zyl" Value="1" />
                            <asp:ListItem Text="Dr C. Hendricks" Value="2" />
                        </asp:RadioButtonList>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblDoctor0" runat="server" Text="Select an appointment type:" Font-Underline="True"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" Font-Bold="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged" CssClass="form-control">
                            <asp:ListItem Text="Surgical - R1500" Value="1" />
                            <asp:ListItem Text="Lab analysis - R360" Value="2" />
                            <asp:ListItem Text="Routine check-up - R500" Value="3" />
                            <asp:ListItem Text="Urgent check-up - R2000" Value="4" />
                        </asp:RadioButtonList>
                    </div>
                    <div class="text-center mb-3">
                        <asp:Button ID="btnBook" runat="server" CssClass="btn btn-warning" OnClick="btnBook_Click" Text="Book Appointment" />
                        <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-info" OnClick="btnEdit_Click" Text="Edit Appointment" />
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" OnClick="btnCancel_Click" Text="Cancel Appointment" />
                    </div>
                    <h3 class="text-center">
                        <asp:Label ID="lblCopyright" runat="server" Font-Underline="True" Text="&copy; 2024"></asp:Label>
                    </h3>
                </div>
            </div>
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
    </form>
</body>
</html>
