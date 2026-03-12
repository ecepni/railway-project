PROJECT: RAILWAY MANAGEMENT SYSTEM

LIBRARIES USED (KULLANILAN KÜTÜPHANELER):
-----------------------------------------
1. ASP.NET Core Blazor (Web Framework)
2. Entity Framework Core (ORM for Database)
3. Microsoft.Data.SqlClient (SQL Server Provider)
4. Bootstrap (UI Styling)

HOW TO RUN THE PROJECT (ÇALIŞTIRMA ADIMLARI):
---------------------------------------------
STEP 1: DATABASE SETUP
   - Open SQL Server Management Studio (SSMS).
   - Open the file "RailwayDB_Setup.sql" (included in this zip).
   - Execute the script to create the database, tables, and triggers.

STEP 2: CONFIGURATION
   - Open the project in Visual Studio.
   - Open "appsettings.json" file.
   - Update the "ConnectionStrings" section with your own SQL Server name.

STEP 3: RUN
   - Press F5 or click the "Run" button in Visual Studio.
   - The application will open in your browser.

NOTE:
   - The project includes a "Wagon Weight Trigger" to prevent negative values.
   - Data Seeding is included in the SQL script.