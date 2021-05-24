DI Container Kata
=================

Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

## Instructions

Building a simple DI container is an excellent way to improve your understanding of dependency injection, reflection, and generics. In this kata, you will be provided with a set of tests to write that demonstrate that your container you're writing meets the requirements. Write each test one by one, then implement the necessary logic in the container to make the tests succeed. Refactor after each step. You're free to give the container whatever API you prefer or to stick with the suggested `Register` and `Resolve` methods.

In general there are 3 steps involved in testing the container:

- Create a container instance
- Register one (or more) types
- Resolve a type

Each test will include all of these steps (though some may move to constructor/fields or helpers).

## Requirements (Tests)

1. Resolve returns a simple non-generic type using a parameterless constructor.
2. Resolve returns a simple non-generic type instance that implements a non-generic interface using its parameterless constructor.
3. Resolve throws a descriptive exception when attempting to resolve a type for which nothing has been registered.
4. Resolve returns an instance of a type that requires a non-generic type as its only constructor parameter.
5. Resolve a specific instance of a generic type using its parameterless constructor.
6. Resolve a type that requires a specific generic type.
7. Resolve a generic type that requires a non-generic type in its constructor.
8. Resolve a generic type that requires another generic type in its constructor.

## Resources (.NET)

- [Activator.CreateInstance Method](https://docs.microsoft.com/en-us/dotnet/api/system.activator.createinstance?view=net-5.0)
- [Type.GetConstructors](https://docs.microsoft.com/en-us/dotnet/api/system.type.getconstructors?view=net-5.0)
