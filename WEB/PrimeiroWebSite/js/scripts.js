

$(document).ready(
    function () {
        atualizaData();
    });

/*Primeira Fun��o*/
function atualizaData() {
    /* A funcao foi adicionada dentro do nosso context do setInterval*/
    setInterval(function () { $('span[name="data_atual"]').text(Date()); }, 100);
  
}