﻿--Trazer somente as marcas que Felipe cadastrou
select mar.Nome from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario like 'Felipe%'

--Trazer somente as marcas que Giomar cadastrou
select mar.Nome from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario like 'Giomar%'

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor "colocar o order by desc   no final do select só isso "
select Count(mar.Nome) from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario like 'Felipe%'
order by  Count(mar.Nome)  desc

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select Count(mar.Nome) from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario like 'Giomar%' 
order by COUNT(mar.Nome) asc

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 

select usu.Usuario as 'Usuario que cadastrou',Count(mar.Nome) as 'Total de marcas' from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id 
where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%' group by usu.Usuario

--Trazer somente os carros que Felipe cadastrou
select car.Modelo from Carros car inner join Usuarios usu on car.UsuInc = usu.Id where usu.Usuario like 'Felipe%'

--Trazer somente os carros que Giomar cadastrou
select car.Modelo  from Carros car inner join Usuarios usu on car.UsuInc = usu.Id where usu.Usuario like 'Giomar%'

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select Count(car.Modelo) from Carros car inner join Usuarios usu   on car.UsuInc = usu.Id 
where usu.Usuario like 'Felipe%' order by  Count(car.Modelo) desc

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select Count(car.Modelo) from Carros car inner join Usuarios usu   on car.UsuInc = usu.Id 
where usu.Usuario like 'Giomar%' order by  Count(car.Modelo) asc

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
 select usu.Usuario as 'Usuario que cadastrou', Count(car.Modelo) as 'Total cadastrado' from Carros car inner join Usuarios usu on car.UsuInc = usu.Id 
 where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%' group by usu.Usuario

--Trazer somente os carros das marcas que Felipe cadastrou
select car.Modelo from Carros car inner join Marcas mar on car.Marca = mar.Id 
inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario  like 'Felipe%'

--Trazer somente os carros das marcas que Giomar cadastrou
select car.Modelo from Carros car inner join Marcas mar on car.Marca = mar.Id 
inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario  like 'Giomar%'

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select Count(car.Modelo) from Carros car inner join Marcas mar on car.Marca = mar.Id 
inner join Usuarios usu on mar.UsuInc = usu.Id where usu.Usuario  like 'Felipe%' order by Count(car.Modelo) desc

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select Count(car.Modelo) from Carros car inner join Marcas mar on car.Marca = mar.Id 
inner join Usuarios usu on mar.UsuInc = usu.Id where  usu.Usuario  like 'Giomar%' order by Count(car.Modelo) asc

--Trazer o valor total de vendas 2019 isolado

select Sum(ver.Valor * ver.Quantidade) as 'Valor total de vendas do ano de 2019' from Vendas ver 
where ver.DatInc between '01/01/2019' and '12/31/2019'

--Trazer a quantidade total de vendas 2019 isolado
select Sum(ver.Quantidade) as 'Quantidade total de vendas do ano de 2019' from Vendas ver 
where ver.DatInc between '01/01/2019' and '12/31/2019'

--Trazer o valor total de vendas em cada ano e ordenar do maior para o menor	
select Year(ver.DatInc) 'Ano', Sum(ver.Valor * ver.Quantidade) as 'Valor total'  from Vendas ver 
group by YEAR(ver.DatInc) order by Sum(ver.Valor * ver.Quantidade) desc

--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
select Year(ver.DatInc) 'Ano', Sum(ver.Quantidade) as 'Quantidade total'  from Vendas ver 
group by YEAR(ver.DatInc) order by Sum(ver.Quantidade) desc

--Trazer o mês de cada ano que retornou a maior quantidade de vendas

select top 3 Year(ver.DatInc) as 'Ano',  Sum(ver.Quantidade) as 'Quantidade', MONTH(ver.DatInc) 'Mês'  from Vendas ver 
group by  MONTH(ver.DatInc),  Year(ver.DatInc) order by Sum(ver.Quantidade) desc

--Trazer o mês de cada ano que retornou o maior valor de vendas
select top 3 Year(ver.DatInc) as 'Ano',  Sum(ver.Quantidade * ver.Valor) as 'Quantidade', MONTH(ver.DatInc) 'Mês'  from Vendas ver 
group by  MONTH(ver.DatInc),  Year(ver.DatInc) order by Sum(ver.Quantidade * ver.Valor) desc

--Trazer o valor total de vendas que Felipe realizou
select usu.Usuario as 'Usuario que vendeu ',Sum(ver.Quantidade* ver.Valor) as 'Total de vendas' from Vendas ver inner join Usuarios usu on ver.UsuInc = usu.Id
where usu.Usuario like 'Felipe%' group by usu.Usuario

--Trazer o valor total de vendas que Giomar realizou
select usu.Usuario as 'Usuario que vendeu ',Sum(ver.Quantidade* ver.Valor) as 'Total de vendas' from Vendas ver inner join Usuarios usu on ver.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' group by usu.Usuario

--Trazer a quantidade total de vendas que Felipe realizou
select usu.Usuario as 'Usuario que vendeu ',Sum(ver.Quantidade) as 'Total de vendas' from Vendas ver inner join Usuarios usu on ver.UsuInc = usu.Id
where usu.Usuario like 'Felipe%' group by usu.Usuario

--Trazer a quantidade de vendas que Giomar realizou
select usu.Usuario as 'Usuario que vendeu ',Sum(ver.Quantidade) as 'Total de vendas' from Vendas ver inner join Usuarios usu on ver.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' group by usu.Usuario

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select usu.Usuario as 'Usuario que vendeu ',Sum(ver.Quantidade* ver.Valor) as 'Total de vendas' from Vendas ver inner join Usuarios usu on ver.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%' group by usu.Usuario order by Sum(ver.Quantidade* ver.Valor) desc

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select usu.Usuario as 'Usuario que vendeu ',Sum(ver.Quantidade) as 'Total de vendas' from Vendas ver inner join Usuarios usu on ver.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' or usu.Usuario like 'Felipe%' group by usu.Usuario order by Sum(ver.Quantidade* ver.Valor) desc

--Trazer  a marca mais vendida de todos os anos
select  YEAR(ver.DatInc),MAX(ver.Quantidade) as quantidade, mar.Nome  from Marcas mar inner join Carros car on car.Marca = mar.Id 
inner join Vendas ver on ver.Carro = car.Id 
group by Year(ver.DatInc)



select * from Vendas