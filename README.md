# C# Learning Archive

A structured archive of C# classwork, laboratory assignments, and homework completed during the Code Academy learning period.

The original exercise implementations are preserved as learning history. The repository structure, project names, solution files, and generated-file handling have been standardized so each project is easier to find, open, and review.

> This repository contains personal educational work and is not an official Code Academy repository.

## Repository Structure

```text
CSharp/
├── Classwork/
├── Labs/
├── Homework/
├── .gitignore
└── README.md
```

- `Classwork` contains numbered console applications and short exercises completed during lessons.
- `Labs` contains the PA201 laboratory assignments.
- `Homework` contains named exercises, packages, and larger applications.
- Projects are grouped by their primary subject, while exercises covering several concepts are placed under the closest matching topic.

## Status Guide

| Status | Meaning |
|---|---|
| `Working` | The solution completed a `dotnet build` successfully. |
| `Incomplete` | The original source currently contains compilation errors or missing references. |
| `Duplicate` | The solution builds, but substantially overlaps another exercise in the archive. |
| `Not Tested` | A build could not be completed in the current environment. |

Build status describes compilation only. Database applications may still require SQL Server and a valid local connection string. File-based exercises containing original Windows paths may require path configuration before they can run on another operating system.

## Classwork

| Topic | Project | Original name | Status |
|---|---|---|---|
| Algorithms | [BinarySearch](Classwork/Algorithms/BinarySearch) | `ConsoleApp3` | Working |
| Algorithms | [PalindromeNumbers](Classwork/Algorithms/PalindromeNumbers) | `Test1` | Working |
| Arrays and Strings | [ArrayAndStringExercises](Classwork/ArraysAndStrings/ArrayAndStringExercises) | `ConsoleApp4` | Incomplete |
| Arrays and Strings | [EmailDomainExtractor](Classwork/ArraysAndStrings/EmailDomainExtractor) | `ConsoleApp7` | Working |
| Arrays and Strings | [StaircaseAndArrayAppend](Classwork/ArraysAndStrings/StaircaseAndArrayAppend) | `ConsoleApp5` | Working |
| Entity Framework | [StudentRelationshipDemo](Classwork/EntityFramework/StudentRelationshipDemo) | `ConsoleApp13` | Working |
| File I/O | [EmployeeJsonStorage](Classwork/FileIO/EmployeeJsonStorage) | `ConsoleApp11` | Working |
| Fundamentals | [EvenNumberRangeStatistics](Classwork/Fundamentals/EvenNumberRangeStatistics) | `ConsoleApp2` | Working |
| Fundamentals | [TriangleAndNumberExercises](Classwork/Fundamentals/TriangleAndNumberExercises) | `Test2` | Duplicate |
| Methods | [BasicMethodExercises](Classwork/Methods/BasicMethodExercises) | `ConsoleApp6` | Working |
| OOP | [DoctorQueryService](Classwork/OOP/DoctorQueryService) | `ConsoleApp8` | Working |
| OOP | [LibraryManagement](Classwork/OOP/LibraryManagement) | `ConsoleApp10` | Working |
| OOP | [StaticInstanceCounter](Classwork/OOP/StaticInstanceCounter) | `ConsoleApp9` | Working |
| OOP | [TypeConversionAndCurrencyExchange](Classwork/OOP/TypeConversionAndCurrencyExchange) | `ConsoleApp12` | Working |

## Labs

| Topic | Project | Original name | Status |
|---|---|---|---|
| Entity Framework | [EventTicketingSystem](Labs/EntityFramework/EventTicketingSystem) | `Pa201LabN7` | Working |
| File I/O | [CardTransactionSystem](Labs/FileIO/CardTransactionSystem) | `Pa201LabN5` | Working |
| Fundamentals | [ConditionalExercises](Labs/Fundamentals/ConditionalExercises) | `Pa201Lab` | Working |
| Fundamentals | [LoopsAndArrays](Labs/Fundamentals/LoopsAndArrays) | `Pa201LabN2` | Working |
| Methods | [MethodAndStringExercises](Labs/Methods/MethodAndStringExercises) | `Pa201LabN3` | Working |
| OOP | [CargoManagement](Labs/OOP/CargoManagement) | `Pa201LabN6` | Incomplete |
| OOP | [FoodService](Labs/OOP/FoodService) | `Pa201LabN4v2` | Working |
| OOP | [OrderManagement](Labs/OOP/OrderManagement) | `Pa201LabN4` | Working |

## Homework

