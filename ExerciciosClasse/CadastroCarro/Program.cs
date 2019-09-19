using Biblioteca;
using CadastroCarro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeCarros = new List<Carros>();
            var resposta = 1;
           
            while (resposta == 1)
            {
                var obj = new Carros();
                var mensagem ="Deseja cadastrar um novo carro: Sim(1) Não(Digite qualquer número)";
                resposta = Validacoes.ValidaInt(mensagem);

                Console.WriteLine("Informe o modelo do carro");
                obj.Modelo = Console.ReadLine();

                Console.WriteLine("Informe a marca do carro");
                obj.Marca = Console.ReadLine();

                var mensagemAno ="Informe o ano do carro";
                obj.Ano = Validacoes.ValidaInt(mensagemAno);

                var mensagemPreco = "Informe o valor do carro (somente o preço)";
                obj.Valor = Validacoes.ValidaDouble(mensagemPreco);

                listaDeCarros.Add(obj);

                resposta = Validacoes.ValidaInt(mensagem);
            }

            listaDeCarros.ForEach(i => Console.WriteLine($"Modelo: {i.Modelo} Marca: {i.Marca} Ano: {i.Ano} Valor: R${i.Valor}"));
            Console.ReadKey();


        }
    }
}
