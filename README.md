# mycodeschool

C# implementations of the data structures and algorithms covered in the
[mycodeschool](https://www.youtube.com/user/mycodeschool) YouTube tutorials.
Each topic is a small, self-contained console app.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

`global.json` pins the 10.0.x SDK, so any 10.0 feature band installed on your
machine will be used.

## Build and run

Build everything:

```sh
dotnet build mycodeschool.sln
```

Run a single project by its folder name (quotes are needed because the names
contain spaces):

```sh
dotnet run --project "MergeSort"
dotnet run --project "Quick sort"
dotnet run --project "Prime numbers"
```

Some programs read a number from standard input and most wait for Enter
before exiting.

## Projects

The solution groups the projects into folders by topic.

### Sorting algorithms

| Project | What it does |
| --- | --- |
| `MergeSort` | Top-down merge sort on an `int[]` |
| `Quick sort` | In-place quicksort using Lomuto partitioning |

### Recursion

| Project | What it does |
| --- | --- |
| `Fibonacci Implementation` | Iterative Fibonacci, printing the first 15 terms |
| `Using factorial` | Recursive factorial with an optional trace of each call |

### Time complexity

| Project | What it does |
| --- | --- |
| `Prime numbers` | Compares an O(n) primality check with the O(√n) version |

### Misc

| Project | What it does |
| --- | --- |
| `Check for balanced parentheses` | Stack-based check that `()`, `[]` and `{}` are balanced |
| `Decimal to Binary` | Converts an integer to its binary digits using repeated division |
| `How many time a array si rotated` | Binary search for the pivot of a rotated sorted array |
| `Operators Evaluation` | Evaluates a postfix expression with a stack |
| `Power Equation` | O(n) and O(log n) exponentiation (uses `unsafe` pointers) |
| `Print 2-D Array in Spiral` | Walks a jagged array in spiral order |

## Layout

- `mycodeschool.sln` – solution with the topic folders above
- `Directory.Build.props` – shared settings (`net10.0`, implicit usings)
- `<Project>/Program.cs` – the implementation for each topic
