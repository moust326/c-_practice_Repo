# Chapter 02 – Processing Data

# Reading Input with TextBox Controls

A TextBox is a Windows Forms control that allows the user to enter data using the keyboard.

The TextBox is commonly used to collect information such as:

- Names
- Numbers
- Addresses
- Student information
- Other user input

The Text property stores the information entered by the user.

---

# Variables

A variable is a storage location in computer memory used to hold data while a program is running.

Every variable has:

- A name
- A data type
- A value

A variable must be declared before it can be used.

---

# Data Types

A data type specifies what kind of data a variable can store.

C# provides built-in data types for storing different kinds of information.

Common data types include:

- string – stores text and characters.
- int – stores whole numbers.
- double – stores numbers that can contain decimal values.
- decimal – stores decimal numbers with greater precision and is commonly used for financial values.

---

# Variable Naming Rules

Variable names should be meaningful and easy to understand.

Important rules include:

- The first character must be a letter or underscore.
- Spaces are not allowed.
- Keywords and reserved words cannot be used as variable names.
- Meaningful names should be chosen to make programs easier to understand.

---

# String Variables

A string is a sequence or combination of characters.

Strings can contain:

- Letters
- Numbers
- Symbols
- Spaces

Strings are commonly used for names, descriptions, phone numbers, and other text information.

---

# String Concatenation

Concatenation means joining one string to another string.

In C#, the + operator can be used to join strings.

Concatenation can also combine strings with other data types such as integers and decimal numbers.

---

# Variable Scope

Scope describes the part of a program where a variable can be accessed.

A local variable belongs to the method where it is declared.

A local variable can only be accessed by statements inside that method.

---

# Variable Lifetime

The lifetime of a variable is the period during which the variable exists in memory while the program is running.

A local variable is created when its method starts executing and is destroyed when the method ends.

---

# Duplicate Variable Names

Two variables cannot have the same name within the same scope.

However, variables with the same name can exist in different methods because each method has its own scope.

---

# Assignment Compatibility

A value assigned to a variable must be compatible with the variable's data type.

For example, a string variable should receive string data, while numeric variables should receive compatible numeric data.

---

# Variable Initialization

A variable should have a value before its value is used.

Initialization means giving a variable its initial value.

Using an uninitialized local variable causes a compiler error.

---

# Numeric Data Types

Numeric data types are used when numbers need to be stored and used in mathematical operations.

The commonly used numeric types in this chapter are:

- int – whole numbers.
- double – real numbers, including fractional values.
- decimal – decimal values with greater precision, commonly used for financial applications.

---

# Numeric Literals

A numeric literal is a number written directly in a program.

Whole-number literals are treated as integers.

Numbers containing a decimal point are treated as double values.

A decimal literal uses the M or m suffix.

---

# Type Casting

Type casting means explicitly converting a value from one data type to another compatible type.

A cast operator is used when the programmer wants to explicitly convert a value.

Type casting can be useful when working with different numeric data types.

---

# The var Keyword

The var keyword allows the compiler to determine the data type automatically from the value assigned to a variable.

A variable declared with var must be initialized when it is declared.

The chapter explains that var is used for local variables.

---

# Arithmetic Operators

C# provides arithmetic operators for performing calculations.

The main operators are:

- + Addition
- - Subtraction
- * Multiplication
- / Division
- % Modulus

The modulus operator gives the remainder of a division.

---

# Order of Operations

Mathematical expressions follow the rules of operation precedence.

Parentheses can be used to group operations and control the order in which calculations are performed.

---

# Integer Division

When two integer values are divided, the result is an integer.

The fractional part is not retained.

To obtain a fractional result, the calculation must involve a type such as double.

---

# Inputting Numeric Values

Data entered through a TextBox is treated as a string, even when the user enters a number.

Therefore, when numeric calculations are required, the string input must be converted into the appropriate numeric data type.

---

# Parse Methods

C# provides Parse methods for converting string input into numeric values.

Important Parse methods include:

- int.Parse – converts a string to an integer.
- double.Parse – converts a string to a double.
- decimal.Parse – converts a string to a decimal.

---

# Displaying Numeric Values

The Text property of controls such as Labels and TextBoxes accepts string values.

Therefore, numeric values may need to be converted into strings before they are displayed.

The ToString method is used to convert a value into a string representation.

# Summary

# Chapter 02 explains how C# programs
1.receive
2.store
3.convert
4.process
5.display data

It covers TextBox input, variables, data types, strings, numeric values, scope, initialization, type casting, var, arithmetic operators, Parse methods, and ToString().
In short:
Input → Store in Variables → Convert Data → Process/Calculate → Display Output