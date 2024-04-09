using reWASDHttpClient.Exceptions;
using System.Runtime.Serialization;
using reWASDHttpClient;

try
{
    Console.WriteLine($"Choose a action to run:{Environment.NewLine}");
    Console.WriteLine("1. Print all controllers with applied configs.");
    Console.WriteLine("2. Print all configs by each game.");
    Console.WriteLine("3. Try do remap for first found controller and first found config. And also show events for remap.");

    string? input = Console.ReadLine();
    Console.Clear();

    switch (input)
    {
        case "1":
            await Client.PrintControllersWithAppliedConfigs();
            break;
        case "2":
            await Client.PrintGamesWithConfigs();
            break;
        case "3":
            await Client.TryRemapWithEvents();
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a number between 1 and 3.");
            break;
    }
}
catch (Exception ex)
{
    switch (ex)
    {
        case ConnectException:
            Console.WriteLine($"Connection error. {ex.Message}");
            break;
        case HttpException httpException:
            Console.WriteLine($"Server error: code - {httpException.StatusCode}, message - {httpException.Message}");
            break;
        case SerializationException:
            Console.WriteLine($"Serialization error. {ex.Message}");
            break;
        default:
            Console.WriteLine($"Exception: {ex.Message}");
            break;
    }
}