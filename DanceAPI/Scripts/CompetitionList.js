$(document).ready(function () {
    const arrOfIds = [0]
    var clickedNum, clickedId
   
    new Promise(resolve => {
        $.ajax({
            url: "Competition/GetCompetitionList",
            type: "GET",
            success: function (results) {
                $('.comptable').append("<tbody class=\"border\"><tbody>");
                results.forEach((item, index) => $('.border').append("<tr><td>" + (index + 1) + "</td><td class=\"comp\">" + item.CompName + "</td><td>" + item.CityName + "</td><td>" + new Date(+item.CompDate.substr(6, 13)).toUTCString() + "</td></tr>"))
                results.forEach(item => arrOfIds.push(item.CompetitionCatalogId))
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
            $(this).addClass("clicked")
            clickedNum = $(this).parent().children(':first-child').text()
            clickedId = arrOfIds[clickedNum]
            $.ajax({
                url: "Competition/GetCompetitionPage",
                type: "Post",
                data: { "Id": clickedId },
                success: function (results) {
                    $('body').html(results)
                    console.log("GetCompetitionPage ajax successed");
                },
                error: console.log("error")
                ,
                dataType: "html"
            });
        });
    })
    

});