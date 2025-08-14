# DotNet-Interview-Preparation

### Table of Contents

| No. | Questions |
| --- | --------- |
|1.| [Introduction to CSharp](#Introduction-toC-Sharp) |
|2.|[Introduction to .NET Framework](#Introduction-to-.NET-Framework)|
|3.|[Namespace in CSharp](#Namespace-in-CSharp)|
|4.|[Reading and Writing console in CSharp](#Reading-and-Writing-console-in-CSharp)|
|5.|[Built-in Data types in C#](Built-in-Data-types-in-C#)|
|6.|[String](#String-Type)|
|7.|[Common Operators](#Common-Operators)|
|8.|[Nullable Types](#Nullable-Types)|
|9.|[Conversion Datatype](#Conversion-Datatype)|
|10.|[Array in Csharp](#Array-in-Csharp)|
|11.|[CSharp Decision Making(If Condition)](#If-Condition)|
|12.|[While Loop](#While-Loop)|
|13.|[do-while Loop](#do-while-Loop)|
|14.|[for-loop](#for-loop)|
|15.|[forEach loop](#foreach-loop)|
|16.|[Switch-Condtion](#Switch-Condition)|






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


### Key CSharp Features

1. **Object-Oriented Programming (OOP)**: C# supports OOP principles like encapsulation, inheritance, and polymorphism, allowing for modular and reusable code.
2. **Strongly Typed**: C# is a strongly typed language, meaning that types are checked at compile time, reducing runtime errors.
3. **Automatic Memory Management**: C# uses a garbage collector to manage memory, which helps prevent memory leaks and other memory-related issues.
4. **Cross-Platform Development**: With .NET Core and .NET 5+, C# can be used to develop applications that run on Windows, macOS, and Linux.
5. **Robust Standard Library**: C# comes with a rich set of libraries that provide functionality for tasks like file I/O, easy debugging,exception handling networking, garbage collection, and data manipulation.
6. **Security Features**: C# includes features like type safety, code access security, and role-based security to help protect applications from unauthorized access and vulnerabilities, Common Language Runtime (CLR) checks type safety and makes sure that code. 
7. **Potable and Interoperable**: C# code can be easily ported across different platforms, and it can interoperate with other languages and technologies, such as COM and C++.


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

### Introduction to .NET Framework
The .NET Framework is a software development platform developed by Microsoft that provides a large library and supports various programming languages, including C#. 
It is primarily used for building Windows applications, web applications, and services.

#### Common Language Runtime(CLR):
This is Heart of .Net Framework. Acting as a virtual machine that runs the code and manages various services such as memory management, security, and thread management.
It is compiled and executed within the CLR is called "Managed Code"

#### .NET Framework Class Library (FCL):
It provides a large set of reusable classes and methods for application development.
It includes libraries for tasks like file I/O, networking, data access, and more, making it easier to develop applications without having to write everything from scratch.


#### Common Language Specification (CLS):
The CLS is a set of rules that all .NET languages must follow to ensure interoperability. It defines a subset of features that are common across all .NET languages, allowing them to work together seamlessly.

#### Common Type System (CTS):
the CTS defines how data types are declared, used, and managed in the .NET Framework. It ensures that types are consistent across different .NET languages, allowing for type safety and interoperability.

#### Assemblies:
Assemblies are compiled code libraries that contain metadata about the types and resources in the code. They can be either executable files (.exe) or dynamic link libraries (.dll). Assemblies are the building blocks of .NET applications and can be shared across different applications.

#### Application Domains:
Application domains provide a way to isolate applications within the same process. Each application domain has its own memory space, allowing multiple applications to run in the same process without interfering with each other.

#### Just-In-Time (JIT) Compilation:
JIT compilation is the process of converting Intermediate Language (IL) code into native machine code at runtime. This allows for platform independence and optimizations based on the specific hardware and operating system.

#### Garbage Collection:
The .NET Framework includes an automatic memory management system called garbage collection. It automatically reclaims memory that is no longer in use, helping to prevent memory leaks and improve application performance.

#### C# Program Structure
A C# program consists of one or more classes, which contain methods and properties. The program starts execution from the `Main` method, which is the entry point of the application.
Main method tell where to start execution of program and where it should end.
Every console application there should be one main method. to execute program.


```cs

using System;
namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
}
```


### Namespace in CSharp
It is Collection of Classes

Namespaces are used to organize Code the Collection of classesinterface structs and delegates.

The namespace declaration usingSystem indicates that you are using System nameSpace.

Two classes with the same name can be created inside 2 different namespaces in a single program.

**Basic Program**


```cs

//namespace declartion
using System;  //namespace System is required for Console class
class Program
{
    public static void Main()  //tells program where to start execution
    {
        Console.WriteLine("Welcome to C# Traning");

        //System.Console.WriteLine("Welcome to C# Traning"); // Using fully qualified name not declared in the top using this line
    }
}

```
**[⬆ Back to Top](#table-of-contents)**

### Reading and Writing console in CSharp
**1.Concatination**

System.Console class provides methods for interacting with the console.

```cs

using System; 
class Program
{
    public static void Main()
    {
        //Prompt the user for their name
        Console.WriteLine("Please enter your name");
        
        // Read user input from the console
        string UserName = Console.ReadLine();  //Return type string
       
        //String concatenation
        //Console.WriteLine("Hello " + UserName);  

        //Concatename name with hello world and print
        Console.WriteLine("Hello {0}", UserName); //Placeholder syntax

    }
}
```
**2.Place holder Syntax** - mostly prefer

Placeholder Syntax are use for multiple String like firstname lastname

```cs
using System; 

class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter your Firstname");        
       
        string FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your Lastname");

        string LastName = Console.ReadLine();       
      
        Console.WriteLine("Hello  {0} {1}"  FirstName, LastName);    //Hello  shital Padole    
    }
}

```
### Built-in Data types in C# :
Data types in C# are used to define the type of data that can be stored in a variable.

C# supports several built-in data types, which can be categorized into value types and reference types.

Types are divide into 2 Categories

Value Types - Int, Float , Double, Struct, enums etc

Reference Type - Interface, Class, Delegates, Array etc 

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
	  
		public static void Main(string[] args)
		{
		  char c='S';  // declaring char
		  
		  int i =10; // used for numeric values
		  
		  string name="shital"; //used for string
		  
		  short s = 56; //used for long values like 56487
		  
		  long l = 8976; // long uses Integer values which may signed or unsigned
		  
		  ulong salary= 8978;   // used for unsigned integer values
			
			uint ui = 95;  // UInt data type used for unsigned integer values
			
			ushort us =78; // larger than short range
			
			float f = 3.7867f;    // for float use 'f' as suffix
			
			double doubl = 46.9867;  // by default fraction value
			
			decimal dec = 897.6m; // for float use 'm' as suffix
			Console.WriteLine("Double "+doubl); 
			Console.WriteLine("float " +f);
			Console.WriteLine("ushort "+us);
			Console.WriteLine("ui " + ui);
			Console.WriteLine("char " + c);
			Console.WriteLine("name " + name);
			Console.WriteLine("Short " + s);
			Console.WriteLine("i " + i);
			Console.WriteLine("long " + l);
			Console.WriteLine("ulong " + salary);
		}
	}
}
```

**String**

It represents a sequence of Unicode characters and its type name is *System.String*.

Strings are immutable, meaning once created, they cannot be changed. 

Any operation that appears to modify a string actually creates a new string.

```cs
string s1 = "hello"; // creating through string keyword  
String s2 = "welcome"; // creating through String class  

```


### Verbatim Literal
Verbatim Literal is a string with an @ symbol prefix, as in @“Hello”. 
Verbatim literals make escape sequences translate as normal printable characters to enhance readability.

**Practical Example:**
Without Verbatim Literal : "C:\\Pragim\\DotNet\\Training\\Csharp"; // Less Readable
With Verbatim Literal : @"C:\Pragim\DotNet\Training\Csharp"; // Better Readable

```cs
using System; 
class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter your Firstname");

        // Displaying double quotes in c#
        string FirstName = "\"Shital\"";
        Console.WriteLine(@"Hello " + FirstName); 

        // Displaying new line character in c#
        string Name = "Shilpa \n Padole \n Manohar";
        Console.WriteLine(Name);

        // Displaying new line character in c#
        string Name1 = "C:\\Manohar\\Mahadeo\\Padole\\Csharp";
        Console.WriteLine(Name1);

        // C# verbatim literal
        Console.WriteLine(@"Hello " + FirstName);
        Console.WriteLine(@"c:\\Pragim\DotNet\Training");  

    }
}
```

### Common Operators

Assignment Operator =

Arithmetic Operators like +,-,*,/,% 

Comparison Operators like ==, !=,>, >=, <, <= 

Conditional Operators like &&, ||

Ternary Operator ?:

Null Coalescing Operator ??

### Nullable Types

Nullable types allow you to assign null to value types, which normally cannot be null. This is useful when dealing with databases or other scenarios where a value may be absent.

---
### Conversion Datatype

1. Implicit conversions
2. Explicit Conversions
3. Difference between Parse() and TryParse()

---

1. **Implicit Conversions**: 
These are automatic conversions that the compiler performs when converting a smaller data type to a larger data type without losing information. 

Implicit conversion is done by the compiler:

When there is no loss of information if the conversion is done
 
If there is no possibility of throwing exceptions during the conversion
 
Example: Converting an int to a float will not loose any data and no exception will be thrown, hence an implicit conversion can be done. 

Where as when converting a float to an int, we loose the fractional part and also a possibility of overflow exception. Hence, in this case an explicit conversion is required. 
For explicit conversion we can use cast operator or the convert class in c#.

For example, converting an `int` to a `long` or a `float` to a `double`.

```cs
public class Program
{
	public static void Main()
	{			
		float f  = 1234.645F;
		//Typecast Oprator is for explicit conversion using cast() Operator
		//int i = (int)f ; 
		
		//Or using Convert class		
		 int i = Convert.ToInt32(f);			
		 Console.WriteLine(i);			
	}
}

```
2. **Explicit Conversions**: These require a cast operator to convert a larger data type to a smaller data type, which may result in data loss. For example, converting a `double` to an `int` requires an explicit cast.

```cs
using System;
class Program
{
    public static void Main()
    {
        float f = 100.25F;

        // Cannot implicitly convert float to int.
        // Fractional part will be lost. Float is a
        // bigger datatype than int, so there is
        // also a possiblity of overflow exception
        // int i = f;

        // Use explicit conversion using cast () operator
        int i = (int)f;

        // OR use Convert class
        // int i = Convert.ToInt32(f);

        Console.WriteLine(i);
    }
}

```

3. **Parse() and TryParse()**: 
   - `Parse()` is used to convert a string representation of a number to its numeric type. It throws an exception if the conversion fails.
	-  Use Parse() if you are sure the value will be valid, otherwise use TryParse()
	- Parse() method throws an exception if it cannot parse the value, whereas TryParse() returns a bool indicating whether it succeeded or failed.
   - `TryParse()` attempts to convert a string to a numeric type and returns a boolean indicating success or failure, without throwing an exception.
	

**Basic Exmaple**

```cs
using System;
					
public class Program
{
	public static void Main()
	{			
		string strNumber = "1001"; //Convert numberwith character into integer
		// int i = int.Parse(strNumber);
		int Result = 0;
		bool isConversionSuccessful = int.TryParse(strNumber, out Result);
		
		if(isConversionSuccessful)
		{
			//true
			 Console.WriteLine(Result);
		}
		else
		{
			//false
			 Console.WriteLine("Please enter a valid Number");
		}
		
					
	}
}

```

### Array in Csharp

An array is a group of like-typed variables that are referred to by a common name. And each data item is called an element of the array. 
```cs
namespace HelloWorld
{
	public class Program
	{
		static void Main()
		{
		//We can not reinstialize again 
		int[] EvenNumbers = new int[3];

		EvenNumbers[0] = 1;
		EvenNumbers[1] = 2;
		EvenNumbers[2] = 3;

		Console.WriteLine(EvenNumbers[1]);

		int[] OddNumber = {1,2,3};

		}
	}
}

```


### CSharp Decision Making

**If Condition**

It Allow test multiple conditions

The && (conditional AND) and || (conditional OR) operators are used in C# to combine multiple boolean expressions and create more complex logical conditions.

if both condition1 and condition2 are true (using &&), or if at least one of them is true (using ||).
```cs
using System;
					
public class Program
{
	public static void Main()
	{			
		Console.WriteLine("Please enter a Number");
		
		int UserNumber = int.Parse(Console.ReadLine()); //Using 		Int.parse method we will convert String to number
		
	
		if(UserNumber != 1 && UserNumber != 2 && UserNumber !=3 )
		{
			Console.WriteLine("Your Number is Not between 1 and 3");
		}
		else if(UserNumber == 10 | UserNumber == 20)
		{
			Console.WriteLine("Your Number is 10 and 20");
		}
        else
        {
        Console.WriteLine("Invalid Number");
        }		
					
	}
}
```

**While Loop**

The test condition is given at the beginning of the loop, and all statements are executed till the given Boolean condition is satisfied. 

When the condition becomes false, the control will be out of the while loop.

The condition is checked before the loop body is executed.
If the condition is initially false, the loop body will never execute.

```cs
int i = 0;
while (i < Numbers.Length)
{
    Console.WriteLine(Numbers[i]);
    i++;
}
```


**do-while Loop**

The loop body is executed at least once before the condition is checked. 

The condition is checked after the loop body has executed for the first time.

If the condition is initially false, the loop body will still execute once.

`while loop`: May execute zero or more times.

`do-while loop`: Executes at least once, then zero or more additional times based on the condition
```cs

		do{
		Console.WriteLine("Do you want to continue YES or NO");		
		UserChoice = Console.ReadLine().ToUpper();
		
		if(UserChoice != "YES" && UserChoice != "NO")
		{
			Console.WriteLine("Invalid Choice,Please say YES or NO");
		}
		}while (UserChoice != "YES" && UserChoice != "NO");	
```

**For Loop**

When explicit control over the iteration is required, when index-based access or modification is necessary, or when the iteration pattern is complex.

```cs

  int[] Numbers = new int[4];

    Numbers[0] = 101;
    Numbers[1] = 102;
    Numbers[2] = 103;
    Numbers[3] = 104;

    //for loop 
    for (int j = 0; j < Numbers.Length; j++)
    {
        Console.WriteLine(Numbers[j]);
    }
```



**For-each Loop**

When iterating through all elements of a collection for processing, and simplicity and readability are prioritized over index-based control.

```cs
	int[] Numbers = new int[4];

    Numbers[0] = 101;
    Numbers[1] = 102;
    Numbers[2] = 103;
    Numbers[3] = 104;

  //foreach
	foreach (int k in Numbers)
	{
		Console.WriteLine(k);
	}

```

**Switch Condition**















### Methods

Methods in C# are blocks of code that perform a specific task and can be called upon when needed. 

They help in organizing code, promoting reusability, and improving readability.
 
Methods improve code organization, readability, and maintainability by promoting code reuse.

 Methods can take parameters, return values, and can be overloaded to provide different implementations based on the parameters passed.

**Static Method vs Instance Method**

The static method is declaration includes a static modifier.

When no static modifier is present, the method said to be instance method. 

Static method is invoked using the class name, where as an instance method is invoked using an instance of class.

The static method uses class memory rather than an object.

| Static Method | Instance Method |
|---------------|-----------------|
| Belongs to the **class** itself | Belongs to a **specific object** |
| Called using **ClassName.MethodName()** | Called using **object.MethodName()** |
| ❌ No object creation required | ✅ Object must be created before calling |
| Can access **only static members** directly | Can access **both static and instance members** |
| Same copy shared across all objects | Separate copy exists for each object |
| Good for **utility/helper functions** | Good for **operations on object’s data** |


```cs
using System;
					
public class Program
{
	public static void Main()
	{   Program.EvenNumbers(30);	 
		Program p = new Program();
		int sum = p.Add(30,60);
	 Console.Write(sum + " ");
	}
	public int Add(int FN, int SN) //integer return type
	{
		return FN + SN;
	}
	
	public static void EvenNumbers(int Target)  //Static method add parameter with int datatype
	{
		int Start = 0;
		while(Start <= Target)
		{
			Console.WriteLine(Start);
			Start = Start + 2;
		}
	}
}

```




#### Declaring a Method
 A method is declared using the following syntax:

 ```cs
 public int Max(int x, int y)
 {
	if(x>y)
	{
		return x;
	}
	else
	{
		return y;
	}
 }
 ```

 #### Method Parameter types
There are 4 types of method
You apply one of the following modifiers to a parameter declaration to pass arguments by reference instead of by value:

`Pass by Reference Parameter  (ref)`:

 Reference Parameter is used for passing the value types by reference

if any changes made in this argument in the method will reflect in that variable when the control return to the calling method

ref parameter does not pass the property.

 The argument must be initialized before calling the method. 
 
 The method can assign a new value to the parameter, but isn't required to do so.

 ```cs
 using System;

public class Program
{
    public static void Main()
    {
        int i = 0;       
        //pass reference parameter   
        SimpleMethod(ref i); // 101
        Console.Write(i);
    }

    public static void SimpleMethod(ref int a)
    {
        a = 101;
    }   
}
```
`Pass by Value Parameters`

It is a normal value parameter in a method Pass by Value.

when the variables are passed as value type they contain the data or value, not any reference.

If you will make any changes in the value type parameter then it will not reflect the original value stored as an argument.

```cs

using System;
					
public class Program
{
	public static void Main()
	{   
	 	string str1 = "shital";
	 	string str2 ="Padole";
	 	string res = AddStr(str1 , str2);	 //shitalpadole	
	 	Console.WriteLine(res);
		
	}
	
	public static string AddStr(string s1, string s2)
	{
		return s1 + s2;
	}
}
```


`Out Parameters`:
It is used for the passing the arguments to methods as a reference type.

It is generally used when a method returns multiple values.

The calling method isn't required to initialize the argument before calling the method. 
 
The method must assign a value to the parameter.

`Params`

It is useful when the programmer doesn’t have any prior knowledge about the number of parameters to be used. 

params you are allowed to pass any variable number of arguments.

Only one params keyword is allowed and no additional Params will be allowed in function declaration after a params keyword.

```cs
using System;
					
public class Program
{
	public static void Main()
	{  
		int[] Number = new int[3];
		Number[0] =101;
		Number[1] =102;
		Number[2] =103;
		ParamsMethod();  // There are 0 elements 
		ParamsMethod(Number); //There are 3 elements 101 102 103
	}
	
	public static void ParamsMethod(params int[] Numbers)
	{
		Console.WriteLine("There are {0} elements ",Numbers.Length);
		foreach(int i in Numbers)
		{
			Console.WriteLine(i);
		}
	}
  	
}

```

