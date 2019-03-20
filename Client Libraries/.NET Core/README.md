# .NET Core Example Project

This solution includes a web API project which connects to the PAN sandbox. It also includes a console application that simulates connecting to the Web API tenant with your package or custom solution.


<h2>Lol</h2>
There are two projects included in this repository:
- <b>ClientLibrary.PublicAPI.External</b>: This project is a WEB API implementation for issue new and updating cases and receiving web notifications
- <b>ClientLibrary.PublicAPI.ConsoleApplication</b>: This project consumes the web api solution. The options for running include:
- (1): Trigger a web notification to the external API 
- (2): Create a new prior authorization case
- (3): Update an existing prior authorization case

The following configurations are provided:
<b>ClientLibrary.PublicAPI.External</b>:
- UrlForPriorAuthNowTestEndpoint : Pre-configured location for the PriorAuthNow test API

<b>ClientLibrary.PublicAPI.Console</b>:
- UrlForPriorAuthNowTestEndpoint : Location for the PriorAuthNow testing tenant. This will likely not be changed
- UrlForWebhook : The webhook URL for receiving messages (if you use the autodeploy option, this will be the environment to connect)
