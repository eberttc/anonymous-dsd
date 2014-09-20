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
    $("input:button", "#divCancelar").click(function () { limpiarCaja(); });
    limpiarCaja();
    $("#caja").slideToggle();


})
//#endregion

//#region CargarTipoDocumento
function CargarTipoDocumento() {
    data = "[{ value: '1', text: 'DNI'},{ value: '2', text: 'Carnet de extranjeria'}]";
    $('input[id$=txtTipoDocumento]').autocomplete(eval(data), {
        minChars: 0,
        matchContains: true,
        autoFill: false,
        formatItem: function (item) {
            return item.text;
        }
    }).result(function (event, item) {
        $('input[id$=txtTipoDocumentoHidden]').val(item.value);
    });
}
//#endregion

//#region Logica de Totales
function AdicionarFilasAGrilla(data, grilla) {

    tot_Ingresos = 0;
    tot_IngresosUSD = 0;
    if (data.length > 0) {
        grilla.clearGridData();
        grilla.setGridParam({ datatype: 'local' });
        for (var i = 0; i < data.length; i++) {
            grilla.addRowData(i, data[i]);
        }
    }
}
//#endregion

//#region Editar Pacientes
function EditarPaciente(codigo, paterno, materno, nombres, correo, contrasenia, sexo, tipoDocumento, nroDocumento) {
    $('input[id$=txtCodigo]').val(codigo);
    $('input[id$=txtNombre]').val(nombres);
    $('input[id$=txtApellidoPaterno]').val(paterno);
    $('input[id$=txtApellidoMaterno]').val(materno);
    $('input[id$=txtCorreo]').val(correo);
    $('input[id$=txtConfirmarCorreo]').val(correo);
    $('input[id$=txtContrasenia]').val(contrasenia);
    $('input[id$=txtConfirmarContrasenia]').val(contrasenia);
    $('input[id$=txtTipoDocumento]').val(tipoDocumento);
    $('input[id$=txtNroDocumento]').val(nroDocumento);
    if (sexo == 'm') {

        $('input:radio[[id$=name=sex}]')['m'].checked = true;
    }
    if (sexo == 'f') {
        $('input:radio[name=sex]')['f'].checked = true;
    }
}
//#endregion

//#region LimpiarCaja
function limpiarCaja() {

    $('input[id$=txtCodigo]').val('0');
    $('input[id$=txtNombre]').val('');
    $('input[id$=txtApellidoPaterno]').val('');
    $('input[id$=txtApellidoMaterno]').val('');
    $('input[id$=txtCorreo]').val('');
    $('input[id$=txtConfirmarCorreo]').val('');
    $('input[id$=txtContrasenia]').val('');
    $('input[id$=txtConfirmarContrasenia]').val('');
    $('input[id$=txtTipoDocumento]').val('');
    $('input[id$=txtNroDocumento]').val('');

    $('input[id$=txtCodigo]').attr("readonly", "true");
    $('input[id$=txtCodigo]').css({ 'background-color': 'gray' });
    $('input[id$=txtCodigo]').css({ 'color': 'white' });
    CargarTipoDocumento();
}
//#endregion



