$('[data-attr="updateMovie"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/UpdateMovie",
            type: "POST",
            data: $('#updateMovieForm').serialize(),
            success: function (response) {
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(response);

                window.location.href = "Index";
                console.log(response);
            },
            error: function (err) {
                console.log(err);
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(err.statusText);
            }
        });
});

