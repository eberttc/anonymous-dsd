//#region Variables Iniciales
var titulo = 'Reserva de Citas';
//#endregion

//#region $(document).ready(function ()
$(document).ready(function () {

    //#region Asignar Titulo 
    titulo = $('input[id$=hdnTitulo]').val();
    $('#divMasterTitle H1').html(titulo);
    //#endregion


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


