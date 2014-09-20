//#region Variables Iniciales
var titulo = 'Pacientes';
//#endregion

//#region $(document).ready(function ()
$(document).ready(function () {

    //#region Asignar Titulo 
    titulo = $('input[id$=hdnTitulo]').val();
    $('#divMasterTitle H1').html(titulo);
    //#endregion

    $("input:button", "#divRegistrarPaciente").button();
    //$("input:button", "#divRegistrarPaciente").click(function () { alert("se registra paciente"); });

    $("input:button", "#divCancelar").button();
    //$("input:button", "#divCancelar").click(function () { alert("se cancela registro"); });

    CargarTipoDocumento();

    $("#caja").slideToggle();
})
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

//#endregion





