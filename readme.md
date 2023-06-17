# Action and Func delegates in C#

## Prerequisite
If you're already familier with the concept of `delegate`, then you can skip the next section titled "What is a delegate?."

## What is a `delegate`?
In C#, a `delegate` is a way to encapsulate a method reference that allows you to treat the method as an objects. Let's take a look at an example here:

```csharp

// Declare your delegate
public delegate void MyDelegate(string message);

static void Main(string[] args)
{
  // Instantiate the delegate by assigning the `PrintMessage` method
  MyDelegate myDelegate = PrintMessage;

  // Call the delegate with the message "Hello, world!".
  myDelegate("Hello, world!");
}

static void PrintMessage(string message)
{
  Console.WriteLine(message);
} 
```

### There are two commonly used generic delegate types: 
* `Action`
* `Func`

## What is an `Action` Delegate?

The Action delegate is a generic type delegate that represents **a method that does not return a value**. It can take up to 16 input parameters of any type.

```csharp

// Action with no parameters
Action print1 = () => Console.WriteLine("Hello World!");
print1(); // Output: Hello World!

// Action with one parameter
Action<string> print2 = (message) => Console.WriteLine(message);
print2("Hello World!"); // Output: Hello World!

// Action with multiple parameters
Action<string,string> print3 = (message1, message2) => Console.WriteLine($"{message1} {message2}");
print3("Hello", "World!"); // Output: Hello World!
```

## What is an `Func` Delegate?

The Func delegate is a generic type delegate that represents **a method that takes input parameters and returns a value**. The last type argument of Func represents the return type. It can take up to 16 input parameters. 

```csharp

```

## Links
* [Using Delegates (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates)
* [Action<T> Delegate](https://learn.microsoft.com/en-us/dotnet/api/system.action-1?view=net-7.0)
* [Func<TResult> Delegate](https://learn.microsoft.com/en-us/dotnet/api/system.func-1?view=net-7.0)
