// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$('.album-button').click(function () {

    var album_id = $(this).parent().data('id');
    $(`.text-box-${album_id}`).html('')
    $.ajax
        ({
            url: `/Home/Photos/${album_id}`,
            type: 'get',
            success: function (result) {
                $(`.text-box-${album_id}`).html(result)
            }
        });
});


