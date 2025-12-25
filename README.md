# OOP_HRSystem is a simple console-based Human Resources Management System developed using C#.
# The project is designed to demonstrate core Object-Oriented Programming (OOP) principles through a real-world scenario such as employee management and salary calculation.
# The system supports multiple employee types (Salaried, Hourly, and Intern), each with its own salary calculation logic. It also generates employee payslips and sends notifications using a flexible notification mechanism.

OOP_HRSystem 
- **Person (abstract)**
  - **Employee (abstract)**
    - SalarriedEmployee
    - HourlyEmployee
    - InternEmployee
  - Applicant

- PayItem  
- PaySlipGenerator  
- INotifier  
- Notifier  
- Program.cs

✅ Inheritance

Inheritance is used to avoid code duplication and to share common properties and behaviors between related classes.

Examples In my project:

Employee inherits from Person

SalarriedEmployee, HourlyEmployee, and InternEmployee inherit from Employee

Benefits:

All employees share common data such as name, birth date, and email

Each employee type has its own salary calculation logic

✅ Polymorphism

Polymorphism is implemented using abstract methods and method overriding.

Examples In My Project:

The method GetSalary() is declared in the Employee abstract class

Each employee type provides its own implementation of GetSalary()

✅ Abstraction

Abstraction is used to hide implementation details and focus on defining common behavior.

Examples In My Project:

Person and Employee are defined as abstract classes

They cannot be instantiated directly

Benefits:

Enforces rules on derived classes

Ensures that every employee implements essential methods such as GetSalary()

✅ Interface

Interfaces are used to define contracts between classes without creating tight coupling.

Examples In My Project:

INotifier defines the Notify method

Notifier implements the INotifier interface

Benefits:

New notification types (Email, SMS, etc.) can be added without modifying existing logic

Reduces direct dependencies between classes

✅ Encapsulation

Encapsulation is used to protect data and restrict direct access to class members.

Examples In My Project:

FirstName and LastName have private setters

Names can only be set using the SetName method with validation

BirthDate is validated inside its property setter

Benefits:

Protects data integrity

Prevents invalid values

Provides controlled access to class properties

✅ Immutable Object

Immutable objects are used for sensitive data that should not change after creation.

Examples In My Project:

The PayItem class

Name and Value properties do not have setters
