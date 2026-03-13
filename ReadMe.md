# Book Management System (Full Stack)

This repository contains a **full-stack Book Management System** built with:

* **Backend:** .NET Web API using Clean Architecture (BookManagement)
* **Frontend:** Angular (book-management-frontend)
* **Database:** PostgreSQL (or configured database)

### book-management-frontend: Consists of the Angular Frontend
### BookManagement: Consists of the .NET backend
The application allows users to **create, view, update, and delete books**.

---

# Project Structure

```
FullStack
│
├── BookManagement.sln                # .NET Solution
│
├── BookManagement                    # Web API (Entry Point)
│   ├── Controllers
│   ├── Program.cs
│   └── appsettings.json
│
├── BookManagement.Application        # Application Layer
│   ├── Interfaces
│   └── Services
│
├── BookManagement.Domain             # Domain Layer
│   └── Entities
│
├── BookManagement.Infrastructure     # Infrastructure Layer
│   └── Repositories
│
├── book-management-frontend          # Angular Frontend
│
└── README.md
```

---

# Backend (ASP.NET Web API)

The backend follows a **Clean Architecture pattern** with the following layers:

### Domain

Contains the core business entities.

Example:

* `Book`

### Application

Contains:

* Interfaces
* Business logic
* Services

### Infrastructure

Handles:

* Data access
* Repository implementations
* Database communication

### Web API

Handles:

* HTTP requests
* Controllers
* API routing

---

# API Endpoints

Base URL:

```
http://localhost:5062/api/book
```

Example endpoints:

| Method | Endpoint         | Description       |
| ------ | ---------------- | ----------------- |
| GET    | `/api/book`      | Get all books     |
| GET    | `/api/book/{id}` | Get book by ID    |
| POST   | `/api/book`      | Create a new book |
| PUT    | `/api/book/{id}` | Update a book     |
| DELETE | `/api/book/{id}` | Delete a book     |

Example response:

```
[
  {
    "id": 2,
    "title": "test2",
    "author": "test",
    "isbn": "test",
    "publicationDate": "2026-03-19T00:00:00"
  }
]
```

---

# Frontend (Angular)

The frontend is built using **Angular** and communicates with the backend API.

Features:

* View all books
* Add a new book
* Edit a book
* Delete a book

The Angular service calls the backend using:

```
http://localhost:5062/api/book
```

Example service configuration:

```
private apiUrl = 'http://localhost:5062/api/book';
```

---

# How to Run the Project

## 1. Run Backend

Navigate to the backend project folder (BookManagement) and run:

```
dotnet run
```

The API will start on:

```
http://localhost:5062
```

---

## 2. Run Frontend

Navigate to the Angular project folder:

```
cd book-management-frontend
```

Install dependencies:

```
npm install
```

Start Angular:

```
ng serve
```

Frontend will run on:

```
http://localhost:4200
```

---

# Technologies Used

Backend:

* .NET Web API
* Clean Architecture
* C#

Frontend:

* Angular
* TypeScript
* HTML / CSS

Tools:

* Git
* GitHub
* Visual Studio
* VS Code

---

# Author

Sathira

---

# Notes

* Make sure the backend API is running before starting the Angular frontend.
* The frontend communicates with the API using the configured base URL:

```
http://localhost:5062/api/book
```
