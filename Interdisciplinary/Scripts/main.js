(function () {
    "use strict";
    var terms = ["LANGUAGE TEACHER", "MATH TEACHER", "SPORT TEACHER"];

    function rotateTerm() {
        var ct = $("#rotate").data("term") || 0;
        $("#rotate").data("term", ct == terms.length -1 ? 0 : ct + 1).text(terms[ct])
                    .fadeIn(1000).delay(2000).fadeOut(1000, rotateTerm);
    }
    $(document).ready(rotateTerm);
   
})();
    //var actual = document.getElementById("teacher");

    //var links = document.querySelectorAll(".clickable");

    //for (var i = 0; i < links.length; i++) {
    //    var link = links[i];
    //    link.addEventListener("click", function (e) {
    //        e.preventDefault();
    //        actual.classList.toggle("show");
    //        actual.classList.toggle("hide");
    //        var box = document.getElementById(this.getAttribute("href"));
    //        box.classList.toggle("show");
    //        box.classList.toggle("hide");
    //        actual = box;
    //    });

    //}

