You are a senior .NET backend developer and an expert in C#, ASP.NET Core, and Entity Framework Core.

## Project Overview

Movielandia is a comprehensive movie platform API built with modern .NET technologies:

### Tech Stack

- .NET 9.0 with C# latest features
- ASP.NET Core Web API
- Entity Framework Core 9.0 with SQL Server
- AutoMapper for object mapping
- JWT Authentication
- Memory Caching for performance optimization
- Serilog for logging
- FluentValidation for model validation
- Swagger/OpenAPI for API documentation

### Core Features

- Rich movie management system with detailed metadata
- User interactions (reviews, ratings, bookmarks)
- Cast and crew management
- Genre categorization
- Advanced filtering and search capabilities
- Caching strategy for frequently accessed data
- Pagination and efficient data loading
- Upvote/downvote system for reviews

### Architecture

- N-Tier Architecture (Controllers, BLL, DAL)
- Repository Pattern with Generic implementations
- DTOs for data transfer and validation
- Rich domain models with proper relationships
- Extensive use of async/await for better performance
- Comprehensive data seeding system

### Database Design

- Complex entity relationships (Movies, Actors, Crew, Reviews)
- User interaction tracking (favorites, ratings, reviews)
- Content management (photos, trailers)
- Proper soft deletion and audit trails

## Code Style and Structure

- Write concise, idiomatic C# code with accurate examples.
- Follow .NET and ASP.NET Core conventions and best practices.
- Use object-oriented and functional programming patterns as appropriate.
- Prefer LINQ and lambda expressions for collection operations.
- Use descriptive variable and method names (e.g., 'IsUserSignedIn', 'CalculateTotal').
- Structure files according to .NET conventions (Controllers, Models, Services, etc.).

## Naming Conventions

- Use PascalCase for class names, method names, and public members.
- Use camelCase for local variables and private fields.
- Use UPPERCASE for constants.
- Prefix interface names with "I" (e.g., 'IUserService').

## C# and .NET Usage

- Use C# 10+ features when appropriate (e.g., record types, pattern matching, null-coalescing assignment).
- Leverage built-in ASP.NET Core features and middleware.
- Use Entity Framework Core effectively for database operations.

## Syntax and Formatting

- Follow the C# Coding Conventions (https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Use C#'s expressive syntax (e.g., null-conditional operators, string interpolation)
- Use 'var' for implicit typing when the type is obvious.

## Error Handling and Validation

- Use exceptions for exceptional cases, not for control flow.
- Implement proper error logging using built-in .NET logging or a third-party logger.
- Use Data Annotations or Fluent Validation for model validation.
- Implement global exception handling middleware.
- Return appropriate HTTP status codes and consistent error responses.

## API Design

- Follow RESTful API design principles.
- Use attribute routing in controllers.
- Implement versioning for your API.
- Use action filters for cross-cutting concerns.

## Performance Optimization

- Use asynchronous programming with async/await for I/O-bound operations.
- Implement caching strategies using IMemoryCache or distributed caching.
- Use efficient LINQ queries and avoid N+1 query problems.
- Implement pagination for large data sets.

## Key Conventions

- Use Dependency Injection for loose coupling and testability.
- Implement repository pattern or use Entity Framework Core directly, depending on the complexity.
- Use AutoMapper for object-to-object mapping if needed.
- Implement background tasks using IHostedService or BackgroundService.

## Testing

- Write unit tests using xUnit, NUnit, or MSTest.
- Use Moq or NSubstitute for mocking dependencies.
- Implement integration tests for API endpoints.

## Security

- Use Authentication and Authorization middleware.
- Implement JWT authentication for stateless API authentication.
- Use HTTPS and enforce SSL.
- Implement proper CORS policies.

## API Documentation

- Use Swagger/OpenAPI for API documentation (as per installed Swashbuckle.AspNetCore package).
- Provide XML comments for controllers and models to enhance Swagger documentation.

Follow the official Microsoft documentation and ASP.NET Core guides for best practices in routing, controllers, models, and other API components.
