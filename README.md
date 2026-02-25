# 🧠 MvcSqlMongoDemo

Proyecto ASP.NET Core MVC que integra bases de datos relacionales y NoSQL en una misma aplicación.

---

## 📌 Descripción

**MvcSqlMongoDemo** es una aplicación desarrollada en ASP.NET Core MVC que demuestra la integración híbrida entre:

- SQL Server para almacenamiento relacional de usuarios.
- MongoDB Atlas para almacenamiento NoSQL de registros de acceso.
- Entity Framework Core para la gestión de datos relacionales.
- MongoDB.Driver para operaciones sobre documentos.

El objetivo del proyecto es evidenciar cómo combinar ambos motores de base de datos dentro de una arquitectura MVC moderna.

---

## 🎯 Objetivo del Proyecto

Demostrar la integración práctica de:

- Base de datos relacional (SQL Server)
- Base de datos NoSQL (MongoDB)
- Arquitectura MVC
- Buenas prácticas de organización y separación de responsabilidades

---

## 🏗️ Arquitectura

La aplicación sigue el patrón **MVC (Model-View-Controller)**:

- **Models** → Representan las entidades del sistema.
- **Controllers** → Gestionan la lógica y las peticiones HTTP.
- **Views** → Interfaz de usuario.
- **Data / Services** → Acceso y gestión de bases de datos.

---


## 🛠️ Tecnologías Utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- MongoDB Atlas
- MongoDB.Driver
- Git
- GitHub

---

## 📂 Estructura del Proyecto

Controllers/  
Models/  
Data/  
Services/  
Views/  
wwwroot/

---

## 🔄 Flujo del Sistema

- El usuario accede a la aplicación.
- Los datos de usuarios se almacenan en SQL Server.
- Los registros de acceso se guardan en MongoDB Atlas.
- La aplicación muestra información proveniente de ambos motores.

---

## 📊 Diagrama de Flujo

### 📖 Descripción del Diagrama

El diagrama representa la arquitectura híbrida del sistema:

- El cliente interactúa con la aplicación MVC.
- El controlador centraliza la lógica de negocio.
- Dependiendo del tipo de operación, la aplicación redirige el flujo hacia:
  - **SQL Server** para operaciones estructuradas (Usuarios).
  - **MongoDB Atlas** para almacenamiento flexible de registros (Logs de acceso).
- Finalmente, los datos procesados se presentan en la interfaz web.

Este flujo demuestra la separación de responsabilidades entre bases de datos relacionales y NoSQL dentro de un mismo proyecto.

<img width="1024" height="1536" alt="ChatGPT Image Feb 24, 2026, 10_07_54 PM" src="https://github.com/user-attachments/assets/23a12bd1-5aac-41da-abd3-fffab3617f3b" />

---

## 👨‍💻 Integrantes del Grupo 4

Jeurys José Durán Beato - A00115777

Bladimir Ventura - A00115757

Ángel Javier Barrientos - A00115984

Miguel José Saint Hilaire Peña - A00116662

Sean Alcántara Carrera - A00115911 

Bladimir Ventura - A00115757
