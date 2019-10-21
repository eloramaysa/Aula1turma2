var minhaBike = { marca: "Caloy", valor: 1200, peso: 8 };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="marca"]').val(minhaBike.marca);
        $('input[name="valor"]').val(minhaBike.valor);
        $('input[name="peso"]').val(minhaBike.peso);
       


        $('input[name="salvar"]').click(function () {
            minhaBike.marca = $('input[name="marca"]').val();
            minhaBike.valor = $('input[name="valor"]').val();
            minhaBike.peso = $('input[name="peso"]').val();
            
        });

        $('input[name="mostrar"]').click(function () {
            alert("Marca: " + minhaBike.marca + "\nValor: " + minhaBike.valor + "\nPeso: " + minhaBike.peso);
        });

    }
);