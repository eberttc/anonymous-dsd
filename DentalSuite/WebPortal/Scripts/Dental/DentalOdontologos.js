
//#region Variables Iniciales
var titulo = 'Odontologos';

//#endregion

//#region $(document).ready(function ()
$(document).ready(function () {

    //#region Asignar Titulo 
    //    titulo = $('input[id$=hdnTitulo]').val();
    $('#divMasterTitle H1').html(titulo);
    //#endregion

    $("input:button", "#divRegistrarOdontologo").button();

    $("input:button", "#divCancelar").button();

    $("input:button", "#divAgregar").button();

    $("input:button", "#divQuitar").button();

    CargarTipoDocumento();
    CargarEspecialidad();

    $("#caja").slideToggle();
})
//#endregion



//#region GetMain(dObj)
function getMain(dObj) {
    if (dObj.hasOwnProperty('d'))
        return dObj.d;
    else
        return dObj;
}
//#endregion

//#region CargarTipoDocumento
function CargarTipoDocumento() {
    data = "[{ value: '1', text: 'DNI'},{ value: '2', text: 'Carnet de extranjeria'}]";
    $("#txtTipoDocumento").autocomplete(eval(data), {
        minChars: 0,
        matchContains: true,
        autoFill: false,
        formatItem: function (item) {
            return item.text;
        }
    }).result(function (event, item) {
        $('#txtTipoDocumentoHidden').val(item.value);
    });
}
//#endregion

//#region CargarEspecialidad
function CargarEspecialidad() {
    data = "[{ value: '1', text: 'Endodentista'},{ value: '2', text: 'Cirujano oral'},{ value: '3', text: 'Ortodoncista'},{ value: '4', text: 'PedoDentista'} ,{ value: '5', text: 'PerioDentista'}]";
    $("#txtEspecialidad").autocomplete(eval(data), {
        minChars: 0,
        matchContains: true,
        autoFill: false,
        formatItem: function (item) {
            return item.text;
        }
    }).result(function (event, item) {
        $('#txtEspecialidadHidden').val(item.value);
    });
}
//#endregion