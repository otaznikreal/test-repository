# Task Manager

A small C# console app for adding tasks and listing them.

## Requirements

- .NET 10 SDK or newer (it can run a single `.cs` file directly, so no project file is needed)

## How to run

From the folder that contains `ukol.cs`:

```
dotnet run ukol.cs
```

## How to use it

When the app starts, it shows the available commands and a `>` prompt. Type a command and press Enter.

| Command      | What it does                     |
|--------------|----------------------------------|
| `add <task>` | Adds a new task to the list      |
| `list`       | Prints every task, numbered      |
| `exit`       | Quits the program                |

Commands are not case-sensitive (`ADD` and `add` both work).

### Example

```
> add Buy milk
Added task #1: Buy milk
> add Do homework
Added task #2: Do homework
> list
1. Buy milk
2. Do homework
> exit
```

## How it works

- Tasks are stored in a `List<string>` in memory.
- The program runs a loop: it reads a line, then splits it into the **command** (the first word) and the **argument** (everything after it).
- A `switch` on the command decides what happens:
  - `add` checks that some text was given, adds it to the list and prints its number.
  - `list` prints "No tasks yet." if the list is empty, otherwise prints each task with its number.
  - `exit` ends the program.
  - Anything else prints an "Unknown command" message.
- Empty lines are ignored, and the program also ends cleanly on end of input (Ctrl+D).

## Limitations

- Tasks are not saved. They are lost when the program closes.
- Tasks can't be removed or marked as done.
