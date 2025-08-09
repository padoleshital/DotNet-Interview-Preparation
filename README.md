# DotNet-Interview-Preparation

### Table of Contents



### Introduction to C-Sharp
C# (C-Sharp) is a object-oriented  programming language developed by Microsoft that runs on the .NET Framework.
 
C# is used to develop web apps, desktop apps, mobile apps, games and much more. 

C# has roots from the C family, language is close to other popular languages like C++ and Java.

The first version was released in year 2002. The latest version, C# 13 was released in November 2024 alongside .NET 9.

**C# is used for**
- Mobile applications
- Desktop applications
- Web applications
- Web services
- Web sites
- Games
- VR
- Database applications

**Why C#**

It is one of the most popular programming languages in the world.

It is easy to learn and simple to use.

It has huge community support

C# is an object-oriented language which gives a clear structure to programs and allows code to be reused, lowering development costs

As C# is close to C, C++ and Java, it makes it easy for programmers to switch to C# or vice versa

**Basic Program**

```cs
using System;

namespace HelloWorld
{
	public class NewClass1
	{
		
		public string SayHelloFromNewClass()
		{
			return "Hello from New Class 1!";
		}
	}
}
```
**[⬆ Back to Top](#table-of-contents)**

### Key C# Features

1. **Object-Oriented Programming (OOP)**: C# supports OOP principles like encapsulation, inheritance, and polymorphism, allowing for modular and reusable code.
2. **Strongly Typed**: C# is a strongly typed language, meaning that types are checked at compile time, reducing runtime errors.
3. **Automatic Memory Management**: C# uses a garbage collector to manage memory, which helps prevent memory leaks and other memory-related issues.
4. **Cross-Platform Development**: With .NET Core and .NET 5+, C# can be used to develop applications that run on Windows, macOS, and Linux.
5. **Robust Standard Library**: C# comes with a rich set of libraries that provide functionality for tasks like file I/O, easy debugging,exception handling networking, garbage collection, and data manipulation.
6. ** Security Features**: C# includes features like type safety, code access security, and role-based security to help protect applications from unauthorized access and vulnerabilities, Common Language Runtime (CLR) checks type safety and makes sure that code. 
7. ** Potable and Interoperable**: C# code can be easily ported across different platforms, and it can interoperate with other languages and technologies, such as COM and C++.


### Execution of C# 

C# code is typically executed in the following steps:

1. **Compiling the Program**: C# source code (.cs files) is compiled by the C# compiler (csc.exe) into an intermediate language (IL) code, which is platform-independent.Executed on any system that has the .NET runtime installed
2. **Creating the Program**: C# programs are written using text editors or Integrated Development Environments (IDEs) like Visual Studio. The source code is saved with a .cs extension.
3. **Running the Program**:The .NET runtime (CLR) executes the compiled IL code. The CLR translates the IL code into native machine code, specific to the platform and architecture and it enables the program to run on different operating systems and devices.

```cs

// Example of a simple C# program
using System;
namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Console.Readkey(); // Wait for user input before closing the console window
		}
	}
}
```

**[⬆ Back to Top](#table-of-contents)**