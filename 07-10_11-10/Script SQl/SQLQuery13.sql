--select * from Livros

update Livros set Ativo = 0 where Id = 4
go
select Id,Nome,Ativo from Livros where Ativo =1