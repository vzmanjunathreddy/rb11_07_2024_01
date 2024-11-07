// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

Console.WriteLine("Hello, World!");
await ProcessDataFromApi.WaitForAny();

await ProcessDataFromApi.WaitForAll();