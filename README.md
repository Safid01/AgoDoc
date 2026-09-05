# 🌾 AgroDoc - Smart Agricultural Management & Decision Support System

[![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/MS%20SQL%20Server-2022-CC292B?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server/)
[![Windows Forms](https://img.shields.io/badge/Platform-WinForms-0078D6?style=for-the-badge&logo=windows&logoColor=white)](https://github.com/Safid01/AgoDoc)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](LICENSE)

**AgroDoc** is an offline-capable Windows Forms desktop application engineered to streamline farm management, soil fertility diagnostics, crop recommendation, and agricultural inventory tracking. Built using **C# (.NET Framework 4.8)** and **Microsoft SQL Server 2022**, AgroDoc bridges empirical agronomic benchmarks (BARI / BRRI standards) with real-world farming operations.

---

## 📌 System Modules & Core Features

### 🌿 1. Soil Health Diagnostics & Visual Analytics (`FormSoilIndex.cs`)
* **NPK & pH Analysis:** Evaluates soil Nitrogen (N), Phosphorus (P), Potassium (K), and pH levels against optimal national agricultural benchmarks.
* **Dual-Series Visual Charting:** Interactive column chart (`MSChart`) comparing current soil test measurements side-by-side with national baseline targets.
* **Automated Agro-Doctor Diagnostics:** Generates instant health ratings (`Optimal & Fertile`, `Moderate/Deficient`, `Critical/Poor`) and targeted soil amendment recommendations (e.g., Dolomite Lime for acidity, Gypsum for alkalinity).
* **Test History Ledger:** Logs and displays historical soil diagnostic tests per farmer account.

### 🌾 2. Smart Crop Recommendation Engine (`FormCropSuggestion.cs`)
* **Temporal Cultivation Window:** Calculates available growing duration based on planting and targeted harvest dates:
  $$\Delta \text{Days} = \text{HarvestDate} - \text{PlantingDate}$$
* **Multi-Constraint Querying:** Filters viable seasonal crops using `CropRepository.cs` and `Crop.cs` models based on regional climate, soil texture compatibility, and growing duration.
* **Nutrient Thresholds:** Displays optimal NPK ranges, pH tolerances, and duration requirements for each matched crop.

### 🧪 3. Fertilizer Prescription & Auto-Deduction (`FormFertilizer.cs`)
* **Deficit Formulation:** Computes nutrient deficits between current soil test metrics and target crop requirements:
  $$\text{Deficit} = \max(0, \text{Target} - \text{Current})$$
* **Targeted Dosages:** Calculates precise application rates for Urea (46% N), TSP (Triple Superphosphate), and MOP (Muriate of Potash).
* **One-Click Ledger Deduction:** Executes transactional stock deductions directly against the farmer's stored inventory.

### 📦 4. Dual-Track Inventory Management (`FormStorageTracker.cs` & `FormDeleteStorage.cs`)
* **Input Supplies Tracking:** Manages fertilizer stock balances with support for restock (`+`) and field application (`-`) operations.
* **Harvest Yield Tracking:** Records harvested crops, storage silo locations, and sale transactions.
* **Overdraw Prevention:** Built-in validation blocks negative inventory balances and preserves ledger consistency.

### 🔐 5. Authentication & Session Isolation (`FormLogin.cs`, `FormRegister.cs`, `Session.cs`)
* Secure farmer registration and credential authentication.
* Thread-safe global session state providing user data isolation across all application views.

---

## 🏗️ Tech Stack & Architecture

* **UI Layer:** Windows Forms (WinForms) with custom resource-based dashboard styling
* **Language & Runtime:** C# (.NET Framework 4.8)
* **Data Layer:** ADO.NET (`System.Data.SqlClient`) with Parameterized Queries & Repository Pattern
* **Database Engine:** Microsoft SQL Server 2022 (with database backup file `AgroDocDb.bak`)
* **Data Visualization:** `System.Windows.Forms.DataVisualization.Charting` (MSChart)

---

## 📂 Repository Structure

```text
AgoDoc/
├── AgroDoc/                                # Main C# WinForms Project
│   ├── Data/
│   │   └── CropRepository.cs               # Data access logic for crop catalog
│   ├── Models/
│   │   └── Crop.cs                         # Crop entity data model
│   ├── Properties/
│   │   ├── AssemblyInfo.cs                 # Assembly metadata
│   │   ├── Resources.resx / .Designer.cs   # Form resources and assets
│   │   └── Settings.settings / .Designer.cs# User settings configuration
│   ├── Resources/                          # Image assets, icons, and UI illustrations
│   │   ├── 3203324.jpg
│   │   ├── Crop.png
│   │   ├── Download premium vector of Farmer controlling smart tractor...jpg
│   │   ├── Ferti1.png
│   │   ├── Ferti.png
│   │   ├── Gemini_Generated_Image_pgfm7ypgfm7ypgfm-removebg-preview.png
│   │   ├── soil.png
│   │   ├── steptodown.com619259.jpg
│   │   ├── Storage.png
│   │   └── Untitled design (1).png
│   ├── AgroDoc.csproj                      # Visual Studio project file
│   ├── AgroDoc.csproj.user                 # User-specific project settings
│   ├── AgroDoc.ico                         # Application desktop icon
│   ├── App.config                          # Application configuration
│   ├── DbHelper.cs                         # Centralized SQL Server connection factory
│   ├── FormCropSuggestion.cs               # Crop recommendation user interface
│   ├── FormCropSuggestion.Designer.cs      # Crop recommendation designer layout
│   ├── FormCropSuggestion.resx             # Crop recommendation resource mapping
│   ├── FormDeleteStorage.cs                # Inventory record removal interface
│   ├── FormDeleteStorage.Designer.cs       # Record removal designer layout
│   ├── FormDeleteStorage.resx              # Record removal resource mapping
│   ├── FormFertilizer.cs                   # Fertilizer catalog and prescription engine
│   ├── FormFertilizer.Designer.cs          # Fertilizer designer layout
│   ├── FormFertilizer.resx                 # Fertilizer resource mapping
│   ├── FormLogin.cs                        # Farmer authentication interface
│   ├── FormLogin.Designer.cs               # Login designer layout
│   ├── FormLogin.resx                      # Login resource mapping
│   ├── FormRegister.cs                     # New farmer registration form
│   ├── FormRegister.Designer.cs            # Registration designer layout
│   ├── FormRegister.resx                   # Registration resource mapping
│   ├── FormSoilIndex.cs                    # Soil testing, diagnosis, and NPK charts
│   ├── FormSoilIndex.Designer.cs           # Soil index designer layout
│   ├── FormSoilIndex.resx                  # Soil index resource mapping
│   ├── FormStorageTracker.cs               # Dual-track fertilizer and harvest inventory
│   ├── FormStorageTracker.Designer.cs      # Storage tracker designer layout
│   ├── FormStorageTracker.resx             # Storage tracker resource mapping
│   ├── MainForm.cs                         # Main dashboard navigation hub
│   ├── MainForm.Designer.cs                # Main dashboard designer layout
│   ├── MainForm.resx                       # Main dashboard resource mapping
│   ├── Program.cs                          # Application startup entry point
│   └── Session.cs                          # Active user context singleton
├── AgroDocDb.bak                           # Complete SQL Server database backup
├── AgroDoc.sln                             # Visual Studio Solution file
└── README.md                               # Project documentation
```

---

## 🚀 Getting Started

### Prerequisites

* **[Visual Studio 2019 or 2022](https://visualstudio.microsoft.com/)** (with the *.NET desktop development* workload enabled)
* **[.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)**
* **[Microsoft SQL Server 2019 / 2022](https://www.microsoft.com/en-us/sql-server/)** (Developer or Express Edition)
* **[SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)**

---

### Installation & Setup

#### 1. Clone the Repository
```bash
git clone [https://github.com/Safid01/AgoDoc.git](https://github.com/Safid01/AgoDoc.git)
cd AgoDoc
```

#### 2. Restore the Database (`AgroDocDb.bak`)
1. Open **SQL Server Management Studio (SSMS)** and connect to your SQL Server instance.
2. In **Object Explorer**, right-click **Databases** $\rightarrow$ select **Restore Database...**
3. Select **Device** $\rightarrow$ click the **`...`** button $\rightarrow$ click **Add**.
4. Browse to the root of the cloned repository and select **`AgroDocDb.bak`**.
5. Click **OK** $\rightarrow$ click **OK** to restore the database.

> *Alternatively, restore via T-SQL Query:*
> ```sql
> RESTORE DATABASE AgroDocDb 
> FROM DISK = 'C:\path\to\AgoDoc\AgroDocDb.bak' 
> WITH MOVE 'AgroDocDb' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AgroDocDb.mdf',
>      MOVE 'AgroDocDb_log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AgroDocDb_log.ldf';
> ```

#### 3. Configure Database Connection String
Open `AgroDoc/DbHelper.cs` in Visual Studio and verify your connection string:

```csharp
public static class DbHelper
{
    // Default SQL Server Instance:
    private static readonly string connectionString = 
        @"Data Source=.;Initial Catalog=AgroDocDb;Integrated Security=True;TrustServerCertificate=True";

    // For SQL Server Express Edition:
    // private static readonly string connectionString = 
    //     @"Data Source=.\SQLEXPRESS;Initial Catalog=AgroDocDb;Integrated Security=True;TrustServerCertificate=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
```

#### 4. Build and Run
1. Open **`AgroDoc.sln`** in Visual Studio.
2. Ensure the build configuration is set to **`Debug`** | **`Any CPU`**.
3. Rebuild the solution (**`Ctrl + Shift + B`**).
4. Press **`F5`** or click **Start** to launch AgroDoc.

---

## 🗄️ Relational Database Schema

```
[Farmers] ──< [SoilRecords]
    │
    ├──< [FertilizerStock]
    │
    └──< [HarvestStock]

[Crops] (Agronomic Benchmark Catalog)
[Fertilizers] (Prescription Dosage Catalog)
```

| Table | Description | Primary / Foreign Keys |
|---|---|---|
| **`Farmers`** | Stores farmer accounts, hashed credentials, and regional locations | `PK: FarmerId` |
| **`SoilRecords`** | Historical soil diagnostic logs with NPK, pH, and rating evaluations | `PK: RecordId`, `FK: FarmerId` |
| **`Crops`** | Crop agronomic profiles, seasonal durations, and optimal NPK/pH thresholds | `PK: CropId` |
| **`Fertilizers`** | Catalog of chemical fertilizers, active nutrients, and dosage rules | `PK: FertilizerId` |
| **`FertilizerStock`**| Input inventory ledger tracking on-hand fertilizer balances (in KG) | `PK: StockId`, `FK: FarmerId` |
| **`HarvestStock`** | Output inventory ledger tracking harvested produce and storage silos | `PK: HarvestId`, `FK: FarmerId` |

---

## 🔮 Future Roadmap

- [ ] **IoT Sensor Integration:** Real-time NPK, soil moisture, and pH telemetry ingestion via ESP32 microcontrollers.
- [ ] **Automated Report Generation:** Export formatted diagnostic summaries and stock ledgers to PDF.
- [ ] **Bilingual Support:** Full localization in Bengali (বাংলা) and English.
- [ ] **Agro-Weather Forecasting:** Live regional precipitation and temperature forecasting via weather APIs.

---

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

---

## 👨‍💻 Author

* **Safid Hasan** - [@Safid01](https://github.com/Safid01)
