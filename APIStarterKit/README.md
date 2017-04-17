# Izenda Impersonated API Starter Kit
The starter kit of hosting Izenda API impersonates any access tokens to be Izenda Admin user. It eliminates a bunch of prerequisite integration setup for authentication.
It is typically for rapid testing purpose.

## Getting Starts
Compile the project and configure the Izenda front-end site to point to this API's URL.

Look at App_Start\IzendaConfig.cs for the detailed impersonation of Izenda authentication.

## Izenda Version
1.24.5-hf.

## How to upgrade
Please download the newer version (https://downloads.izenda.com) of the API copy the following:

* Copy all files & folders in API\bin -> APIStarterKit\IzendaReferences
* API\Content -> APIStarterKit\IzendaResources
* API\EmailTemplates -> APIStarterKit\IzendaResources
* API\Export -> APIStarterKit\IzendaResources
* Find appropriate migration scripts in SchemaMigrationScripts (database and versions), run against the Izenda database located in App_Data\Izenda.mdf using SSMS or Visual Studio.