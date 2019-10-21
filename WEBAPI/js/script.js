
$(document).ready(
    function () {

        $('input[name="cep"]').mask('00000-000');
        $('input[type="button"]').click(

            function () {
                var cep = $('input[name="cep"]').val();

                if (cep.length < 9) {
                    alert("CEP informado não existe");
                    LimparTela();
                } else {

                    $.get("https://viacep.com.br/ws/" + cep + "/json/", function (data, status) {

                        if (data.erro) {
                            alert("CEP informado não existe");
                            LimparTela();
                        } else {
                            $('input[name=bairro]').val(data.bairro);
                            $('input[name=logradouro]').val(data.logradouro);
                            $('input[name=localidade]').val(data.localidade);
                            $('input[name=uf]').val(data.uf);
                        }
                    });
                }

            }
        );
    }

);

function LimparTela() {
    var meusInputs = $('input[type=text]');

    meusInputs.val("");

};
