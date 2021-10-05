# Welcome to Data Acquisition App

This is a .NET5 + Angular 12 multi-layered web application to learn how to use some .NET and Angular features and how to implement some design patterns with real-life examples.

Web UI project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 12.2.2.

## What does this application do?

This application allows users to collect data from different type of data loggers and display experiment results on UI.

Each data logger device belong to a workstation, workstations belong to a facility, facilities belong to a company.

Users can add new facilities, workstations and devices to create experiments (test reports) regarding their companies' organization structure.

## Installation

### Backend

1. Choose DataAcquision.API as a startup project.

2. In Package Manager Console, choose DataAcquisition.DataAccessEF as a Default Project and run `Update-Database` command. This will create local database and will apply seed data.

### Frontend

1. Install Nodejs LTS `14.16.1`

2. On VS Code terminal or Powershell, go to acquisition-web-app folder and run `npm install` command.

## Start the application

1. Start DataAcquision.API, you will see the swagger document.

2. In Angular project, run `ng serve` command and navigate to `http://localhost:4200/`.

## Backend Project Structure

![image](/backend-structure.png "Backend Project Structure")
