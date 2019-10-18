var meuAnimal = { nome: "Toby", idade: 8, raca: "Labrador", cor: "Amarelo" };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nome"]').val(meuAnimal.nome);
        $('input[name="idade"]').val(meuAnimal.idade);
        $('input[name="raca"]').val(meuAnimal.raca);
        $('input[name="cor"]').val(meuAnimal.cor);


        $('input[name="salvar"]').click(function () {
            meuAnimal.nome = $('input[name="nome"]').val();
            meuAnimal.idade = $('input[name="idade"]').val();
            meuAnimal.raca = $('input[name="raca"]').val();
            meuAnimal.cor = $('input[name="cor"]').val();
        });

        $('input[name="mostrar"]').click(function () {
            alert("Nome: " + meuAnimal.nome + "\nIdade: " + meuAnimal.idade + "\nRaca: " + meuAnimal.raca + "\nCor: " + meuAnimal.cor);
        });

    }
);