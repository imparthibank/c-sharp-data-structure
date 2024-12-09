//See https://aka.ms/new-console-template for more information

using DataStructure._01Arrays;
using DataStructure._02Lists;
using DataStructure._03Dictionaries;
using DataStructure._04HashSets;
using DataStructure._05Queues;
using DataStructure._06Stacks;
using DataStructure._07SortedList;
using DataStructure._08SortedDictionary;
using DataStructure._09LinkedLists;
using DataStructure._10ConcurrentDictionary;
using DataStructure._11ConcurrentQueue;
using DataStructure._12ConcurrentStack;

var arrays = new Arrays();
var daysOfWeek = arrays.GetDaysOfWeek();
// Accessing elements
Console.WriteLine(daysOfWeek[0]); // Output: Monday
// Iterating
foreach (var day in daysOfWeek)
{
    Console.WriteLine(day);
}

var lists = new Lists();
var shoppingCart = lists.GetShoppingCart();
// Iterating
foreach (var item in shoppingCart)
{
    Console.WriteLine(item);
}
Console.WriteLine($"---------------------------");
// Add items
shoppingCart.Add("Orange");

// Iterating
foreach (var item in shoppingCart)
{
    Console.WriteLine(item);
}
// Remove items
shoppingCart.Remove("SamSung");
Console.WriteLine($"---------------------------");
foreach (var item in shoppingCart)
{
    Console.WriteLine(item);
}

var dictionaries = new Dictionaries();
var users = dictionaries.GetUsers();
// Access a user
Console.WriteLine(users[1]); // Output: Alice
// Check existence
if (users.ContainsKey(5))
{
    Console.WriteLine(users[5]);
}

var hasSets = new HashSets();
var programmingLanguages = hasSets.GetProgrammingLanguages();
programmingLanguages.Add("C#"); // No effect, already exists

foreach (var pmLang in programmingLanguages)
{
    Console.WriteLine(pmLang);
}

var queues = new Queues();
var serviceQueue = queues.GetCustomerServiceRequests();
foreach (var queue in serviceQueue)
{
    Console.WriteLine(queue);
}
Console.WriteLine(serviceQueue.Dequeue());// FIFO

var stacks = new Stacks();
var undoStack = stacks.GetUndo();
foreach (var stack in undoStack)
{
    Console.WriteLine(stack);
}
Console.WriteLine(undoStack.Pop()); // Output: Delete 'o'
foreach (var stack in undoStack)
{
    Console.WriteLine(stack);
}
undoStack.Push("Delete 'l'");
foreach (var stack in undoStack)
{
    Console.WriteLine(stack);
}
Console.WriteLine(undoStack.Pop()); // Output: Delete 'o'
foreach (var stack in undoStack)
{
    Console.WriteLine(stack);
}

var sortedList = new SortedLists();
var studentMarks = sortedList.GetStundentsTopMarksByAutoSort();
foreach (var mark in studentMarks)
{
    Console.WriteLine($"Name : {mark.Value}, Mark : {mark.Key}");
}
Console.WriteLine($"---------------------------");
studentMarks.Add(110, "Aadhvik");
foreach (var mark in studentMarks)
{
    Console.WriteLine($"Name : {mark.Value}, Mark : {mark.Key}");
}

var sortedDictionaries = new SortedDictionaries();
var eventLogs = sortedDictionaries.GetEventLog();

foreach (var eventLog in eventLogs)
{
    Console.WriteLine($"{eventLog.Key}: {eventLog.Value}");
}
Console.WriteLine($"---------------------------");
eventLogs[DateTime.Now.AddMinutes(-1)] = "Event 3";

foreach (var eventLog in eventLogs)
{
    Console.WriteLine($"{eventLog.Key}: {eventLog.Value}");
}

var linkedLists = new LinkedLists();
var browserHistory = linkedLists.GetBrowserHistory();

foreach (var page in browserHistory)
{
    Console.WriteLine(page);
}

var concurrentDictionaries = new ConcurrentDictionaries();
var wordCounts = concurrentDictionaries.GetSharedCollectionOfCounters();
Console.WriteLine(wordCounts["hello"]);
Console.WriteLine(wordCounts["world"]);

var cuncurrentQueues = new ConcurrentQueues();
var logQueue = cuncurrentQueues.GetLogMessages();

// Process logs
if (logQueue.TryDequeue(out string log))
{
    Console.WriteLine(log); // Output: Log1
}

var cuncurrentStacks = new ConcurrentStacks();
var undOConcurrentStacks = cuncurrentStacks.GetUndoStack();

foreach (var stack in undOConcurrentStacks)
{
    Console.WriteLine(stack);
}

// Undo last operation
if (undOConcurrentStacks.TryPop(out string operation))
{
    Console.WriteLine(operation); // Output: Operation2
}

Thread thread = new Thread(new ThreadStart(PrintNumbers));
thread.Start(); // Start the new thread
PrintNumbers(); // Run on the main thread

Task.Run(() => PrintNumbers());
PrintNumbers();
Parallel.For(0, 10, i =>
{
    Console.WriteLine($"Processing item {i}");
});
Console.ReadLine();


static void PrintNumbers()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"Number: {i}");
        Thread.Sleep(1000); // Pause for 1 second
    }
}