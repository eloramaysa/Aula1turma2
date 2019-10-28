
$(document).ready(function () {
    $('#botao').click(function () {
        $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function (data) {
            //loop para cada objeto 
            $.each(data, function (key, value) {
                //criamos uma variavel que ira armazenas a informação 
                var templateContent = "";
                //iniciamos um separador de informação 
                templateContent += "";
                //outro laco para repetir para cada informacao 
                $.each(value, function (key, value) {
                    //adicionamos todas as informações do nosso objeto 
                    templateContent += ("<b>"+ key + "</b>") + ":" + value + ", ";
                });
                //finalizamos nosso objeto
                templateContent += ",";
                //adicionamos ao nosso campo de texto 
                $('#divContent').append(

                    
                
                    "<div class=\"accordion\"id=\"accordionExample\"<div class=\"card\"><div class=\"card-header\" id=\"heading"+key+"\"><h5 class=\"mb-0\"><button class=\"btn btn-link\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse" + key + "\" aria-expanded=\"true\" aria-controls=\"collapse"+key+"\">" + value.bairro +
                    "</button></h5></div> <div id=\"collapse" + key + "\" class=\"collapse show\" aria-labelledby=\"heading"+key+"\" data-parent=\"#accordionExample\"><div class=\"card-body\">" + templateContent
                    + "</div> </div ></div >"
                    


                );
            });
        });
    });

});