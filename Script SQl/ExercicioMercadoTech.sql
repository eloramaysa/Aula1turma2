insert into Funcionarios (Nome) values ('Maria'), ('Ana')

insert into Produtos (Nome, Valor) values ('Budweiser', 9.90), ('Pepsi',10.20), ('Guarana', 11.9), ('Skol',7),('H2O', 8.99)

select * from Produtos
select * from Pedidos

insert into Pedidos (FuncionarioId,ProdutoId,Quantidade) values 
(1, 2, 2), 
(1,3,2), 
(2,4,3) 

select Nome from Funcionarios order by Nome

select Nome, Valor from Produtos order by Valor desc

select fun.Nome, ped.ProdutoId, ped.Quantidade from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id

select fun.Nome, Sum(ped.Quantidade) as 'Quantidade Itens' from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id 
inner join Produtos pro on ped.ProdutoId = pro.Id group by fun.Nome

select fun.Nome, Sum(ped.Quantidade * pro.Valor) as 'Total da Compra'from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id 
inner join Produtos pro on ped.ProdutoId = pro.Id group by fun.Nome

select top 1 Sum(ped.Quantidade), pro.Nome from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id 
inner join Produtos pro on ped.ProdutoId = pro.Id group by pro.Nome  order by Sum(ped.Quantidade) desc

select top 1 pro.Nome, Sum(ped.Quantidade* pro.Valor) from Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutoId 
group by pro.NOme
order by Sum(ped.Quantidade* pro.Valor) desc

select * from Produtos where Id not in (
Select pro.Id from Funcionarios fun inner join Pedidos ped on fun.Id = ped.FuncionarioId
inner join Produtos pro on pro.Id = ped.ProdutoId 
where fun.Nome like 'Maria%')

select * from Produtos pro left join Pedidos ped on pro.Id= ped.ProdutoId 
inner join Funcionarios fun on ped.FuncionarioId = fun.Id
where ped.ProdutoId is null 


select pro.Nome, COUNT(ped.ProdutoId) as 'Quantidade' from Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutoId
group by pro.Nome order by 'Quantidade' desc