# Mission 10 Assignment

A bowling league directory for the **Marlins** and **Sharks** teams. Displays a table of bowlers with full name, team, address (street, city, state, zip), and phone number.

## Tech Stack

| Layer    | Technologies                                       |
| -------- | -------------------------------------------------- |
| Frontend | React 19, TypeScript, Vite 8                       |
| Backend  | ASP.NET Core 10, Entity Framework Core 10, SQLite  |

## Prerequisites

- **Node.js** — for the frontend
- **.NET SDK 10** — for the backend

## Getting Started

### Backend (run first)

```bash
cd backend/Mission10Assignment/Mission10Assignment
dotnet run
```

- Uses the SQLite database `BowlingLeague.sqlite` in the backend project folder
- Swagger UI: `https://localhost:5000/swagger`

### Frontend

```bash
cd frontend
npm install
npm run dev
```

- Serves at `http://localhost:3000`

**Note:** The backend must be running for the frontend to fetch bowler data. CORS is configured to allow requests from `http://localhost:3000`.

## Ports

| Service  | Port | Config File                                                      |
| -------- | ---- | ---------------------------------------------------------------- |
| Frontend | 3000 | [frontend/vite.config.ts](frontend/vite.config.ts)               |
| Backend  | 5000 | [backend/.../Properties/launchSettings.json](backend/Mission10Assignment/Mission10Assignment/Properties/launchSettings.json) |

## Project Structure

```
Mission10Assignment/
├── frontend/                         # React + Vite SPA
│   ├── src/
│   │   ├── App.tsx
│   │   ├── Header.tsx
│   │   ├── BowlerList.tsx            # Fetches and displays bowler table
│   │   └── types/
│   │       └── bowler.ts
│   ├── package.json
│   └── vite.config.ts
├── backend/
│   └── Mission10Assignment/Mission10Assignment/
│       ├── Controllers/
│       │   └── BowlingController.cs  # GET /Bowling/GetBowlers
│       ├── Data/
│       │   ├── BowlingLeagueDbContext.cs
│       │   ├── Bowler.cs
│       │   └── Team.cs
│       ├── Program.cs
│       ├── appsettings.json
│       └── BowlingLeague.sqlite
└── README.md
```

## File Summary

### Frontend

- **bowler.ts** — TypeScript type for bowler data (id, name, address, team, phone, etc.)
- **App.tsx** — Root component that renders the Header and BowlerList
- **BowlerList.tsx** — Fetches bowlers from the API and renders them in a table
- **Header.tsx** — Displays the page title and welcome message for the Bowling League directory

### Backend

- **Bowler.cs** — Entity model for a bowler (ID, name, address, phone, TeamID)
- **Team.cs** — Entity model for a team (ID, name, CaptainID); has a collection of Bowlers
- **BowlingLeagueDbContext.cs** — EF Core DbContext; maps Bowlers and Teams to SQLite tables
- **BowlingLeague.sqlite** — SQLite database with bowler and team data
- **Program.cs** — App setup: controllers, CORS, EF Core, Swagger

## API

| Method | Endpoint               | Description                                      |
| ------ | ---------------------- | ------------------------------------------------ |
| GET    | /Bowling/GetBowlers    | Returns bowlers for Marlins and Sharks teams only |

## Frontend Scripts

| Script       | Command                | Description                      |
| ------------ | ---------------------- | -------------------------------- |
| `npm run dev`    | `vite`                 | Start development server         |
| `npm run build`  | `tsc -b && vite build` | Build for production             |
| `npm run lint`   | `eslint .`             | Run ESLint                       |
| `npm run preview`| `vite preview`         | Preview production build locally |
