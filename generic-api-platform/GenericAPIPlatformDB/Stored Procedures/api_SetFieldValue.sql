CREATE PROCEDURE dbo.api_SetFieldValue(@api_target_id int, @field_name nvarchar(1000), @field_value nvarchar(4000))
AS
	SET NOCOUNT ON;

	UPDATE dbo.api_TargetFieldValues
		SET FieldValue = @field_value
	WHERE
		TargetID = @api_target_id
	AND FieldName = @field_name