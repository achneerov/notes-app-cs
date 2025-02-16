# Notes App

A full-stack notes application built with .NET Core, Entity Framework Core, and SQLite. This application provides a clean, intuitive interface for creating, reading, updating, and deleting notes.

## Features

- Create new notes with title and content
- View all notes in a clean, card-based interface
- Edit existing notes
- Delete notes
- Automatic timestamps for creation and updates
- Persistent storage using SQLite database
- Responsive web interface

## Technology Stack

- **Backend:**
  - .NET Core 9.0
  - Entity Framework Core
  - SQLite Database
  - ASP.NET Core Web API

- **Frontend:**
  - HTML5
  - CSS3
  - Vanilla JavaScript
  - Fetch API for HTTP requests

## Project Structure

```
NotesApp/
├── Controllers/
│   └── NotesController.cs    # API endpoints for note operations
├── Models/
│   └── Note.cs              # Note entity model
├── Data/
│   └── NotesContext.cs      # Database context
├── wwwroot/
│   └── index.html          # Web interface
└── Program.cs              # Application configuration
```

## Getting Started

### Prerequisites

- .NET Core SDK 9.0 or later
- Any modern web browser

### Installation

1. Clone the repository:
```bash
git clone https://github.com/YOUR_USERNAME/notes-app.git
cd notes-app
```

2. Install the required packages:
```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.AspNetCore.StaticFiles
```

3. Create and apply the database migrations:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

4. Run the application:
```bash
dotnet run
```

5. Open your browser and navigate to:
```
http://localhost:5121
```

## API Endpoints

The application exposes the following RESTful API endpoints:

- `GET /api/notes` - Retrieve all notes
- `GET /api/notes/{id}` - Retrieve a specific note
- `POST /api/notes` - Create a new note
- `PUT /api/notes/{id}` - Update an existing note
- `DELETE /api/notes/{id}` - Delete a note

### API Request Examples

#### Create a Note
```bash
curl -X POST http://localhost:5121/api/notes \
-H "Content-Type: application/json" \
-d '{"title":"Test Note","content":"This is my first note"}'
```

#### Update a Note
```bash
curl -X PUT http://localhost:5121/api/notes/1 \
-H "Content-Type: application/json" \
-d '{"id":1,"title":"Updated Note","content":"This note has been updated"}'
```

## Database Schema

The Notes table has the following structure:

```sql
CREATE TABLE "Notes" (
    "Id" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    "Title" TEXT NOT NULL,
    "Content" TEXT NOT NULL,
    "CreatedAt" TEXT NOT NULL DEFAULT (CURRENT_TIMESTAMP),
    "UpdatedAt" TEXT NULL
);
```

## Frontend Features

The web interface provides:
- A form for creating and editing notes
- Real-time updates when notes are modified
- Responsive design that works on both desktop and mobile devices
- Confirmation dialogs for delete operations
- Clear visual feedback for all operations
- XSS protection through HTML escaping

## Security Features

- Input validation on both client and server side
- XSS protection through HTML escaping
- SQL injection protection through Entity Framework Core
- Required field validation

## Development

To contribute to this project:

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## Future Enhancements

Potential features to be added:
- Note categories/tags
- Search functionality
- Rich text editing
- User authentication
- Note sharing capabilities
- Dark mode theme

## License

This project is open source and available under the MIT License.