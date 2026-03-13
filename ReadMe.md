# 📚 Book Management Application

> A full-stack application for managing your book collection — built with **ASP.NET Web API** and **Angular**.

Users can seamlessly **add, view, update, and delete books** through a clean Angular frontend powered by a RESTful ASP.NET backend.

---

## 🗂️ Project Structure
BookManagement/
│
├── backend/                        # ASP.NET Web API
│   ├── BookManagement.sln
│   ├── BookManagement.Web/
│   ├── BookManagement.Application/
│   ├── BookManagement.Domain/
│   └── BookManagement.Infrastructure/
│
└── frontend/                       # Angular Application
├── angular.json
├── package.json
└── src/

---

## ⚙️ Getting Started

### 🔧 Backend (ASP.NET)

1. Open the project in **Visual Studio** or **VS Code**
2. Navigate to the backend directory:
```bash
   cd backend/BookManagement.Web
```
3. Restore NuGet packages:
```bash
   dotnet restore
```
4. Start the API server:
```bash
   dotnet run
```

> The API will be available at `https://localhost:5001`

---

### 🌐 Frontend (Angular)

1. Navigate to the frontend directory:
```bash
   cd frontend
```
2. Install dependencies:
```bash
   npm install
```
3. Start the development server:
```bash
   ng serve
```

> The app will be available at `http://localhost:4200`
>
> ⚠️ Make sure the backend is running at `https://localhost:5001` before launching the frontend.

---

## 🔌 API Reference

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/book` | Retrieve all books |
| `GET` | `/api/book/{id}` | Retrieve a book by ID |
| `POST` | `/api/book` | Add a new book |
| `PUT` | `/api/book/{id}` | Update an existing book |
| `DELETE` | `/api/book/{id}` | Delete a book |

---

## ✨ Features

- 📖 View a list of all books
- ➕ Add a new book
- ✏️ Edit an existing book
- 🗑️ Delete a book

---

## 🛠️ Configuration

If your backend runs on a different port, update the API URL in:
frontend/src/app/services/book.service.ts
```typescript
private apiUrl = 'https://localhost:5001/api/book';
```

---

## 🧰 Tech Stack

| Layer | Technology |
|-------|------------|
| Frontend | Angular |
| Backend | ASP.NET Web API |
| Language | TypeScript / C# |