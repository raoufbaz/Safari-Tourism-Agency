<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjetSafari.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <section id="slideshow">
        <input type="button" class="slidebutton" id="slidebutton1" name="name" value="" />
        <input type="button" class="slidebutton" id="slidebutton2" name="name" value="" />
        <input type="button" class="slidebutton" id="slidebutton3" name="name" value="" />
        <h1 id="textslide1">Explore Africa</h1>
        <h1 id="textslide2">During Amazing Safari Tours</h1>
        <img id="slideimg1" src="photos/slide1.jpg" alt="img" />

    </section>



    <article class="info" id="article1">
        <div class="titreInfo">
            <h3 class="TitreH3">Unusual Holidays</h3>
        </div>
        <div class="imgInfo">
            <img class="Infoimg" id="Infoimg1" src="photos/info1.jpg" alt="img" />
        </div>

        <div class="DescInfo">
            <h5>Spend a Week-End with us</h5>
            <p class="Desc">When you book your Holiday with Safari Adventure Co. you can rest assured that we are a fully licensed  travel agent. so your hard earned holiday money is secured.</p>
        </div>
    </article>

    <article class="info" id="article2">
        <div class="titreInfo">
            <h3 class="TitreH3">Best Time to Visit</h3>
        </div>
        <div class="imgInfo">
            <img class="Infoimg" id="Infoimg2" src="photos/info2.jpg" alt="img" />
        </div>
         <div class="DescInfo">
            <h5>Plan your African Safari with Us</h5>
            <p class="Desc">Our company offers comprehensive information on africa travel, connecting you with the best travel service providers who will assist with your Africa Safari Travel arrangements.</p>
        </div>
    </article>

    <article class="info" id="article3">
         <div class="titreInfo">
            <h3 class="TitreH3">Big Cat Safaris</h3>
        </div>
        <div class="imgInfo">
            <img class="Infoimg" id="Infoimg3" src="photos/info3.jpg" alt="img" />
        </div>
        <div class="DescInfo">
            <h5>Explore Africa's Unique Safari</h5>
            <p class="Desc">The Variety and Beauty of Africa will take your break away. Be it a wildlife Safari or a relaxing breach holiday on Zanzibar, the choices are exceptional.</p>
        </div>
    </article>

</asp:Content>
