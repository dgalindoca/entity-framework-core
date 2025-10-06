# Entity Framework Core Course

## What is Entity Framework Core

Is a lightweight, cross-platform, open-source object-relational mapper (ORM) for .NET developers to access and persist data

## What is an ORM

An *Object-Relational Mapping (ORM)* is a programming technique that **creates a bridge between a relational database and an object-oriented programming language**. ORMs act as a translator, allowing developers to **interact with and manipulate data in the database using their programming language's familiar objects and paradigms**, rather than writing complex Structured Query Language (SQL).

## Entity Framework Core Tools

* add-migration \[MigrationName]: Creates a new **migration file** based on the **changes detected in the DbContext** and model classes compared to the last applied migration. This file **contains C# code that defines the necessary operations to evolve the database schema**.
* update-database: Applies any **pending migrations*** to the database, bringing its schema in line with the application's current model.
* remove-migration: Removes the **most recently added migration** that has **not yet been applied to the database**.

    **Note:** This command should only be used for migrations that have not been applied to the database using *update-database*. If a migration has already been applied, removing it directly can lead to inconsistencies.

## When to add a migration?

1. Add a new Class / table in the database
2. Add a new property / Column to table
3. Modify existing property / Column in a table *(e.g. Renaming property, changing data type)*
4. Delete existing property / Column in a table
5. Delete a Class / table in the database
