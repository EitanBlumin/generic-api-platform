CREATE PROCEDURE dbo.api_SetFieldValue(@api_target_id int, @field_name nvarchar(1000), @field_value nvarchar(4000))
AS
	SET NOCOUNT ON;
	
	WITH Trgt
	AS
	(
	SELECT *
	FROM dbo.api_TargetFieldValues
	WHERE TargetID = @api_target_id
	AND FieldName = @field_name
	)
	MERGE INTO Trgt
	USING (VALUES(@api_target_id, @field_name, @field_value)) AS Src(TargetID, FieldName, FieldValue)
	ON
		Trgt.TargetID = Src.TargetID
	AND Trgt.FieldName = Src.FieldName
	WHEN MATCHED THEN
		UPDATE SET FieldValue = Src.FieldValue
	WHEN NOT MATCHED BY TARGET THEN
		INSERT (TargetID, FieldName, FieldValue)
		VALUES (TargetID, FieldName, FieldValue)
	;