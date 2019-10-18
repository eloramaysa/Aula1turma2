$(document).ready(function () {
   
    $('input[type="button"]').click(function () {

         var url = ("https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json");


        $.getJSON(url, function (data) {

            var tipo = $('#moeda').val();
            var valor = $('input[name="name"]').val();
            valor = valor.replaceAll('.', '');
            valor = valor.replaceAll(',', '.');
            if (tipo == "dolar") {

                var result = valor / 4.16;


                /* $('input[name="total"]').mask('#.##0,00', { reverse: true }).val(result + " Dolares").trigger('input');*/


            } if (tipo == "euro") {

                var result = valor / 4.61;
                $('input[name="total"]').val(result + " Euros");
            }
            if (tipo == "pesoArg") {
                var result = valor * 13.88;
                $('input[name="total"]').val(result + " Pesos Argentinos");
            }

        });

       

    });

   
    });

    $("#valor").mask('#.##0,00', { reverse: true });


   


String.prototype.replaceAll = String.prototype.replaceAll || function (needle, replacement) {
    return this.split(needle).join(replacement);
};