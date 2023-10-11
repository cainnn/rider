﻿CREATE TABLE IF NOT EXISTS Employees (
                                         "Id" INTEGER NOT NULL,
                                         "FirstName" TEXT NOT NULL,
                                         "LastName" TEXT NOT NULL,
                                         "Age" INTEGER NOT NULL,
                                         PRIMARY KEY("Id" AUTOINCREMENT)
    );
CREATE TABLE IF NOT EXISTS Studios (
                                       "Id" INTEGER NOT NULL,
                                       "HouseNumber" INTEGER NOT NULL,
                                       "City" TEXT NOT NULL,
                                       "EmployeeId" INTEGER NOT NULL UNIQUE,
                                       PRIMARY KEY("Id" AUTOINCREMENT),
    FOREIGN KEY (EmployeeId) REFERENCES Employees (Id)
    );
CREATE TABLE IF NOT EXISTS Albums (
                                      "Id" INTEGER NOT NULL,
                                      "Title" TEXT NOT NULL,
                                      "Price" REAL NOT NULL,
                                      "EmployeeId" INTEGER NOT NULL,
                                      PRIMARY KEY("Id" AUTOINCREMENT),
    FOREIGN KEY (EmployeeId) REFERENCES Employees (Id)
    );
CREATE TABLE IF NOT EXISTS Tags (
                                    "Id" INTEGER NOT NULL,
                                    "Title" TEXT NOT NULL,
                                    PRIMARY KEY("Id" AUTOINCREMENT)
    );
CREATE TABLE IF NOT EXISTS AlbumTags(
                                        AlbumId INTEGER,
                                        TagId INTEGER,
                                        FOREIGN KEY(AlbumId) REFERENCES Albums(Id) ON DELETE CASCADE,
    FOREIGN KEY(TagId) REFERENCES Tags(Id) ON DELETE CASCADE,
    PRIMARY KEY(AlbumId, TagId)
    );


















