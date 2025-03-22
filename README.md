# Clean Architecture in .NET 8 with MediatR (CQRS) & Options Pattern

## 🚀 Overview
This repository demonstrates the implementation of **Clean Architecture** in **.NET 8** using **MediatR (CQRS Pattern)** along with **Options Pattern** for structured configuration management. It also integrates **CancellationToken** for better request handling.

## 📂 Solution Structure
The project follows **Clean Architecture** principles and is organized into four layers:

- **MyCleanArchitectureApp.Api** (Presentation Layer)  
  - Handles HTTP requests
  - Implements Controllers
  - Configures Dependency Injection
  
- **MyCleanArchitectureApp.Application** (Application Layer)  
  - Implements CQRS with **Commands** & **Queries**
  - Uses MediatR for request handling
  - Supports **CancellationToken** for efficient processing
  
- **MyCleanArchitectureApp.Core** (Domain Layer)  
  - Defines Entities and Interfaces
  - Contains core business logic
  
- **MyCleanArchitectureApp.Infrastructure** (Persistence Layer)  
  - Implements the **Repository Pattern**
  - Uses **EF Core** for database operations
  - Includes Migrations and Database Context

## 🛠️ Key Features
✅ **CQRS with MediatR** - Separates read & write operations  
✅ **CancellationToken Support** - Improves request handling  
✅ **Options Pattern** - Strongly-typed configuration management  
✅ **EF Core & Migrations** - Database handling  
✅ **Dependency Injection** - Manages dependencies efficiently  
✅ **Repository Pattern** - Abstracts database logic 
