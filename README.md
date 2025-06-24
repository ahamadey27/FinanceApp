# FinanceApp
Building a Personal Finance Tracker: A Comprehensive Guide to ASP.NET Core MVC and Entity Framework

## Project Overview
FinanceApp is a personal finance management web application built with ASP.NET Core MVC. It provides a clean, intuitive platform for tracking personal expenses with visual analytics through interactive charts. The project demonstrates modern web development practices using the MVC architectural pattern and is designed for learning, portfolio showcase, and real-world expense tracking scenarios.

## Features
- **Expense Management**: Add, view, and categorize personal expenses
- **Interactive Data Visualization**: Dynamic pie charts showing expense breakdown by category
- **Form Validation**: Client-side and server-side validation for data integrity
- **Responsive Design**: Bootstrap-powered responsive UI that works on all devices
- **Database Integration**: Entity Framework Core with SQL Server for data persistence
- **Service Layer Architecture**: Clean separation of concerns with service pattern implementation
- **Date Tracking**: Automatic timestamping of expenses with formatted date display
- **Category-based Analytics**: Group and analyze expenses by user-defined categories

## How It Was Built
- **Backend:** ASP.NET Core 9.0 MVC, Entity Framework Core, Repository/Service Pattern
- **Frontend:** Razor Views, Bootstrap 5, Chart.js for data visualization
- **Database:** SQL Server with Entity Framework migrations
- **Architecture:** Model-View-Controller (MVC) pattern with service layer
- **Validation:** Data annotations with client-side jQuery validation
- **Charts:** Chart.js integration for interactive pie charts

## Key Technologies
- **.NET 9.0** - Latest .NET framework
- **Entity Framework Core** - Object-relational mapping
- **SQL Server** - Database backend
- **Bootstrap** - Responsive CSS framework  
- **Chart.js** - JavaScript charting library
- **jQuery Validation** - Client-side form validation

## Database Schema
The application uses a simple but effective schema:
- **Expenses Table**: Id, Description, Amount (decimal), Category, Date
- **Decimal Precision**: 18,2 for accurate financial calculations
- **Data Validation**: Required fields with range validation for amounts

---
Feel free to use this project in your portfolio or as a learning resource for ASP.NET Core MVC development. The clean architecture and modern practices make it an excellent foundation for expanding into a full-featured personal finance application.
