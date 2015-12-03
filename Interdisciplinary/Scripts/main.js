(function () {
    "use strict";

    //var quotes = document.getElementsByClassName(".quotes");
    //var quoteIndex = -1;

    //function showNextQuote() {
    //    ++quoteIndex;
    //    quotes.eq(quoteIndex % quotes.length)
    //        .fadeIn(2000)
    //        .delay(2000)
    //        .fadeOut(2000, showNextQuote);
    //}
    //showNextQuote();
    var actual = document.getElementById("teacher");

    var links = document.querySelectorAll(".clickable");

    for (var i = 0; i < links.length; i++) {
        var link = links[i];
        link.addEventListener("click", function (e) {
            e.preventDefault();
            actual.classList.toggle("show");
            actual.classList.toggle("hide");
            var box = document.getElementById(this.getAttribute("href"));
            box.classList.toggle("show");
            box.classList.toggle("hide");
            actual = box;
        });

    }

})();