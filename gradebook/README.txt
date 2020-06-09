The purpose of this project is to create an electronic grade book to read the scores of an individual student and then compute some simple statistics from the scores.

The grades are entered as floating point numbers from 0 to 10, and the statistics show us the highest grade, the lowest grade, and the average grade.

Project is created using .NET enviroment and it is designed following the most important features of C# language: abstraction, encapsulation, inheritance and polymorphism.
The code that shows only the main functionalities of software is stored in file Program.cs and all the calculations of entered grades and method which adds the grade are abstracted from the Main method and encapsulated in class Stats (Stats.cs). The program has a base class - Book (Book.cs) which inherits class NamedObject (NamedObject.cs) and interface IBook (IBook.cs). Then two different book classes InMemoryBook and DiskBook inherits base class Book and overrides methods AddGrade and GetsStats in order to implement different storing of grades. Entered grades are stored either in temporary memory or in .txt file.

Project includes unit tests (xUnit), exception and events handling, inheritance from class and from interface.
