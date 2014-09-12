$(document).ready(function () {
    $('#divLoginMessage').html('');

    $("#txtUsuario").Watermark("Usuario");
    //$("#txtContrasena").Watermark("Contraseña");
    $("input:text:visible:first").focus();

    $("#txtUsuario").val("admin");
    $("#txtContrasena").val("admin");

});

function replaceT(obj) {
    var newO = document.createElement('input');
    newO.setAttribute('type', 'password');
    newO.setAttribute('name', obj.getAttribute('name'));
    newO.setAttribute('id', obj.getAttribute('id'));
    newO.setAttribute('class', 'tdText');
    obj.parentNode.replaceChild(newO, obj);
    newO.focus();
}



