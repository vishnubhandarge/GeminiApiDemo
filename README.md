# GeminiApiDemo

A .NET 10 Web API project that demonstrates how to integrate Google's Gemini AI models into ASP.NET Core applications. This project provides a simple REST API that accepts user prompts, sends them to Gemini, and returns AI-generated responses.

## Features

* .NET 10 Web API
* Google Gemini AI Integration
* RESTful API Endpoints
* Dependency Injection
* HttpClient Factory
* Swagger/OpenAPI Documentation
* Configuration-based API Key Management
* Clean Service-Based Architecture
* Async Programming Support

## Technology Stack

* .NET 10
* ASP.NET Core Web API
* Google Gemini API
* Swagger / OpenAPI
* Dependency Injection
* HttpClient Factory

## Project Structure

```text
GeminiApiDemo
│
├── Controllers
│   └── GeminiController.cs
│
├── Services
│   ├── IGeminiService.cs
│   └── GeminiService.cs
│
├── Models
│   └── GeminiRequest.cs
│
├── appsettings.json
├── Program.cs
└── README.md
```

## Prerequisites

Before running the project, ensure you have:

* .NET 10 SDK
* Visual Studio 2026 or Visual Studio Code
* Google Account
* Gemini API Key

## Getting Started

### 1. Clone Repository

```bash
git clone https://github.com/yourusername/GeminiApiDemo.git
cd GeminiApiDemo
```

### 2. Configure Gemini API Key

Update `appsettings.json`:

```json
{
  "Gemini": {
    "ApiKey": "YOUR_GEMINI_API_KEY",
    "Model": "gemini-2.5-flash"
  }
}
```

### 3. Run Application

```bash
dotnet restore
dotnet run
```

### 4. Open Swagger

```text
https://localhost:5001/swagger
```

## API Endpoints

### Generate AI Response

**POST**

```http
/api/gemini/ask
```

### Request

```json
{
  "prompt": "Explain JWT Authentication in .NET"
}
```

### Response

```json
{
  "response": "JWT Authentication is a token-based authentication mechanism..."
}
```

## Sample Use Cases

* AI Chat Applications
* Knowledge Assistants
* Documentation Generators
* Customer Support Bots
* Learning Assistants
* Internal Business Tools
* AI-Powered APIs

## Security Recommendations

For production environments:

* Store API keys in Azure Key Vault
* Use User Secrets during development
* Enable Rate Limiting
* Add Request Validation
* Implement Logging and Monitoring
* Configure Retry Policies
* Protect Endpoints with Authentication

## Future Enhancements

* Streaming Responses
* Conversation Memory
* Chat History Persistence
* Multiple Gemini Models Support
* Prompt Templates
* Token Usage Tracking
* Authentication & Authorization
* Azure Deployment Pipeline
* Docker Support
* OpenTelemetry Integration

## Learning Objectives

This project helps developers learn:

* How to call Gemini AI from .NET applications
* HttpClient best practices
* Dependency Injection patterns
* External API integration
* Clean Architecture fundamentals
* REST API development

## License

This project is provided for educational and learning purposes.

## Author

Developed as a Proof of Concept for learning Google Gemini AI integration with ASP.NET Core Web API.
