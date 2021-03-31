# CSharp.9.Stack

declarar una pila: 
```csharp
Stack<string> numbers = new Stack<string>();
```

Para agregar:
```csharp
numbers.Push("one");
numbers.Push("two");
numbers.Push("three");
numbers.Push("four");
numbers.Push("five");
```

obtener y eliminar:
```csharp
numbers.Pop();
```

solo obtener:
```csharp
Console.WriteLine(numbers.Peek());
```
