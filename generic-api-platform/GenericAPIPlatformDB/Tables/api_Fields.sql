﻿CREATE TABLE [dbo].[api_Fields] (
	[ID]					 INT			NOT NULL IDENTITY(1,1),
    [APITypeID]              INT             NOT NULL,
    [FieldName]              NVARCHAR (100)  NOT NULL,
    [FieldLabel]             NVARCHAR (1000) NOT NULL,
    [FieldDataType]          VARCHAR (100)   NOT NULL,
    [FieldDefaultValue]      NVARCHAR (4000) NULL,
    [AllowAlertPlaceholders] BIT             DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_api_Fields] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_api_Fields_Type] FOREIGN KEY ([APITypeID]) REFERENCES [dbo].[api_Type] ([ID]) ON DELETE CASCADE
);

