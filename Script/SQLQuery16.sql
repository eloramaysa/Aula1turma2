CREATE TABLE [dbo].[LocacoesDeCarros]
(
	[Id] INT NOT NULL PRIMARY KEY identity (1,1), 
    [UsuarioId] INT NOT NULL, 
    [CarroId] INT NOT NULL, 
    [Valor ] MONEY NULL, 
    [DataInicial ] DATETIME NULL DEFAULT GETDATE(), 
    [DatatDevolucao] DATETIME NULL DEFAULT (DateAdd(day,5,GETDATE())),
	[Ativo ] BIT NULL DEFAULT 1, 
    [UsuarioCriacao] INT NULL DEFAULT 0, 
    [UsuarioAlteracao] INT NULL DEFAULT 0, 
    [DataCriacao] DATETIME NULL DEFAULT GETDATE(), 
    [DataAlteracao] DATETIME NULL DEFAULT GETDATE()

)

