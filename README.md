
# SaveUp App

## Projektbeschreibung

Die SaveUp App wurde im Rahmen des Modul 335 entwickelt. Ziel der App ist es, Benutzern zu ermöglichen, kleine tägliche Einsparungen zu erfassen und den angesparten Betrag zu überwachen. Diese Einsparungen können beispielsweise für größere private Investitionen wie Urlaub genutzt werden.

## Funktionen

- **Produkt hinzufügen**: Benutzer können Produkte mit einer Beschreibung und einem Preis erfassen.
- **Produktliste**: Anzeige aller erfassten Produkte in einer Liste.
- **Datenpersistenz**: Speicherung der Daten lokal auf dem Gerät.

## Technologie-Stack

- **Framework**: .NET MAUI
- **Programmiersprache**: C#
- **Entwicklungsumgebung**: Visual Studio

## Installation

1. **Repository klonen**:
   ```bash
   git clone https://github.com/Nesimo05/SaveUp.git
   ```
2. **Projekt öffnen**:
   Öffne das Projekt in Visual Studio.

3. **Abhängigkeiten wiederherstellen**:
   Visual Studio wird automatisch alle benötigten NuGet-Pakete wiederherstellen.

4. **Projekt ausführen**:
   Wähle das gewünschte Gerät oder Emulator und starte das Projekt mit `F5`.

## Projektstruktur

- **Views**:
  - `MainPage.xaml` / `MainPage.xaml.cs`: Startseite der App.
  - `AddProductPage.xaml` / `AddProductPage.xaml.cs`: Seite zum Hinzufügen von Produkten.
  - `ProductListPage.xaml` / `ProductListPage.xaml.cs`: Seite zur Anzeige der Produktliste.

- **ViewModels**:
  - `MainViewModel.cs`: ViewModel für die MainPage.
  - `AddProductViewModel.cs`: ViewModel für die AddProductPage.
  - `ProductListViewModel.cs`: ViewModel für die ProductListPage.

- **Models**:
  - `Product.cs`: Datenmodell für die Produkte.

## Nutzung

1. **Produkt hinzufügen**:
   - Navigiere zur `AddProductPage`.
   - Gib die Produktdetails ein und speichere das Produkt.

2. **Produktliste anzeigen**:
   - Navigiere zur `ProductListPage`.
   - Alle erfassten Produkte werden in einer Liste angezeigt.

