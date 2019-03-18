# pandemo
This sample project provides an end-to-end solution to connect to the testing instance of PriorAuthNow Case API.  

This solution includes a web API project which includes a direct connection to the PAN tenant. It also includes a console application that simulates connecting to the Web API tenant.

The current library includes extensions for:
- .NET Core 2.2

For access to the PriorAuthNow testing tenant, please email PriorAuthNow at sales@priorauthnow.com..

This solution allows PriorAuthNow API partners to access a fully-working API client.

There are two projects included in this repository:
- <b>ClientLibrary.PublicAPI.External</b>: This project is a WEB API implementation for issue new and updating cases and receiving web notifications
- <b>ClientLibrary.PublicAPI.ConsoleApplication</b>: This project consumes the web api solution. The options for running include:
- - (1): Trigger a web notification to the external API 
- - (2): Create a new prior authorization case
- - (3): Update an existing prior authorization case

Detailed specifications may be found here. 

The following configurations are provided:
<b>ClientLibrary.PublicAPI.External</b>:
- UrlForPriorAuthNowTestEndpoint : Location for the PriorAuthNow testing tenant. This will likely not be changed
- UrlForWebhook : The webhook URL for receiving messages (if you use the autodeploy option, this will be the environment to connect)
