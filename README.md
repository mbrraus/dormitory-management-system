# Dormitory Management System

## DESCRIPTION

The Dormitory Management System is a web application designed to streamline dormitory management processes, offering a unified platform for administrators to manage rooms, student information, and inventory efficiently. Simultaneously, it provides students with a digital platform to report issues, facilitating quicker and more effective communication compared to traditional methods. Developed using .NET 8.0 and Blazor, the system leverages a PostgreSQL database, ensuring robust data management and a seamless user experience.

## Features

- **Authentication System**: Secure login for administrators and students.
- **Room Management**: Administrators can add, remove, or modify room details.
- **Student Management**: Keep track of student details and room assignments.
- **Maintenance Tickets**: Students can report issues, which admins can manage and resolve.
- **Inventory Management**: Track and manage dormitory assets and supplies.

### Prerequisites

- .NET 8.0 SDK
- PostgreSQL
- Any modern web browser

### Installation

```bash
git clone https://github.com/mbrraus/dormitory-management-system.git
cd dormitory-management-system
dotnet restore
dotnet run
```
## Screenshots

### Rooms Overview
![Rooms Overview](images/rooms-overview.png)

### Student List
![Student List](images/student-list.png)

### Student Registration Form
![Student Registration Form](images/student-registration-form.png)

### Detailed Room View
![Detailed Room View](images/rooms-detail.png)

### Room Assignment
![Room Assignment](images/room-assignment-1.png)
![Room Assignment](images/room-assignment.png)

### Ticket Submission
![Ticket Submission](images/ticket-submission.png)

### Ticket View - Admin Panel
![Ticket View](images/ticket-view-admin-panel.png)




