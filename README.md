# .NET ERP DevOps

A DevOps portfolio project demonstrating the containerization, CI/CD automation, deployment, and infrastructure management of an ASP.NET Core ERP application.

## Project Overview

This project uses an existing ASP.NET Core ERP application as the workload for implementing and practicing a complete DevOps workflow.

The primary focus of this repository is:

* Application containerization with Docker
* Multi-container orchestration with Docker Compose
* SQL Server database integration
* Persistent database storage using Docker volumes
* Automated database initialization
* CI/CD automation with GitHub Actions
* Cloud deployment
* Application monitoring and operational practices

## Technology Stack

* **Application:** ASP.NET Core (.NET 8)
* **ORM:** Entity Framework Core
* **Database:** Microsoft SQL Server 2022
* **Containerization:** Docker
* **Orchestration:** Docker Compose
* **CI/CD:** GitHub Actions
* **Cloud:** AWS *(planned)*
* **Monitoring:** *(planned)*

## Architecture

The application currently runs as a multi-container Docker environment:

```text
                    User
                      |
                      v
              ASP.NET Core App
                 (.NET 8)
                      |
                      v
               SQL Server 2022
                      |
                      v
              Persistent Volume

        Database Initialization Container
                      |
                      v
                    MTDB
```

Docker Compose manages three services:

### Application

The ASP.NET Core application is built from its Dockerfile and communicates with SQL Server through the internal Docker network.

### Database

Microsoft SQL Server 2022 runs in a dedicated container with persistent storage provided through a Docker volume.

### Database Initialization

A dedicated initialization container executes the database initialization script before the application starts.

## Current DevOps Implementation

* [x] Dockerized ASP.NET Core application
* [x] SQL Server container
* [x] Docker Compose orchestration
* [x] Persistent database volume
* [x] Automated database initialization
* [x] Environment-based database credentials
* [ ] GitHub Actions CI pipeline
* [ ] Automated Docker image build
* [ ] Cloud deployment on AWS
* [ ] Monitoring and logging

## DevOps Roadmap

The next stages of this project will introduce:

1. Continuous Integration using GitHub Actions
2. Automated application build and validation
3. Automated Docker image builds
4. Container image registry integration
5. AWS deployment
6. Monitoring and logging
7. Deployment automation

## Purpose

This repository is maintained as a hands-on DevOps portfolio project to demonstrate practical experience with containerization, CI/CD pipelines, cloud deployment, database persistence, and application operations.

