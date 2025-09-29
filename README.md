# Student Marketplace

**Student Marketplace** is a web application built with **ASP.NET MVC** that allows students to buy, sell, and trade items within their campus or community. The platform provides user authentication, product listings, and an admin panel for managing users, products, and messages.

---

## Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Usage](#usage)
- [Database](#database)
- [Folder Structure](#folder-structure)
---

## Features

- User authentication and authorization (Student login/signup).  
- Add, update, and delete **product listings**.  
- Support for **Digital and Non-Digital Products**:
  - **Digital products** (e.g., notes, PDFs) have **price = 0** and can be downloaded directly.  
  - **Non-digital products** (e.g., stationery, books) have a regular price and can be traded or purchased.  
- View product listings with search and filter options.  
- **Contact Us page** for users to send messages or queries:
  - Users can submit name, email, subject, and message.  
  - Admin can view messages in the dashboard.  
- Admin panel to manage users, products, and messages.  
- Option to contact seller via email or in-app messaging.  
- Responsive design for desktop and mobile.  

---

## Tech Stack

- **Frontend:** HTML, CSS, Bootstrap, Razor Views  
- **Backend:** ASP.NET MVC (C#)  
- **Database:** SQL Server  
- **Tools:** Visual Studio, SQL Server Management Studio  

---
### Usage

Signup/Login as a student.

Browse products by category or search keywords.

Add products you want to sell:

For digital products, upload files (PDF, notes, etc.) and set price = 0.

For non-digital products, set regular price and upload images.

Edit/Delete your own listings.

Contact Us: Navigate to the Contact page to send messages to admin.

Admin can view all users, products, and contact messages from the Admin Panel.

Digital products can be downloaded directly, while non-digital products follow normal trade or offline payment process.

### Database

Use SQL Server or MySQL to store user, product, and contact data.

Sample tables:

Users

Id

Name

Email

PasswordHash

Role

Categories

Id

Name

Products

Id

Title

Description

Price (0 for digital products)

IsDigital (Boolean)

FileUrl (for digital products)

ImageUrl (for non-digital products)

UserId (seller)

CategoryId

Orders (if implemented)

Id

ProductId

BuyerId

Amount

Status

ContactMessages

Id

Name

Email

Subject

Message

CreatedAt (timestamp)
---

### Folder Structure
StudentMarketplace/
│
├─ Controllers/          # MVC controllers
├─ Models/               # C# models
├─ Views/                # Razor views
├─ Scripts/              # JavaScript files
├─ Content/              # CSS, images
├─ App_Data/             # Database files if local
├─ Web.config            # Configuration file
└─ README.md


