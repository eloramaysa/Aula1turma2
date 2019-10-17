$(document).ready(function () {
   
    $('input[type="button"]').click(function () {
        
        var tipo = $('#moeda').val();
        var valor = $('input[name="name"]').val();
        valor = valor.replaceAll('.', '');
        valor = valor.replaceAll(',', '.');
        if (tipo == "dolar") {
           
            var result = valor / 4.16;
            
            $('input[name="total"]').mask('#.##0,00', { reverse: true }).val(result + " Dolares").trigger('input');
           

        } if (tipo == "euro") {

            var result = valor / 4.61;
            $('input[name="total"]').val(result + " Euros");
        }
        if (tipo == "pesoArg"){
            var result = valor * 13.88;
            $('input[name="total"]').val(result + " Pesos Argentinos");
        }

    });

    $("#money").keyup(function () {
        alert("Handler for .keyup() called.");
    });

    $("#valor").mask('#.##0,00', { reverse: true });

    $("#money").mask('#.##0,00', { reverse: true });

   
});

String.prototype.replaceAll = String.prototype.replaceAll || function (needle, replacement) {
    return this.split(needle).join(replacement);
};