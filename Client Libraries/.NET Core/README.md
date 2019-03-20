# PriorAuthNow .NET Core Sample Project

<h2>Contents</h2>
This solution allows PriorAuthNow API partners to access a fully-working API client.

There are two projects included in this repository:
- <b>ClientLibrary.PublicAPI.External</b>: This project is a WEB API implementation for issue new and updating cases and receiving web notifications
- <b>ClientLibrary.PublicAPI.ConsoleApplication</b>: This project consumes the web api solution. The three supported use cases are:
- - Trigger a web notification to the external API 
- - Create a new prior authorization case
- - Update an existing prior authorization case

<h2> Requirements </h2>
- Visual Studio 2017 Community or higher

- .NET Core 2.1 

<h2> Deployment </h2>
The solution can be deployed to any major public cloud provider or on-premises infrastructure. 


To create the environment in the Microsoft Azure Cloud, click here: <a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fquicksolutions%2Fpandemo%2Fmaster%2FClient%2520Libraries%2F.NET%2520Core%2FDeployment%2Fazuredeploy.json" target="_blank">
<img src="https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/1-CONTRIBUTION-GUIDE/images/deploytoazure.png"/>
</a>

To deploy your web solution in to the above Azure cloud, follow the instructions provided <a href="https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-2.2">here</a>

<h2> Configuration </h2>
The following configurations are provided:
<b>ClientLibrary.PublicAPI.External</b>:
- UrlForPriorAuthNowTestEndpoint : Pre-configured location for the PriorAuthNow test API
<b>ClientLibrary.PublicAPI.Console</b>:
- UrlForPriorAuthNowTestEndpoint : Location for the PriorAuthNow testing tenant. This will likely not be changed
- UrlForWebhook : The webhook URL for receiving messages (if you use the autodeploy option, this will be the environment to connect)