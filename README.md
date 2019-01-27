# generic-api-platform
Generic SQL Server platform for configuring and running API requests via HTTP

## Tables
A set of tables will be used to save data needed for communicating with external APIs:

* **api_Type** (name, icon, enabled)
    * **api_Headers** (name, value, allow API field placeholders)
    * **api_Fields** (name, API type, data type, default value)
    * *api_Targets* (name, description, API type, enabled)
        * *api_TargetFieldValues* (API target, field, value)

Each `api_Type` record will also have the following (static) generic fields:

* TargetURI
* Payload
* Method (GET/POST/PUT/DELETE)
* Alt_TargetURI
* Alt_Payload
* Alt_Method (GET/POST/PUT/DELETE)

Each of the above fields would also support placeholders that would be replaced by the user-specified target field values.

Something like `$(parameter[fieldname])` or whatever generic like that.
For example: `$(parameter[authToken])`

`api_Type`, `api_Headers` and `api_Fields` are non-changeable "system" tables.

`api_Targets` and `api_TargetFieldValues` are user managed.

## Programmability Modules

* Scalar function: `api_GetFieldValue(api_target_id, field_name)`
* Table function: `api_GetAPIType(api_type_id)`
* Procedure: `api_RunTarget(api_target_id, response OUTPUT, debug)`
* Scalar function: `api_FillPlaceholders(text_template, api_target_id)`
* Procedure: `api_SetFieldValue(api_target_id, field_name, field_value)`

## Design

`api_Headers` will be used for specifying headers for the `clr_http_request` function (such as Content-Type, Authentication settings, etc). Their values will support placeholders from the API target field values.

API targets are user-created instances of API plugins, with specific configuration values entered in the API fields (you can create multiple targets per API type, each with their own settings).

These fields will then be used when communicating with the various APIs (such as username, access tokens, API keys, various custom settings, etc.)

In an easy-to-use portal, we'll be able to manage and configure the various API targets.

When configuring a new API target, there would also be a way to **test** the new target API by manually entering values for the API fields, and inspecting the response.

This whole module is as generic as possible and easy to use, as well as extendable with more plugins.
