# Blazor_webassembly_learning

## Get Started
1. Install .NET core 3.1.3
2. `dotnet add package Blazored.Modal`
3. `dotnet watch run` for debugging locally
4. `make deploy` to deploy release build to "production" container
5. NOTE: Info entry in browser console log about WebAssembly compilation faillback in Chrome but not in FF.  

 Implementation of the usual Punk API beer search single-page app to learn new frontend framework.

Current ASP.NET landscape:
- MVC (not single page app, server renders html and sends to client)
- Razor Pages (same as mvc but less cruft)
- Blazor Server (components instead of pages, all UI interaction results in round-trip to server, full .NET core libraries available)
- Blazor WebAssembly (components instead of pages, all app loaded in client so no roundtrips to server therefore can be staticly served, only .NET Standard libraries)

This time it's not a Javascript but rather a .NET one called Blazor.
We are using the WebAssembly Blazor `hosting model` as it most closely resembles the UX users would experience with popular Javascript frameworks such as Angular and React.
https://docs.microsoft.com/en-us/aspnet/core/Blazor/?view=aspnetcore-3.1