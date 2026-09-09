# projectChurch – Mobile Church Application

**projectChurch** is a cross-platform church application developed using **.NET MAUI and C#**. The application provides users with convenient access to church hymns, creeds, search functionality, and saved content through a simple and user-friendly mobile interface.

The project is being developed as a practical software development project to demonstrate skills in **C#, .NET MAUI, XAML, MVVM architecture, SQLite, database management, UI development, debugging, and performance optimization**.

---

## Project Overview

The purpose of projectChurch is to provide a digital platform for accessing important church content from a mobile device.

Instead of relying entirely on physical books or documents, users can access church material directly from the application.

The application currently focuses on:

* Hymns
* Creeds
* Content searching
* Saved content
* Mobile-friendly navigation
* Light and dark themes
* Local database storage

---

## Current Features

### Home Page

Provides access to the main sections of the application.

### Hymns

Users can browse available hymns and open individual hymns to view their content.

### Creeds

Users can browse and read available creeds.

### Search

Users can search for church content without having to manually browse through large lists.

### Saved Content

Users can save important or frequently used content for quick access later.

### Theme Support

The application supports different visual themes to improve the user experience.

### Database

Church content is stored and retrieved using a database rather than hard-coding large amounts of content directly into the application.

---

# Application Architecture

The application follows the **MVVM (Model-View-ViewModel)** architecture.

```text
projectChurch
│
├── Models
│
├── Views
│
├── ViewModels
│
├── Services
│
├── Resources
│   ├── Images
│   ├── Fonts
│   └── Raw
│
├── App.xaml
├── AppShell.xaml
└── projectChurch.csproj
```

### Model

Models represent the application's data.

Examples include church content such as hymns and creeds.

### View

Views represent the application's user interface.

### ViewModel

ViewModels contain the presentation logic and connect the user interface with the underlying data and services.

### Services

Services handle application functionality such as database operations.

---

# Technologies Used

* **C#**
* **.NET MAUI**
* **XAML**
* **MVVM**
* **SQLite**
* **SQL**
* **Visual Studio 2022**
* **Git**
* **GitHub**

---

# Database

The application uses SQLite for storing and retrieving church content.

The database layer is responsible for operations such as:

* Retrieving hymns
* Retrieving creeds
* Searching content
* Loading individual content
* Managing saved content
* Supporting efficient data access

The application is being developed with performance in mind because a large collection of church content can affect mobile application performance.

---

# Search Functionality

The application allows users to search through church content.

The search functionality is intended to make it easier to find specific material by searching information such as:

* Hymn titles
* Hymn content
* Creed titles
* Creed content

---

# Known Issues

## Mobile Performance

One of the current issues with the application is **mobile performance**.

The application can become slow when working with a large amount of content, particularly when loading or displaying data on mobile devices.

### Planned investigation

Future development will investigate:

* Database query optimization
* Pagination
* Lazy loading
* Reducing unnecessary data loading
* CollectionView performance
* UI rendering performance
* Memory usage
* Background data loading
* Caching where appropriate

### GitHub Issue

**Issue: Improve Mobile Application Performance**

> Investigate and improve the application's performance on mobile devices. The application should load and display church content efficiently without unnecessary delays, freezing, or excessive memory usage.

---

# Future Security Feature

A planned feature is to introduce **security access for the application**.

The intended functionality is for an authorized user to enter a **unique password/access code** that is associated with a specific application installation/device.

The goal is to prevent unauthorized users from simply installing the application and accessing protected content.

### Planned concept

```text
Install Application
       ↓
Application generates/identifies installation
       ↓
Security Access Screen
       ↓
Enter unique access password
       ↓
Verify access
       ↓
Application unlocked
```

### Important security consideration

The final implementation will need to securely handle authentication credentials and device identification. Passwords should **not** be stored as plain text.

The implementation will be researched and designed carefully before being added to the production version.

### GitHub Issue

**Issue: Implement Device-Bound Security Access**

> Develop a secure authentication/access system where a unique password or access credential can be associated with a specific application installation/device. Investigate secure credential storage, device identification, authentication, and protection against unauthorized access.

---

# Future Features

The following features are planned for future versions:

* Device-bound security access
* Mobile performance optimization
* Notifications
* Church events
* Church announcements
* Improved bookmarking
* Advanced search
* Content sharing
* Cloud synchronization
* Online/offline synchronization
* User accounts
* Additional themes
* Improved Android support
* Improved Windows support

---

# Project Status

**Status: In Development**

projectChurch is an ongoing development project.

Current priorities include:

1. Improving mobile performance
2. Optimizing database access
3. Improving search functionality
4. Implementing secure application access
5. Improving the overall user interface
6. Testing across different devices

---

# Application Preview

Screenshots will be added as the application continues to develop.

```text
Coming soon...
```

---

# Getting Started

## Requirements

To run the project, you will need:

* Visual Studio 2022
* .NET MAUI workload
* .NET SDK compatible with the project
* Android SDK for Android development
* Git

## Clone the Repository

```bash
git clone https://github.com/PaballoPitso/Mobile_Church_App.git
```

Navigate into the project:

```bash
cd Mobile_Church_App
```

Open the solution in **Visual Studio 2022**.

Restore the required NuGet packages and build the solution.

You can run the application using:

* Android Emulator
* Physical Android Device
* Windows Machine

---

# Security

Sensitive information should never be committed to the repository.

Examples include:

* Passwords
* API keys
* Authentication credentials
* Private database credentials
* Personal documents
* Private configuration files

Development folders such as `.vs`, `bin`, and `obj` should also be excluded through `.gitignore`.

---

# Skills Demonstrated

This project demonstrates practical experience with:

* C# programming
* .NET MAUI development
* XAML
* MVVM architecture
* SQLite
* Database integration
* CRUD operations
* Search functionality
* Application navigation
* Mobile UI development
* Debugging
* Performance optimization
* Git version control
* GitHub
* Cross-platform development
* Problem solving
* Software development lifecycle

---

# Developer

**Paballo Pitso**

**Diploma in Information Technology**

This project forms part of my practical software development portfolio and demonstrates my ability to design, develop, troubleshoot, improve, and maintain a cross-platform application.

---

# License

This project is currently intended for educational, development, and portfolio purposes.
