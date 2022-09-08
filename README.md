# TestBlazor2022
Test Blazor in 2022

## Structure

![image](https://user-images.githubusercontent.com/48028805/189083485-af6a5fc3-6d8c-4db2-b8e3-ccf727831079.png)


Klick auf TestBlazor2022_Server um die .csproj zu öffnen

![image](https://user-images.githubusercontent.com/48028805/189083502-2c673ad8-3f0e-475e-9515-44367de4366a.png)


ImplicitUsings ist neu und dient dazu nicht jedesmal die usings bei Standard Libraries schreiben zu müssen.



- **Properties > launchSettings.json**
Sind die profiles für das Ausführen einer Anwendung und iissettings


- **wwwroot**
Root Folder. Ist zuständig für die static Files der Webseite (css, favicon, images, pdf, …)

- **Data**
Hier kommen die .cs Files hinein. Auch Services und Models

- **Pages**
Alle Webpages
.cshtml = razor pages
.razor = razor components

- **Shared**
Pages, die über der ganzen Webseite verwendet werden und nicht wie die Pages einzelne Seiten sind.
z.B. das NavMenu -> ein Navigationsmenü, dass auf jeder Seite existiert

- **_Imports.razor**
Using Statements, die man auf mehreren / allen Seiten benötigt.

- **App.razor**
Main Page der Applikation
Für Routing verantwortlich

- **Appsettings.json**
Connection Strings
Secrets

- **Program.cs**
Main File, welches die Applikation startet
Ab .net 6 wurden Program.cs und Startup.cs in Program.cs kombiniert




![image](https://user-images.githubusercontent.com/48028805/189083448-457b93e9-9296-4072-8c5c-c1b3e8a4fcd6.png)
Regelt das ganze SignalR Handling



_Host.cshtml beinhaltet das Main Layout "_Layout.cshtml" und die Main App "App.razor"
