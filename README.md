# TrainingSlns
Repo for training development process with Clean Architecture


# OptcgExplorer

A simple One Piece Card Game explorer built with **.NET 10**, **Blazor Server**, and **Clean Architecture**.

This project consumes the public OPTCG API and serves as a learning project for practicing:

- Clean Architecture
- Separation of Concerns
- Dependency Injection
- HTTP APIs
- Blazor Server
- Vertical Slice Features

---

## Features

### Current Features

- View all available card sets
- Consume external REST APIs
- Clean Architecture structure
- Feature-based organization

### Planned Features

- View cards by set
- Search cards
- Card details page
- Starter Deck support
- Promo support
- DON!! card support
- MAUI client

---

## Architecture

```text
OptcgExplorer.sln

src/
├── OptcgExplorer.Core
├── OptcgExplorer.UseCases
├── OptcgExplorer.Infrastructure
└── OptcgExplorer.Web

tests/
```

### Layer Responsibilities

#### Core

Contains:

- Entities
- Domain models
- Business concepts

#### UseCases

Contains:

- Queries
- Handlers
- Results
- Interfaces

#### Infrastructure

Contains:

- API integrations
- DTOs
- Services

#### Web

Contains:

- Blazor UI
- Pages
- Components

---

## Technologies

- .NET 10
- C#
- Blazor Server
- Clean Architecture
- HttpClient
- Dependency Injection

---

## Prerequisites

Install:

### .NET 10 SDK

https://dotnet.microsoft.com/download

Verify installation:

```bash
dotnet --version
```

Expected:

```text
10.x.x
```

---

## Running with VS Code

### Recommended Extensions

Install:

- C# Dev Kit
- C# Extension
- .NET Install Tool

### Clone Repository

```bash
git clone https://github.com/YOUR_USERNAME/OptcgExplorer.git
```

```bash
cd OptcgExplorer
```

### Restore Packages

```bash
dotnet restore
```

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run --project src/OptcgExplorer.Web
```

Open:

```text
https://localhost:5001
```

or

```text
http://localhost:5000
```

---

## Running with Visual Studio

### Requirements

- Visual Studio 2026
- ASP.NET and Web Development workload

### Steps

1. Open:

```text
OptcgExplorer.sln
```

2. Set:

```text
OptcgExplorer.Web
```

as Startup Project

3. Press:

```text
F5
```

or

```text
Ctrl + F5
```

---

## API Source

This project uses:

https://www.optcgapi.com/

Current endpoint:

```text
/api/allSets/
```

---

## Project Structure Example

```text
Features
└── Sets
    └── GetSets
        ├── GetSetsQuery.cs
        ├── GetSetsHandler.cs
        └── GetSetsResult.cs
```

Request Flow:

```text
Blazor Page
    ↓
Handler
    ↓
Service
    ↓
External API
```

---

## Learning Goals

This repository intentionally focuses on:

- Readability
- Simplicity
- Maintainability
- Clean Architecture fundamentals

The goal is to provide a practical example that can be understood and extended by developers who are learning modern .NET development.

---

## License

MIT License