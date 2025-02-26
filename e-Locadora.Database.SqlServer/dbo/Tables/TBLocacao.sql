﻿CREATE TABLE [dbo].[TBLocacao] (
    [Id]                     INT          IDENTITY (1, 1) NOT NULL,
    [idFuncionario]          INT          NOT NULL,
    [idGrupoVeiculo]         INT          NOT NULL,
    [idVeiculo]              INT          NOT NULL,
    [idCliente]              INT          NOT NULL,
    [idCondutor]             INT          NOT NULL,
    [dataLocacao]            DATE         NOT NULL,
    [dataDevolucao]          DATE         NOT NULL,
    [quilometragemDevolucao] DECIMAL (18) NOT NULL,
    [plano]                  VARCHAR (50) NOT NULL,
    [seguroCliente]          DECIMAL (18) NOT NULL,
    [seguroTerceiro]         DECIMAL (18) NOT NULL,
    [emAberto]               TINYINT      NOT NULL,
    [valorTotal]             DECIMAL (18) NOT NULL,
    [caucao]                 DECIMAL (18) NOT NULL,
    [idCupom]                INT          NULL,
    [emailEnviado]           TINYINT      NOT NULL,
    CONSTRAINT [PK_TBLocacao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBLocacao_Categorias] FOREIGN KEY ([idGrupoVeiculo]) REFERENCES [dbo].[Categorias] ([Id]),
    CONSTRAINT [FK_TBLocacao_TBClientes] FOREIGN KEY ([idCliente]) REFERENCES [dbo].[TBClientes] ([Id]),
    CONSTRAINT [FK_TBLocacao_TBCondutor] FOREIGN KEY ([idCondutor]) REFERENCES [dbo].[TBCondutor] ([Id]),
    CONSTRAINT [FK_TBLocacao_TBCupons] FOREIGN KEY ([idCupom]) REFERENCES [dbo].[TBCupons] ([ID]),
    CONSTRAINT [FK_TBLocacao_TBFuncionario] FOREIGN KEY ([idFuncionario]) REFERENCES [dbo].[TBFuncionario] ([Id]),
    CONSTRAINT [FK_TBLocacao_TBVeiculos] FOREIGN KEY ([idVeiculo]) REFERENCES [dbo].[TBVeiculos] ([Id])
);











