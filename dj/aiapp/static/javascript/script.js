var swiper = new Swiper('.swiper-container', {
    pagination: '.swiper-pagination',
    paginationClickable: true,
    nextButton: '.swiper-button-next',
    prevButton: '.swiper-button-prev',
    spaceBetween: 30
});

// var GLOBAL_PATH = '{{ STATIC_PATH }}';
var dDisplay = true;
function doDisplay() {
    var con = document.getElementById("Set_more");
    if (con.style.display == "none") {
      con.style.display = "block";
      document.getElementById("S_btn").src = "/static/images/set.png";
      document.getElementById("D_Set_more").style.display = "none";
      document.getElementById("style_btn").src = "/static/images/style2.png";
    } else {
      con.style.display = "none";
      document.getElementById("style_btn").src = "/static/images/style.png";
    }
}

function doDisplay_t() {
    var con = document.getElementById("D_Set_more");
    if (con.style.display == "none") {
        document.getElementById("Set_more").style.display = "none";
        document.getElementById("style_btn").src = "/static/images/style.png";
        con.style.display = "block";
        document.getElementById("S_btn").src = "/static/images/set2.png";
    } else {
        con.style.display = "none";
        document.getElementById("S_btn").src = "/static/images/set.png";
    }
}