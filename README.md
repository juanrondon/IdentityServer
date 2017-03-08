# IdentityServer

## Before you run the project modify the hosting:

### Modify hosting
By default Visual Studio uses IIS Express to host your web project. This is totally fine, besides that you won’t be able to see the real time log output to the console.
IdentityServer makes extensive use of logging whereas the “visible” error message in the UI or returned to clients are deliberately vague.
We recommend to run IdentityServer in the console host. You can do this by switching the launch profile in Visual Studio. You also don’t need to launch a browser every time you start IdentityServer - you can turn that off as well:

For more details please [Follow Link](http://docs.identityserver.io/en/release/quickstarts/0_overview.html#modify-hosting)
