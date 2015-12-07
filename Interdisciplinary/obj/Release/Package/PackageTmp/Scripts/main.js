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
    
