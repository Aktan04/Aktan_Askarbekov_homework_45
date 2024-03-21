int totalTime = 0; 

Thread vasyaThread = new Thread(VasyasMorningRoutine);
vasyaThread.Start();
vasyaThread.Join(); 
Console.WriteLine($"Общее затраченное время: {totalTime} минут");

void VasyasMorningRoutine()
{
    totalTime += WaitAndReturnTime(15, "Просыпается и лежит в кровати");
    totalTime += WaitAndReturnTime(5, "Ставит чайник на плиту");
    totalTime += WaitAndReturnTime(5, "Подогревает вчерашний ужин");
    totalTime += WaitAndReturnTime(10, "Набирает ванну");
    totalTime += WaitAndReturnTime(15, "Принимает ванну");
    totalTime += WaitAndReturnTime(10, "Завтракает");
    totalTime += WaitAndReturnTime(5, "Одевается");
    totalTime += WaitAndReturnTime(55, "Едет на работу");
}

int WaitAndReturnTime(int minutes, string action)
{
    int ms = minutes * 100; 
    Thread.Sleep(ms); 
    Console.WriteLine($"Затрачено времени на {action}: {minutes} минут");
    return minutes;
}