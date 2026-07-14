# Drawing Practice

A simple C# Windows Forms application that demonstrates how to draw basic shapes using the **Graphics** class in the `Paint` event.

## 📌 Features

- Draw a vertical line.
- Draw a rectangle.
- Draw an ellipse.
- Customize the pen color and thickness.
- Rounded line start and end caps.

## 🛠️ Technologies Used

- C#
- Windows Forms (.NET Framework)
- Visual Studio
- System.Drawing

## 📷 Preview

![Project Screenshot](/Screenshot 2026-07-14 102456.png)


## ⚙️ How It Works

When the form is painted, the application:

- Creates a black `Pen`.
- Sets the pen width to **10 pixels**.
- Uses rounded caps for smoother line endings.
- Draws:
  - A vertical line
  - A rectangle
  - An ellipse

## 💡 Concepts Practiced

- Windows Forms Graphics
- Paint Event
- Graphics.DrawLine()
- Graphics.DrawRectangle()
- Graphics.DrawEllipse()
- Pen Customization
- Colors
- Line Caps

## 📁 Project Structure

```text
Drawing Practice
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── Properties
└── README.md
```

## 🎯 Learning Objectives

This project helps beginners understand:

- The Windows Forms painting system.
- Drawing with the `Graphics` object.
- Using the `Pen` class.
- Rendering basic geometric shapes.
- Creating simple custom graphics in desktop applications.

## 🚀 Future Improvements

- Draw circles, polygons, and arcs.
- Fill shapes with colors.
- Draw text.
- Support mouse drawing.
- Create a simple paint application.

## 👨‍💻 Author

**Tamer Hamdan**

GitHub: https://github.com/tamerhamdan-del
