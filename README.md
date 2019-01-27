# generic-api-platform
Generic SQL Server platform for configuring and running API requests via HTTP

# Tables
A set of tables will be used to save data needed for communicating with external APIs:

* **API_Type** (name, icon, enabled)
    * **API_Headers** (name, value, allow API field placeholders)
    * **API_Fields** (name, API type, data type, default value)
    * *API_Targets* (name, description, API type, enabled)
        * *API_TargetFieldValues* (API target, field, value)

Each API_Type record will also have the following (static) generic fields:

* TargetURI
* Payload
* Method (GET/POST/PUT/DELETE)
* Alt_TargetURI
* Alt_Payload
* Alt_Method (GET/POST/PUT/DELETE)

Each of the above fields would also support placeholders that would be replaced by the user-specified target field values.
Something like `$(parameter[fieldname])` or whatever generic like that.
For example: `$(parameter[authToken])`

`API_Type`, `API_Headers` and `API_Fields` are non-changeable "system" tables.
`API_Targets` and `API_TargetFieldValues` are user managed.

## Programmability Modules

* Scalar function: `GetAPIFieldValue(api_target, field_name)`
* Table function: `GetAPIType(api_name)`
* Procedure: `SetAPIFieldValue(api_target, field_name, field_value)`
* Procedure: `RunAPITarget(api_target, TBD)`
* Scalar function: `FillPlaceholdersByAPI(text_template, APITargetID)`

# Design

API_Headers will be used for specifying headers for the `clr_http_request` function (such as Content-Type, Authentication settings, etc). Their values will support placeholders from the API target field values.

API targets are user-created instances of API plugins, with specific configuration values entered in the API fields (you can create multiple targets per API type, each with their own settings).

These fields will then be used when communicating with the various APIs (such as username, access tokens, API keys, various custom settings, etc.)

In an easy-to-use portal, we'll be able to manage and configure the various API targets.

When configuring a new API target, there would also be a way to **test** the new target API by manually entering values for the API fields, and inspecting the response.

This whole module is as generic as possible and easy to use, as well as extendable with more plugins.
