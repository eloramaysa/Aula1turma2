-- Quando vc utiliza uma subQuery vc só pode retornar um valor, para um Nome tem um valor. 
select Nome,(select Sum(Valor) from Salarios where FuncionarioId = Funcionarios.Id) from Funcionarios


select fun.Nome, Avg(sal.Valor) as 'Media dos três meses', 
COUNT(sal.Valor)  as 'Quantidade de Pagamentos'
from Funcionarios fun inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome 

select * from Salarios where Id between 3 and 8
--São iguais o betwenn se torna mais direto 
select * from Salarios where Id >= 3 and Id <=8

select * from Salarios where DataCriacao between '07/06/2019' and '08/07/2019'

select top 5* from Salarios order by Valor desc

update Funcionarios set DataSaida= '10/03/2019', Ativo = 0, DataAlteracao= GetDATE() where Nome like 'Pedro%';

select * from Funcionarios