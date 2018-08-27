$('[data-attr="submit"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/SearchById",
            type: "GET",
            data: { 'id': $('#SearchId').val()},
            success: function (response) {
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(response);

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