using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    // os dois pontos indicam que a nossa classe vai herdar todas as propriedades e funções do banco de dados 
    public class EntityContextDB : DbContext
    {
        //Criando uma tabela de pessoas, a tabela no caso se chama Pessoa ela sempre vai o nome da Classe
        public DbSet<Pessoa> ListaDePessoas { get; set; } //ListaDePessoas é nome dado para acessar essa tabela 
    }
}
