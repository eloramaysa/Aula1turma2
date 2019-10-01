using Biblioteca;
using CadastroPessoa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CadastroPessoa
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var cadastroDePessoas = new List<Pessoa>();
            var resposta = 0;
            var mensagem = "Deseja cadastro um novo usuário: Sim (1) Não(qualquer numero)";
            resposta = Validacoes.ValidaInt(mensagem);

            while (resposta == 1)
            {
                var obj = new Pessoa();
                Console.WriteLine("Informe o seu nome:");
                obj.Nome = Console.ReadLine();

                var mensagemIdade = "Informe a sua idade:";
                obj.Idade = Validacoes.ValidaInt(mensagemIdade);

               char sexo = 'c';
      
                while (sexo != 'M' && sexo !='F' && sexo!='O')
                {
                    var mensagemSexo= "Informe seu sexo M(Masculino) F(Feminino) O(outro):";
                    sexo = Validacoes.ValidaChar(mensagemSexo);
                    
                }
                obj.Sexo = sexo;

                var mensagemAltura = "Informe sua altura:";
                obj.Altura = Validacoes.ValidaDouble(mensagemAltura);

                var valido = false;
                var vrCPF = string.Empty;
                while (valido == false)
                {
                    Console.WriteLine("Informe seu CPF:");
                    vrCPF = Console.ReadLine();
                    valido = Validacoes.ValidaCPF(vrCPF);
                }
                obj.CPF = vrCPF;

                //Rg ainda não validado
                Console.WriteLine("Informe seu RG:");
                obj.RG = Console.ReadLine();


                cadastroDePessoas.Add(obj);
                resposta = Validacoes.ValidaInt(mensagem);
            }

            Console.WriteLine("Usuários Cadastrados: ");
            cadastroDePessoas.ForEach(i => Console.WriteLine($"Nome: {i.Nome} Idade: {i.Idade} Sexo: {i.Sexo} Altura: {i.Altura} CPF: {i.CPF} RG: {i.RG}"));
            Console.ReadKey(); 

        }

        

    }
}
