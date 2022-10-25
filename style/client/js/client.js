$('.drop').on('click', function () {
    $('.wrp_drop').toggleClass('active');
});

$('.item_drop').on('click', '.title_drop', function () {
    $(this).parent().find('.dropdown_list').toggleClass('active');
    //var drop = $('.title_drop').find('.imgup');
    //var dropdown = $('.title_drop').find('.imgdown');
    $(this).find('.imgup').toggleClass('active');
    $(this).find('.imgdown').toggleClass('active');
});

$('.drop_chitiet').on('click', '.head', function () {
    $(this).parent().find('.box_chitiet').toggleClass('active');
});

$('.box_chitiet').on('click', function () {
    $(this).parent().find('.box_chitiet_drop').toggleClass('active');
});

$('.gr_title .title_item').on('click', function () {
    var val = $(this).attr('data');
    if ($(this).hasClass('active')) return;
    $('.gr_title .title_item').removeClass('active');
    $('.gr_decs .box_item').removeClass('active');
    $(this).addClass('active');
    $('.' + val).addClass('active');
});

// const myTimeout = setTimeout(modal, 5000);

// function modal() {
//     var layer = $('.layer_modal');
//     $(layer).addClass('active');
// }

$('.close').on('click', function () {
    $('.layer_modal').removeClass('active');
});

$('.sec3_tc_right .congnghebtn').on('click', function () {
    var val = $(this).attr('data');
    if ($(this).hasClass('active')) return;
    $('.sec3_tc_right .congnghebtn').removeClass('active');
    $('.sec3_tc_left .txt').removeClass('active');
    $(this).addClass('active');
    $('.' + val).addClass('active');
});
$('.sec1_chitiet .left .gr_img').on('click', '.WImage img', function () {
    var imgclick = $(this).attr('src');
    $('.sec1_chitiet .left .img_daidien').attr('src', imgclick);
});

$('.menu_btn').on('click', function () {
    $('header .bot .wrp .nav').addClass('active');
});

$('.close_btn').on('click', function () {
    $('header .bot .wrp .nav').removeClass('active');
});

$('.menudp').on('click', function () {
    $('.submenu').addClass('active');
});
