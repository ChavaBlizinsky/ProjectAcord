# 🎵 Akord - Music School Management System

**A modern, full-featured administration platform for managing music education institutions, combining intuitive UI/UX with robust backend integration.**

---

## 📋 Table of Contents
- [Overview](#overview)
- [Key Features](#key-features)
- [Tech Stack](#tech-stack)
- [Architecture](#architecture)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)

---

## 🎯 Overview

**Akord** is a sophisticated React-based management system designed for music schools and teaching studios. It provides educators and administrators with a comprehensive dashboard to manage the complete operational lifecycle of a music education institution—from student enrollment to payment tracking, course scheduling, and staff management.

The application features:
- **Premium UI Design** with elegant gold-accented branding and smooth animations
- **Real-time Data Synchronization** with backend API integration
- **Interactive Musical Experience** with a dynamic, instrument-based home interface
- **Hebrew Language Support** with proper RTL (right-to-left) text rendering
- **Scalable State Management** using modern Redux Toolkit patterns

---

## ✨ Key Features

### 👥 Student Management
- Complete student database with comprehensive profiles
- Multi-status tracking: Active, Paused, and Waiting list students
- Student records with ID, birth date, start date, and lesson counts
- Real-time data fetching from backend API
- Organized table views sorted by student status

### 🎓 Teacher Management
- Full teacher roster with profiles and qualifications
- Active/Paused teacher status tracking
- Teacher assignment and availability management

### 🎼 Course Management
- Dynamic course catalog with pricing tiers
- Age-appropriate course filtering (from/to age ranges)
- Course descriptions and duration specifications
- Support for multiple course types and genres
- API-driven course data management

### 📅 Schedule Management
- Timetable creation and management
- Lesson scheduling system
- Conflict resolution and planning tools

### 💳 Payment Management
- Payment tracking and processing
- Financial reporting capabilities
- Transaction history management

### 🎹 Interactive Home Dashboard
- Musical instrument selection interface (Piano, Violin, Guitar, Flute, Drums)
- Interactive audio experience with instrument controls
- Dynamic visual feedback with animated confetti effects
- Premium gold gradient theme with professional branding

---

## 🛠️ Tech Stack

| Layer | Technology | Version |
|-------|-----------|---------|
| **Frontend Framework** | React | 19.1.1 |
| **State Management** | Redux Toolkit | Latest |
| **Routing** | React Router | Latest |
| **HTTP Client** | Axios | Latest |
| **Testing** | @testing-library/react | 16.3.0 |
| **Build Tool** | React Scripts | 5.0.1 |
| **Styling** | CSS3 + SVG Graphics | Custom |

### Key Libraries & Tools:
- **Redux Toolkit**: Simplified Redux setup with slices pattern
- **Axios**: Promise-based API client for backend communication
- **React Router**: Client-side routing and navigation
- **Web Vitals**: Performance monitoring
- **ESLint + React App Config**: Code quality standards

---

## 🏗️ Architecture

### State Management Pattern
The application uses a **feature-based Redux architecture** with Redux Toolkit slices:

```
src/
├── app/
│   └── store.js                 # Redux store configuration
├── features/
│   ├── students/
│   │   ├── MnagerStudents.js   # Student list component
│   │   ├── StudentsSlice.js    # Redux state for students
│   │   ├── AddStudent.js       # Student creation form
│   │   └── StudentsTable.js    # Data display component
│   ├── curses/
│   │   ├── ManagerCurses.js    # Course management
│   │   ├── CursesSlice.js      # Redux state for courses
│   │   ├── AddCours.js         # Course creation form
│   │   └── CursesTable.js      # Course display
│   ├── teachers/
│   ├── schedule/
│   ├── payments/
│   └── home/                    # Interactive dashboard
└── App.jsx                      # Main routing & layout
```

### Data Flow
1. **Components** dispatch Redux actions to modify state
2. **Redux Slices** handle state mutations immutably
3. **Axios Interceptors** communicate with backend API (`https://localhost:7273/api/`)
4. **useSelector Hooks** allow components to subscribe to state changes
5. **useDispatch Hooks** enable components to trigger actions

### API Integration
- Backend Base URL: `https://localhost:7273/api/`
- Endpoints: `/ReadStudents`, `/ReadCourses`, etc.
- Request Method: GET for data fetching
- Response Format: JSON array with complete entity objects

---

## 🚀 Getting Started

### Prerequisites
- Node.js (v14 or higher)
- npm or yarn package manager

### Installation

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd Acord
   ```

2. **Install dependencies**
   ```bash
   npm install
   ```

3. **Configure API endpoint** (optional)
   - Update `https://localhost:7273/api/` in manager components if using different backend URL

4. **Start the development server**
   ```bash
   npm start
   ```

5. **Open in browser**
   ```
   http://localhost:3000
   ```

### Build for Production
```bash
npm run build
```

The optimized build will be created in the `build/` directory.

### Run Tests
```bash
npm test
```

---

## 📁 Project Structure

```
src/
├── App.jsx                      # Root component, navigation, routing
├── App.css                      # Global styles with gold theme
├── Context.js                   # Context API setup (if applicable)
├── index.js                     # React DOM rendering
│
├── app/
│   └── store.js                 # Redux store with slices
│
├── features/
│   ├── home/
│   │   └── Home.js              # Interactive instrument dashboard
│   │
│   ├── students/
│   │   ├── MnagerStudents.js   # Student management interface
│   │   ├── StudentsSlice.js    # Redux: Student state management
│   │   ├── AddStudent.js       # Form for new student enrollment
│   │   ├── StudentsActiveTable.js
│   │   ├── StudentsPauseTable.js
│   │   └── StudentsWaitsTable.js
│   │
│   ├── curses/
│   │   ├── ManagerCurses.js    # Course management interface
│   │   ├── CursesSlice.js      # Redux: Course state management
│   │   ├── AddCours.js         # Form for course creation
│   │   └── CursesTable.js      # Course display
│   │
│   ├── teachers/
│   │   ├── ManagerTeachers.js
│   │   ├── TeachersSlice.js
│   │   ├── AddTeachers.js
│   │   ├── TeachersActiveTable.js
│   │   └── TeachersPauseTable.js
│   │
│   ├── schedule/
│   │   ├── ManagerSchedule.js
│   │   └── ScheduleSlice.js
│   │
│   └── payments/
│       ├── ManagerPayments.js
│       └── PaymentsSlice.js
│
└── public/
    ├── index.html
    ├── manifest.json
    └── JSON/
        ├── users.json
        └── recipies.json
```

---

## 🎨 Design Highlights

### Visual Identity
- **Color Scheme**: Premium gold gradient (#fffbe7, #ffe082, #bfa14a) with dark accents
- **Typography**: Modern, clear fonts supporting Hebrew text
- **Animations**: Smooth transitions, confetti effects, hover states
- **Responsiveness**: Adaptive layouts for desktop and tablet views

### UX Patterns
- **Tabbed Navigation**: Easy access to all management sections
- **Data Tables**: Clear, organized data presentation with headers and rows
- **Action Buttons**: Prominect/submit buttons for user actions
- **Form Inputs**: Accessible form components for data entry

---

## 📊 State Management

### Redux Slices Architecture

**StudentsSlice** - Manages student data
```javascript
{
  arrStudents: [
    { codeOfStudent, idOfStudents, codeFamily, firstName, 
      birsDate, beginDate, countLessonAct, fixLesson, status, notes }
  ]
}
```

**CursesSlice** - Manages course data
```javascript
{
  arrCourses: [
    { codeOfCourse, nameOfCourse, sexOfCourse, priceOfCourse,
      descriptionOfCourse, duretionTimeOfCourse, ageFrom, ageTo }
  ]
}
```

---

## 🔌 API Integration

### Backend Communication
- **Framework**: RESTful API (ASP.NET Core running on port 7273)
- **Authentication**: HTTPS endpoint
- **Data Format**: JSON

### Example Endpoints
```
GET https://localhost:7273/api/ReadStudents
GET https://localhost:7273/api/ReadCourses
GET https://localhost:7273/api/ReadTeachers
```

---

## 🎯 Future Enhancements

- [ ] User authentication and role-based access control
- [ ] Real-time notifications for payment/schedule updates
- [ ] Advanced reporting and analytics dashboard
- [ ] Email/SMS integration for student communications
- [ ] Mobile app version for on-the-go management
- [ ] Data export to PDF/Excel formats
- [ ] Online course enrollment portal for students

---

## 📱 Browser Support

- Chrome (latest)
- Firefox (latest)
- Safari (latest)
- Edge (latest)

---

## 📝 License

This project is proprietary software for music school management.

---

## 👨‍💻 Developer

Created with ❤️ for efficient music education administration.

---

**Akord** - Making music education management harmonious. 🎼

## Notes

- Some management pages rely on a backend API at `https://localhost:7273`.
- The current `package.json` includes Create React App dependencies; additional packages may be required such as `react-router-dom`, `react-redux`, `@reduxjs/toolkit`, and `axios`.
- This repo is mainly a frontend prototype for music-school administration and expects external API routes for data management.

## Purpose

The Akord project is a front-end prototype for managing music school operations. It showcases navigation, Redux state handling, API-driven dashboards, and an engaging studio-themed user interface.
