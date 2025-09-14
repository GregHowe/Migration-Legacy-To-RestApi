# 💼 Richard's Portfolio (Final)

![.NET](https://img.shields.io/badge/.NET-8.0-blue) ![Vue](https://img.shields.io/badge/Vue-3-green) ![Postgres](https://img.shields.io/badge/Postgres-15-blueviolet) ![Docker](https://img.shields.io/badge/Docker-Compose-2496ED) ![Tests](https://img.shields.io/badge/Tests-xUnit%20%7C%20Jest-success)

This repository is a polished, runnable portfolio prepared for the Senior Fullstack .NET Developer interview.

## What is included
- backend-dotnet-postgres: .NET 8 Web API (EF Core, Repository/Service pattern, migrations + seed data)
- frontend-vue-demo: Vue 3 + Vite + TypeScript frontend (Axios, simple Product list)
- fullstack-dockerized: Docker Compose to run backend + frontend + Postgres
- docs/: Detailed case study PDF, coding guidelines, architecture diagram, screenshots/GIF placeholders
- .github/workflows/ci.yml: CI to run backend and frontend tests

## Quick start (Docker required)
```bash
cd fullstack-dockerized
docker compose up --build
```
- Backend: http://localhost:5000/swagger
- Frontend: http://localhost:8080

## Tests
### Backend (xUnit)
From `backend-dotnet-postgres` folder:
```bash
dotnet test
```

### Frontend (Jest)
From `frontend-vue-demo` folder:
```bash
npm install
npm run test
```

## How to push to GitHub (clean commits)
```bash
git init
git add .
git commit -m "chore: init portfolio"
# then commit by area as suggested in docs
```
