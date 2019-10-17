$(document).ready(
    function () {
        $('input[name="botao"]').click(function () {
            var nome = $('input[name= "nome"]').val();
            alert("Seja Bem Vindo(a) " + nome + " ao nosso sistema de cerveja");
            
        });

    }
);