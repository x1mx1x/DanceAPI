$(document).ready(function () {



    /*
    $("body").click(function (event) {
        var target = $(event.target.className);
        if (target === "button")  console.log("rvevr");
        
    });*/
    
    $.ajax({
        url: "Competition/CompetitionList",
        type: "GET",
        success: (res) => {
            $("body").html(res);
        },
        dataType: "html"
    });

});