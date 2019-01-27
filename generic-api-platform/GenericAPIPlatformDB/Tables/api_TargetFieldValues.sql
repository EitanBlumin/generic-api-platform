CREATE TABLE [dbo].[api_TargetFieldValues] (
    [TargetID]   INT             NOT NULL,
    [FieldName]  NVARCHAR (100)  NOT NULL,
    [FieldValue] NVARCHAR (4000) NOT NULL,
    CONSTRAINT [PK_api_TargetFieldValues] PRIMARY KEY CLUSTERED ([TargetID] ASC, [FieldName] ASC),
    CONSTRAINT [FK_api_TargetFieldValues_Target] FOREIGN KEY ([TargetID]) REFERENCES [dbo].[api_Target] ([TargetID]) ON DELETE CASCADE
);

