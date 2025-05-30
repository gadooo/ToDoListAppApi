﻿# 
# 📝 ToDo List API (.NET 8)

This is a simple RESTful API for managing a ToDo list, built with ASP.NET Core 8 and Entity Framework Core.

## 📦 Features

- Get all tasks ✅
- Add new task ➕
- Update task (complete/incomplete) 🔄
- Delete task 🗑️
- Connected to a SQL Server database using Entity Framework Core

## 📁 Project Structure

- `TaskModel.cs` – Represents the task entity (Id, Task, ItCompilet).
- `TaskController.cs` – Contains all the API endpoints.
- `AppDbContext.cs` – Database context using EF Core.

## 🛠️ Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server or SQLite (based on how `AppDbContext` is configured)

## 🚀 How to Run

1. **Clone the repo**
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   cd your-repo-name
