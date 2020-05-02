# .NET Dialog Service [![Build status](https://ci.appveyor.com/api/projects/status/g3jr0r74wmgmm90h?svg=true)](https://ci.appveyor.com/project/feel-the-dz3n/dialogservice)
This library is the replacement for MessageBoxes and TaskDialogs and aims to be as simple as possible.

### How to use library in your project
1. Go to you solution directory
2. Clone this repository
```
git clone https://github.com/feel-the-dz3n/DialogService
```
2. Go to your project directory 
3. Reference DialogService **(ensure that directory in command is correct)**
```
dotnet add reference ../DialogService/DialogService/DialogService.csproj
```
3. Reference DialogService.CrossPlatform **(ensure that directory in command is correct)**
```
dotnet add reference ../DialogService/DialogService.CrossPlatform/DialogService.CrossPlatform.csproj
```
4. Write some code
```csharp
using DialogService;
using DialogService.Items;
var dialogService = CrossPlatform.DialogService.Get(); // get's implementation for current platform
var dialog = new Dialog("Test Dialog"); // create a dialog model with title

dialog.Items.Add(new Button("Click me"));
dialog.Items.Add(new Label("This is the label!"));

dialog.BottomPanel.Add(new Button("OK"));
dialog.BottomPanel.Add(new Button("Cancel"));

dialogService.Show(dialog);
```

### Platforms
 - ✔️ **Windows**: half-implemented with WPF
 
   ![image](https://user-images.githubusercontent.com/25367511/80859811-2dbdee00-8c6c-11ea-8ecc-558f96a3f692.png)
   
 - ⛔ **Linux**: not implemented
 - ⛔ **macOS**: not implemented
