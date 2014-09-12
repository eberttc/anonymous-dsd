
function getMain(dObj) {
    if (dObj.hasOwnProperty('d'))
        return dObj.d;
    else
        return dObj;
}

/*
* String.Format( " cadena que se reemplaza {0}, {1}", "valor1", "valor 2");
*/
function _StringFormatInline() {
    var txt = this;
    for (var i = 0; i < arguments.length; i++) {
        var exp = new RegExp('\\{' + (i) + '\\}', 'gm');
        txt = txt.replace(exp, arguments[i]);
    }
    return txt;
}
function _StringFormatStatic() {
    for (var i = 1; i < arguments.length; i++) {
        var exp = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
        arguments[0] = arguments[0].replace(exp, arguments[i]);
    }
    return arguments[0];
}
if (!String.prototype.format) { String.prototype.format = _StringFormatInline; }
if (!String.format) { String.format = _StringFormatStatic; }

/*
* String.trim() -> quita espacios en blanco
*/
function _StringTrimInLine() { return this.replace(/^(\s|\&nbsp;)*|(\s|\&nbsp;)*$/g, ""); }
function _StringTrimStatic() { return arguments[0].replace(/^(\s|\&nbsp;)*|(\s|\&nbsp;)*$/g, ""); }
if (!String.prototype.trim) { String.prototype.trim = _StringTrimInLine; }
if (!String.trim) { String.trim = _StringTrimStatic; }

/*
* String.ltrim() -> quita espacios en blanco de la izquierda
*/
function _StringLTrimInLine() { return this.replace(/^(\s|\&nbsp;)+/, ""); }
function _StringLTrimStatic() { return arguments[0].replace(/^(\s|\&nbsp;)+/, ""); }
if (!String.prototype.ltrim) { String.prototype.ltrim = _StringLTrimInLine; }
if (!String.ltrim) { String.ltrim = _StringLTrimStatic; }

/*
* String.rtrim() -> quita espacios en blanco de la derecha
*/
function _StringRTrimInLine() { return this.replace(/(\s|\&nbsp;)+$/, ""); }
function _StringRTrimStatic() { return arguments[0].replace(/(\s|\&nbsp;)+$/, ""); }
if (!String.prototype.rtrim) { String.prototype.rtrim = _StringRTrimInLine; }
if (!String.rtrim) { String.trim = _StringRTrimStatic; }

function number_format(number, decimals, dec_point, thousands_sep) {
    number = (number + '').replace(',', '').replace(' ', '');
    var n = !isFinite(+number) ? 0 : +number,
        prec = !isFinite(+decimals) ? 0 : Math.abs(decimals),
        sep = (typeof thousands_sep === 'undefined') ? ',' : thousands_sep,
        dec = (typeof dec_point === 'undefined') ? '.' : dec_point,
        s = '',
        toFixedFix = function (n, prec) {
            var k = Math.pow(10, prec);
            return '' + Math.round(n * k) / k;
        };
    // Fix for IE parseFloat(0.55).toFixed(0) = 0;
    s = (prec ? toFixedFix(n, prec) : '' + Math.round(n)).split('.');
    if (s[0].length > 3) {
        s[0] = s[0].replace(/\B(?=(?:\d{3})+(?!\d))/g, sep);
    }
    if ((s[1] || '').length < prec) {
        s[1] = s[1] || '';
        s[1] += new Array(prec - s[1].length + 1).join('0');
    }
    return s.join(dec);
}