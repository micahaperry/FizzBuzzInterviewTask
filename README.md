# Solution Overview

The test solution contains three projects:

1. FizzBuzzLib - where the business logic should be implemented, (contains interfaces for implementation API)
2. FizzBuzzLib.Tests - an XUnit project for testing `FizzBuzzLib`
3. FizzBuzzConsoleApp - dotnet Core console app

There are three interfaces defined:

1. `IFizzBuzz` defines the core piece of functionality for this task. It specifies one method that takes an int and returns a string.
2. `IFizzBuzzRange` specifies a method that takes a start int and an end int, and returns an enumerable of strings.
3. `IFlexiFizzBuzz` specifies that there should be a dictionary of int and strings, for use in the extended version

## Main Task

The task is to implement the following requirements in a TDD manner (one commit per task):

1. Implement the `IFizzBuzz` interface in the `FizzBuzz` class
   * Method `FizzBuzzifyAnInt` should return string representation of input integer, with the following substitutions:
     * Where input is a multiple of 3, method should return "Fizz"
     * Where input is a multiple of 5, method should return "Buzz"
     * Where input is a multiple of 3 and 5 (e.g. 15), method should return "FizzBuzz"

2. Implement the `IFizzBuzzRange` interface in the `FizzBuzz` class.
   * The `FizzBuzzValuesForRange` should take two integers, a "start" and "end" integer, iterate over a range containing both values, and return an enumerable of FizzBuzzed strings
  
3. The console app should run `FizzBuzzValuesForRange(1,100)` and write the results to the console (no XUnit test needed, just implement in console app)

## Extended Task

1. Implement `IFlexiFizzBuzz` in the FizzBuzz class, with the dictionary defaulting to `{ {3, "Fizz"}, {5, "Buzz"} }`
2. Refactor `FizzBuzzifyAnInt` to use the dictionary - for each dictionary key that the input is a multiple of, return value should include the corresponding string value.
3. Add the 3 following test cases for a range of 1-10:
   1. Dictionary contains default FizzBuzz values (i.e. default is not overwritten by setter). Result sequence should be as expected.
   2. Dictionary contains `{ {2, "Even"} }`. Result sequence should be `{"1", "Even", "3", "Even", "5", "Even", "7", "Even", "9", "Even"}`
   3. Dictionary contains `{ {2, "Quack"}, {5, "Honk"} }`. Result sequence should be `{ "1", "Quack", "3", "Quack", "Honk", "Quack", "7", "Quack", "9", "QuackHonk" }`