$(document).ready(function () {
   
    $('input[type="button"]').click(function () {
        
        var tipo = $('#moeda').val();
        var valor = $('input[name="name"]').val();
        valor = valor.replaceAll('.', '');
        valor = valor.replaceAll(',', '.');
        if (tipo == "dolar") {
           
            var result = valor / 4.16;
            $('output[name="total"]').val(result)
           

        } if (tipo == "euro") {

            var result = valor / 4.61;
            alert("Seu valor convertido é igual a: " + result + " euros");
        }
        if (tipo == "pesoArg"){
            var result = valor * 13.88;
            alert("Seu valor convertido é igual a: " + result + " Peso Argentino");
        }

    });
    $("#valor").mask('#.##0,00', { reverse: true });
});

String.prototype.replaceAll = String.prototype.replaceAll || function (needle, replacement) {
    return this.split(needle).join(replacement);
};