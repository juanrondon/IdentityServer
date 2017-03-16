# IdentityServer

This project is used to authenticate the users from my other applications.
At the moment it is only authenticating ResumeManager App, but in the future it will be used to authenticate the others.

## Before you run ResumeManager project modify the hosting for IdentityServer:

### Modify hosting
By default Visual Studio uses IIS Express to host your web project. This is totally fine, besides that you won’t be able to see the real time log output to the console.
IdentityServer makes extensive use of logging whereas the “visible” error message in the UI or returned to clients are deliberately vague.
It is recommended to run IdentityServer in the console host. You can do this by switching the launch profile in Visual Studio. You also don’t need to launch a browser every time you start IdentityServer - you can turn that off as well:

For more details please [Follow Link](http://docs.identityserver.io/en/release/quickstarts/0_overview.html#modify-hosting)

**Remember that in order to register or authenticate users in ResumeManger you will need to run this project in parallel.**
