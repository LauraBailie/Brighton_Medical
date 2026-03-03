# Brighton Medical Management System

## Overview
Brighton Medical Management System is a C# application designed to manage core medical practice operations including patient records, appointments, and administrative workflows.

The system consists of:

- A **Windows Forms desktop application** for administrative staff  
- A **web application** for patients  

The goal of this project was to design and implement a structured, maintainable system that separates administrative and patient functionality while ensuring data integrity, usability, and security considerations.

This project demonstrates object-oriented programming, role-based system design, and full-system workflow implementation.

---

## Technologies Used

- C#
- .NET Framework / .NET
- Windows Forms
- ASP.NET (Web Application)
- SQL Database (Patient records & appointments)
- Object-Oriented Programming principles
- Session & cookie handling
- Form validation and structured error handling

---

## System Architecture

The system follows a role-based separation model:

### 1️⃣ Administrative Desktop Application (Windows Forms)

Designed for internal staff to manage operational workflows securely and efficiently.

**Core Capabilities:**
- View daily appointment schedules
- Manage patient records (Create, Read, Update, Delete)
- Add, edit, and remove appointments
- Generate invoices linked to completed appointments
- Structured tab-based navigation for operational clarity

The administrative system focuses on workflow efficiency, data accuracy, and controlled record management.

---

### 2️⃣ Patient Web Application

Designed as a user-friendly portal for patients to interact with the practice.

**Core Capabilities:**
- Secure login based on stored patient credentials
- Personalised dashboard upon authentication
- View and manage upcoming appointments
- Update personal details and change password
- Book appointments (restricted to authenticated users)
- Informational pages (About, Contact, Reviews)
- Service showcase via landing page carousel

Session cookies are used for temporary authentication management during active sessions.

---

## Design Considerations

- Clear separation between administrative and patient roles  
- Input validation to protect data integrity  
- Structured workflow logic for appointment-to-invoice lifecycle  
- Encapsulation of business logic within modular components  
- Maintainable class structure following OOP best practices  

The application was built with scalability in mind, allowing future migration to a service-oriented or API-driven architecture.

---

## Demo

Video demonstrations of both applications are included below:

- Admin Application Demo: [demo1.zip](https://github.com/user-attachments/files/18588286/demo1.zip)
- Patient Application Demo: [demo2.zip](https://github.com/user-attachments/files/18588298/demo2.zip)

Demo credentials are available within the seeded development data for testing purposes.

---

## Key Learning Outcomes

Through this project, I strengthened my ability to:

- Design structured, multi-layered applications in C#
- Implement role-based system logic
- Manage relational data workflows
- Apply clean, readable code practices
- Debug and refactor for improved maintainability
- Think in terms of full-system lifecycle rather than isolated features

---

## Future Improvements

- Migration to ASP.NET Core Web API backend
- Implementation of Entity Framework Core
- Role-based authentication with Identity
- RESTful service layer separation
- Unit testing implementation
- Azure cloud deployment with CI/CD pipeline

---

## Summary

Brighton Medical Management System demonstrates my ability to build structured, role-driven applications using .NET technologies.  

The project reflects practical software engineering principles including separation of concerns, workflow modelling, validation, and maintainability.

---

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/LauraBailie/Brighton_Medical.git

2. Open in Visual Studio

3. Build and run the project
