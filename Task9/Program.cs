Task task1 = Task.Run(() =>
{
    Console.WriteLine("Hello from task1");
});

Task task2 = Task.Run(() =>
{
    Console.WriteLine(2924 + 2354);
});

Task task3 = Task.Run(async () =>
{
    Console.WriteLine("10s");
    await Task.Delay(3000);
});

Task.WaitAll(task1, task2, task3);
Console.WriteLine("after waiting");