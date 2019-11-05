$(document).ready(function () {
    $('input[name="botaoLogin"]').click(function () {
        //obter as informações dos meus campos
        //Obtemos as informações do nosso formulario web completo
        var informacoes = $('form[name="LoginSistema"]').serializeArray();
        //Obtemos o atributo que indica a pagina que vamos enviar o post


        //Enviamos o post para nosso servidor web
        $.post("http://localhost:54018/api/AcessoLogin", informacoes, function (data) {
            //aqui como recebemos uma string com formato de JSON
            //temos que passar ela para o JSON parecido com o int.Parse()

            //Aqui carregamos as informações automaticamente
            if (!data) {
                alert("Login e Senha Incorretos")
            }
           
        });
    });
});