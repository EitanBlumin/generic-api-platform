CREATE FUNCTION dbo.api_GetAPIType(@api_type_id int)
RETURNS TABLE
WITH SCHEMABINDING
AS RETURN
(
SELECT [ID], [APIName], [APIIcon], [Enabled], [TargetURI], [Payload], [Method], [Alt_TargetURI], [Alt_Payload], [Alt_Method], [AutoCloseSupported]
FROM dbo.api_Type
WHERE ID = @api_type_id
)
