# pandemo
A sample project that allows users to connect to the development instance of PAN API. 

This solution includes a web API project that includes a direct connection to the PAN tenant. Also, a console application that simulates authenticating and connecting to the PAN tenant. 

This will allow clients to request access to interact with the PAN API. Once access is granted, clients will be able to create cases, update cases, delete cases, and recieve notifications on case updates. 

Configurations:
- AllowedHosts : "*"
- UrlForPriorAuthNowTestEndpoint : "http://localhost:61434/api/NotificationTrigger"
- UrlForWebhook : "http://localhost:61434/api/Notification"
