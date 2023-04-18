# File Organizer

File Organizer is a .NET-based application that helps users organize their files using a tagging system. It offers a user interface resembling Windows Explorer, allowing users to navigate, search, and filter their files using tags.

## Table of Contents

- [Features](#features)
- [System Requirements](#system-requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Features

- File navigation: Browse files and folders with a familiar Windows Explorer-like interface.
- Tagging system: Attach custom tags to files for better organization.
- Database integration: File metadata and tags are stored in a lightweight SQLite database.
- Search and filtering: Quickly locate files using search and filtering options based on tags.
- Multi-database support: Manage multiple SQLite databases for separate projects or use cases.

## System Requirements

- Windows 10 or later
- .NET 7/8 runtime

## Installation

1. Download the installer from the releases page.
2. Run the installer and follow the on-screen instructions to complete the installation.
3. Launch the application from the Start menu or desktop shortcut.

## Usage

1. Open File Organizer and navigate to a folder with files you want to tag.
2. Select a file and add tags using the tag management pane.
3. Use the search and filtering options to locate files based on tags.

## Project Structure

- FileOrganizer.UI: Contains the WPF user interface, views, and view models.
- FileOrganizer.Core: Contains the business logic and models for the application.
- FileOrganizer.Data: Handles data access and storage using SQLite.
- FileOrganizer.Services: Contains various services such as file management, search, and tagging.
- Test projects: Separate test projects for each main project, ensuring a maintainable and testable codebase.

## Contributing

1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Make your changes and commit them to the branch.
4. Open a pull request, and a team member will review your changes.

## License

File Organizer is released under the GNU AGPL v3 License. See [LICENSE](LICENSE.txt) for details.
