CREATE FUNCTION dbo.api_FillPlaceholders(@text_template nvarchar(4000), @api_target_id int)
RETURNS nvarchar(4000)
WITH SCHEMABINDING, RETURNS NULL ON NULL INPUT
AS
BEGIN
	SELECT @text_template = REPLACE(@text_template, N'$(parameter[' + tfv.FieldName + N'])', tfv.FieldValue)
	FROM dbo.api_TargetFieldValues AS tfv
	WHERE tfv.TargetID = @api_target_id

	RETURN @text_template;
END
