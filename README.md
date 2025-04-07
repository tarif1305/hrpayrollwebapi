# 💼 HR Payroll Web API

A RESTful Web API built with **ASP.NET Core** for managing employees and their payroll data. This project provides endpoints for CRUD operations and supports uploading employee-related files like images.

---

## 🚀 Features

- 🔍 View employees with their payroll details
- ➕ Add new employees and payroll records
- ✏️ Update and replace employee records
- ❌ Delete employees and their associated payrolls
- 📁 Upload files (e.g., employee images)
- 🌱 Seeded sample data using `OnModelCreating`

---

## 📦 Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (or any EF Core compatible DB)
- LINQ + Lambda for querying
- Swagger/OpenAPI (optional for testing)

---

## 📁 Project Structure

- `Models/Employee.cs`  
  Defines employee entity with properties like `FullName`, `Position`, `BasicSalary`, and related payroll records.

- `Models/PayrollDetails.cs`  
  Represents payroll information per employee including `GrossSalary`, `Deductions`, and `NetSalary`.

- `Controllers/EmployeeController.cs`  
  API Controller exposing all endpoints for employee and payroll management.

- `Data/ApplicationDbContext.cs`  
  Database context managing EF Core entities and seeded sample data for quick testing.

---

## 🔧 Endpoints

| Method | Endpoint              | Description                     |
|--------|-----------------------|---------------------------------|
| GET    | `/api/employee`       | Get all employees + payrolls    |
| GET    | `/api/employee/{id}`  | Get specific employee           |
| POST   | `/api/employee`       | Add new employee                |
| PUT    | `/api/employee`       | Update existing employee        |
| DELETE | `/api/employee/{id}`  | Delete employee & payroll       |
| POST   | `/upload`             | Upload file (image/doc)         |

---

## 🔍 Sample Seeded Data

Employees and payrolls are automatically seeded:
- 👨‍💼 Tarif Hossain (Manager)
- 👨‍💻 Ashraf Uddin (Developer)
- 🧑‍💼 Abul Bashar Emon (HR Officer)
- 🧾 Ahsanul Kabir (Accountant)
- 🧍‍♂️ Abdur Rahim (Sales Executive)

---

## 🧪 How to Run

1. Clone the repository
2. Run migrations or ensure the database is created
3. Launch the API using Visual Studio or `dotnet run`
4. Test with Postman or Swagger UI

---
