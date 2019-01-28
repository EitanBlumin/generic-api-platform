CREATE TABLE [dbo].[api_Headers] (
	[ID]				INT				NOT NULL IDENTITY(1,1),
    [APITypeID]         INT             NOT NULL,
    [HeaderName]        NVARCHAR (100)  NOT NULL,
    [HeaderValue]       NVARCHAR (1000) NOT NULL,
    [AllowPlaceholders] BIT             DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_api_Headers] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_api_Headers_Type] FOREIGN KEY ([APITypeID]) REFERENCES [dbo].[api_Type] ([ID]) ON DELETE CASCADE
);
GO
CREATE UNIQUE INDEX [UQ_api+Headers] ON [dbo].[api_Headers] ([APITypeID], [HeaderName])
