# JobExplorer API

JobExplorer is a simple ASP.NET Core Web API project that fetches job listings from an external API, processes the data using AutoMapper, and exposes a clean API endpoint for clients.

## Features

- Fetches job data from [remoteok.com API](https://remoteok.com/api)
- Uses AutoMapper for mapping data models to DTOs
- Provides a RESTful endpoint to get job listings
- Supports CORS for frontend integration
- Swagger UI for easy API exploration during development

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)
- Internet connection to fetch job data from remote API

### Setup

1. Clone the repository

```bash
git clone https://github.com/yourusername/JobExplorer.Api.git
cd JobExplorer.Api
````

#Restore dependencies and build
```bash
dotnet restore
dotnet build
```
#Run the application
```bash
dotnet run
```
##Open your browser and navigate to
https://localhost:5093/swagger
to explore the Swagger UI and test the API endpoint.
