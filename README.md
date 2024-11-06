# 📝 To-Do List App

![Language](https://img.shields.io/badge/Language-VB.NET-blue.svg)
![License](https://img.shields.io/badge/License-MIT-green.svg)
![Platform](https://img.shields.io/badge/Platform-.NET%20Core-blue)

Welcome to the **To-Do List App** 🎉, a simple command-line application built in VB.NET for managing tasks. This app lets you add tasks, view them, mark them as complete, and delete tasks as needed, all from a user-friendly console interface.

---


## ✨ Features

- 📌 **Add Tasks**: Add a new task with a unique ID and description.
- 📋 **View Tasks**: View all tasks, including their completion status (Pending or Completed).
- ✅ **Mark as Complete**: Update a task’s status to "Completed" when finished.
- 🗑️ **Delete Tasks**: Remove a task permanently by its ID.
- 💻 **User-Friendly Interface**: Console interface with emojis and clear options to improve usability.

---

## 📂 Project Structure

- **Program**: Main application loop that handles user input and displays the menu.
- **Task**: Represents a single task with properties like ID, Description, and IsComplete.
- **TaskManager**: Manages tasks, including adding, viewing, marking as complete, and deleting tasks.

---

## 🚀 Getting Started


### ✅ Prerequisites

- **.NET SDK**: This project requires the .NET SDK to run. You can download it from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

### 🛠 Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/zamange/ToDoList.git
   cd ToDoListApp

2. **Build the Project**:
    ```bash
    Copy code
    dotnet build



3. **Run the Application**:
    ```bash
    Copy code
    dotnet run

## Usage

Launch the app with dotnet run.
Follow the on-screen instructions to manage tasks:
Choose an option by entering a number (1-5).
Optionally, provide task details (ID or description) as prompted.

1. **Menu Options**
    ```markdown
    1️⃣ Add a new task: Enter a description, and the app will assign a unique ID to the task.
    2️⃣ View tasks: Displays all tasks with their ID, description, and status.
    3️⃣ Mark task as complete: Enter the task ID to mark it as completed.
    4️⃣ Delete a task: Enter the task ID to remove it from the list.
    5️⃣ Exit: Close the application.

1. ## Example Usage
   ```bash

   Copy code
   ========================================
           🌟 Welcome to the To-Do List App 🌟
   ========================================
   Choose an option:
   1️⃣  ➔ Add a new task
   2️⃣  ➔ View tasks
   3️⃣  ➔ Mark task as complete
   4️⃣  ➔ Delete a task
   5️⃣  ➔ Exit
   ➡️  Enter your choice (1-5):

## Code Overview
Program.cs
Handles the main application loop, displaying the menu and routing user actions to the TaskManager.

Task.cs
Defines the Task class with properties for ID, description, and completion status. Includes:

Constructor for creating new tasks.
Method MarkAsComplete() to update task status.
Override of ToString() for formatted display.
TaskManager.cs
Handles task operations with methods to:

Add tasks
View all tasks
Mark tasks as complete
Delete tasks
Contributions
Contributions are welcome! If you have suggestions or improvements, please submit a pull request.

## License
This project is open-source and available under the MIT License.
