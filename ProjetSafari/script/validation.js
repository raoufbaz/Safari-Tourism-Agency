//----------------------------------
$(document).ready(function () {
    var nom = document.getElementById('fnom');
    var email = document.getElementById('femail');
    var phone = document.getElementById('fphone');
    var message = document.getElementById('fmessage');
    var btn = document.getElementById("btnSave");

    function Contact(Name, Email, Phone, Message) {
        this.Name = Name;
        this.Email = Email;
        this.Phone = Phone;
        this.Message = Message;
    }

        //if (!e.validatePhone()) {
        //    Phone.style.borderColor = "red";

        //}
        //else {
        //    Phone.style.borderColor = "black";
        //}

        //if (!e.validateEmail()) {
        //    email.style.borderColor = "red";
        //}
        //else {
        //    email.style.borderColor = "black";
        //}
    Contact.prototype.validatePhone = function () {

        var telRegEx = /^(\(\d{3}\)) ?\d{3}-\d{4}/;
        if (telRegEx.test(this.Phone)) {
            return true;  //code
        }
        else {
            return false;
        }


    }
    //fonction permettant de valider le email
    Contact.prototype.validateEmail = function () {

        var emailRegEx = /[a-zA-Z0-9]+(\.|_|-)?[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+/;
        if (emailRegEx.test(this.Email)) {
            return true;  

        }
        else {
            return false;
        }

    }


    btn.addEventListener("click", function () {
        var e = new Contact(nom.value, email.value, phone.value, message.value);
        if (e.validatePhone() && e.validatePhone()) {
            alert("good work.");
            $.get("QueryAdapter.aspx?nom=" + e.Name+ "&email=" + e.Email+ "&phone=" + e.Phone+ "&message=" + e.Message, function (data) {
                alert(data);
            });
         }

        else {
            alert("not valid");
        }

    });
    //$("#btnSave").click(function () {
    //    var n = $("#fnom").val();
    //    var e = $("#femail").val();
    //    var p = $("#fphone").val();
    //    var m = $("#fmessage").val();
    //    $.get("Contact.aspx?nom=" + n + "&email=" + e + "&phone=" + p + "&message=" + m, function (data) {

    //        $("#p").text(data);

    //    });

    //});
});
