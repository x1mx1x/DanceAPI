$(document).ready(function () {

    new Promise(resolve => {
        $.ajax({
            url: "Competition/GetCompetitionList",
            type: "GET",
            success: function (results) {
                $('.comptable').append("<tbody class=\"border\"><tbody>");
                results.forEach((item, index) => $('.border').append("<tr><td>" + (index + 1) + "</td><td class=\"comp\">" + item.CompName + "</td><td>" + item.CityName + "</td><td>" + new Date(+item.CompDate.substr(6, 13)).toUTCString() + "</td></tr>"))
                resolve()
            },
            error: (res) => {
                console.log("error");
            },
            dataType: "json"
        });
    })
    .then(() => {
        $('.comp').on('click', function (e) {
            console.log(1)
            $.ajax({
                url: "Competition/GetCompetitionPage",
                type: "GET",
                success: function (results) {
                    $('body').html(results)
                    console.log("qqqqqqqqqqqqq");
                },
                error: (res) => {
                    console.log("error");
                },
                dataType: "html"
            });
        });
    })
    

});