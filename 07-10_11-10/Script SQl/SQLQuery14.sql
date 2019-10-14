update Livros set Ativo = 0 where id = (
select Id from Livros where Ativo= 1 order by id desc
offset 1 rows fetch next 1 rows only)
-- esse comando vai sempre atualizar o penultimo item da lista dos itens ativos 

select * from Livros where Ativo = 1