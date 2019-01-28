CREATE TABLE [dbo].[api_Target] (
    [ID]				INT             IDENTITY (1, 1) NOT NULL,
    [APITypeID]         INT             NOT NULL,
    [TargetName]        NVARCHAR (255)  NOT NULL,
    [TargetDescription] NVARCHAR (4000) NULL,
    [Enabled]           BIT             DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_api_Target] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_api_Target_Type] FOREIGN KEY ([APITypeID]) REFERENCES [dbo].[api_Type] ([ID]) ON DELETE CASCADE
);

