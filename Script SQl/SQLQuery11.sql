insert into Usuarios
(Nome,Login,Senha)
values
('Adagoberto','urineidson','56464')
go 
select * from Usuarios

update Usuarios set Ativo = 0 where Id = 9
update Usuarios set Senha = '123' where Senha is null

update Usuarios set Nome ='Maria S.' where Nome ='Maria'

select * from Usuarios where Ativo = 1
