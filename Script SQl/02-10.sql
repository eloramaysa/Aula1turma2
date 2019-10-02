
select ver.Modelo , mar.Nome as 'Marca', tip.Veiculo from  Veiculo ver inner join Marca mar on ver.MarcaCod = mar.Codigo 
						 inner join TipoVeiculo tip on ver.TipoVeiculoCod = tip.Codigo 
						 where mar.Codigo = 10 and tip.Codigo = 1

 go
 

select ver.Modelo , mar.Nome as 'Marca', tip.Veiculo from  Veiculo ver inner join Marca mar on ver.MarcaCod = mar.Codigo 
						 inner join TipoVeiculo tip on ver.TipoVeiculoCod = tip.Codigo 
						 where mar.Codigo = 20 and tip.Codigo = 2


select * from Veiculos 
select * from Marcas
select * from Tipos


select vei.Id, vei.Descricao, mar.Nome as 'Marca', tip.Nome as 'Tipo' from Veiculos vei inner join Marcas mar 
on vei.MarcaCodigo = mar.Codigo inner join Tipos tip on mar.TipoCodigo = tip.Codigo where mar.Codigo = 4


select vei.Id, vei.Descricao, mar.Nome as 'Marca', tip.Nome as 'Tipo' from Veiculos vei inner join Marcas mar 
on vei.MarcaCodigo = mar.Codigo inner join Tipos tip on mar.TipoCodigo = tip.Codigo where mar.Codigo = 3