
$(document).ready(function () {

/*-------------------------------------------------------------*/  
/*                        Index                                */  
/*-------------------------------------------------------------*/  

    $("#slidebutton1").click(function () {
      $("#slideimg1").attr("src", "photos/slide1.jpg");
        $("#slidebutton1").css("background-color", "orange");
        $("#slidebutton2").css("background-color", "white");
        $("#slidebutton3").css("background-color", "white");
    });
    $("#slidebutton2").click(function () {
      $("#slideimg1").attr("src", "photos/slide2.jpg");
        $("#slidebutton1").css("background-color", "white");
        $("#slidebutton2").css("background-color", "orange");
        $("#slidebutton3").css("background-color", "white");
    });
    $("#slidebutton3").click(function () {
     $("#slideimg1").attr("src", "photos/slide3.jpg");
        $("#slidebutton1").css("background-color", "white");
        $("#slidebutton2").css("background-color", "white");
        $("#slidebutton3").css("background-color", "orange");
    });

/*-------------------------------------------------------------*/
/*                        Gallery                              */
/*-------------------------------------------------------------*/

    // Get the modal
    var modal = document.getElementById("myModal");

    $("#imggal1").click(function () {
        modal.style.display = "block";
        $("#modalimg").attr("src", $("#imggal1").attr("src") );
    });

    $("#imggal2").click(function () {
        modal.style.display = "block";
        $("#modalimg").attr("src", $("#imggal2").attr("src"));
    });

    $("#imggal3").click(function () {
        modal.style.display = "block";
        $("#modalimg").attr("src", $("#imggal3").attr("src"));
    });

    $("#imggal4").click(function () {
        modal.style.display = "block";
        $("#modalimg").attr("src", $("#imggal4").attr("src"));
    });

    $("#imggal5").click(function () {
        modal.style.display = "block";
        $("#modalimg").attr("src", $("#imggal5").attr("src"));
    });

    $("#imggal6").click(function () {
        modal.style.display = "block";
        $("#modalimg").attr("src", $("#imggal6").attr("src"));
    });


});

