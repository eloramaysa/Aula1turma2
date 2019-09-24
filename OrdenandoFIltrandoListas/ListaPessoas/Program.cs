using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaPessoas.Controller;
namespace ListaPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramenta de pessoas 
            //podemos agora listar e demais funcionalidades 
            PessoaController pessoaController = new PessoaController();

            //Mostrando a lista geral
            MostraIdentificador(" Lista Corrida: ");
            pessoaController.ListaDePessoasPublica.ForEach(i => MostraInformacoes(i));
            LimpaTela();
            

            //Mostrando a lista em ordem alfabética
            MostraIdentificador("Lista Ordenada Por Nome:");
            pessoaController.GetPessoasOrdenadaAsc().ForEach(i => MostraInformacoes(i));
            LimpaTela();

            //Mostrando lista em ordem de nascimento descrescente
            MostraIdentificador("Lista Ordenada Por Data de Nascimento");
            pessoaController.GetPessoasDataDecres().ForEach(i => MostraInformacoes(i));
            LimpaTela();

            //Mostrando lista de pessoas com mais de 500 reais 
            MostraIdentificador("Mostrando pessoas com mais de 500 reais na carteira");
            pessoaController.GetPessoasRicas(500).ForEach(i => MostraInformacoes(i));
            LimpaTela();

            //Mostrando lista de pessoa com mais de 18 anos 
            MostraIdentificador("Pessoas Maiores de Idade");
            pessoaController.GetPessoasMaioresDe(18).ForEach(i => MostraInformacoes(i));
            LimpaTela();

            //Mostrando lista de pessoas com menos de 16 anos 
            MostraIdentificador("Pessoas Menores de Idade");
            pessoaController.GetPessoasMenoresDe(16).ForEach(i => MostraInformacoes(i));
            LimpaTela();

        }
        /// <summary>
        /// Metodo para mostrar a informação inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao"></param>
        private static void LimpaTela()
        {
            Console.ReadKey();
            Console.Clear();
        }
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("-------{0,20}------", nomeAcao));
        }
        /// <summary>
        /// Metodo que mostra no console formata nosso objeto "Pessoa"
        /// </summary>
        /// <param name="pessoa">Objeto pessoa que vamos apresentar</param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //Template que apreseta as informações organizadas
            string template = "Id: {0,-3} Nome: {1,10} Data de Nascimento: {2,10} Valor na Carteira:{3,5}";

            string textoFormatado = string.Format(template, pessoa.Id, pessoa.Nome, pessoa.DataDeNascimento.ToShortDateString(), pessoa.ValorCarteira.ToString("C"));

            Console.WriteLine(textoFormatado);

        }


    }
}
