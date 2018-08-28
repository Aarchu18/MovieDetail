$('[data-attr="createMovie"]').on('click', function () {
    $.ajax(
        {
            url: "/Movie/InsertMovie",
            type: "POST",
            data: $('#createMovieForm').serialize(),
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

function Exit() {
    var exit = confirm('Are You sure want to exit?');
    if (exit) window.close();
    window.location.href = "Index";
}





 