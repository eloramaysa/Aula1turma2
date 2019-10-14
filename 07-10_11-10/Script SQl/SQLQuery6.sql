
-- Select * from Pedidos
/*insert into Pedidos (Numero,ClienteId, Valor) values ('K00092',1, 567),('K00890',1, 234.98),('K00343',2, 547),
('KL0009',2, 124),('K007800',2, 673.91),('K007800',3, 673.91),('L988000',3, 298),('J90000',3, 789.71),
('L00990',4, 134), ('K90088',4, 567.99),('L92000',4, 678.55);*/

Select cli.Nome, ped.Numero, ped.Valor from  Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id 
where cli.Id = 4;

Select Sum(ped.Valor) as'Total'from  Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id 
where cli.Id = 4 
 

 select IIF(Sum(ped.Valor)> 500 , 'Brinde', 'Nao gahou') as 'Resultado', sum(ped.Valor) as 'Total', cli.Nome 
 from Pedidos ped inner join Clientes cli on ped.ClienteId = cli.Id group by cli.Nome
