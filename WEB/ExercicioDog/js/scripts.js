var minhaBike = { nome: "Toby", idade: 8, raca: "Labrador", cor: "Amarelo" };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nome"]').val(minhaBike.nome);
        $('input[name="idade"]').val(minhaBike.idade);
        $('input[name="raca"]').val(minhaBike.raca);
        $('input[name="cor"]').val(minhaBike.cor);


        $('input[name="salvar"]').click(function () {
            minhaBike.nome = $('input[name="nome"]').val();
            minhaBike.idade = $('input[name="idade"]').val();
            minhaBike.raca = $('input[name="raca"]').val();
            minhaBike.cor = $('input[name="cor"]').val();
            LimparTela();
        });

        $('input[name="mostrar"]').click(function () {
            alert("Nome: " + minhaBike.nome + "\nIdade: " + minhaBike.idade + "\nRaca: " + minhaBike.raca + "\nCor: " + minhaBike.cor);
        });

    }
);

function LimparTela() {
    var meusInputs = $('input[type=text]');

   
        meusInputs.val("");
    
}