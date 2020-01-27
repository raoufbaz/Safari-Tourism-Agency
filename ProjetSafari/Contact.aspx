<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ProjetSafari.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/Contact.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="Infos">
        <ul class="listeInfo">
            <li class="InfosTitre">
                <h3>ADRESS :</h3>
                <ul>
                    <li class="InfoItem"><i class="medium material-icons">home</i> 138 Atlantis Kingsport, illinois</li>
                </ul>
            </li>
            <li class="InfosTitre">
                <h3>PHONES :</h3>
                <ul>

                    <li class="InfoItem"><i class="medium material-icons">phone</i> 800-234-6789</li>
                    <li class="InfoItem"><i class="medium material-icons">domain</i> 800-234-6789</li>
                </ul>
            </li>
            <li class="InfosTitre">
                <h3>EMAIL :</h3>
                <ul>
                    <li class="InfoItem"><i class="medium material-icons">email</i> mail@demolink.org</li>
                    <li id="cc" class="InfoItem">Download Information as: Vcard</li>
                </ul>
            </li>
        </ul>
        <!-- ------------------------------------------------ -->
    </section>

    <section id="sectionForm">

        <h3 id="formTitle">MISCELLANEOUS INFORMATION :</h3>
        <label>Email Us for any questions or inquiries or use our contact data.</label>
        <br />
        <input type="text" id="fnom" name="nom" placeholder="Name">
        <input type="text" id="femail" name="email" placeholder="Email" >
        <input type="text" id="fphone" name="phone" placeholder="Phone" >
        <br />
        <textarea id="fmessage" placeholder="Message"></textarea>
        <br />
        <input class="btncontact" id="btnSave" type="submit" name="send" value="Send" />
        <input class="btncontact" type="button" name="clear" value="Clear" />
    </section>
</asp:Content>
