# Blazor_webassembly_learning

Regular implementation of beer single-page app to learn new Frontend framework.

Current ASP.NET landscape:
- MVC (not single page app, server renders html and sends to client)
- Razor Pages (same as mvc but less cruft)
- Blazor Server (components instead of pages, all UI interaction results in round-trip to server, full .NET core libraries available)
- Blazor WebAssembly (components instead of pages, all app loaded in client so no roundtrips to server therefore can be staticly served, only .NET Standard libraries)

This time it's not a Javascript but rather a .NET one called Blazor.
We are using the WebAssembly Blazor `hosting model` as it most closely resembles the UX users would experience with popular Javascript frameworks such as Angular and React.
https://docs.microsoft.com/en-us/aspnet/core/Blazor/?view=aspnetcore-3.1