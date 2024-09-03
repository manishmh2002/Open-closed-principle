# Open–closed Principle Notification System

## Overview

The **Open–closed Principle Notification System** is a software project designed to showcase the Open–closed Principle (OCP) in object-oriented design. The OCP states that software entities (such as classes, modules, and functions) should be open for extension but closed for modification. This means that you should be able to add new functionality without changing the existing code, thereby promoting code reusability and maintainability.

In this project, we implement a notification system that adheres to the OCP by allowing the addition of new notification types without modifying existing classes.

![Class Diagram](Images/classDiagram.png)

## Project Structure

The project is organized into the following folders and files:

### Models

- **`Notification.cs`**: Contains the `Notification` class, which represents a notification with a type and a message.
- **`NotificationType.cs`**: Contains the `NotificationType` enumeration, defining the different types of notifications (e.g., Email, SMS, Push).

### Services

- **`INotificationService.cs`**: Defines the interface `INotificationService` that all notification services must implement. This interface ensures that each notification service provides a `Send` method.
- **`EmailNotificationService.cs`**: Implements the `INotificationService` interface to handle email notifications.
- **`SmsNotificationService.cs`**: Implements the `INotificationService` interface to handle SMS notifications.
- **`PushNotificationService.cs`**: Implements the `INotificationService` interface to handle push notifications.

### Tests

- **`NotificationTests.cs`**: Contains unit tests for the notification system, validating the functionality of different notification services and ensuring they adhere to the expected behavior.

### Class1.cs

- **`Class1.cs`**: An example class demonstrating basic functionality and usage of the notification system.

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) must be installed on your machine.
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) for code editing and running the project.

### Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/open-closed-principle.git
    ```

2. **Navigate to the project directory**:
    ```bash
    cd open-closed-principle
    ```

3. **Restore dependencies**:
    ```bash
    dotnet restore
    ```

### Building the Project

1. **Build the project**:
    ```bash
    dotnet build
    ```

2. **Verify the build output**:
    The build output will be located in the `bin/Debug/net8.0` directory. Ensure that the `Open-closed principle.dll` file is generated.

### Running the Project

1. **Run the project**:
    ```bash
    dotnet run
    ```

2. **Example usage**:
    To create and display a notification, use the following code snippet:
    ```csharp
    var notification = new Notification(NotificationType.Email, "This is an email notification.");
    notification.Display();
    ```

### Running Tests

1. **Run unit tests**:
    ```bash
    dotnet test
    ```

2. **Test results**:
    The test results will be displayed in the console. Ensure that all tests pass and validate the functionality of the notification services.

## Detailed Usage

### Creating a Notification

To create a notification, instantiate the `Notification` class with the desired `NotificationType` and a message. Here is an example:

```csharp
var notification = new Notification(NotificationType.Email, "Your email notification message here.");
notification.Display();


### Explanation

- **Image Path**: Adjust the image path (`Images/classDiagram.png`) to match the folder name you used in your project if you chose a different name.
- **Image Usage**: The image will be displayed in your Markdown file when viewed in GitHub, Visual Studio Code, or other Markdown renderers.

This update ensures that the class diagram is prominently displayed in the `README.md` file, providing a visual representation of the project structure.
