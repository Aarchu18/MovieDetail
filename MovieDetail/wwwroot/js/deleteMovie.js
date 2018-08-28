$('[data-attr="deleteMovie"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/DeleteMovie",
            type: "POST",
            data: $('#DeleteMovieForm').serialize(),
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
