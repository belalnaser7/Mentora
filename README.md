# 🎓 Mentora

Mentora is a modern **Learning Management System (LMS)** backend built with **ASP.NET Core 8** using **Clean Architecture**.

The goal of the project is to provide a scalable and maintainable platform for managing online education, instructors, students, subscriptions, and learning content while following enterprise-level development practices.

> **Project Status:** 🚧 Under Active Development

---

# ✨ Features

## Authentication & Authorization

* ASP.NET Core Identity
* JWT Authentication
* Refresh Token Rotation
* OTP Verification
* Password Reset
* Email Verification (In Progress)
* Role-Based Authorization
* Student, Teacher and Admin Roles

---

## Course Management

* Create and manage courses
* Course publishing workflow
* Course modules
* Lessons
* Course levels
* Pricing support

---

## Student Features

* Course Enrollment
* Subscription Management
* Quiz Attempts
* Progress Tracking (Planned)

---

## Quiz System

* Quiz Management
* Multiple Choice Questions
* Student Quiz Attempts
* Automatic Scoring
* Quiz History

---

## Subscription System

* Multiple Subscription Packages
* Package Limits
* Expiration Management
* Auto Renewal Support

---

## Security

* JWT Access Tokens
* Refresh Tokens
* Password Hashing
* OTP Verification
* Role-Based Authorization
* Secure Authentication Flow

---

# 🏗 Architecture

The project follows **Clean Architecture** principles.

```
Presentation (API)

        │

Application

        │

Domain

        │

Infrastructure
```

The architecture separates business logic from infrastructure concerns, making the application easier to maintain, test, and extend.

---

# 🛠 Technologies

* ASP.NET Core 8
* C#
* Entity Framework Core
* SQL Server
* ASP.NET Identity
* JWT Authentication
* Refresh Tokens
* BCrypt
* FluentValidation
* LINQ
* Clean Architecture
* Repository Pattern
* Dependency Injection
* Unit of Work (EF Core DbContext)
* Swagger / OpenAPI

---

# 📂 Current Modules

* Authentication
* Users
* Roles
* Courses
* Modules
* Lessons
* Quizzes
* Subscriptions
* OTP
* Refresh Tokens
* Enrollment

---

# 📖 API Documentation

Swagger/OpenAPI documentation is available with the project and can be used to generate client SDKs for Flutter, React, Angular, or other frontend frameworks.

---

# 🚀 Deployment

Production API

http://divmentora.runasp.net/

---

# 🎯 Project Goals

This project is being developed as a production-ready backend while applying modern software engineering principles and enterprise development practices.

The main objective is to build a scalable LMS that can support real-world educational platforms.

---

# 📌 Roadmap

* Email Service Integration
* Notifications
* File Uploads
* Video Streaming
* Payment Integration
* Certificates
* Student Progress Analytics
* Dashboard
* Admin Reports
* Unit Testing
* Integration Testing

---

# 👨‍💻 Author

Developed by **Belal Naser**

Backend Developer (.NET)

Alexandria, Egypt
