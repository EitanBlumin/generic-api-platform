
/*
-- Example usage:

DECLARE @response nvarchar(max)

EXEC dbo.api_RunTarget 1, @response OUTPUT, 1

SELECT [Response] = @response
*/
CREATE PROCEDURE dbo.api_RunTarget(@api_target_id int, @response nvarchar(max) OUTPUT, @debug bit = 0)
AS
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	SET ARITHABORT ON;

	DECLARE @api_type_id int, @headers nvarchar(4000)

	SELECT @api_type_id = APITypeID
	FROM api_Target
	WHERE ID = @api_target_id;

	SET @headers = (
		SELECT [@Name] = [HeaderName], [text()] = CASE WHEN AllowPlaceholders = 1 THEN dbo.api_FillPlaceholders([HeaderValue], @api_target_id) ELSE [HeaderValue] END
		FROM api_Headers
		WHERE APITypeID = @api_type_id
		FOR XML PATH('Header'), ROOT('Headers')
	);

	DECLARE @uri nvarchar(4000), @method varchar(6), @payload nvarchar(max)

	SELECT
		@uri = dbo.api_FillPlaceholders(TargetURI, @api_target_id),
		@method = Method,
		@payload = dbo.api_FillPlaceholders(Payload, @api_target_id)
	FROM dbo.api_GetAPIType(@api_type_id)
	
	IF @debug = 1
	BEGIN
		PRINT @headers
		PRINT @uri
		PRINT @method
		PRINT @payload
	END

	SET @response = [dbo].[clr_http_request]
        (
            @method,
            @uri,
            @payload,
            @headers,
            300000,
            0,
            0
        ).value('/Response[1]/Body[1]', 'NVARCHAR(MAX)')
