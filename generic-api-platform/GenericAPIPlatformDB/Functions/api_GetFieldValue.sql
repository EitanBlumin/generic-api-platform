CREATE FUNCTION dbo.api_GetFieldValue(@api_target_id int, @api_field_name nvarchar(100), @default_value nvarchar(4000) = NULL)
RETURNS nvarchar(4000)
WITH SCHEMABINDING, RETURNS NULL ON NULL INPUT
AS
BEGIN
	DECLARE @rv nvarchar(4000);

	SELECT @rv = FieldValue
	FROM dbo.api_TargetFieldValues
	WHERE TargetID = @api_target_id
	AND FieldName = @api_field_name

	RETURN ISNULL(@rv, @default_value)
END
