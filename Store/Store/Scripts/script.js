$(document).ready(function () {
    $('#apply_button').click(function (e) {
        e.preventDefault();
        var sort = document.querySelector("#exampleFormControlSelect1").value;
        var price_from = document.querySelector("body > div > div.container > div:nth-child(2) > div > input:nth-child(1)").value;
        var price_to = document.querySelector("body > div > div.container > div:nth-child(2) > div > input:nth-child(2)").value;
        var gender = $('input[name="gender"]:checked').val();
        var type = $('input[name="type"]:checked').val();

        $('#goods').load('Home/GoodsSection?sort=' + sort + '&price_from=' + price_from + '&price_to=' + price_to + '&gender=' + gender + '&type=' + type);
    });
    $('.changeloc').click(function (e) {
        e.preventDefault();
        var loc = $(this).attr("data-loc");
        console.log(loc);
        $('#location').load('Home/Location?loc=' + loc);
    });
    $('.tocart').click(function (e) {
        e.preventDefault();
        let id = $(this).attr("data-cardid");
        $('#badge').load('Home/AddGood?id=' + id);
    });
});