| Topic | Project | Original name | Status |
|---|---|---|---|
| Algorithms | [AlgorithmExercises](Homework/Algorithms/AlgorithmExercises) | `AlgorithmDataStructure` | Working |
| Algorithms | [ArrayAndSearchExercises](Homework/Algorithms/ArrayAndSearchExercises) | `DataStructures` | Working |
| Algorithms | [MixedAlgorithmExercises](Homework/Algorithms/MixedAlgorithmExercises) | `CopilotAlgorithm` | Working |
| Collections | [StackQueueHashSet](Homework/Collections/StackQueueHashSet) | New practice | Working |
| Data Access | [AdoNetStudentManagement](Homework/DataAccess/AdoNetStudentManagement) | `AdoNetProject` | Working |
| Entity Framework | [AcademyManagementApp](Homework/EntityFramework/AcademyManagementApp) | `AcademyApp` | Working |
| Entity Framework | [BookLibraryApp](Homework/EntityFramework/BookLibraryApp) | `BookApp` | Working |
| Entity Framework | [CourseManagementApp](Homework/EntityFramework/CourseManagementApp) | `CourseApp` | Working |
| Entity Framework | [GroupCrudDemo](Homework/EntityFramework/GroupCrudDemo) | `OrmEfProject` | Working |
| Entity Framework | [RestaurantReservationApp](Homework/EntityFramework/RestaurantReservationApp) | `RestaurantApp` | Working |
| Fundamentals | [ControlFlowAndLoopExercises](Homework/Fundamentals/ControlFlowAndLoopExercises) | `ControlFlowAndLoop` | Working |
| Fundamentals | [DigitAnalysisExercises](Homework/Fundamentals/DigitAnalysisExercises) | `CSharpIntro` | Working |
| Fundamentals | [DoWhilePractice](Homework/Fundamentals/DoWhilePractice) | New practice | Working |
| Fundamentals | [MethodExercises](Homework/Fundamentals/MethodExercises) | `Methods` | Working |
| Fundamentals | [StringAndArrayExercises](Homework/Fundamentals/StringAndArrayExercises) | `StringMethods` | Working |
| OOP | [CalculatorApp](Homework/OOP/CalculatorApp) | `Classes` | Working |
| OOP | [DelegateAndEventDemo](Homework/OOP/DelegateAndEventDemo) | New practice | Working |
| OOP | [DoctorManagementApp](Homework/OOP/DoctorManagementApp) | `ClassesProject` | Working |
| OOP | [EmployeeManagementApp](Homework/OOP/EmployeeManagementApp) | `InterfaceProject` | Working |
| OOP | [LibraryManagementApp](Homework/OOP/LibraryManagementApp) | `DelegateMiniApp` | Incomplete |
| OOP | [ObjectCopyingDemo](Homework/OOP/ObjectCopyingDemo) | `ObjectCopy` | Working |
| OOP | [VirtualOverrideAndHiding](Homework/OOP/VirtualOverrideAndHiding) | New practice | Working |
| Packages | [CaesarCipherPackage](Homework/Packages/CaesarCipherPackage) | `CriptografiaPackage` | Working |
| Packages | [MorseCodePackage](Homework/Packages/MorseCodePackage) | `MorseCodePackage` | Working |

## Build Summary

- 46 independent pieces of coursework
- 50 `.csproj` files
- 46 validated solution files
- 42 projects marked `Working`
- 3 projects marked `Incomplete`
- 1 project marked `Duplicate` and confirmed to build

The four new practice projects build successfully and their console output has been checked. The remaining statuses come from the earlier archive build pass.

Known compilation issues have been left unchanged to preserve the original exercise implementations:

- `ArrayAndStringExercises` redeclares local variables in the same top-level scope.
- `CargoManagement` has unresolved namespace references in its original source.
- `LibraryManagementApp` has an unresolved service namespace in its original source.

## C# Coverage

The archive demonstrates:

- Variables, data types, conversions, conditions, and loops
- `do-while` loops with input validation and repeated calculation
- Arrays, strings, methods, `params`, `ref`, and `out`
- Classes, constructors, encapsulation, inheritance, abstraction, and polymorphism
- Virtual methods, overriding, and method hiding
- Interfaces, enums, generics, extension methods, indexers, and custom exceptions
- Custom delegates, events, and event subscriptions
- Collections including `List<T>`, `Dictionary<TKey, TValue>`, `Stack<T>`, `Queue<T>`, and `HashSet<T>`
- LINQ, lambdas, regular expressions, and object copying
- File I/O and JSON serialization
- Async programming and Entity Framework Core
- ADO.NET and SQL Server access
- Class libraries and NuGet package creation

The focused examples are [DoWhilePractice](Homework/Fundamentals/DoWhilePractice), [DelegateAndEventDemo](Homework/OOP/DelegateAndEventDemo), [VirtualOverrideAndHiding](Homework/OOP/VirtualOverrideAndHiding), and [StackQueueHashSet](Homework/Collections/StackQueueHashSet).

## Running a Project

Open the relevant `.sln` file in Visual Studio or Rider, or run a project directly with the .NET CLI:

```bash
dotnet run --project path/to/Project.csproj
```

To check compilation without running the application:

```bash
dotnet build path/to/Solution.sln
```

## Notes

- Generated build output and IDE-specific files are excluded by the root `.gitignore`.
- EF Core migration files are retained because they are part of the source history.
- Existing namespaces and internal class or method names are preserved, including historical spelling, to avoid changing the learning code.
- NuGet package identity and version metadata are preserved even when the containing folder has a clearer display name.

## License

This repository is maintained for educational and portfolio purposes. Unless otherwise specified, all rights are reserved.
