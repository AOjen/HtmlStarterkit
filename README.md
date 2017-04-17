# Izenda Html Starter Kit
The starter kit demonstrates how to integrate Izenda BI 7 Series tool in an html page. 
The API in the kit impersonates all requests to be Izenda Admin user.

## Izenda Version
1.25.2.

## Prerequisites

1. If the deployment is newer than 1.25.2, please follow the upgrade instructions.
   
2. Location of files to modify:   
   * APIStarterKit\izendadb.config
   * DB\IzendaDBScript.sql
   * Website\index.html
   
## Getting Started

1. In Visual Studio, compile and deploy the APIStarterKit and Website. Deploy the APIStarterKit and the Website to IIS server.
	* APIStarterKit : Modified API to work with an HTML Deployment
	* Website : An HTML Page rendering an Izenda page.

2. Run the IzendaDBScript.sql in SSMS to populate your Izenda Database. In your Izenda Database, ensure the DeploymentMode = 3 (Full Integration) in IzendaSystemSettings table.

3. Update the Izenda database connection string in izendadb.config file. If your connection string is unencrypted, ensure that you escape any special characters.
   
   ```
   "server=My-PC\SQLEXPRESS;database=HTML_Izenda;User Id=Test;Password=test123;"  ==> "server=My-PC\\SQLEXPRESS;database=HTML_Izenda;User Id=Test;Password=test123;"
   ```
 
4. Update the WebApiUrl in index.html file to point to APIStarterKit URL. Ensure to append /api/ after the URL.
   
   ```
   "WebApiUrl": "http://localhost:4546/api/",
   ```
   
5. Reset IIS and clear your cache.

6. Browse the index.html in browser. Then Izenda application appears and you need to set the license, token key in Settings page.
	* If you press the "Connect" button for your IzendaDB connection string, the connection string in the IzendaDB.config will be encrypted.

7. Enjoy!



## Upgrade
Download a newer version (https://downloads.izenda.com) of the API copy the following:

### API
* Copy all files & folders in API\bin -> APIStarterKit\IzendaReferences
* API\Content -> APIStarterKit\IzendaResources
* API\EmailTemplates -> APIStarterKit\IzendaResources
* API\Export -> APIStarterKit\IzendaResources

### Database
* Find appropriate migration scripts in SchemaMigrationScripts (database and versions), run against the Izenda database located in App_Data\Izenda.mdf using SSMS or Visual Studio.

### Javascript
* Copy all files & folders in EmbeddedUI -> Website\izenda
