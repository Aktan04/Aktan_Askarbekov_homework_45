int totalTime = 0; 

Task parallelTasks = Task.WhenAll(
    PutKettleOnStove(),
    HeatUpDinner(),
    FillBathtub(),
    WakeUpAndLieInBed()
    );

parallelTasks.Wait();
totalTime += 15;
Console.WriteLine($"Потрачено времени на просыпание, чайник, подогрев ужина и наполнение ванны: {totalTime} минут");
SequentialTasks(); 
Task secondParallelTask = Task.WhenAll(
    HaveBreakfast(),
    GoToWork());
secondParallelTask.Wait();
totalTime += 55;
Console.WriteLine("Вася ел по пути на работу и потратил на это 55 минут");
Console.WriteLine($"Общее затраченное время: {totalTime} минут, Вася успел ровно к 9:00");
    

async Task PutKettleOnStove()
{ 
    int minutes = 5;
    Task.Delay(minutes * 100).Wait(); 
}

async Task HeatUpDinner()
{
    int minutes = 5;
    Task.Delay(minutes * 100).Wait(); 
}

async Task FillBathtub()
{
    int minutes = 10;
    Task.Delay(minutes * 100).Wait(); 
}

async Task WakeUpAndLieInBed()
{
    int minutes = 15;
    Task.Delay(minutes * 100).Wait(); 
}

void SequentialTasks()
{
    TakeBath();
    GetDressed();
}

void TakeBath()
{
    int minutes = 15;
    totalTime += minutes;
    Task.Delay(minutes * 100).Wait(); 
    Console.WriteLine($"Затрачено времени на принятие ванны: {minutes} минут");
}

async Task HaveBreakfast()
{
    int minutes = 10;
    Task.Delay(minutes * 100).Wait(); 
}

void GetDressed()
{
    int minutes = 5;
    totalTime += minutes;
    Task.Delay(minutes * 100).Wait(); 
    Console.WriteLine($"Затрачено времени на одевание: {minutes} минут");
}

async Task GoToWork()
{
    int minutes = 55;
    Task.Delay(minutes * 100).Wait(); 
}

