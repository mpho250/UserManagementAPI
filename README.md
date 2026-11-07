User Management API

Project Description

The User Management API is a RESTful web API developed using C# and ASP.NET Core.

It allows users to be created, retrieved, updated and deleted through CRUD operations.

Features

GET: Retrieve all users or a specific user by ID.

POST: Create a new user.

PUT: Update existing user information.

DELETE: Remove a user.

Data Validation: Validate names, email addresses and age.

Logging Middleware: Record incoming HTTP requests and response status codes.

Error Handling: Return appropriate HTTP status codes when users are not found or invalid data is submitted.

Technologies Used

C#

ASP.NET Core Web API

.NET 8

GitHub

GitHub Copilot

API Endpoints

Method

Endpoint

Purpose

GET

/api/users

Get all users

GET

/api/users/{id}

Get user by ID

POST

/api/users

Create a user

PUT

/api/users/{id}

Update a user

DELETE

/api/users/{id}

Delete a user
