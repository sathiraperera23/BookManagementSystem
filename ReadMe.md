# Book Management Application

This repository contains both the **backend** (ASP.NET Web API) and **frontend** (Angular) for the Book Management application.

Users can **add, view, update, and delete books**. The backend provides a RESTful API, and the frontend consumes it using Angular.

---

## Project Structure


BookManagement/
│
├── backend/ <-- ASP.NET backend
│ ├── BookManagement.sln
│ ├── BookManagement.Web/
│ ├── BookManagement.Application/
│ ├── BookManagement.Domain/
│ └── BookManagement.Infrastructure/
│
└── frontend/ <-- Angular frontend
├── angular.json
├── package.json
├── src/
└── ...other Angular files


---

## Backend (ASP.NET)

1. Open the backend project in **Visual Studio** or **VS Code**.
2. Navigate to the backend folder:

```bash
cd backend/BookManagement.Web

Restore NuGet packages:

dotnet restore

Run the backend:

dotnet run

The API will start on https://localhost:5001 (or another port shown in console).

API Endpoints:

GET /api/book → Get all books

GET /api/book/{id} → Get book by ID

POST /api/book → Add new book

PUT /api/book/{id} → Update book

DELETE /api/book/{id} → Delete book

Frontend (Angular)

Open a terminal and navigate to the frontend folder:

cd frontend

Install dependencies:

npm install

Run the Angular app:

ng serve

The frontend will run on http://localhost:4200 by default.

Make sure the backend is running at https://localhost:5001 for API calls.

Notes

The Angular frontend is configured to call the backend API at https://localhost:5001/api/book.
If your backend runs on a different port, update the URL in frontend/src/app/services/book.service.ts:

private apiUrl = 'https://localhost:5001/api/book';

Use the frontend to:

View the list of books

Add a new book

Edit an existing book

Delete a book