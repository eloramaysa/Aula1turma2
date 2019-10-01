insert into Veiculo (Modelo, MarcaCod, TipoVeiculoCod) values
('Cadenza', 10, 1),
('Carnival', 10, 1),
('Sephia', 10, 1),
('Sportag', 10, 1),
('Civic',7,1),
('Accent', 8, 1),
('Concours',20,2),
('Voyager',20,2),
('Dtrackerx',20,2)


select * from Marca
go 

select ver.Modelo , mar.Nome as 'Marca', tip.Veiculo from  Veiculo ver inner join Marca mar on ver.MarcaCod = mar.Codigo 
						 inner join TipoVeiculo tip on ver.TipoVeiculoCod = tip.Codigo 
						 where mar.Codigo = 20 and tip.Codigo = 2

