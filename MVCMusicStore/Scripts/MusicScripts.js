$(function () {
    $(".form-group").mouseover(function () {
        $(this).animate({ height: '+=25', width: '+=25' })
        $(this).animate({ height: '-=25', width: '-=25' });
    });
});