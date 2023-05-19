# EShop-RazorPage
The Source Code of the ASP.NET Core E-Commerce Razor Page Course

## Features
* Clean Architecture
* Using Web API

## Packages
* AutoMapper.Extensions.Microsoft.DependencyInjection `v11.0.0`
* CookieManager `v2.0.0`
* Microsoft.AspNetCore.Authentication.JwtBearer `v6.0.4`
* Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation `v6.0.4`
* Newtonsoft.Json `v13.0.1`
* System.Drawing.Common `v6.0.0`

## Getting Started
To run the application:

1. Clone the Project
2. Open Visual Studio and load the Solution
3. Resolve any missing/required nuget package
4. Set `Shop.API` as startup project
5. Build Database. Open `Package Manager Console`, set `Shop.Infrastructure` as defualt project and run the following commands: `update-database`
6. That's all... Run the Project!