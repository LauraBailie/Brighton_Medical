<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="_43938442_Exam_WebApp.user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Dashboard</title>
    <link rel="shortcut icon" href="download.jpeg" type="image/jpg" />
    <style>
        body {
            background-color: #04FBC3;
        }
        h2 {
            font-family:'Arial Nova';
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
                <asp:Label ID="lblWelcome" runat="server"></asp:Label>
            </h2>
            <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#B5C7DE" />
                <DynamicSelectedStyle BackColor="#507CD1" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/about.aspx" Text="About" Value="About"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/contact.aspx" Text="Contact Us" Value="Contact Us"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/reviews.aspx" Text="Reviews" Value="Reviews"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/book_appt.aspx" Text="Book Appointment" Value="Book Appointment"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#507CD1" />
            </asp:Menu>
            <p>
            </p>
            <h4>
                <asp:Label ID="lblShow" runat="server" Font-Names="Arial Nova"></asp:Label>
            &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/book_appt.aspx">Book an Appointment</asp:HyperLink>
            &nbsp;<asp:Button ID="btnLogOut" runat="server" Height="20px" OnClick="btnLogOut_Click" Text="Log out" Width="88px" />
            </h4>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333" Font-Names="Arial Nova">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Doctor], [Date], [Time], [AppointmentType], [Status], [Amount] FROM [Patients] WHERE (([FirstName] = @FirstName) AND ([LastName] = @LastName))">
            <SelectParameters>
                <asp:CookieParameter CookieName="UserInfo" DefaultValue="" Name="FirstName" Type="String" />
                <asp:CookieParameter CookieName="UserInfo" Name="LastName" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <h4>
                <asp:Label ID="lblChange" runat="server" Font-Names="Arial Nova" ForeColor="#CC0000">Set new password after registration:</asp:Label>
            </h4>
            <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#E3EAEB" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Arial Nova" Font-Size="0.8em">
                <CancelButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
                <ChangePasswordButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
                <ChangePasswordTemplate>
                    <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
                        <tr>
                            <td>
                                <table cellpadding="0">
                                    <tr>
                                        <td align="center" colspan="2" style="color:White;background-color:#1C5E55;font-size:0.9em;font-weight:bold;">Change Your Password</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="CurrentPasswordLabel" runat="server" AssociatedControlID="CurrentPassword">Password:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CurrentPassword" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="CurrentPasswordRequired" runat="server" ControlToValidate="CurrentPassword" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="NewPasswordLabel" runat="server" AssociatedControlID="NewPassword">New Password:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="NewPassword" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" ControlToValidate="NewPassword" ErrorMessage="New Password is required." ToolTip="New Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="ConfirmNewPasswordLabel" runat="server" AssociatedControlID="ConfirmNewPassword">Confirm New Password:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="ConfirmNewPassword" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="ConfirmNewPasswordRequired" runat="server" ControlToValidate="ConfirmNewPassword" ErrorMessage="Confirm New Password is required." ToolTip="Confirm New Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2">
                                            <asp:CompareValidator ID="NewPasswordCompare" runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword" Display="Dynamic" ErrorMessage="The Confirm New Password must match the New Password entry." ValidationGroup="ChangePassword1"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color:Red;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="True"></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Button ID="ChangePasswordPushButton" runat="server" BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" CommandName="ChangePassword" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" OnClick="ChangePasswordPushButton_Click" Text="Change Password" ValidationGroup="ChangePassword1" />
                                        </td>
                                        <td>
                                            <asp:Button ID="CancelPushButton" runat="server" BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Cancel" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" Text="Cancel" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ChangePasswordTemplate>
                <ContinueButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <PasswordHintStyle Font-Italic="True" ForeColor="#1C5E55" />
                <TextBoxStyle Font-Size="0.8em" />
                <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            </asp:ChangePassword>
        <h4>
                <asp:Label ID="lblPasswordChange" runat="server" Font-Names="Arial Nova" ForeColor="#CC0000"></asp:Label>
        </h4>
        <h4>
                <asp:Label ID="lblUpdate" runat="server" Font-Names="Arial Nova" ForeColor="#CC0000">Edit personal details:</asp:Label>
        </h4>
        <h4>
                <asp:Label ID="lblName" runat="server" Font-Names="Arial Nova" ForeColor="Black">First Name:</asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="NameRequired" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Name is required." ToolTip="Name is required.">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblSurname" runat="server" Font-Names="Arial Nova" ForeColor="Black">Last Name:</asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxSurname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="LastNameRequired" runat="server" ControlToValidate="TextBoxSurname" ErrorMessage="Last name is required." ToolTip="Last name is required.">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblEmail" runat="server" Font-Names="Arial Nova" ForeColor="Black">Email:</asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" Width="205px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email address is required." ToolTip="Email address is required.">*</asp:RequiredFieldValidator>
        </h4>
        <h4>
                <asp:Label ID="lblCell" runat="server" Font-Names="Arial Nova" ForeColor="Black">Cell:</asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCell" runat="server" TextMode="Phone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CellRequired" runat="server" ControlToValidate="TextBoxCell" ErrorMessage="Cell number is required." ToolTip="Cell number is required.">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblEmergency" runat="server" Font-Names="Arial Nova" ForeColor="Black">Emergency Contact:</asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxEmCell" runat="server" TextMode="Phone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="EmergencyCellRequired" runat="server" ControlToValidate="TextBoxEmCell" ErrorMessage="Emergency contact is required." ToolTip="Emergency contact is required.">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblAllergies" runat="server" Font-Names="Arial Nova" ForeColor="Black">Allergies:</asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAllergies" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="AllergiesRequired" runat="server" ControlToValidate="TextBoxAllergies" ErrorMessage="Notice of allergies is required. If not applicable, enter 'None'" ToolTip="Notice of allergies is required.">*</asp:RequiredFieldValidator>
        </h4>
        <p>
                <asp:Button ID="btnEdit" runat="server" Text="Edit details" OnClick="btnEdit_Click" Font-Names="Arial Nova" />
        &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblError" runat="server" Font-Names="Arial Nova" ForeColor="#CC0000"></asp:Label>
        </p>
        <p>
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" Font-Names="Arial Nova" ForeColor="#333333" SelectedIndex="0">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ID], [FirstName], [LastName], [Cell], [Email], [Allergies], [EmergencyContact], [Password] FROM [Patients] WHERE (([FirstName] = @FirstName) AND ([LastName] = @LastName))">
                    <SelectParameters>
                        <asp:CookieParameter CookieName="UserInfo" Name="FirstName" Type="String" />
                        <asp:CookieParameter CookieName="UserInfo" Name="LastName" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
        </p>
        <h4>
                <asp:Label ID="lblChanged" runat="server" Font-Names="Arial Nova" ForeColor="#CC0000"></asp:Label>
        </h4>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
