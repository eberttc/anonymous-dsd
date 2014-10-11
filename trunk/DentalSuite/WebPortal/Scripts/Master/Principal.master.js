
$(document).ready(function () {
    var d = new Date();

    $('#aAnioMaster').html(d.getFullYear());
   /* $("#procesando").dialog({ dialogClass: 'mt', autoOpen: false, resizable: false, modal: true, width: 160, height: 110 }); //xhumpy, 100%, 100%
    $('.mt div.ui-dialog-titlebar').hide();
    */

    $("#procesando").dialog({
        height: 150,
        modal: true,
        autoOpen: false, 
        resizable:false,
        autoOpen: false
    });
    $('div.ui-dialog-titlebar').hide();

    $("#procesando2").dialog({ dialogClass: 'mt', autoOpen: false, resizable: false, modal: true, width: 170, height: 110 }); //xhumpy, 100%, 100%
    $('.mt div.ui-dialog-titlebar').hide();

    CargarMenu();
    $('#divMasterBody').bind('resize', function () { AjustarPantalla(); }).trigger('resize');
});

function Logout() {
    window.location = urlLogOut;
 }

function AjustarPantalla() {
//    var lenObject = $('#divMasterHeader').height() + $('#divMasterMenu').height() + $('#divMasterTitle').height();
//    var lenBody = $('#divMasterBody').height()
//    var lenWindow = ($(window).height() - lenObject);
//    var topFooter = 0;
//    if (lenWindow>lenBody){
//        topFooter = lenWindow - ($('#divMasterFooter').height() / 2);
//    }
//    else{
//        topFooter=lenBody;
//    }
    $('#divMasterFooter').css({ 'top': '50px' });

    // $('#divMasterFooter').css({ 'top': $('#divMasterBody').height() - 150 + 'px' });
    //        c = document.getElementById('masterContainer');
    //        c.style.width = ($(window).width() - 213) + 'px';
    //        c.style.height = ($(window).height() - 61) + 'px';
}

function CargarMenu() {
//    $.ajax({
//        type: 'POST',
//        contentType: "application/json; charset=utf-8",
//        url: urlMasterMenu,
//        data: "{token:'" + $('input[id$=hdfToken]').val() + "'}",
//        dataType: "json",
//        success: function (dataObject, textStatus) {
//            if (textStatus == "success") {
//                var data = getMain(dataObject);
//                if (data.length > 0) {
//                    $("#divMenu").html(data);
//                    CargaEventos();
//                }
//                //else { alert('vacio'); }
//            }
//            else { alert('malo'); }
//        }
//    });


    var data= "<ul id=\"topnav\"><li><a href=\"#\" >Administración</a><div class=\"sub\"><div class=\"row\"><ul style='width: 180px;'><li><h2><a href=\"#\">Seguridad</a></h2></li><li>"+
            "<a href=\"http://localhost:20000/WebPortal/Seguridad/Mantenimientos/Modulos.aspx?Config=0&Titulo=Modulos & Menús\" class=\"item-link\">Modulos & Menús</a></li><li>"+
            "<a href=\"http://localhost:20000/WebPortal/Seguridad/Mantenimientos/Perfiles.aspx?Config=3&Titulo=Perfiles\" class=\"item-link\">Perfiles</a></li><li>"+
            "<a href=\"http://localhost:20000/WebPortal/Seguridad/Mantenimientos/Usuarios.aspx?Config=0&Titulo=Usuarios\" class=\"item-link\">Usuarios</a></li></ul></div></div></li><li>" +
            "<a href=\"#\" >Comercial</a><div class=\"sub\"><div class=\"row\"><ul style='width: 180px;'><li><h2>"+
            "<a href=\"#\">Mantenimientos</a></h2></li><li>"+
            "<a href=\"http://localhost:20000/WebPortal/Dental/Pacientes.aspx?Config=0&amp;Titulo=Pacientes\">Pacientes</a></li><li>"+
            "<a href=\"http://localhost:20000/WebPortal/Dental/Odontologos.aspx?Config=0&amp;Titulo=Odontologos\">Odontologos</a></li><li>"+
            "<a href=\"http://localhost:20000/WebPortal/Dental/Especialidades.aspx?Config=0&amp;Titulo=Especialidades\">Especialidades</a></li></ul>"+
            "<ul style='width: 180px;'><li><h2><a href=\"#\">" +
            "Procesos</a></h2></li>"+
            "<li><a href=\"http://localhost:20000/WebPortal/Dental/reservaCitas.aspx?Config=0&Titulo=Reserva de Citas\" class=\"item-link\">Reserva de Citas</a></li>" +
            "<li><a href=\"http://localhost:20000/WebPortal/Dental/consultaCitas.aspx?Config=0&Titulo=Consulta de Citas\" class=\"item-link\">Consulta de Citas</a></li></ul></div></div></li></ul>";
    $("#divMenu").html(data);
    CargaEventos();


}

function CargaEventos() {

    function megaHoverOver() {
        $(this).find(".sub").stop().fadeTo('fast', 1).show();

        //Calculate width of all ul's
        (function ($) {
            jQuery.fn.calcSubWidth = function () {
                rowWidth = 0;
                //Calculate row
                $(this).find("ul").each(function () {
                    rowWidth += $(this).width();
                });
            };
        })(jQuery);

        if ($(this).find(".row").length > 0) { //If row exists...
            var biggestRow = 0;
            //Calculate each row
            $(this).find(".row").each(function () {
                $(this).calcSubWidth();
                //Find biggest row
                if (rowWidth > biggestRow) {
                    biggestRow = rowWidth;
                }
            });
            //Set width
            $(this).find(".sub").css({ 'width': biggestRow });
            $(this).find(".row:last").css({ 'margin': '0' });

        } else { //If row does not exist...

            $(this).calcSubWidth();
            //Set Width
            $(this).find(".sub").css({ 'width': rowWidth });

        }
    }

    function megaHoverOut() {
        $(this).find(".sub").stop().fadeTo('fast', 0, function () {
            $(this).hide();
        });
    }

    var config = {
        sensitivity: 2, // number = sensitivity threshold (must be 1 or higher)    
        interval: 50, // number = milliseconds for onMouseOver polling interval    
        over: megaHoverOver, // function = onMouseOver callback (REQUIRED)    
        timeout: 200, // number = milliseconds delay before onMouseOut    
        out: megaHoverOut // function = onMouseOut callback (REQUIRED)    
    };

    $("ul#topnav li .sub").css({ 'opacity': '0' });
    $("ul#topnav li").hoverIntent(config);
}