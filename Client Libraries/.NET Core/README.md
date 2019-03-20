# .NET Core Sample Project

This solution includes a web API project which connects to the PAN sandbox. It also includes a console application that simulates connecting to the Web API tenant with your package or custom solution.

<h2>Contents</h2>

There are two projects included in this repository:
- <b>ClientLibrary.PublicAPI.External</b>: This project is a WEB API implementation for issue new and updating cases and receiving web notifications
- <b>ClientLibrary.PublicAPI.ConsoleApplication</b>: This project consumes the web api solution. The options for running include:
- (1): Trigger a web notification to the external API 
- (2): Create a new prior authorization case
- (3): Update an existing prior authorization case

<h2> Requirements </h2>
- Visual Studio 2017 Community or higher
- .NET Core 2.1 

<h2> Deployment </h2>
The solution can be deployed to any major public cloud provider or on-premises infrastructure. 

To create the environment in the Microsoft Azure Cloud, click here: <a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fgithub.com%2FAzure%2Fazure-quickstart-templates%2Ftree%2Fmaster%2F101-webapp-basic-windows%2Fazuredeploy.json" target="_blank">
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
