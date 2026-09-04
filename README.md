# 📱 MobileShop Management System

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-11.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-Express-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-Desktop-0078D4?style=for-the-badge&logo=windows&logoColor=white)

A comprehensive desktop-based retail management system for mobile phone shops, built with **C#**, **Windows Forms (.NET 8)**, and **SQL Server**. It features complete user authentication, a dynamic product catalog, shopping cart functionality, checkout processing, and a dedicated admin dashboard for inventory management.

 **Live Project Overview & Architecture Visualization**: [mobile-shop-project-azure.vercel.app](https://mobile-shop-project-azure.vercel.app)

---

##  Table of Contents

- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Database Schema](#-database-schema)
- [Installation](#-installation)
- [Usage Guide](#-usage-guide)
- [Project Structure](#-project-structure)
- [Screenshots](#-screenshots)
- [Security Notes](#-security-notes)
- [License](#-license)

---

## ✨ Features

### 👤 Customer Features
- **User Authentication**: Secure login, registration, and multi-step password recovery (Email + Phone verification).
- **Product Catalog**: Browse mobile phones with images, brand, model, prices, and dynamic discount badges.
- **Search & Sort**: Real-time product filtering by name and sorting by price or alphabetical order.
- **Shopping Cart**: Add items, increment/decrement quantities, remove items, and view real-time total calculations.
- **Checkout System**: Seamless order placement with support for **Cash on Delivery (COD)** and **Online Payments (bKash)**.
- **Order Confirmation**: Dedicated success screen displaying the generated Order ID.

### 🔧 Admin Features
- **Role-Based Access**: Dedicated admin panel accessible only to users with the `'Admin'` role.
- **Product Management**: Full CRUD (Create, Read, Update, Delete) operations for the product catalog.
- **Image Handling**: Browse and upload local product images directly through the UI.
- **Inventory Tracking**: Automatic stock deduction upon successful order placement.
- **Order Management**: View all customer orders, transaction details, and payment methods.

---

## ️ Tech Stack

| Technology | Version | Purpose |
|------------|---------|---------|
| **.NET** | 8.0 | Core Framework |
| **C#** | 11.0 | Programming Language |
| **Windows Forms** | Latest | Desktop UI Framework |
| **SQL Server Express** | Latest | Relational Database |
| **ADO.NET** | Latest | Data Access Layer (`System.Data.SqlClient`) |

---

## 🗄️ Database Schema

The database is normalized up to **3NF (Third Normal Form)** to eliminate redundancy and prevent update anomalies. It consists of 5 core tables:

1. **Users**: Stores customer/admin credentials and roles.
2. **Products**: Catalog of mobile phones (Name, Brand, Price, Stock, ImagePath, etc.).
3. **Cart**: Temporary storage for user shopping sessions.
4. **Orders**: Header information for placed orders (Total, Payment Method, Address).
5. **OrderItems**: Line items linking Orders to Products with historical pricing.

---

## 🚀 Installation

### Prerequisites
- **Visual Studio 2022** (with ".NET Desktop Development" workload installed)
- **SQL Server Express** (Local instance: `.\SQLEXPRESS`)
- **SQL Server Management Studio (SSMS)** (Optional, for database setup)

### Step-by-Step Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/Shishir-ip/Mobile-Shop-Project.git
   cd Mobile-Shop-Project
   ```

2. **Set up the database**
   - Open **SQL Server Management Studio (SSMS)** and connect to `.\SQLEXPRESS`.
   - Create a new database named **`MobileShop`**.
   - Execute the SQL script to create tables and insert sample data.

3. **Open the project**
   - Launch **Visual Studio 2022**.
   - Open `MobileShop.sln` (solution file in the root directory).

4. **Verify Connection String**
   
   The application uses the following default connection string:
   ```
   Data Source=.\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True
   ```
   
   If your SQL Server instance name is different, update the `conString` variable in these files:
   - `MobileShop/Form1.cs`
   - `MobileShop/LoginForm.cs`
   - `MobileShop/CheckoutForm.cs`

5. **Build and Run**
   - Press **F5** or click the **Start** button in Visual Studio to launch the application.

---

##  Usage Guide

### First-Time Setup

1. **Create an Admin Account**:
   - Register a new user through the application's Registration form.
   - Open SQL Server Management Studio and run this query:
   ```sql
   UPDATE Users SET Role = 'Admin' WHERE Email = 'your-email@example.com';
   ```

2. **Login**: Use your credentials. Admin users will automatically be routed to the `AdminForm`, while regular users will see the `Form1` storefront.

### Customer Workflow

1. Register → Login → Browse Products
2. Add desired items to the cart
3. Click "Buy Now" to proceed to checkout
4. Enter shipping address and select a payment method (COD or bKash)
5. Place the order and receive the Order ID confirmation

### Admin Workflow

1. Login with an Admin account
2. Access the Admin Dashboard
3. Add new products (including uploading images from your local machine)
4. Edit existing product details or delete items
5. Monitor incoming customer orders and inventory stock levels

---

## 📁 Project Structure

```
Mobile-Shop-Project/
│
├──  MobileShop.sln                 # Visual Studio Solution file
├── 📄 MobileShop_db.sql              # Database setup script
── 📄 index.html                     # Project visualization page
│
├──  MobileShop/                    # Main C# Project Folder
│   ├── 📂 Images/                    # Product images
│   ├── 📂 bin/Debug/                 # Compiled binaries
│   ├── 📂 obj/                       # Build objects
│   │
│   ├── 📄 Program.cs                 # Application entry point
│   ├── 📄 Session.cs                 # User session management
│   │
│   ├── 📄 Form1.cs                   # Main storefront UI
│   ├── 📄 Form1.Designer.cs
│   ├── 📄 Form1.resx
│   │
│   ├── 📄 LoginForm.cs               # User authentication
│   ├── 📄 LoginForm.Designer.cs
│   ├── 📄 LoginForm.resx
│   │
│   ├── 📄 RegisterForm.cs            # User registration
│   ├── 📄 RegisterForm.Designer.cs
│   ├── 📄 RegisterForm.resx
│   │
│   ├── 📄 ForgotPasswordForm.cs      # Password recovery
│   ├── 📄 ForgotPasswordForm.Designer.cs
│   ├── 📄 ForgotPasswordForm.resx
│   │
│   ├── 📄 ProductDetailsForm.cs      # Product details view
│   ├── 📄 ProductDetailsForm.Designer.cs
│   ├── 📄 ProductDetailsForm.resx
│   │
│   ├── 📄 CheckoutForm.cs            # Order processing
│   ├── 📄 CheckoutForm.Designer.cs
│   ├── 📄 CheckoutForm.resx
│   │
│   ├── 📄 AdminForm.cs               # Admin dashboard
│   ├── 📄 AdminForm.Designer.cs
│   ├── 📄 AdminForm.resx
│   │
│   ├── 📄 OrderSuccessForm.cs        # Order confirmation
│   ├── 📄 OrderSuccessForm.Designer.cs
│   ├── 📄 OrderSuccessForm.resx
│   │
│   └──  MobileShop.csproj          # Project file
│
└── 📂 .vs/                           # Visual Studio cache
```

---

##  Screenshots

*Add your actual screenshots by replacing the placeholder links below*

### Login & Registration
![Login Screen](https://via.placeholder.com/600x400/512BD4/FFFFFF?text=Login+Screen)

### Main Storefront
![Product Catalog](https://via.placeholder.com/600x400/239120/FFFFFF?text=Product+Catalog)

### Shopping Cart
![Shopping Cart](https://via.placeholder.com/600x400/CC2927/FFFFFF?text=Shopping+Cart)

### Admin Dashboard
![Admin Panel](https://via.placeholder.com/600x400/0078D4/FFFFFF?text=Admin+Panel)

---

## 🔐 Security Notes

> ⚠️ **Disclaimer**: This project was developed primarily for **educational and academic purposes** to demonstrate fundamental desktop application development concepts.

For production environments, the following security improvements are highly recommended:

1. **Password Hashing**: Currently, passwords are stored in plaintext. Implement `bcrypt` or `Argon2` hashing with per-user salts.
2. **SQL Injection Prevention**: Some queries in `CheckoutForm.cs` use string concatenation. Refactor to use strictly parameterized `SqlParameter` objects.
3. **Input Validation**: Add comprehensive Regex validation for emails, phone numbers, and numeric inputs.
4. **Configuration**: Move the hardcoded connection string to `App.config` or environment variables.

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** your changes (`git commit -m 'Add some AmazingFeature'`)
4. **Push** to the branch (`git push origin feature/AmazingFeature`)
5. **Open** a Pull Request

---

##  License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 👨💻 Author

**Shishir**  
- GitHub: [@Shishir-ip](https://github.com/Shishir-ip)  
- Project Repo: [Mobile-Shop-Project](https://github.com/Shishir-ip/Mobile-Shop-Project)

---

<p align="center">
  <strong>⭐ If you found this project helpful, please consider giving it a star!</strong>
</p>

<p align="center">
  Made with ❤️ using C# and .NET 8
</p>
