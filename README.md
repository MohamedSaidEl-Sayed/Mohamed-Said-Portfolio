# 🌐 Mohamed Said | Personal Portfolio Website

[![GitHub](https://img.shields.io/badge/GitHub-Repository-blue?logo=github)](https://github.com/MohamedSaidEl-Sayed/Mohamed-Said-Portfolio)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Framework-purple)](https://dotnet.microsoft.com/)
[![Blazor Server](https://img.shields.io/badge/Blazor-Server-blueviolet)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind-CSS-38B2AC?logo=tailwindcss&logoColor=white)](https://tailwindcss.com/)

> **Personal Website** – A fully-featured, visually appealing personal portfolio  
> 📅 **Start Date:** 2025  
> 👨‍💻 **Developer:** [Mohamed Said El-Sayed](https://github.com/MohamedSaidEl-Sayed)

---

## 📋 Table of Contents

- [📌 Project Overview](#-project-overview)
- [🛠️ Technologies Used](#️-technologies-used)
- [✨ Features](#-features)
- [🚀 Getting Started](#-getting-started)
- [🔧 Installation Guide](#-installation-guide)
- [📁 Project Structure](#-project-structure)
- [📸 Application Screenshots](#-application-screenshots)
- [🤝 Contributing](#-contributing)

---

## 📌 Project Overview

This project is a professional **.NET 8 Blazor Server**-based personal portfolio designed to highlight development skills, personal branding, and previous work in a dynamic and interactive way.

It allows the admin to manage content via a powerful backend and showcases experiences, projects, courses, blog posts, contact icons, and skills. 

### 🔍 Key Highlights

- Fully responsive user interface using **Tailwind CSS**
- Built-in admin section for managing website content
- Clean code, scalable structure, and minimal dependencies
- Can be deployed on **IIS**, **Azure**, or any cloud/VPS

---

## 🛠️ Technologies Used

### Backend

- **.NET 8** with **Blazor Server**
- **ASP.NET Core Identity** (Optional – depends on your actual implementation)
- **Entity Framework Core** for ORM
- **SQL Server** for the database

### Frontend

- **Blazor Components** (Razor)
- **Tailwind CSS v4.1** for modern styling
- **JavaScript Interop** (for DOM manipulation or third-party integrations)

### Development Tools

- **Visual Studio 2022+**
- **SQL Server Management Studio**
- **Git** for version control
- **Node.js + npm** for Tailwind CLI build

---

## ✨ Features

### 🎯 Portfolio & Presentation
- Show **Personal Info** Name, Job Title, Summary and Personal Image
- Showcase **projects** with used skills, videos and images
- Present **courses** and educational achievements
- Highlight **technical skills** and competencies
- List **contact methods** like GitHub, LinkedIn, etc.
- **Blog Page** to Share Experiences and knowledge

### 🔐 Admin Dashboard
- **Manage Personal Info**: Create, update, or delete personal Info
- **Manage Projects**: Create, update, or delete personal projects
- **Manage Courses**: Display courses with details and links
- **Skills Section**: Add/edit technical or soft skills
- **Blog Page**: Post articles or professional thoughts
- **Contact Icons**: Dynamically manage social/contact links

### 📈 Performance & Design
- SEO-ready layout with proper metadata
- Dark mode / light mode (optional via Tailwind)
- Smooth transitions and animations

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/)
- [Node.js + npm](https://nodejs.org/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/)
- Visual Studio 2022+ (Blazor & EF support)

### System Requirements

| Component       | Minimum                |
|------------------|-------------------------|
| OS               | Windows 10/11 or Linux/macOS |
| RAM              | 4 GB (8 GB recommended) |
| Disk Space       | 2 GB free               |

---

## 🔧 Installation Guide

### 1. Clone the Repository

```bash
git clone https://github.com/MohamedSaidEl-Sayed/Mohamed-Said-Portfolio.git
cd Mohamed-Said-Portfolio
```

### 2. Restore NuGet Packages and npm packages
```bash
dotnet restore
npm install
```
### 🎨 Tailwind CSS Setup

This project uses [Tailwind CSS v4+](https://tailwindcss.com) with the new config-less setup.

- `input.css` – contains your theme colors, safelists, and source styles.
- `output.css` – the compiled Tailwind CSS (already included, no build step required).

#### 🔧 Want to customize the design?
Edit `input.css` directly.

#### 🔁 Want to recompile Tailwind CSS?
```bash
npx tailwindcss -i ./wwwroot/input.css -o ./wwwroot/output.css --watch
```

### 3. Database Setup
Update the connection string in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PersonalPortfolioDB;Trusted_Connection=true;MultipleActiveResultSets=true"  (e.g. your connection)
  }
}
```

### 4. Apply Database Migrations
```bash
dotnet ef database update
```

### 5. Build and Run the Application
```bash
dotnet build
dotnet run
```

The application will be available at: `https://localhost:5001` or `http://localhost:5000`

---

## 📁 Project Structure

### 🏠 Solution
![Solution](https://github.com/MohamedSaidEl-Sayed/Mohamed-Said-Portfolio/blob/main/ScreenShots/Project_Structure1.png)

---

### 🚀 Blazor Server Project
![Blazor Server Project](https://github.com/MohamedSaidEl-Sayed/Mohamed-Said-Portfolio/blob/main/ScreenShots/Project_Structure2.png)

---

### Three Class libraries
- ```🧠 Core – Domain models, interfaces, business logic```
- ```🏗️ Infrastructure – Data access, EF Core, external services```
- ```📦 Shared – DTOs, constants, common utilities```
  
![Core-Infrastructure-Shared](https://github.com/MohamedSaidEl-Sayed/Mohamed-Said-Portfolio/blob/main/ScreenShots/Project_Structure3.png)

---

## 📱 Application Screenshots

### 🏠 Home Page
![Main Page](https://github.com/MohamedSaidEl-Sayed/Al-Araby/blob/main/Demo_ScreenShots/MainPage.png)

---

### 👨‍🏫 Manage Resourses
![Manage Resourses](https://github.com/MohamedSaidEl-Sayed/Al-Araby/blob/main/Demo_ScreenShots/ManagedResources.png)

---

### 📚 Exams
![Examst](https://github.com/MohamedSaidEl-Sayed/Al-Araby/blob/main/Demo_ScreenShots/Exams.png)

---

### 📊 Quiz Management System
![Quiz Management](https://github.com/MohamedSaidEl-Sayed/Al-Araby/blob/main/Demo_ScreenShots/QuizManagement.PNG)

---

### 🎬 Videos
![Videos](https://github.com/MohamedSaidEl-Sayed/Al-Araby/blob/main/Demo_ScreenShots/Videos.png)

---

## 🤝 Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request
---

**⭐ If you find this project helpful, please consider giving it a star on GitHub!**

---

*Last Updated: May 2025*
