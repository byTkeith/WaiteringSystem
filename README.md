Overview
This project is a simple Windows Forms Application named WaiteringSystem. It includes several key components that are structured to handle the basic functionality of a waitering system. The project is built using C# and the .NET Framework, utilizing Windows Forms for the user interface.

Project Structure
1. Program.cs
Namespace: WaiteringSystem
Class: Program
This file contains the Main method, which serves as the entry point of the application.
The Main method initializes the application's settings and launches the main form (Form1).
2. Person.cs
Namespace: WaiteringSystem
Class: Person
This is an abstract class representing a general person within the system.
Data Members:
id: Represents the unique identifier for a person.
name: Represents the name of the person.
phone: Represents the contact number of the person.
Properties:
ID: Getter and setter for the id field.
Name: Getter and setter for the name field.
Phone: Getter and setter for the phone field.
Constructors:
Default constructor.
Parameterized constructor to initialize id, name, and phone.
Methods:
ToString(): Overrides the default ToString method to return a string containing the name and phone number of the person.
