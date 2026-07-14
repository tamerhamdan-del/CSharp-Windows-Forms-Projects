# Family Tree Builder

A C# Windows Forms application that demonstrates how to use **TreeView** and **ImageList** controls to build a simple family tree. Users can add family members, assign gender-specific icons, create parent-child relationships, and manage the tree dynamically.

## 📌 Features

- 🌳 Create a hierarchical family tree.
- 👨 Add male members with a male icon.
- 👩 Add female members with a female icon.
- 👪 Add children under any selected family member.
- 🗑️ Remove selected family members.
- 🔄 Clear the entire tree.
- 📂 Automatically expand parent nodes after adding children.

## 🛠️ Technologies Used

- C#
- Windows Forms (.NET Framework)
- Visual Studio

## 📷 Preview

![Project Screenshot](Screenshot%202026-07-14%20111056.png)

## ⚙️ How It Works

1. Enter a person's name.
2. Select the gender (Male or Female).
3. If the tree is empty, the person becomes the root node.
4. To add a child:
   - Select a parent node.
   - Enter the child's name.
   - Choose the gender.
   - Click **Add**.
5. Use **Remove** to delete the selected member.
6. Use **Clear** to remove the entire family tree.

## 💡 Concepts Practiced

- TreeView Control
- TreeNode
- ImageList
- RadioButton
- TextBox
- Button Events
- Parent-Child Relationships
- Event Handling

## 📁 Project Structure

```text
Tree View and ImageList Project
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── Properties
├── Resources
└── README.md
```

## 🎯 Learning Objectives

This project helps beginners learn how to:

- Create hierarchical data using TreeView.
- Add and remove TreeNodes dynamically.
- Associate icons with nodes using ImageList.
- Build parent-child relationships.
- Design interactive Windows Forms applications.

## 🚀 Future Improvements

- 💾 Save the family tree to a file.
- 📂 Load an existing family tree.
- ✏️ Rename existing nodes.
- 🔍 Search for family members.
- 📊 Display additional information (age, relationship, etc.).
- 🖼️ Use custom profile pictures instead of icons.

## 👨‍💻 Author

**Tamer Hamdan**

GitHub: https://github.com/tamerhamdan-del
