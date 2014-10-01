
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
    //$("input:button", "#divRegistrarEspecialidad").click(function () { alert("se registra especialidad"); });


    $("input:button", "#divCancelar").button();
    $("input:button", "#divCancelar").click(function () { limpiarCaja(); });

    $("#caja").slideToggle();

    $('input[id$=txtCodigo]').attr("readonly", "true");

    $('input[id$=txtCodigo]').attr("readonly", "true");
    $('input[id$=txtCodigo]').css({ 'background-color': 'gray' });
    $('input[id$=txtCodigo]').css({ 'color': 'white' });
    //MostrarGrilla();
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



//#region Buscar Usuario
function Busqueda(grilla) {
    $.ajax({
        //type: 'GET',
        contentType: "application/json; charset=utf-8",
        url: 'http://localhost:20001/RESTServices/Especialidades.svc/especialidades',
        dataType: "json",
        success: function (dataObject, textStatus) {
            if (textStatus == "success") { AdicionarFilasAGrilla(getMain(dataObject), grilla); }
        }
    });
}
//#endregion

//#region Mostrar Datos
function MostrarGrilla() {
    jQuery.ajax({
        type: "GET",
        url: "http://localhost:20001/RESTServices/Especialidades.svc/especialidades",
        //         contentType: "application/json; charset=utf-8",
        //         dataType: "jsonp",
        //         success: function (data, status, jqXHR) {
        //             alert('hola');
        //         },

        //         error: function (jqXHR, status) {
        //             // error handler
        //         }

        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        ProcessData: true,
        success: function (data) {
            alert('dsds');
        }
		,
        error: function (error, data) {
            console.log(error)
        }


    });


//    $("#GrillaEspecialidad").jqGrid('GridUnload');
//    var grilla = $("#GrillaEspecialidad");
//    grilla.jqGrid({
//        datatype: function () { Busqueda(grilla); },
//        rownumbers: false,
//        altRows: true,
//        height: "100%",
//        width: "980px",
//        //caption: 'Usuarios',
//        colNames: ['Codigo', 'Nombre', 'Descripcion', 'Acciones'],
//        colModel: [
//                    { name: 'Codigo', index: 'Codigo', align: 'center'},
//                    { name: 'Nombre', index: 'Nombre' },
//                    { name: 'Descripcion', index: 'Descripcion' },
//                    { name: 'Acciones', label: 'Acciones', align: 'center', width: '70px' }
//	        ],
//        rowNum: 1000000,
//        loadonce: true,
////        onSelectRow: function (rowid) {
////            $("#detail").jqGrid('GridUnload');
////            var CodigoUsuario = grilla.getCell(rowid, 'Codigo');
////            var grilladetalle = $("#detail");
////            MostrarGridDetailUsuarioPerfil(CodigoUsuario, grilladetalle);
////            $('#divDisponibles').show();
////            $('#txtUsuariosHidden').val(CodigoUsuario);
////            DestroyAutoComplete(CodigoUsuario);
////        },
//        afterInsertRow: function (rowid, data) {
//            grilla.setCell(rowid, 'Acciones', '<img id="Editar_' + rowid + '" alt="+" src="../../Resources/icono_editar.png" height="20px" width="20px" onClick="EditarUsuario(' + data.Codigo + ',\'' + data.Nombres + '\',\'' + data.Paterno + '\',\'' + data.Materno + '\',\'' + data.Usuario + '\',\'' + data.Contrasena + '\',\'' + data.Correo + '\',\'' + data.Telefono + '\',\'' + data.URL + '\',' + data.Estado + ')"/>');
//        }

//    });
}
//#endregion

//#region Editar Especialidad
function EditarEspecialidad(codigo, nombre, descripcion) {
    $('input[id$=txtCodigo]').val(codigo);
    $('input[id$=txtNombre]').val(nombre);
    $('input[id$=txtDescripcion]').val(descripcion);
    //    if (sexo == 'm') {

    //        $('input:radio[[id$=name=sex}]')['m'].checked = true;
    //    }
    //    if (sexo == 'f') {
    //        $('input:radio[name=sex]')['f'].checked = true;
    //    }
}
//#endregion

//#region Adicionar Filas a Grilla
function AdicionarFilasAGrilla(data, grilla) {
    if (data.length > 0) {
        grilla.clearGridData();
        grilla.setGridParam({ datatype: 'local' });
        for (var i = 0; i < data.length; i++) grilla.addRowData(i, data[i]);
    }
}
//#endregion


//#region LimpiarCaja
function limpiarCaja() {

    $('input[id$=txtCodigo]').val('0');
    $('input[id$=txtNombre]').val('');
    $('input[id$=txtDescripcion]').val('');

    $('input[id$=txtCodigo]').attr("readonly", "true");
    $('input[id$=txtCodigo]').css({ 'background-color': 'gray' });
    $('input[id$=txtCodigo]').css({ 'color': 'white' });
}
//#endregion