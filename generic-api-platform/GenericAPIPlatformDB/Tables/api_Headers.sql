CREATE TABLE [dbo].[api_Headers] (
    [APITypeID]         INT             NOT NULL,
    [HeaderName]        NVARCHAR (100)  NOT NULL,
    [HeaderValue]       NVARCHAR (1000) NOT NULL,
    [AllowPlaceholders] BIT             DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_api_Headers] PRIMARY KEY CLUSTERED ([APITypeID] ASC, [HeaderName] ASC),
    CONSTRAINT [FK_api_Headers_Type] FOREIGN KEY ([APITypeID]) REFERENCES [dbo].[api_Type] ([ID]) ON DELETE CASCADE
);

