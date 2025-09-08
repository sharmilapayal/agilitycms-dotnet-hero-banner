# Agility CMS .NET Starter — Fork with Custom HeroBanner

This is a **fork** of the [Agility CMS .NET Starter](https://github.com/agility/agilitycms-dotnet-starter) repository.  
It extends the official starter by adding a **HeroBanner ViewComponent**, demonstrating dynamic content integration from Agility CMS and responsive Tailwind CSS styling.

---

## 🧩 Key Features

- **HeroBanner ViewComponent**
  - ViewComponent: `ViewComponents/PageModules/HeroBanner.cs`
  - Razor view: `Views/PageModules/HeroBanner.cshtml`
  - Fetches dynamic content from Agility CMS (`title`, `subtitle`, `image`, optional `button`)
  - Fully responsive with Tailwind CSS overlay support
  - Rendered on pages via:
    ```cshtml
    @await Component.InvokeAsync("HeroBanner")
    ```

- **CMS Model Updates**
  - `Models/AgilityModels.cs` updated to support HeroBanner fields

---

## 🚀 Changes in This Fork

| File / Feature | Description |
|----------------|-------------|
| `ViewComponents/PageModules/HeroBanner.cs` | Added HeroBanner ViewComponent to fetch CMS content |
| `Views/PageModules/HeroBanner.cshtml` | Razor view for rendering HeroBanner |
| `Models/AgilityModels.cs` | Updated model definitions to include HeroBanner fields |

---

## 📦 Getting Started

**Clone the repository and restore dependencies:**

```bash
git clone <your-fork-url>
cd Agility.NET.Starter
dotnet restore
