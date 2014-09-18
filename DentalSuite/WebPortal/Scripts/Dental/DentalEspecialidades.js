
//#region Variables Iniciales
var titulo = 'Especialidades';
//#endregion

//#region $(document).ready(function ()
$(document).ready(function () {

    //#region Asignar Titulo 
    titulo = $('input[id$=hdnTitulo]').val();
    $('#divMasterTitle H1').html(titulo);
    //#endregion

    $("input:button", "#divRegistrarEspecialidad").button();
    $("input:button", "#divRegistrarEspecialidad").click(function () { alert("se registra especialidad"); });

    $("input:button", "#divCancelar").button();
    $("input:button", "#divCancelar").click(function () { alert("se cancela registro"); });

    $("#caja").slideToggle();
});
//#endregion

//#region getMain(dObj)
function getMain(dObj) {
    if (dObj.hasOwnProperty('d'))
        return dObj.d;
    else
        return dObj;
}
//#endregion
