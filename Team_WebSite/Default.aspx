<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="section">  
 <%--       slide show--%>
        <div class="slideshow-container">

        <div class="mySlides fade">
          <div class="numbertext"></div>
          <%--<img src="img_nature_wide.jpg" style="width:100%">--%>
           <asp:Image ID="Image1" runat="server" ImageUrl="~/Games/SlideShow/MHW.jpg" />
          <div class="text">Hunt Down The Monsters!</div>
        </div>

        <div class="mySlides fade">
          <div class="numbertext"></div>
          <%--<img src="img_snow_wide.jpg" style="width:100%">--%>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Games/SlideShow/DS.jpg" />
          <div class="text">Are You Tough Enough?</div>
        </div>

        <div class="mySlides fade">
          <div class="numbertext"></div>
        <%--  <img src="img_mountains_wide.jpg" style="width:100%">--%>
            <asp:Image ID="Image3" runat="server" ImageUrl="~/Games/SlideShow/pubg.jpg" />
          <div class="text">Winner Winner Chiken Dinner!</div>
        </div>

        <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
        <a class="next" onclick="plusSlides(1)">&#10095;</a>

        </div>
        <br />
        <div style="text-align:center">
              <span class="dot" onclick="currentSlide(1)"></span> 
              <span class="dot" onclick="currentSlide(2)"></span> 
              <span class="dot" onclick="currentSlide(3)"></span> 
        </div>
        <script>
            var slideIndex = 1;
            showSlides(slideIndex);

            function plusSlides(n) {
                showSlides(slideIndex += n);
            }

            function currentSlide(n) {
                showSlides(slideIndex = n);
            }

            function showSlides(n) {
                var i;
                var slides = document.getElementsByClassName("mySlides");
                var dots = document.getElementsByClassName("dot");
                if (n > slides.length) { slideIndex = 1 }
                if (n < 1) { slideIndex = slides.length }
                for (i = 0; i < slides.length; i++) {
                    slides[i].style.display = "none";
                }
                for (i = 0; i < dots.length; i++) {
                    dots[i].className = dots[i].className.replace(" active", "");
                }
                slides[slideIndex - 1].style.display = "block";
                dots[slideIndex - 1].className += " active";
            }
        </script>
       <%-- end of slide show--%>
        <h1>Top Selling</h1>
         <div class="grid-container">

            <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton1" runat="server"  ImageUrl="~/Games/1.jpg" OnClick="ImageButton1_Click"/>
                </div>
                <p><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
            </div>
            <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/Games/2.jpg" OnClick="ImageButton2_Click" />
                </div>
                <p><asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></p>
            </div>
             <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Games/3.jpg" OnClick="ImageButton3_Click"  />
                </div>
                 <p><asp:Label ID="Label15" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
            </div>
             <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Games/4.jpg" OnClick="ImageButton4_Click" />
                </div>
                 <p><asp:Label ID="Label16" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></p>
            </div>
        </div>
    </div>
    <div class="section">
    <h1>Special Offers</h1>
         <div class="grid-container">
            <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Games/5.jpg" OnClick="ImageButton5_Click" />
                </div>
                <p><asp:Label ID="Label17" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></p>
            </div>
            <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/Games/6.jpg" OnClick="ImageButton6_Click" />
                </div>
                <p><asp:Label ID="Label18" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></p>
            </div>
             <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/Games/7.jpg" OnClick="ImageButton7_Click" />
                </div>
                 <p><asp:Label ID="Label19" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></p>
            </div>
             <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/Games/8.jpg" OnClick="ImageButton8_Click" />
                </div>
                 <p><asp:Label ID="Label20" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></p>
            </div>
        </div>
    </div>
    <div class="section">
    <h1>New Releases</h1>
         <div class="grid-container">
            <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/Games/2.jpg" OnClick="ImageButton9_Click" />
                </div>
                <p><asp:Label ID="Label21" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></p>
            </div>
            <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/Games/3.jpg" OnClick="ImageButton10_Click" />
                </div>
                <p><asp:Label ID="Label22" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></p>
            </div>
             <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/Games/5.jpg" OnClick="ImageButton11_Click" />
                </div>
                 <p><asp:Label ID="Label23" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></p>
            </div>
             <div class="grid-item">
                <div>
                    <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/Games/7.jpg" OnClick="ImageButton12_Click" />
                </div>
                 <p><asp:Label ID="Label24" runat="server" Text="Label"></asp:Label></p>
                <p>Price: $<asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></p>
            </div>
        </div>
    </div>
</asp:Content>

