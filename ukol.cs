using System;
using System.Collections.Generic;

var tasks = new List<string>();

Console.WriteLine("Task manager");
Console.WriteLine("Commands:");
Console.WriteLine("  add <task>  - add a new task");
Console.WriteLine("  list        - show all tasks");
Console.WriteLine("  exit        - quit");

while (true)
{
    Console.Write("> ");
    string? input = Console.ReadLine();
    if (input == null) break; // end of input (Ctrl+D)

    input = input.Trim();
    if (input.Length == 0) continue;

    string command = input.Split(' ', 2)[0].ToLower();
    string argument = input.Length > command.Length ? input.Substring(command.Length).Trim() : "";

    switch (command)
    {
        case "add":
            if (argument.Length == 0)
            {
                Console.WriteLine("Usage: add <task>");
            }
            else
            {
                tasks.Add(argument);
                Console.WriteLine($"Added task #{tasks.Count}: {argument}");
            }
            break;

        case "list":
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            break;

        case "exit":
            return;

        default:
            Console.WriteLine("Unknown command. Use: add <task>, list, exit");
            break;
    }
}
