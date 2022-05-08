// See https://aka.ms/new-console-template for more information
using RandomTest;

var testCount = 10000000;
var chance = 0.215;

var rndProvider = new CustomRandomProvider();
rndProvider.SetChance(chance);

int procCount = 0;
int[] streakCount = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
int maxStreak = 0;

int currStreak = 0;


for (var i = 0; i < testCount; i++)
{
    var res = rndProvider.GetNextValue();

    if (res)
    {
        currStreak++;
        procCount++;
    }
    else
        currStreak = 0;

    if (currStreak > maxStreak)
        maxStreak = currStreak;

    for (var j = 0; j < 9; j++)
    {
        if (currStreak == j + 2)
            streakCount[j]++;
    }

}

Console.WriteLine($"Target - {chance}");
Console.WriteLine($"Result - {(double)procCount / testCount}");
Console.WriteLine("");
Console.WriteLine($"{procCount}/{testCount}");
Console.WriteLine("");
Console.WriteLine($"Max Streak - {maxStreak}\n");
Console.WriteLine("");
for (var j = 0; j < 9; j++)
    Console.WriteLine($"{j + 2} streak - {streakCount[j]}");

Console.ReadLine();




