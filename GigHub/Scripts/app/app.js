var GigsController = function () {
    var init = function () {
        $(".js-toggle-attendance")
    .click(function (e) {

        var button = $(e.target);
        if (button.hasClass("btn-default")) {

            $.post("/api/attendances", { "GigId": button.attr("data-gig-id") })
                .done(function () {
                    button
                        .removeClass("btn-default")
                        .addClass("btn-info")
                        .text("Going");
                })
                .fail(function () {
                    alert("something wrong with attendance button.");
                });

        } else {
            $.ajax({
                url: "/api/attendances/" + button.attr("data-gig-id"),
                method: "DELETE"
            })
                .done(function () {
                    button
                        .removeClass("btn-info")
                        .addClass("btn-default")
                        .text("Going?");
                })
                .fail(function () {
                    alert("Something failed");
                });
        }
    });

    };

    return {
        init: init
    }
}();



