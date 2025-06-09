# Wadele Courier System (ودّيلي)

## Overview

**Wadele Courier System** is a desktop application developed in C# using Windows Forms, designed for managing courier operations efficiently. The system targets courier companies and service administrators, providing them with tools to manage customers, couriers, and orders through a user-friendly interface.

The application uses an Oracle Database as its backend, facilitating robust storage and queries for operational data.

---

## Features

- **Admin Panel**  
  A dedicated interface for administrators to:
  - View and edit customer, courier, and order records.
  - Load data from the Oracle backend into interactive tables.
  - Save changes back to the database with a single click.
  
- **Data Management**  
  - Edit and update information for customers, couriers, and orders.
  - Use radio buttons to toggle between data categories.
  - Display records in a grid view for easy navigation and editing.

- **Modern UI**  
  - Professional layout with intuitive controls.
  - Multilingual support, including Arabic branding.

---

## Folder Structure

```
Wadele_Hatwadeha-Fean/
├── Documentation.docx         # Project and user documentation (Word)
├── SQL_Code.docx              # SQL database schema and sample queries (Word)
└── Waddele_Main/
    ├── Waddele_Main.sln           # Visual Studio solution file
    └── Waddele_Main/
        ├── Admin.cs               # Main Admin panel code
        ├── Admin.Designer.cs      # UI design code for Admin panel
        ├── Admin.resx             # UI resources (strings, images, etc.)
        ├── images/                # (Optional) UI images/resources
        ├── bin/                   # Output binaries (auto-generated)
        └── Properties/            # Project properties and settings
```

---

## Setup Instructions

### Prerequisites

- **Windows OS** (for running WinForms apps)
- **Visual Studio 2019/2022** (or compatible)
- **.NET Framework 4.x**
- **Oracle Database** (tested with default `scott/tiger` user)
- **Oracle Data Access Components (ODAC)** installed

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/ahmedreda38/Wadele-Courier-System-.git
   ```
2. **Open the Solution**
   - Open `Waddele_Main.sln` in Visual Studio.

3. **Restore Dependencies**
   - Ensure Oracle Data Access references are resolved.  
     If not, add the appropriate Oracle.DataAccess DLLs.

4. **Configure Database**
   - Update the connection string in `Admin.cs` if your database credentials differ:
     ```csharp
     string constr = "Data Source=orcl; User Id=scott; Password=tiger;";
     ```
   - Refer to `SQL_Code.docx` for the required database schema and setup scripts.

5. **Build and Run**
   - Build the solution (`Ctrl+Shift+B`).
   - Run the project (`F5`).

---

## Usage Guide

1. **Admin Login**
   - (If authentication is present; otherwise, the main panel loads directly.)

2. **Main Admin Panel**
   - Use the radio buttons at the top to select Customers, Couriers, or Orders.
   - Click **"Load Information"** to populate the table with data from the database.
   - Edit records directly in the table/grid view.
   - Click **"Save edits"** to commit your changes to the database.

3. **Branding**
   - The application features the company name in Arabic (ودّيلي) and modern UI elements.

---

## Database

- The system connects to an Oracle Database.
- Default user: `scott`, password: `tiger`, data source: `orcl`.
- For table structure and sample data, see:  
  - [`SQL_Code.docx`](Wadele_Hatwadeha-Fean/SQL_Code.docx)

---

## Documentation

- **User and Developer Guide:**  
  - [`Documentation.docx`](Wadele_Hatwadeha-Fean/Documentation.docx)
- **Database Schema and Queries:**  
  - [`SQL_Code.docx`](Wadele_Hatwadeha-Fean/SQL_Code.docx)

---

## Screenshots
<h2 align="center">Screenshots</h2>

<p align="center">
  <img src="https://github.com/user-attachments/assets/1ba1d130-1957-419f-8a70-4d31c0232b70" alt="Logo" width="200"/>
</p>

<table>
  <tr>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/78c82bb1-8dde-4da1-878a-74226950f918" alt="Screenshot 1" width="320"/><br>
      <sub>Login Screen</sub>
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/1bcb08fb-2f23-446a-aa17-ebe9509a0cc9" alt="Screenshot 2" width="320"/><br>
      <sub>Main Dashboard</sub>
    </td>
  </tr>
  <tr>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/c2d301b4-2590-4353-8813-fa80c74ba1db" alt="Screenshot 3" width="320"/><br>
      <sub>Order Management</sub>
    </td>
    <td align="center">
      <img src="https://github.com/user-attachments/assets/f70f12a2-468d-44e8-bae9-e96214b74ffd" alt="Screenshot 4" width="320"/><br>
      <sub>Customer Records</sub>
    </td>
  </tr>
  <tr>
    <td align="center" colspan="2">
      <img src="https://github.com/user-attachments/assets/bd50942d-4a43-4ed9-9da9-4de9badce710" alt="Screenshot 5" width="320"/><br>
      <sub>Settings Panel</sub>
    </td>
  </tr>
</table>

---

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

---

## License

[MIT](LICENSE) (or specify your license here)

---

## Acknowledgements

- Developed using Microsoft Visual Studio and .NET WinForms.
- Oracle Database for backend support.

---

## Contact

For questions or support, please contact [ahmedreda38](https://github.com/ahmedreda38).
