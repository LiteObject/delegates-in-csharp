// Action with no parameters
Action print1 = () => Console.WriteLine("Hello World!");
print1(); // Output: Hello World!

// Action with one parameter
Action<string> print2 = (message) => Console.WriteLine(message);
print2("Hello World!"); // Output: Hello World!

// Action with multiple parameters
Action<string,string> print3 = (message1, message2) => Console.WriteLine($"{message1} {message2}");
print3("Hello", "World!");
