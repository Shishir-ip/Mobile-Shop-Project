# Mobile-Shop-Project

A Windows Forms desktop e-commerce application for selling mobile phones. Built with C# and .NET 8, using SQL Server Express as the local database.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies](#technologies)
- [Prerequisites](#prerequisites)
- [Setup & Installation](#setup--installation)
- [Database Schema](#database-schema)
- [Project Structure](#project-structure)
- [Key Code Entrypoints](#key-code-entrypoints)
- [Demo Flow](#demo-flow)
- [Security & Limitations](#security--limitations)
- [Suggested Improvements](#suggested-improvements)
- [Sample Data](#sample-data)
- [License](#license)

---

## Overview

MobileShop is a simple e-commerce desktop application focused on mobile phone sales. It provides product browsing, shopping cart management, checkout with multiple payment options, user authentication, and an admin panel for product and order management.

---

## Features

- **Product Browsing** — View products with images, search, and sort functionality
- **Product Details** — Detailed view with specifications
- **Shopping Cart** — Per-user cart with quantity management
- **Checkout** — Cash on Delivery (COD) and online payment (bKash) support
- **User Management** — Register, login, and forgot password functionality
- **Admin Panel** — CRUD operations on products and order viewing
- **Local Database** — SQL Server Express backend

---

## Technologies

| Layer | Technology |
|-------|-----------|
| UI | Windows Forms (WinForms) |
| Language | C# |
| Framework | .NET 8 |
| Database | Microsoft SQL Server Express |
| IDE | Visual Studio 2022 |
| DB Tool | SQL Server Management Studio (SSMS) |

---

## Prerequisites

- Windows OS
- .NET 8 Runtime & SDK installed
- SQL Server Express installed and running (instance: `.\SQLEXPRESS`)
- Visual Studio 2022 (recommended)

---

## Setup & Installation

1. Clone or open the solution in **Visual Studio 2022**
2. Restore NuGet packages and build the solution
3. Ensure SQL Server Express is running
4. Create a database named `MobileShop`
5. Run the SQL scripts from the [Database Schema](#database-schema) section to create tables
6. Place product image files on disk and update `ImagePath` fields accordingly
7. Run the application (`Program.cs` entry point launches `Form1`)

---

## Database Schema

```sql
CREATE TABLE Users (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Name NVARCHAR(200),
  Email NVARCHAR(200) UNIQUE,
  Phone NVARCHAR(50),
  Password NVARCHAR(200),
  Role NVARCHAR(50)
);

CREATE TABLE Products (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  Name NVARCHAR(200),
  Brand NVARCHAR(100),
  Model NVARCHAR(100),
  Price DECIMAL(18,2),
  Stock INT,
  ImagePath NVARCHAR(500),
  Specifications NVARCHAR(MAX)
);

CREATE TABLE Cart (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  UserId INT,
  ProductId INT,
  Quantity INT,
  FOREIGN KEY (UserId) REFERENCES Users(Id),
  FOREIGN KEY (ProductId) REFERENCES Products(Id)
);

CREATE TABLE Orders (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  UserId INT,
  CustomerName NVARCHAR(200),
  Phone NVARCHAR(50),
  Address NVARCHAR(500),
  TotalAmount DECIMAL(18,2),
  PaymentMethod NVARCHAR(50),
  TransactionId NVARCHAR(200),
  CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE OrderItems (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  OrderId INT,
  ProductId INT,
  Quantity INT,
  Price DECIMAL(18,2),
  FOREIGN KEY (OrderId) REFERENCES Orders(Id),
  FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
