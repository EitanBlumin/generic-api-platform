CREATE TABLE [dbo].[api_Type] (
    [ID]                 INT            IDENTITY (1, 1) NOT NULL,
    [APIName]            NVARCHAR (100) NOT NULL,
    [APIIcon]            NVARCHAR (100) NULL,
    [Enabled]            BIT            CONSTRAINT [DF__api_Type__Enable__3D5E1FD2] DEFAULT ((1)) NOT NULL,
    [TargetURI]          VARCHAR (4000) NOT NULL,
    [Payload]            NVARCHAR (MAX) NULL,
    [Method]             VARCHAR (6)    NOT NULL,
    [Alt_TargetURI]      VARCHAR (4000) NULL,
    [Alt_Payload]        NVARCHAR (MAX) NULL,
    [Alt_Method]         VARCHAR (6)    NULL,
    [AutoCloseSupported] BIT            CONSTRAINT [DF__api_Type__AutoCl__3E52440B] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_api_Type] PRIMARY KEY CLUSTERED ([ID] ASC)
);

