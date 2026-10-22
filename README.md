# 🛒 E-Commerce Backend (.NET 10 Clean Architecture)

A modern, enterprise-grade E-Commerce API built with **.NET 10**, adhering to **Clean Architecture**, **CQRS (MediatR)**, **FluentValidation**, and **Entity Framework Core**. Engineered with high code quality standards, automatic request validation pipelines, and standardized error handling.

---

## 📸 Application Screenshot
> Below is the interactive Swagger API documentation and pipeline validation in action:
<img width="1920" height="1056" alt="image" src="https://github.com/user-attachments/assets/c336990e-ea63-4b83-939f-3f8488b05bf6" />
<img width="1920" height="2803" alt="image" src="https://github.com/user-attachments/assets/f5758050-cc5f-466e-9bc5-886074f6ab30" />


## 🏗️ Architecture Overview

This solution strictly adheres to **Clean Architecture** principles to ensure high testability, scalability, and weak coupling between layers:

* **API Layer (.NET 10):** Controllers, Global Exception Handling Middleware, and Swagger UI configuration.
* **Application Layer:** CQRS Handlers (MediatR), DTOs, Business Validation (FluentValidation), and Interfaces.
* **Domain Layer:** Core Entities, Enums, Exceptions, and Value Objects (uses `Guid` primary keys for global uniqueness).
* **Infrastructure Layer:** Database context, EF Core configurations, and SQLite persistence.

---

## ⚡ Key Features

- ✅ **Framework:** Built on top of bleeding-edge **.NET 10**.
- ✅ **Clean Architecture:** Strict separation of concerns across 4 distinct projects.
- ✅ **CQRS Pattern:** Requests and handlers isolated using **MediatR**.
- ✅ **Validation Pipeline:** Automated pipeline behaviors via **FluentValidation** before hitting domain logic.
- ✅ **Global Exception Middleware:** Centralized middleware converting domain & validation exceptions to standardized JSON error responses (`400 Bad Request`, `404 Not Found`, etc.).
- ✅ **Persistence:** Relational persistence using **EF Core** with **SQLite**.
- ✅ **Interactive API Docs:** Fully configured Swagger/OpenAPI documentation.

---

## 🛠️ Tech Stack & Dependencies

* **Language:** C# 13 / .NET 10
* **Architecture:** Clean Architecture + CQRS
* **Libraries:**
  * `MediatR` - CQRS pattern & Pipeline Behaviors
  * `FluentValidation` - Strongly-typed validation rules
  * `Microsoft.EntityFrameworkCore.Sqlite` - ORM Persistence
  * `Swashbuckle.AspNetCore` - Swagger Documentation

---

## 🚀 Getting Started

### Prerequisites
* [.NET 10 SDK](https://dotnet.microsoft.com/download)
* Visual Studio 2022 / VS Code

### Installation & Run

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/MdAbdullah6/EcommerceBackend.git](https://github.com/MdAbdullah6/EcommerceBackend.git)
