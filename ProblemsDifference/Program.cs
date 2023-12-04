static int minNum(int samDaily, int kellyDaily, int difference)
{
    if (kellyDaily <= samDaily)
    {
        return -1;
    }

    int days = 0;
    int samSolved = difference;
    int kellySolved = 0;

    while (samSolved >= 0)
    {
        samSolved += samDaily;
        kellySolved += kellyDaily;
        difference = samSolved - kellySolved;
        days++;

        if (difference <= 0)
        {
            return days;
        }
    }

    return -1;
}
Console.WriteLine("Enter Sam's daily solved problems:");
int samDaily = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Kelly's daily solved problems:");
int kellyDaily = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the initial difference in solved problems (Sam ahead):");
int difference = int.Parse(Console.ReadLine());

int result = minNum(samDaily, kellyDaily, difference);

Console.WriteLine($"Minimum number of days for Kelly to surpass Sam: {result}");