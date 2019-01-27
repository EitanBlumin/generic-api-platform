CREATE FUNCTION [dbo].[clr_http_request]
(@requestMethod NVARCHAR (MAX) NULL, @url NVARCHAR (MAX) NULL, @parameters NVARCHAR (MAX) NULL, @headers NVARCHAR (MAX) NULL, @timeout INT NULL, @autoDecompress BIT NULL, @convertResponseToBas64 BIT NULL)
RETURNS XML
AS
 EXTERNAL NAME [ClrHttpRequest].[UserDefinedFunctions].[clr_http_request]

