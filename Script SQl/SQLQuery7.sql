select * from Clientes;
select * from Pedidos;

--A partir de um numero de pedido vc consegue pegar todas as compras do cliente do pedido referenciado 
--em ordem do maior para o menor 
select * from Pedidos ped where ped.ClienteId in(
select cli.Id from clientes cli inner join Pedidos ped on cli.Id = ped.ClienteId 
where ped.Numero in ('N000001'))order by ped.Valor desc