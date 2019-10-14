select car.Modelo, mar.Nome as 'Marca', usu.Nome as 'UsuarioCriacao', usuA.Nome as 'UsuarioAlteracao'
from Carros car inner join Marcas mar on car.MarcaCodigo = mar.Codigo 
						inner join Usuarios usu on car.UsuarioCriacao = usu.Id
						inner join Usuarios usuA on car.UsuarioAlteracao = usuA.Id
