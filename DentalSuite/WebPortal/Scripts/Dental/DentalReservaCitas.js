//#region Variables Iniciales
var titulo = 'Reserva de Citas';
//#endregion

//#region $(document).ready(function ()
$(document).ready(function () {

    //#region Asignar Titulo 
    titulo = $('input[id$=hdnTitulo]').val();
    $('#divMasterTitle H1').html(titulo);
    //#endregion

    $('#txtFecha').datepicker();
    $('#txtFecha').datepicker('option', 'dateFormat', 'dd/mm/yy');
    $('#txtFecha').datepicker('setDate', new Date());


    $("input:button", "#divBuscar").button();

    $("input:button", "#divReservar").button();

    $("#caja").slideToggle();
})
//#endregion

//#region getMain(dObj)
function getMain(dObj) {
    if (dObj.hasOwnProperty('d'))
        return dObj.d;
    else
        return dObj;
}
//#endregion


