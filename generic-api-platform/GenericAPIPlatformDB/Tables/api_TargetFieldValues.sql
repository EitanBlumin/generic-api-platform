CREATE TABLE [dbo].[api_TargetFieldValues] (
	[ID]		 INT			 NOT NULL IDENTITY(1,1),
    [TargetID]   INT             NOT NULL,
    [FieldName]  NVARCHAR (100)  NOT NULL,
    [FieldValue] NVARCHAR (4000) NOT NULL,
    CONSTRAINT [PK_api_TargetFieldValues] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_api_TargetFieldValues_Target] FOREIGN KEY ([TargetID]) REFERENCES [dbo].[api_Target] ([ID]) ON DELETE CASCADE
);


GO

CREATE UNIQUE INDEX [UQ_api_TargetFieldValues] ON [dbo].[api_TargetFieldValues] ([TargetID], [FieldName])
