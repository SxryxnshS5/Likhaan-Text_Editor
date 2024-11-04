---

# Likhaan Text Editor

Likhaan Text Editor is a lightweight, feature-rich text editing tool developed using Windows Forms in C#. It provides a simple interface for creating, editing, and managing text files, with essential functionalities like printing, searching, undo/redo, and more.

The next steps for this project include adding version control integration and improving the overall UI/UX for a more seamless user experience.

## Features

- **Create, Open, and Save Files**: Easily create new text documents, open existing files, and save them either directly or with the 'Save As' option.
- **Edit Options**: Supports basic text editing functions such as undo, redo, cut, copy, paste, and select all.
- **Search**: Search for specific text within the document using the built-in search feature.
- **Printing**: Preview and print text documents using the integrated Print Manager.
- **User-Friendly Interface**: Intuitive UI designed for ease of use.
- **Open-Source**: Likhaan Text Editor is open-source and available on GitHub for collaboration and improvements.

## Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/SxryxnshS5/Likhaan-Text_Editor.git
    ```

2. **Open in Visual Studio**:
    - Open the solution file (`LikhaanTextEditor.sln`) in Visual Studio.

3. **Build and Run**:
    - Compile the project using `Ctrl + Shift + B`.
    - Run the application (`F5` or `Ctrl + F5`).

## Usage

### Basic Functions:
- **New File**: Clears the editor for a new text document.
- **Open File**: Open any `.txt` or other text files through the `File -> Open` menu.
- **Save File**: Save the current document using `File -> Save` or `File -> Save As`.
  
### Editing:
- **Undo/Redo**: Quickly undo or redo your changes via the Edit menu or using shortcuts (`Ctrl + Z` / `Ctrl + Y`).
- **Cut/Copy/Paste**: Basic text operations can be done from the Edit menu or using the keyboard shortcuts (`Ctrl + X` / `Ctrl + C` / `Ctrl + V`).

### Advanced Features:
- **Search**: Use the `Search` function to find specific text in the document.
- **Print**: Preview and print your document via `File -> Print`.
  
## Code Structure

The project is built using Windows Forms and organized as follows:

- **MainForm.cs**: Contains the main UI logic and event handlers for various menu items like `New`, `Open`, `Save`, `Print`, etc.
- **FileManager.cs**: Manages file operations such as opening, saving, and saving as.
- **PrintManager.cs**: Handles printing functionality, including print preview and actual document printing.

### Core Components

1. **FileManager**: Handles file-related tasks:
    - `OpenFile()`: Opens and loads a text file into the editor.
    - `SaveFile()`: Saves the current text file.
    - `SaveFileAs()`: Prompts the user to save the file with a new name.

2. **PrintManager**: Manages printing operations:
    - `Print()`: Displays the print preview dialog and prepares the document for printing.
    - `PrintPage()`: Sends the text content to the printer.

### Search Functionality
Implemented within the `MainForm` class, the search function allows users to find specific text in the document, using a dialog box to input the search query.

## GitHub Actions Deployment

This project uses GitHub Actions to automate the build and release process:

1. **Builds on Push to Main**: Each push to the `main` branch triggers an automated workflow to build the project.
2. **Artifact Upload**: After building, the executable is zipped and uploaded as an artifact.
3. **Automated Releases**: The workflow creates a release draft on GitHub with the latest build, making it available for download.

### Workflow File

The GitHub Actions workflow is defined in `.github/workflows/dotnet-desktop.yml`. It includes the following jobs:
- **Build**: Checks out the code, builds the solution using MSBuild, and uploads the output as an artifact.
- **Release**: Downloads the artifact, creates a GitHub release, and attaches the executable.

## Contributions

Contributions are welcome! Feel free to open an issue or submit a pull request on GitHub.

## License

This project is open-source under the MIT License. For more details, see the [LICENSE](LICENSE) file.

## Links

- [GitHub Repository](https://github.com/SxryxnshS5/Likhaan-Text_Editor)

---

Thank you for using Likhaan Text Editor! For any issues, please open an issue on the GitHub repository.
