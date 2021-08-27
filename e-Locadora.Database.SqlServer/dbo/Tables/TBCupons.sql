﻿CREATE TABLE [dbo].[TBCupons] (
    [ID]               INT           IDENTITY (1, 1) NOT NULL,
    [NOME]             VARCHAR (100) NOT NULL,
    [VALOR_PERCENTUAL] INT           NULL,
    [VALOR_FIXO]       DECIMAL (18)  NULL,
    [DATA_VALIDADE]    DATE          NOT NULL,
    [PARCEIRO]         VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
