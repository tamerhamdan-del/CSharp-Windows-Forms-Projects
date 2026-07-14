# MDI Sample Project

A simple C# Windows Forms application demonstrating the use of **Multiple Document Interface (MDI)**. The project allows opening a child form inside a parent form using a button.

## 📌 Features

- Create an MDI Parent Form.
- Open a Child Form inside the parent window.
- Simple and beginner-friendly implementation.
- Demonstrates the `MdiParent` property.

## 🛠️ Technologies Used

- C#
- Windows Forms (.NET Framework)
- Visual Studio

## 📷 Preview

![Project Screenshot](Screenshot%202026-07-14%20103303.png)

## ⚙️ How It Works

1. Run the application.
2. Click the **Open Form** button.
3. A child form is displayed inside the main MDI parent window.

## 💡 Concepts Practiced

- Multiple Document Interface (MDI)
- Parent and Child Forms
- Button Click Events
- Object Instantiation
- Windows Forms Navigation

## 📁 Project Structure

```text
MDI Sample Project
│
├── Form1.cs          // MDI Parent Form
├── Form2.cs          // MDI Child Form
├── Program.cs
├── Properties
└── README.md
```

## 🧠 Code Overview

The application creates an instance of the child form and assigns the current form as its MDI parent:

```csharp
Form2 frm = new Form2();

private void button1_Click(object sender, EventArgs e)
{
    frm.MdiParent = this;
    frm.Show();
}
```

## 🎯 Learning Objectives

This project helps beginners understand:

- What an MDI application is.
- How to create parent and child forms.
- How to display forms inside another form.
- Basic event-driven programming in Windows Forms.

## 🚀 Future Improvements

- Open multiple child forms.
- Add a MenuStrip to manage child windows.
- Cascade and Tile window layouts.
- Prevent opening duplicate child forms.
- Add icons and toolbars.

## 👨‍💻 Author

**Tamer Hamdan**

GitHub: https://github.com/tamerhamdan-del
