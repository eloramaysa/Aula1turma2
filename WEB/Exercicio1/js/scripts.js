$(document).ready(function () {

    $('input[type="button"]').click(function () {
        var nome = $('input[name="nome"]').val();
        $("#NomeConvidado").text("Seja Bem Vindo(a) " + nome);
        $("#modalExemplo").show();
    });
   
});
