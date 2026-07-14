# Menu Strip Sample Project

A simple C# Windows Forms application demonstrating how to use **MenuStrip** controls, **MDI Forms**, and built-in dialogs such as **ColorDialog** and **FontDialog**.

## 📌 Features

- MenuStrip navigation.
- Open child forms inside an MDI Parent.
- Display messages using MessageBox.
- Change the background color of a TextBox.
- Change the font of a TextBox.
- Clear the TextBox content.

## 🛠️ Technologies Used

- C#
- Windows Forms (.NET Framework)
- Visual Studio

## 📷 Preview

![Project Screenshot](Screenshot%202026-07-14%20103805.png)

## ⚙️ How It Works

### Main Form

The main form contains a **MenuStrip** with several menu items, including:

- Add New Client
- Update Client
- Find Client
- Delete Client
- Login
- Exit
- Open Form2

Each menu item demonstrates handling the `Click` event using `MessageBox` or by opening another form.

### Child Form (Form2)

The child form includes:

- **Change Color** → Opens a `ColorDialog` to change the TextBox background color.
- **Change Font** → Opens a `FontDialog` to change the TextBox font.
- **Clear** → Clears the TextBox content.

## 💡 Concepts Practiced

- MenuStrip
- ToolStripMenuItem
- MDI Parent & Child Forms
- MessageBox
- ColorDialog
- FontDialog
- TextBox Manipulation
- Event Handling

## 📁 Project Structure

```text
Menu Strip Sample Project
│
├── Form1.cs          // Main MDI Parent Form
├── Form2.cs          // Child Form
├── Program.cs
├── Properties
└── README.md
```

## 🎯 Learning Objectives

This project helps beginners learn how to:

- Create and use a MenuStrip.
- Handle menu item click events.
- Build MDI (Multiple Document Interface) applications.
- Work with built-in Windows Forms dialogs.
- Modify controls dynamically at runtime.

## 🚀 Future Improvements

- Add File Open and Save functionality.
- Implement Cut, Copy, and Paste options.
- Add keyboard shortcuts.
- Create a simple text editor.
- Support multiple child windows simultaneously.

## 👨‍💻 Author

**Tamer Hamdan**

GitHub: https://github.com/tamerhamdan-del
