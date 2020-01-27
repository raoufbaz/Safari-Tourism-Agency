<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="ProjetSafari.Gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/Gallery.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 id="TitreGallery"><asp:Label ID="TitreGall" runat="server" Text="Label">Gallery</asp:Label></h1>
    <section id="imgGallery">
        <img class="imgGallery" id="imggal1" src="photos/info1.jpg" alt="Alternate Text" />
        <img class="imgGallery" id="imggal2" src="photos/info2.jpg" alt="Alternate Text" />
        <img class="imgGallery" id="imggal3" src="photos/info3.jpg" alt="Alternate Text" />
        <img class="imgGallery" id="imggal4" src="photos/slide2.jpg" alt="Alternate Text" />
        <img class="imgGallery" id="imggal5" src="photos/slide3.jpg" alt="Alternate Text" />
    </section>
    <div id="myModal" class="modal" onclick="this.style.display='none'">
        <div id="imgContainer">
            <img id="modalimg" src="#" alt="" />
        </div>
    </div>
</asp:Content>
