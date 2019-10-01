select car.Modelo, mar.Nome, car.Placa, car.Ano  from Carros car inner join Marcas mar on car.MarcaCodigo = mar.Codigo
--relacionar uma informação de uma tabela com outra tabela nesse caso vai pegar a marca do carro de acordo com o codigo. 
--inner join indica que ambas as tabelas deves estar relacionadas com os dados