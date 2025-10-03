# Entity Framework Core Course

## What is Entity Framework Core

Is a lightweight, cross-platform, open-source object-relational mapper (ORM) for .NET developers to access and persist data

## What is an ORM

An *Object-Relational Mapping (ORM)* is a programming technique that **creates a bridge between a relational database and an object-oriented programming language**. ORMs act as a translator, allowing developers to **interact with and manipulate data in the database using their programming language's familiar objects and paradigms**, rather than writing complex Structured Query Language (SQL).

## Entity Framework Core Tools

* add-migration \[MigrationName]: Creates a new **migration file** based on the **changes detected in the DbContext** and model classes compared to the last applied migration. This file **contains C# code that defines the necessary operations to evolve the database schema**.
* update-database: Applies any **pending migrations*** to the database, bringing its schema in line with the application's current model.
