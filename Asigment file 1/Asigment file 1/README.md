C# File Handling Assignment

Project Description

This project is a simple C# Windows Forms application that demonstrates basic file handling operations using the "System.IO" namespace.

The application allows users to create, read, append, copy, rename, check, and delete text files. It also displays file contents inside a ListBox.

Technologies Used

- C#
- Windows Forms
- Visual Studio
- System.IO Namespace
- StreamWriter
- StreamReader

File Operations

1. Create File

Creates a new text file named "output.txt" and writes four lines of text into it using "File.CreateText()".

2. Delete File

Checks whether "output.txt" exists. If the file exists, it deletes the file using "File.Delete()" and clears the ListBox.

3. Read File

Reads the contents of "output.txt" line by line using "StreamReader" and displays them in "listBox1".

4. Clear ListBox

Removes all items displayed inside the ListBox using:

listBox1.Items.Clear();

5. Append Text

Adds new text to the end of "output.txt" without deleting the existing content using "File.AppendText()".

6. Check File Exists

Checks whether "output.txt" exists using "File.Exists()".

7. Copy File

Copies "output.txt" into a new file named "copy.txt" using "File.Copy()".

The "true" parameter allows the destination file to be overwritten if it already exists.

8. Rename File

Renames "output.txt" to "newfile.txt" using "File.Move()".

Before renaming, the application checks whether the destination file already exists.

Files Used

File Name| Description
output.txt| Main text file
copy.txt| Copied file
newfile.txt| Renamed file

How to Run the Project

1. Open the project in Visual Studio.
2. Build and run the Windows Forms application.
3. Click the buttons to perform different file operations.
4. View file contents inside the ListBox.
5. Check the MessageBox notifications after each operation.

Learning Outcomes

After completing this project, I learned how to:

- Create text files.
- Write data into files.
- Read files line by line.
- Append new text to existing files.
- Check whether a file exists.
- Copy and rename files.
- Delete files.
- Use StreamReader and StreamWriter in C#.

Conclusion

This project helped me understand the fundamentals of file handling in C# Windows Forms and how to manage text files using the System.IO namespace.