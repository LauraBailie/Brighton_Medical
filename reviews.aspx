<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reviews.aspx.cs" Inherits="_43938442_Exam_WebApp.reviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Reviews</title>
    <link rel="shortcut icon" href="download.jpeg" type="image/jpg" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    <style>
        body {
            background-color: #4f3396;
        }
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
            height: 320px;
        }
        .auto-style3 {
            text-align: center;
            height: 200px;
            width: 200px;
        }
        .custom-carousel {
            max-width: 600px; 
            max-height: 400px; 
            margin: 0 auto; 
        }
        .carousel-control-next {
            color: black;
        }
        .carousel-control-prev {
            color: black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">
                <asp:Label ID="lblReviews" runat="server" Font-Names="Arial Nova" Font-Underline="True">Reviews</asp:Label>
            </h1>
        </div>
        <asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#E3EAEB" />
            <DynamicSelectedStyle BackColor="#1C5E55" />
            <Items>
                <asp:MenuItem NavigateUrl="~/default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/user.aspx" Text="Dashboard" Value="Dashboard"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/about.aspx" Text="About" Value="About"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/contact.aspx" Text="Contact Us" Value="Contact Us"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/book_appt.aspx" Text="Book Appointment" Value="Book Appointment"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#666666" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#1C5E55" />
        </asp:Menu>
        <div class="row justify-content-center mt-10">
            <div class="col-md-8">
                    <div id="Carousel" class="carousel slide custom-carousel" data-ride="carousel">
                        <div class="carousel-inner auto-style2">
                            <div class="carousel-item active">
                                <textarea id="TextArea1" cols="20" name="S1" rows="2" class="auto-style3">"The staff at Brighton Medical are very friendly and they were quite knowledgeable when I enquired about the do's and don'ts of my procedure. Dr van Zyl holds a lot of empathy for his patients and is excellent in his field. Cannot recommend this practice enough!"</textarea>
                            </div>
                            <div class="carousel-item">
                                <textarea id="TextArea2" cols="20" name="S2" rows="2" class="auto-style3">"Dr Hendricks was quickly able to accommodate me at short notice, which I appreciated immensely. She definitely has a tough-love approach, yet is friendly and very good at what she does. The practice décor cultivates a vibrant and welcoming atmosphere - optimal for healing. Very professional and affordable!"</textarea>
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
                    </div>
                </div>
            </div>
        <div class="text-center">
        <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.min.js" integrity="sha384-0pUGZvbkm6XF6gxjEnlmuGrJXVbNuzT9qBBavbLwCsOGabYfZo0T0to5eqruptLy" crossorigin="anonymous"></script>
        <script>
            $(document).ready(function () {
                $('#Carousel').carousel();
            });
        </script>
        &copy; 2024
        </div>
    </form>
</body>
</html>
